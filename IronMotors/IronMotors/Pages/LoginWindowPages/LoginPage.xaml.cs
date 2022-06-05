using IronMotors.AppWindows;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace IronMotors.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
            //Properties.Settings.Default.ClientId это данные о клиенте который последний раз заходил, они сохраняются в приложении, поэтому если id не равен 0 то значит приложение сразу переходит на главное окно, иначе открывается окно регистрации
            if (Properties.Settings.Default.ClientId != 0)
            {
                App.LoggedClient = App.DB.Client.FirstOrDefault(c => c.Id == Properties.Settings.Default.ClientId); 
                new MainWindow().Show();
                App.LoginWindowInstance.Close();
            }
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var loggedClient = App.DB.Client.FirstOrDefault(c => c.PhoneNumber == TBPhone.Text);
            if (loggedClient == null)
            {
                MessageBox.Show("Неверный номер телефона", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (loggedClient.Password != PBPassword.Password)
            {
                MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Properties.Settings.Default.ClientId = loggedClient.Id;
            Properties.Settings.Default.Save();
            App.LoggedClient = loggedClient;
            new MainWindow().Show();
            App.LoginWindowInstance.Close();

        }

        private void BRegistration_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }

        private void ResetPasswordHyperLink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ResetPasswordPage());
        }
    }
}
