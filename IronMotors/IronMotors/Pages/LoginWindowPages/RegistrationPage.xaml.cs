using IronMotors.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace IronMotors.Pages
{
    /// <summary>
    /// Interaction logic for RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        Client contextClient;
        public RegistrationPage()
        {
            InitializeComponent();
            contextClient = new Client();
            DataContext = contextClient;
        }

        private void BRegistration_Click(object sender, RoutedEventArgs e)
        {
            //string errorMessage = "";
            //if (!MyValidator.Validate(contextClient, out errorMessage))
            //{
            //    MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            //if (App.DB.Client.FirstOrDefault(c => c.PhoneNumber == contextClient.PhoneNumber) != null)
            //{
            //    MessageBox.Show("Данный номер уже используется", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            //if (App.DB.Client.FirstOrDefault(c => c.Email == contextClient.Email) != null)
            //{
            //    MessageBox.Show("Данная электронная почта уже используется", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            //App.DB.Client.Add(contextClient);
            //App.DB.SaveChanges();
            //NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void FullNameTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"[А-я]")) //проверка на воод только букв
                e.Handled = true;
        }

        private void PhoneTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"[0-9]")) //проверка на воод только цифр
                e.Handled = true;
        }
    }
}
