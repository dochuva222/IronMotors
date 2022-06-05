using IronMotorsService.AppWindows;
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

namespace IronMotorsService.Pages.LoginPages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
            if (Properties.Settings.Default.AdministratorId != 0)
            {
                App.LoggedAdmin = App.DB.Administrator.FirstOrDefault(c => c.Id == Properties.Settings.Default.AdministratorId);
                new MainWindow().Show();
                App.LoginWindowInstance.Close();
            }
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var loggedAdmin = App.DB.Administrator.FirstOrDefault(c => c.Login == TBLogin.Text);
            if (loggedAdmin == null)
            {
                MessageBox.Show("Неверный номер телефона", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (loggedAdmin.Password != PBPassword.Password)
            {
                MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Properties.Settings.Default.AdministratorId = loggedAdmin.Id;
            Properties.Settings.Default.Save();
            App.LoggedAdmin = loggedAdmin;
            new MainWindow().Show();
            App.LoginWindowInstance.Close();

        }
    }
}
