using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TumblrViewer.Model;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace TumblrViewer.ViewModel
{
    public class PageHeaderViewModel : INotifyPropertyChanged
    {
        public List<String> MenuList = new List<string>(new string[5] { "Favorite 1", "Favorite 2", "Favorite 3", "Favorite 4", "Favorite 5" });

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
