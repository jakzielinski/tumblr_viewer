using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TumblrViewer.Model;
using Windows.UI.Xaml.Data;

namespace TumblrViewer.Utils.Converters
{
    public class PhotoListToPhotoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            String url = String.Empty;
            tumblrPostsPostPhotourl[] val = (tumblrPostsPostPhotourl[])value;
            url = val.ToList().OrderBy(x => x.maxwidth).First().Value;
            return url;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
