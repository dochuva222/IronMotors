using IronMotors.AppWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IronMotors.Pages.MainWindowPages.DirectorPages
{
    /// <summary>
    /// Interaction logic for DirectorMenuPage.xaml
    /// </summary>
    public partial class DirectorMenuPage : Page
    {
        public DirectorMenuPage()
        {
            InitializeComponent();
            MenuFrame.Navigate(new CarServicesPage());
        }

        private void BLogout_Click(object sender, RoutedEventArgs e)
        {
            App.LoggedDirector = null;
            new LoginWindow().Show();
            App.MainWindowInstance.Close();
        }

        private void BClients_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new ClientsPage());

        }

        private void BCarServices_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new CarServicesPage());

        }

        private void BServices_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new ServicesPage());
        }
    }
}
