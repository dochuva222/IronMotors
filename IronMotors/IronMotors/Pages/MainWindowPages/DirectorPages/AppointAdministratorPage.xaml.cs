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

namespace IronMotors.Pages.MainWindowPages.DirectorPages
{
    /// <summary>
    /// Interaction logic for AppointAdministratorPage.xaml
    /// </summary>
    public partial class AppointAdministratorPage : Page
    {
        CarService contextCarService;
        public AppointAdministratorPage(CarService carService)
        {
            InitializeComponent();
            contextCarService = carService;
            if (contextCarService.Administrator.FirstOrDefault() != null)
                LCurrentAdmin.Content = contextCarService.Administrator.FirstOrDefault().User.Fullname;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CBAdmins.ItemsSource = App.DB.Administrator.Where(a => a.CarService == null).ToList();
        }

        private void BAddAdmin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdministratorPage());
        }

        private void BApppointAdmin_Click(object sender, RoutedEventArgs e)
        {
            var selectedAdmin = CBAdmins.SelectedItem as Administrator;
            if (selectedAdmin == null)
            {
                MessageBox.Show("Выберите администратора");
                return;
            }
            contextCarService.Administrator = null;
            selectedAdmin.CarService = contextCarService;
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
