﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Culinars
{   
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public object SplitViewFrame { get; private set; }

        public MainPage()
        {
            (App.Current as App).currentLanguage = "English";
            this.InitializeComponent();
            Frame.Navigate(typeof(HomePage));

        }

        private void HamburgerButton_Click(object  sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HomePage));
        }

        private void MenuButton1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HomePage));
        }

        private void MenuButton2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SettingsPage));
            

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            


        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void listBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MenuButton3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AboutPage));
        }
    }
}