﻿#pragma checksum "C:\Users\Egemen\Documents\Visual Studio 2015\Projects\Culinars\Culinars\Pages\Recipe.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AB0F53F3478D5AAC27285F17CBA2C651"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Culinars.Pages
{
    partial class Recipe : 
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
                    this.itemImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 2:
                {
                    this.HamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\Pages\Recipe.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamburgerButton).Click += this.Button_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.recipePivot = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                }
                break;
            case 4:
                {
                    this.item1 = (global::Windows.UI.Xaml.Controls.PivotItem)(target);
                }
                break;
            case 5:
                {
                    this.item2 = (global::Windows.UI.Xaml.Controls.PivotItem)(target);
                }
                break;
            case 6:
                {
                    this.recipeText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.IngredientList = (global::Windows.UI.Xaml.Controls.ListView)(target);
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

