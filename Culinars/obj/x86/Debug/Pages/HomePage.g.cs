﻿#pragma checksum "C:\Users\Egemen\Documents\Visual Studio 2015\Projects\Culinars\Culinars\Pages\HomePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4D35E578D4B88D31509DC3316CF16983"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Culinars
{
    partial class HomePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.listBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 2:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 40 "..\..\..\Pages\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.Search = (global::Windows.UI.Xaml.Controls.SearchBox)(target);
                    #line 26 "..\..\..\Pages\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.SearchBox)this.Search).QueryChanged += this.Search_QueryChanged;
                    #line 26 "..\..\..\Pages\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.SearchBox)this.Search).QuerySubmitted += this.Search_QuerySubmitted;
                    #line default
                }
                break;
            case 4:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

