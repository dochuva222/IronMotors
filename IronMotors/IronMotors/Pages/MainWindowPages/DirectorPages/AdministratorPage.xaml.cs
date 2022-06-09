using IronMotors.Models;
using System;
using System.Collections.Generic;
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

namespace IronMotors.Pages.MainWindowPages.DirectorPages
{
    /// <summary>
    /// Interaction logic for AdministratorPage.xaml
    /// </summary>
    public partial class AdministratorPage : Page
    {
        User contextUser;
        public AdministratorPage()
        {
            InitializeComponent();
            contextUser = new User();
            DataContext = contextUser;
        }


        private void BRegistration_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";

            MyValidator.Validate(contextUser, out errorMessage);
            if (App.DB.User.FirstOrDefault(u => u.Login == contextUser.Login) != null)
                errorMessage += $"Введеный Логин уже используется\n";
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            App.DB.User.Add(contextUser);
            App.DB.Administrator.Add(new Administrator() { User = contextUser });
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void FullNameTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"[А-я]"))
                e.Handled = true;
        }
    }
}
