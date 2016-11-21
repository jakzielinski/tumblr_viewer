using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TumblrViewer.ViewModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TumblrViewer.Utils.Selectors
{
    public class PostsDataTemplateSelector : DataTemplateSelector
    {
        //public override DataTemplate SelectTemplate(object item, DependencyObject container)
        //{
        //    //var viewModel = (item as UserPageViewModel);
        //    //switch ()
        //    //{
        //    //    case ViewModelType.Photo:
        //    //        return PhotoTemplate;
        //    //    default:
        //    //        return TextTemplate;
        //    //}
        //}

        public DataTemplate RegularTemplate { get; set; }
        public DataTemplate LinkTemplate { get; set; }
        public DataTemplate QuoteTemplate { get; set; }
        public DataTemplate PhotoTemplate { get; set; }
        public DataTemplate ConversationTemplate { get; set; }
        public DataTemplate VideoTemplate { get; set; }
        public DataTemplate AudioTemplate { get; set; }
        public DataTemplate AnswerTemplate { get; set; }
    }
}
