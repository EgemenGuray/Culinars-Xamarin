using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Culinars.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Recipe : Page
    {
        string selected;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {


            selected = e.Parameter.ToString();
            base.OnNavigatedTo(e);
            recipeText.Text = (App.Current as App).CurrentRecipe.ToString();
            ///////Image.source = (App.Current as App).currentImage.ToString();
            string process = (App.Current as App).CurrentIngredients.ToString();
            itemImage.Source = new BitmapImage(new Uri(this.BaseUri, (App.Current as App).currentImage.ToString()));
            while (process.Contains(";"))
            {
                string dummy = process.Substring(0, process.IndexOf(";"));
                //process = process.Substring(0, dummy.Length);
                process = process.Remove(0, dummy.Length + 1);

                //process = process.Substring(dummy.Length+2,process.Length);
                //dummy.Remove(dummy.IndexOf(";"));
                TextBlock text = new TextBlock();
                text.Text = dummy;
                if((App.Current as App).NavigateText.Contains(dummy))
                {
                    text.Foreground = new SolidColorBrush(Colors.DarkGreen);
                }
                else
                {
                    text.Foreground = new SolidColorBrush(Colors.DarkRed);
                }
               
                
                IngredientList.Items.Add(text);
                
                dummy = "";
            }
            if (process.Contains(";"))
            {
                process = process.Substring(0, process.IndexOf(";"));

                IngredientList.Items.Add(process);
            }
        }
        

        public Recipe()
        {

            this.InitializeComponent();
            
            
            /*for(int i = 0; i < 100; i++)
            {
                TextBlock test = new TextBlock();
                
                test.Text = "Test";
                test.HorizontalAlignment = HorizontalAlignment.Center;
                IngredientList.Items.Add(test);
                
            }*/
            //recipeText.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Frame.Navigate(typeof(ResultPage));
        }
    }
}
