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
using Windows.UI.Core;

namespace TumblrViewer.ViewModel
{
    public class UserPageViewModel : INotifyPropertyChanged
    {
        public String userName { get; set; }

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
            try
            {
                HttpClient http = new HttpClient();
                String url = String.Format($"http://{userName}.tumblr.com/api/read");

                HttpResponseMessage response = await http.GetAsync(url);
                String result = await response.Content.ReadAsStringAsync();

                XmlSerializer serializer = new XmlSerializer(typeof(tumblr));
                tumblr data;
                using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(result)))
                {
                    data = (tumblr)serializer.Deserialize(ms);
                }
                postCollection = new ObservableCollection<tumblrPostsPost>(data.posts.post.ToList());
            }
            catch (Exception ex)
            {
                //TODO
            }
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
    }
}
