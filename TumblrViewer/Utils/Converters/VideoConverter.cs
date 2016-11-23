using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TumblrViewer.Model;
using Windows.UI.Xaml.Data;

namespace TumblrViewer.Utils.Converters
{
    public class VideoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var uriLink = (value as tumblrPostsPostVideoplayer[]).ToList().OrderBy(w => w.maxwidth).First().Value;
            var keyWord = "src=";
            var srcIndex = uriLink.IndexOf(keyWord);
            var halfResult = uriLink.Substring(srcIndex + keyWord.Length + 1);
            var endIndex = halfResult.IndexOf("?");
            var result = halfResult.Substring(0, endIndex).Replace("https", "http");
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
