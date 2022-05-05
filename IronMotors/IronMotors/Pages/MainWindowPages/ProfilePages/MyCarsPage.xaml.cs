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
    /// Interaction logic for MyCarsPage.xaml
    /// </summary>
    public partial class MyCarsPage : Page
    {
        public MyCarsPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            LVMyCars.ItemsSource = App.DB.Car.Where(c => c.ClientId == App.LoggedClient.Id).ToList();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CarPage(new Car()));
        }

        private void LVMyCars_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedCar = LVMyCars.SelectedItem as Car;
            if (selectedCar == null)
            {
                return;
            }
            NavigationService.Navigate(new CarPage(selectedCar));
        }
    }
}
