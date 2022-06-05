using IronMotorsService.AppWindows;
using IronMotorsService.Pages.MaintenancesPages;
using IronMotorsService.Pages.WorkersPages;
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

namespace IronMotorsService.Pages
{
    /// <summary>
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
            MenuFrame.Navigate(new MaintenancesPage());
        }

        private void BMaintenances_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new MaintenancesPage());
        }

        private void BWorkers_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new WorkersPage());
        }

        private void BLogout_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.AdministratorId = 0;
            Properties.Settings.Default.Save();
            new LoginWindow().Show();
            App.MainWindowInstance.Close();
        }
    }
}
