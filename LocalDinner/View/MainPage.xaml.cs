using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.Threading;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using LocalDinner.View;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LocalDinner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            //LoopyDoopy();
        }

        //public void LoopyDoopy()
        //{
        //    TimeSpan period = TimeSpan.FromSeconds(0.1);

        //    ThreadPoolTimer PeriodicTimer = ThreadPoolTimer.CreatePeriodicTimer(async (source) =>
        //    {
        //        await Dispatcher.RunAsync(CoreDispatcherPriority.High,
        //            () =>
        //            {
        //                if (TextBox_Search.Text == "")
        //                {
        //                    // Gør intet
        //                }
        //                else
        //                {
        //                    String search = TextBox_Search.Text;
        //                }
        //            });
        //    }, period);
        //}

        private void BtnAdminLogin_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminLogin));
        }

        private void BtnAbout_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AboutPage));
        }
    }
}
