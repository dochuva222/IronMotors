using IronMotorsService.Models;
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

namespace IronMotorsService.Pages.WorkersPages
{
    /// <summary>
    /// Interaction logic for WorkersPage.xaml
    /// </summary>
    public partial class WorkersPage : Page
    {
        public WorkersPage()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            var searchText = TBSearch.Text.ToLower();
            var filtred = App.LoggedAdmin.CarService.Worker.ToList();
            if (!string.IsNullOrWhiteSpace(searchText))
                filtred = filtred.Where(f => f.Lastname.ToLower().Contains(searchText) 
                                          || f.Firstname.ToLower().Contains(searchText) 
                                          || f.Middlename.ToLower().Contains(searchText)).ToList();
            LVWorkers.ItemsSource = filtred;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LVWorkers.SelectedItem = null;
            Refresh();
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void BAddWorker_Click(object sender, RoutedEventArgs e)
        {
            var newWorker = new Worker() { CarServiceId = App.LoggedAdmin.CarServiceId };
            NavigationService.Navigate(new WorkerPage(newWorker));
        }

        private void LVWorkers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedWorker = LVWorkers.SelectedItem as Worker;
            if (selectedWorker == null)
                return;
            NavigationService.Navigate(new WorkerPage(selectedWorker));
        }
    }
}
