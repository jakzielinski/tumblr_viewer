using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TumblrViewer.Model;
using Windows.ApplicationModel.Core;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Popups;

namespace TumblrViewer.ViewModel
{
    public class PostPageViewModel : INotifyPropertyChanged
    {
        private tumblrPostsPost _post;
        public tumblrPostsPost post
        {
            get
            {
                return _post;
            }
            set
            {
                if (value != _post)
                {
                    _post = value;
                    NotifyPropertyChanged("post");
                }
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

        internal async void Save()
        {
            var url = new Uri(post.photourl.First().Value);
            var folder = KnownFolders.PicturesLibrary;
            var photoFile = await folder.CreateFileAsync($"tumblrViewer.jpg", CreationCollisionOption.GenerateUniqueName);
            var downloader = new Windows.Networking.BackgroundTransfer.BackgroundDownloader();
            var dl = downloader.CreateDownload(url, photoFile);
            await dl.StartAsync();
            SavedPopUp();
        }

        private async void SavedPopUp()
        {
            MessageDialog msgbox = new MessageDialog(Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView().GetString("PostPageSaved"));
            await msgbox.ShowAsync();
        }
    }
}
