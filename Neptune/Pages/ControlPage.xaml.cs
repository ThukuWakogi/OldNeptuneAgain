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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Neptune.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ControlPage : Page
    {
        public ControlPage()
        {
            this.InitializeComponent();
            //AppTitle.Text = "Neptune";
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            switch (((NavigationViewItem)args.SelectedItem).Tag.ToString())
            {
                case "Positions":
                    ContentFrame.Navigate(typeof(UnderConstructionPage), ((NavigationViewItem)args.SelectedItem).Tag.ToString());
                    ControlNavigationView.Header = ((NavigationViewItem)args.SelectedItem).Tag.ToString();
                    break;
                case "Workers":
                    ContentFrame.Navigate(typeof(UnderConstructionPage), ((NavigationViewItem)args.SelectedItem).Tag.ToString());
                    ControlNavigationView.Header = ((NavigationViewItem)args.SelectedItem).Tag.ToString();
                    break;
                case "Customers":
                    ContentFrame.Navigate(typeof(UnderConstructionPage), ((NavigationViewItem)args.SelectedItem).Tag.ToString());
                    ControlNavigationView.Header = ((NavigationViewItem)args.SelectedItem).Tag.ToString();
                    break;
                case "Materials":
                    ContentFrame.Navigate(typeof(UnderConstructionPage), ((NavigationViewItem)args.SelectedItem).Tag.ToString());
                    ControlNavigationView.Header = ((NavigationViewItem)args.SelectedItem).Tag.ToString();
                    break;
                case "Flies":
                    ContentFrame.Navigate(typeof(UnderConstructionPage), ((NavigationViewItem)args.SelectedItem).Tag.ToString());
                    ControlNavigationView.Header = ((NavigationViewItem)args.SelectedItem).Tag.ToString();
                    break;
                case "Orders":
                    ContentFrame.Navigate(typeof(UnderConstructionPage), ((NavigationViewItem)args.SelectedItem).Tag.ToString());
                    ControlNavigationView.Header = ((NavigationViewItem)args.SelectedItem).Tag.ToString();
                    break;
                case "Job Cards":
                    ContentFrame.Navigate(typeof(UnderConstructionPage), ((NavigationViewItem)args.SelectedItem).Tag.ToString());
                    ControlNavigationView.Header = ((NavigationViewItem)args.SelectedItem).Tag.ToString();
                    break;
                case "User":
                    ContentFrame.Navigate(typeof(UnderConstructionPage), ((NavigationViewItem)args.SelectedItem).Tag.ToString());
                    ControlNavigationView.Header = ((NavigationViewItem)args.SelectedItem).Tag.ToString();
                    break;
            }
        }
    }
}
