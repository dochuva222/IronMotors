using IronMotors.Models;
using IronMotors.Pages.MainWindowPages;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        Client contextClient;
        DbPropertyValues oldValues;
        public ClientPage(Client client)
        {
            InitializeComponent();
            contextClient = client;
            DataContext = contextClient;
            if (contextClient.Id != 0)
            {
                oldValues = App.DB.Entry(contextClient).CurrentValues.Clone();
                LHeader.Content = "Редактирование клиента";
                BRegistration.Content = "Сохранить";
            }
            else
            {
                LHeader.Content = "Регистрация клиента";
            }
        }

        private void BRegistration_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";
            if (contextClient.Id != 0)
            {
                if (App.DB.Client.Where(c => c.Id != contextClient.Id).FirstOrDefault(c => c.PhoneNumber == contextClient.PhoneNumber) != null)
                    errorMessage += $"Данный номер уже используется\n";
            }
            else
            {
                if (App.DB.Client.FirstOrDefault(c => c.PhoneNumber == contextClient.PhoneNumber) != null)
                    errorMessage += $"Данный номер уже используется\n";
            }

            if (!MyValidator.Validate(contextClient, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            App.DB.Client.Add(contextClient);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            if (oldValues != null)
                App.DB.Entry(contextClient).CurrentValues.SetValues(oldValues);
            NavigationService.GoBack();
        }

        private void FullNameTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"[А-я]"))
                e.Handled = true;
        }

        private void PhoneTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"[0-9]"))
                e.Handled = true;
        }

        private void BAddCar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CarPage(new Car() { Client = contextClient }));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LVCars.ItemsSource = contextClient.Car.ToList();
        }

        private void LVCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCar = LVCars.SelectedItem as Car;
            if (selectedCar == null)
                return;
            NavigationService.Navigate(new CarPage(selectedCar));
        }
    }
}
