using IronMotors.Models;
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

namespace IronMotors.Pages.MainWindowPages.ProfilePages
{
    /// <summary>
    /// Interaction logic for MyDataPage.xaml
    /// </summary>
    public partial class MyDataPage : Page
    {
        public MyDataPage()
        {
            InitializeComponent();
            DataContext = App.LoggedClient;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";
            if (!MyValidator.Validate(App.LoggedClient, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (App.DB.Client.Where(c => c.Id != App.LoggedClient.Id).FirstOrDefault(c => c.PhoneNumber == App.LoggedClient.PhoneNumber) != null)
            {
                MessageBox.Show("Данный номер уже используется", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (App.DB.Client.Where(c => c.Id != App.LoggedClient.Id).FirstOrDefault(c => c.Email == App.LoggedClient.Email) != null)
            {
                MessageBox.Show("Данная электронная почта уже используется", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            App.DB.SaveChanges();
            MessageBox.Show("Данные успешно изменены", "Успешно", MessageBoxButton.OK);
        }

        private void BChangePassword_Click(object sender, RoutedEventArgs e)
        {
            if(PBOldPassword.Password != App.LoggedClient.Password)
            {
                MessageBox.Show("Старый пароль не совпадает", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if(PBNewPassword.Password != PBRepeatPassword.Password)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            App.LoggedClient.Password = PBNewPassword.Password;
            App.DB.SaveChanges();
            PBOldPassword.Clear();
            PBNewPassword.Clear();
            PBRepeatPassword.Clear();
            MessageBox.Show("Пароль успешно изменен", "Успешно", MessageBoxButton.OK);
        }
    }
}
