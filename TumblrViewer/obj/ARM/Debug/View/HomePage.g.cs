﻿

#pragma checksum "C:\Users\korko\Documents\Visual Studio 2015\Projects\TumblrViewer\TumblrViewer\View\HomePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "55E7C29777CF30B9CE8CB2CF8C194440"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TumblrViewer.View
{
    partial class HomePage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 98 "..\..\..\View\HomePage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.MenuItems_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 113 "..\..\..\View\HomePage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.MenuItems_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 90 "..\..\..\View\HomePage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.MainListView_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 75 "..\..\..\View\HomePage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.MenuIcon_Tapped;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 77 "..\..\..\View\HomePage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.SearchBox_TextChanged;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 78 "..\..\..\View\HomePage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.SearchIcon_Tapped;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 79 "..\..\..\View\HomePage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.SearchButton_Tapped;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 133 "..\..\..\View\HomePage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.AppBarButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


