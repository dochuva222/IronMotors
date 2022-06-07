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

namespace IronMotors.Pages.MainWindowPages
{
    /// <summary>
    /// Interaction logic for ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        public ClientsPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGClients.SelectedItem = null;
            Refresh();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClientPage(new Client()));
        }

        private void DGClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedClient = DGClients.SelectedItem as Client;
            if (selectedClient == null)
                return;
            NavigationService.Navigate(new ClientPage(selectedClient));

        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            var searchText = TBSearch.Text.ToLower();
            var filtred = App.DB.Client.ToList();
            if (!string.IsNullOrWhiteSpace(searchText))
                filtred = filtred.Where(f => f.Lastname.ToLower().Contains(searchText) || f.Firstname.ToLower().Contains(searchText) || f.PhoneNumber.Contains(searchText)).ToList();
            DGClients.ItemsSource = filtred;
        }
    }
}
