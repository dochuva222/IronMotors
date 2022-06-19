using IronMotors.Models;
using IronMotors.Pages.MainWindowPages.CarServicePages;
using Microsoft.Maps.MapControl.WPF;
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
    /// Interaction logic for CarServicesPage.xaml
    /// </summary>
    public partial class CarServicesPage : Page
    {
        public CarServicesPage()
        {
            InitializeComponent();
            LoadPushPins();
            MainMap.CredentialsProvider = new ApplicationIdCredentialsProvider(App.BingMapsToken);
        }

        private void LoadPushPins()
        {
            foreach (var carService in App.DB.CarService)
            {
                var layer = new MapLayer();
                var pushpin = new Pushpin() { Location = new Location(carService.Latitude, carService.Longitude) };
                layer.Children.Add(pushpin);
                MainMap.Children.Add(layer);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LVCarServices.ItemsSource = App.DB.CarService.ToList();
        }

        private void Workers_Click(object sender, RoutedEventArgs e)
        {
            var selectedCarService = LVCarServices.SelectedItem as CarService;
            if (selectedCarService == null)
                return;
            NavigationService.Navigate(new WorkersPage(selectedCarService));
        }

        private void AdministartorAppoint_Click(object sender, RoutedEventArgs e)
        {
            var selectedCarService = LVCarServices.SelectedItem as CarService;
            if (selectedCarService == null)
                return;
            NavigationService.Navigate(new AppointAdministratorPage(selectedCarService));
        }

        private void Maintenances_Click(object sender, RoutedEventArgs e)
        {
            var selectedCarService = LVCarServices.SelectedItem as CarService;
            if (selectedCarService == null)
                return;
            NavigationService.Navigate(new MaintenancesPage(selectedCarService));
        }

        private void Statistics_Click(object sender, RoutedEventArgs e)
        {
            var selectedCarService = LVCarServices.SelectedItem as CarService;
            if (selectedCarService == null)
                return;
            NavigationService.Navigate(new CarServiceChart(selectedCarService));
        }
    }
}
