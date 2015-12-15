using System;
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
using France_Vacances.Common;
using France_Vacances.Model;
using France_Vacances.ViewModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace France_Vacances
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            if (GlobalVars.Global_LoggedInBool == true)
            {
                grid_UserSection.Visibility = Visibility.Collapsed;
                textBlock3.Text = GlobalVars.Global_LoggedInName;
            }
            else
            {
                grid_UserSection2.Visibility = Visibility.Collapsed;
            }

        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.LoginPage));
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (View.Apartments));
        }
    }
}
