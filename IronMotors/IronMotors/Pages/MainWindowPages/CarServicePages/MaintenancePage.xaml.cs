using IronMotors.Services;
using Microsoft.Maps.MapControl.WPF;
using Microsoft.Maps.MapControl.WPF.Core;
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
    /// Interaction logic for ServiceRegistrationPage.xaml
    /// </summary>
    public partial class MaintenancePage : Page
    {
        public MaintenancePage()
        {
            InitializeComponent();
            DPMaintenance.BlackoutDates.AddDatesInPast();
            LoadPushPins();
            LVServices.ItemsSource = App.DB.CarService.ToList();
            MainMap.CredentialsProvider = new ApplicationIdCredentialsProvider(App.BingMapsToken);
        }

        private void BRegistrate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoadPushPins()
        {
            foreach (var carService in App.DB.CarService)
            {
                var layer = new MapLayer();
                var pushpin = new Pushpin() { Location = new Location(Math.Round(carService.Longitude, 4), Math.Round(carService.Latitude, 4)) };
                layer.Children.Add(pushpin);
                MainMap.Children.Add(layer);
            }
        }

        private void LoadTimes()
        {
            CBTimes.Items.Clear();
            var selectedDate = DPMaintenance.SelectedDate;
            var maintenances = App.DB.Maintenance.ToList().Where(m => m.DateTime.Date == selectedDate.Value.Date).ToList();
            for (int workHour = 8; workHour <= 20; workHour++)
            {
                if (maintenances.FirstOrDefault(m => m.DateTime.Hour == workHour) != null)
                    continue;
                CBTimes.Items.Add(TimeSpan.FromHours(workHour));
            }
        }

        private void DPMaintenance_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadTimes();
        }
    }
}
