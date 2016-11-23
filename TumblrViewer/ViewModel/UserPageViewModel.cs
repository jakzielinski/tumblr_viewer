using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TumblrViewer.Model;
using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.Resources;
using Windows.Networking.Connectivity;
using Windows.UI.Core;
using Windows.UI.Popups;

namespace TumblrViewer.ViewModel
{
    public class UserPageViewModel : INotifyPropertyChanged
    {
        public String userName { get; set; }

        private tumblrTumblelog _tumblrLog;
        public tumblrTumblelog tumblrLog
        {
            get
            {
                return _tumblrLog;
            }
            set
            {
                if (value != _tumblrLog)
                {
                    _tumblrLog = value;
                    NotifyPropertyChanged("tumblrLog");
                }
            }
        }

        private ObservableCollection<tumblrPostsPost> _postCollection;
        public ObservableCollection<tumblrPostsPost> postCollection
        {
            get
            {
                if (_postCollection == null)
                {
                    _postCollection = new ObservableCollection<tumblrPostsPost>();
                }
                return _postCollection;
            }
            set
            {
                if (value != _postCollection)
                {
                    _postCollection = value;
                    NotifyPropertyChanged("postCollection");
                }
            }
        }

        internal async void SendRequest()
        {
            HttpResponseMessage response;
            ConnectionProfile connections = NetworkInformation.GetInternetConnectionProfile();
            bool internet = connections != null && connections.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess;

            if (internet)
            {
                HttpClient http = new HttpClient();
                String url = $"http://{userName}.tumblr.com/api/read";
                try
                {
                    response = await http.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        String result = await response.Content.ReadAsStringAsync();

                        XmlSerializer serializer = new XmlSerializer(typeof(tumblr));
                        tumblr data;
                        using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(result)))
                        {
                            data = (tumblr)serializer.Deserialize(ms);
                        }
                        if (data != null)
                        {
                            tumblrLog = data.tumblelog;
                            postCollection = new ObservableCollection<tumblrPostsPost>(data.posts.post.ToList());
                        }
                    }
                }
                catch
                {
                    Popup();
                }
            }
            else
            {
                NoInternetPopup();
            }
        }

        private async void NoInternetPopup()
        {
            MessageDialog msgbox = new MessageDialog(ResourceLoader.GetForCurrentView().GetString("NoInternet"));
            await msgbox.ShowAsync();
        }

        private async void Popup()
        {
            MessageDialog msgbox = new MessageDialog(ResourceLoader.GetForCurrentView().GetString("NoSuchUser"));
            await msgbox.ShowAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private async void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                if (CoreApplication.MainView.CoreWindow.Dispatcher.HasThreadAccess)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
                else
                {
                    await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs(info));
                    });
                }
            }
        }

        internal void Reverse()
        {
            if (postCollection.Any())
            {
                postCollection = new ObservableCollection<tumblrPostsPost>(postCollection.Reverse().ToList());
            }
        }
    }
}
