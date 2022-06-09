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
        List<MaintenanceService> services = new List<MaintenanceService>();
        List<MaintenanceWorker> appointedWorkers = new List<MaintenanceWorker>();
        public MaintenancePage(Maintenance maintenance)
        {
            InitializeComponent();
            CBClients.ItemsSource = App.DB.Client.ToList();
            CBServices.ItemsSource = App.DB.Service.ToList();
            contextMaintenance = maintenance;
            DataContext = contextMaintenance;
            services = contextMaintenance.MaintenanceService.ToList();
            appointedWorkers = contextMaintenance.MaintenanceWorker.ToList();
            Refresh();
            RefreshWorkers();
            if (contextMaintenance.Id != 0)
            {
                LHeader.Content = "Информация о заявке";
                DPMaintenance.SelectedDate = contextMaintenance.DateTime.Date;
                CBTimes.SelectedItem = contextMaintenance.DateTime.TimeOfDay;
                CBClients.IsEnabled = false;
                CBCars.IsEnabled = false;
                DPMaintenance.IsEnabled = false;
                CBTimes.IsEnabled = false;
                BAppointWorker.IsEnabled = false;
                BRemoveWorker.IsEnabled = false;
                BAppointWorker.Visibility = Visibility.Hidden;
                BRemoveWorker.Visibility = Visibility.Hidden;
                LVAllWorkers.Visibility = Visibility.Hidden;
                SPServicePanel.Visibility = Visibility.Collapsed;
                BRegistrate.Visibility = Visibility.Collapsed;
                BAddClient.Visibility = Visibility.Collapsed;
                CBClients.SelectedItem = contextMaintenance.Car.Client;
                CBCars.SelectedItem = contextMaintenance.Car;
            }
            else
            {
                LVAllWorkers.ItemsSource = App.LoggedAdmin.CarService.Worker.ToList();
                DPMaintenance.BlackoutDates.AddDatesInPast();
            }
            
        }

        private void BRegistrate_Click(object sender, RoutedEventArgs e)
        {
            var selectedDate = DPMaintenance.SelectedDate;
            var selectedTime = CBTimes.SelectedItem;
            contextMaintenance.Car = CBCars.SelectedItem as Car;

            var errorMessage = "";
            MyValidator.Validate(contextMaintenance, out errorMessage);
            if (selectedDate == null)
                errorMessage += $"Выберите дату\n";
            if (selectedTime == null)
                errorMessage += $"Выберите время\n";
            if (services.Count == 0)
                errorMessage += $"Необходимо выбрать как минимум одну услугу\n";
            if (appointedWorkers.Count == 0)
                errorMessage += $"Необходимо выбрать как минимум одного работника\n";

            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            contextMaintenance.DateTime = selectedDate.Value.Add((TimeSpan)selectedTime);
            App.DB.Maintenance.Add(contextMaintenance);
            App.DB.MaintenanceService.AddRange(services);
            App.DB.MaintenanceWorker.AddRange(appointedWorkers);
            App.DB.SaveChanges();
            MessageBox.Show("Заявка создана", "Успешно", MessageBoxButton.OK);
            NavigationService.GoBack();
        }

        

        private void DPMaintenance_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (contextMaintenance.Id != 0)
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
                    if (selectedDate.Value.AddHours(workHour) < DateTime.Now)
                        continue;
                    CBTimes.Items.Add(TimeSpan.FromHours(workHour));
                }
            }
            RefreshWorkers();
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
            CBCars.SelectedItem = null;
            CBCars.ItemsSource = selectedClient.Car.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CBClients.ItemsSource = App.DB.Client.ToList();
        }

        private void BAddService_Click(object sender, RoutedEventArgs e)
        {
            var selectedService = CBServices.SelectedItem as Service;
            if (selectedService == null)
            {
                MessageBox.Show("Выберите услугу");
                return;
            }
            services.Add(new MaintenanceService() { Maintenance = contextMaintenance, Service = selectedService });
            var allowedServices = CBServices.ItemsSource.Cast<Service>().ToList();
            allowedServices.Remove(selectedService);
            CBServices.ItemsSource = allowedServices;
            Refresh();
        }


        private void Refresh()
        {
            LSum.Content = services.Sum(s => s.Service.Price);
            DGServices.ItemsSource = services.ToList();
        }

        private void BRemoveService_Click(object sender, RoutedEventArgs e)
        {
            if(contextMaintenance.Id != 0)
            {
                MessageBox.Show("Изменения не возможны");
                return;
            }
            var selectedService = (sender as Button).DataContext as MaintenanceService;
            if (selectedService == null)
                return;
            services.Remove(selectedService);
            var allowedServices = CBServices.ItemsSource.Cast<Service>().ToList();
            allowedServices.Add(selectedService.Service);
            CBServices.ItemsSource = allowedServices;
            Refresh();
        }

        private void RefreshWorkers()
        {
            LVAppointedWorkers.ItemsSource = appointedWorkers.ToList();
        }

        private void BAppointWorker_Click(object sender, RoutedEventArgs e)
        {
            var selectedWorker = LVAllWorkers.SelectedItem as Worker;
            if (selectedWorker == null)
                return;
            var allWorkers = LVAllWorkers.ItemsSource.Cast<Worker>().ToList();
            allWorkers.Remove(selectedWorker);
            LVAllWorkers.ItemsSource = allWorkers.ToList();
            appointedWorkers.Add(new MaintenanceWorker() { Maintenance = contextMaintenance, Worker = selectedWorker });
            RefreshWorkers();
        }

        private void BRemoveWorker_Click(object sender, RoutedEventArgs e)
        {
            var selectedWorker = LVAppointedWorkers.SelectedItem as MaintenanceWorker;
            if (selectedWorker == null)
                return;
            var allWorkers = LVAllWorkers.ItemsSource.Cast<Worker>().ToList();
            allWorkers.Add(selectedWorker.Worker);
            LVAllWorkers.ItemsSource = allWorkers;
            appointedWorkers.Remove(selectedWorker);
            RefreshWorkers();
        }
    }
}
