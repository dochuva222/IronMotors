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

namespace IronMotorsService.Pages.MaintenancesPages
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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LVMaintenances.ItemsSource = App.LoggedAdmin.CarService.Maintenance.ToList();
        }

        private void MIAbout_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MIWorkers_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BFinish_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
