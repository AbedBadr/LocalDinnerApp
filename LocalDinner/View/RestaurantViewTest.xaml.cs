using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using LocalDinner.ViewModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LocalDinner.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RestaurantViewTest : Page
    {
        private static LocalDinnerViewModel vm = new LocalDinnerViewModel();
        
        private ObservableCollection<Restaurant> obs;
        
        public RestaurantViewTest()
        {
            InitializeComponent();
            
            ListView_Search.ItemsSource = vm.RestaurantCatalog;
        }
        
        private void Button_Search_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (TextBox_Search.Text != "")
            {
                obs = new ObservableCollection<Restaurant>();
                
                foreach (var i in vm.RestaurantCatalog)
                {
                    if (i.Name.ToLowerInvariant().Contains(TextBox_Search.Text.ToLowerInvariant()) == true)
                    {
                        obs.Add(i);
                    }
                }
                ListView_Search.ItemsSource = obs;
            }
            else
            {
                TextBox_Search.PlaceholderText = "Incorrect query!";
                ListView_Search.ItemsSource = vm.RestaurantCatalog;
            }
        }
    }
}
