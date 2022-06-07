using IronMotors.Models;
using IronMotors.Pages.MainWindowPages;
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
        Maintenance contextMaintenance;
        public MaintenancePage(Maintenance maintenance)
        {
            InitializeComponent();

            //DPMaintenance.BlackoutDates.AddDatesInPast(); // ПОПРАВИТЬ
            CBClients.ItemsSource = App.DB.Client.ToList();
            contextMaintenance = maintenance;
            DataContext = contextMaintenance;
            if(contextMaintenance.Id != 0)
            {
                LHeader.Content = "Информация о заявке";
                DPMaintenance.SelectedDate = contextMaintenance.DateTime.Date;
                CBTimes.SelectedItem = contextMaintenance.DateTime.TimeOfDay;
                CBClients.IsEnabled = false;
                CBCars.IsEnabled = false;
                BRegistrate.Visibility = Visibility.Collapsed;
                DPMaintenance.IsEnabled = false;
                CBTimes.IsEnabled = false;
                TBDescription.IsEnabled = false;
                BAddClient.Visibility = Visibility.Collapsed;
            }
            //CBCars.ItemsSource = App.DB.Car.Where(c => c.ClientId == App.LoggedClient.Id).ToList();
            //LoadPushPins();
            //MainMap.CredentialsProvider = new ApplicationIdCredentialsProvider(App.BingMapsToken);
        }

        private void BRegistrate_Click(object sender, RoutedEventArgs e)
        {
            var selectedCar = CBCars.SelectedItem as Car;
            var selectedDate = DPMaintenance.SelectedDate;
            var selectedTime = CBTimes.SelectedItem;
            var errorMessage = "";
            if (selectedCar == null)
                errorMessage += $"Выберите машину\n";
            if (selectedDate == null)
                errorMessage += $"Выберите дату\n";
            if (selectedTime == null)
                errorMessage += $"Выберите время\n";

            if (string.IsNullOrWhiteSpace(TBDescription.Text))
                errorMessage += $"Опишите причину обращения";
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var newMaintenance = new Maintenance() { CarServiceId = App.LoggedAdmin.CarServiceId, DateTime = selectedDate.Value.Add((TimeSpan)selectedTime), CarId = selectedCar.Id, Description = TBDescription.Text, StatusId = 1 };
            App.DB.Maintenance.Add(newMaintenance);
            App.DB.SaveChanges();
            MessageBox.Show("Вы успешно записались", "Успешно", MessageBoxButton.OK);
        }

        //private void LoadPushPins()
        //{
        //    foreach (var carService in App.DB.CarService)
        //    {
        //        var layer = new MapLayer();
        //        var pushpin = new Pushpin() { Location = new Location(carService.Latitude, carService.Longitude) };
        //        layer.Children.Add(pushpin);
        //        MainMap.Children.Add(layer);
        //    }
        //}

        private void DPMaintenance_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if(contextMaintenance.Id != 0)
            {
                CBTimes.Items.Add(contextMaintenance.DateTime.TimeOfDay);
                CBTimes.SelectedIndex = 0;
                return;
            }
            var selectedDate = DPMaintenance.SelectedDate;
            if (selectedDate.HasValue)
            {
                CBTimes.Items.Clear();
                var maintenances = App.DB.Maintenance.ToList().Where(m => m.DateTime.Date == selectedDate.Value.Date && m.CarServiceId == App.LoggedAdmin.CarServiceId).ToList();
                for (int workHour = 8; workHour <= 20; workHour++)
                {
                    if (maintenances.FirstOrDefault(m => m.DateTime.Hour == workHour) != null)
                        continue;
                    CBTimes.Items.Add(TimeSpan.FromHours(workHour));
                }
            }
        }

        private void BAddClient_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClientPage(new Client()));
        }

        private void CBClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedClient = (sender as ComboBox).SelectedItem as Client;
            if (selectedClient == null)
                return;
            CBCars.ItemsSource = selectedClient.Car.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CBClients.ItemsSource = App.DB.Client.ToList();
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
