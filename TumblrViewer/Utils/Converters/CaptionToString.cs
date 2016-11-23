using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace TumblrViewer.Utils.Converters
{
    public class CaptionToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            String caption = value as String;
            String result = String.Empty;

            try
            {
                char[] array = new char[caption.Length];
                int arrayIndex = 0;
                bool inside = false;

                for (int i = 0; i < caption.Length; i++)
                {
                    char let = caption[i];
                    if (let == '<')
                    {
                        inside = true;
                        continue;
                    }
                    if (let == '>')
                    {
                        inside = false;
                        continue;
                    }
                    if (!inside)
                    {
                        array[arrayIndex] = let;
                        arrayIndex++;
                    }
                }
                result = new string(array, 0, arrayIndex);
                return result;
            }
            catch (ArgumentNullException ex)
            {
                //
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
