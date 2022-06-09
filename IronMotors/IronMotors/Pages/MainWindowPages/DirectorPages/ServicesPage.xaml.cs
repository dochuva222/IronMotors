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
    /// Interaction logic for ServicesPage.xaml
    /// </summary>
    public partial class ServicesPage : Page
    {
        public ServicesPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGServices.SelectedItem = null;
            Refresh();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ServicePage(new Service()));
        }

        private void DGServices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedService = DGServices.SelectedItem as Service;
            if (selectedService == null)
                return;
            NavigationService.Navigate(new ServicePage(selectedService));

        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            var searchText = TBSearch.Text.ToLower();
            var filtred = App.DB.Service.ToList();
            if (!string.IsNullOrWhiteSpace(searchText))
                filtred = filtred.Where(f => f.Name.ToLower().Contains(searchText)).ToList();
            DGServices.ItemsSource = filtred;
        }
    }
}
