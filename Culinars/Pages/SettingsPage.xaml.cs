using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Culinars
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            this.InitializeComponent();
            comboBox.Items.Add("English");
            //comboBox.Items.Add("Deutsch");
            //comboBox.Items.Add("Türkçe");
            if ((App.Current as App).currentLanguage == "English")
            {
                comboBox.SelectedIndex = 0;
               
            }else if ((App.Current as App).currentLanguage == "Türkçe")
            {
                comboBox.SelectedIndex = 2;
                
            }
            else if ((App.Current as App).currentLanguage == "Deutsch")
            {
                comboBox.SelectedIndex = 1;

            }

        }
        

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            (App.Current as App).currentLanguage = comboBox.SelectedItem.ToString();
            /*if (comboBox.SelectedIndex == 0)
            {
                textBlock1.Text = "Settings";
                comboBox.Header = "Offline Mode";
            }
            else if(comboBox.SelectedIndex == 1)
            {

            }
            else if (comboBox.SelectedIndex == 2)
            {
                textBlock1.Text = "Ayarlar";
                comboBox.Header = "Çevrimdışı Mod";
            }*/

        }

        private async void toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Online mode is not available right now. Check again later", "Culinars");

            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "OK", Id = 0 });
            //msgbox.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            //msgbox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            //msgbox.Commands.Add(new UICommand { Label = "Cancel", Id = 2 });

            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
               
                //if (toggleSwitch.IsOn == true)
                //{
                    
                    toggleSwitch.IsOn = false;
                //}
            }

            /*if ((int)res.Id == 1)
            {
                MessageDialog msgbox2 = new MessageDialog("Oh well, too bad! :(", "User Response");
                await msgbox2.ShowAsync();
            }

            if ((int)res.Id == 2)
            {
                MessageDialog msgbox2 = new MessageDialog("Nevermind then... :|", "User Response");
                await msgbox2.ShowAsync();
            }*/
            
        }
    }
}
