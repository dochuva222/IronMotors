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
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();

        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var loggedUser = App.DB.User.FirstOrDefault(c => c.Login == TBLogin.Text);
            if (loggedUser == null)
            {
                MessageBox.Show("Неверный логин", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (loggedUser.Password != PBPassword.Password)
            {
                MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (loggedUser.Administrator != null)
                App.LoggedAdmin = loggedUser.Administrator.FirstOrDefault();
            new MainWindow().Show();
            App.LoginWindowInstance.Close();

        }
    }
}
