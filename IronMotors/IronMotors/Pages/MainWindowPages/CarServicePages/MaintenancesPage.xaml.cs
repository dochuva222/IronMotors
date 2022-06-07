using IronMotors.Models;
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

namespace IronMotors.Pages.MainWindowPages.CarServicePages
{
    /// <summary>
    /// Interaction logic for MaintenancesPage.xaml
    /// </summary>
    public partial class MaintenancesPage : Page
    {
        public MaintenancesPage()
        {
            InitializeComponent();
        }

        private void Refresh()
        {

            LVMaintenances.ItemsSource = App.LoggedAdmin.CarService.Maintenance.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void MIAbout_Click(object sender, RoutedEventArgs e)
        {
            var selectedMaintenance = LVMaintenances.SelectedItem as Maintenance;
            if (selectedMaintenance == null)
                return;
            NavigationService.Navigate(new MaintenancePage(selectedMaintenance));
        }

        private void MIWorkers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AppointWorkersPage());
        }

        private void BFinish_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FinishMaintenancePage());

        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            var selectedMaintenance = (sender as Button).DataContext as Maintenance;
            if (selectedMaintenance == null)
                return;
            selectedMaintenance.StatusId = 3;
            App.DB.SaveChanges();
            Refresh();
        }

        private void BCreateMaintenance_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MaintenancePage(new Maintenance() { CarServiceId = App.LoggedAdmin.CarServiceId, StatusId = 1}));
        }
    }
}
