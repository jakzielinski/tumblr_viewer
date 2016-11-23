using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TumblrViewer.Model;
using TumblrViewer.ViewModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TumblrViewer.Utils.Selectors
{
    public class PostsDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate RegularTemplate { get; set; }
        public DataTemplate LinkTemplate { get; set; }
        public DataTemplate QuoteTemplate { get; set; }
        public DataTemplate PhotoTemplate { get; set; }
        public DataTemplate ConversationTemplate { get; set; }
        public DataTemplate VideoTemplate { get; set; }
        public DataTemplate AudioTemplate { get; set; }
        public DataTemplate AnswerTemplate { get; set; }
        public DataTemplate DefaultTemplate { get; set; }


        protected override DataTemplate SelectTemplateCore(object item)
        {
            var x = (item as tumblrPostsPost).type;

            switch ((item as tumblrPostsPost).type)
            {
                case "video":
                    return VideoTemplate;
                case "photo":
                    return PhotoTemplate;
                case "regular":
                    return RegularTemplate;
                case "link":
                    return LinkTemplate;
                case "quote":
                    return QuoteTemplate;
                case "conversation":
                    return ConversationTemplate;
                case "audio":
                    return AudioTemplate;
                case "answer":
                    return AnswerTemplate;
                default:
                    return DefaultTemplate;
            }
        }
    }
}
