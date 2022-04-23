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
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var loggedClient = App.DB.Client.FirstOrDefault(c => c.PhoneNumber == TBPhone.Text);
            if (loggedClient == null)
            {
                MessageBox.Show("Неверный номер телефона");
                return;
            }
            if (loggedClient.Password != PBPassword.Password)
            {
                MessageBox.Show("Неверный пароль");
                return;
            }
            App.LoggedClient = loggedClient;
            NavigationService.Navigate(new MainPage());
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
