using IronMotors.AppWindows;
using IronMotors.Pages.MainWindowPages.CarServicePages;
using IronMotors.Pages.MainWindowPages.ProfilePages;
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

namespace IronMotors.Pages.MainWindowPages
{
    /// <summary>
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
            MenuFrame.Navigate(new ProfilePage(new MyDataPage()));
        }

        private void BProfile_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new ProfilePage(new MyDataPage()));
        }

        private void BMaintenance_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new MaintenancePage());
        }

        private void BLogout_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.ClientId = 0;
            Properties.Settings.Default.Save();
            new LoginWindow().Show();
            App.MainWindowInstance.Close();
        }
    }
}
