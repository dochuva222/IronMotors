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
    /// Interaction logic for WorkersPage.xaml
    /// </summary>
    public partial class WorkersPage : Page
    {
        CarService contextCarService;
        public WorkersPage(CarService carService)
        {
            InitializeComponent();
            contextCarService = carService;
        }

        private void BAddWorker_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WorkerPage(new Worker() { CarServiceId = contextCarService.Id }));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LVWorkers.SelectedItem = null;
            Refresh();
        }

        private void Refresh()
        {
            var searchText = TBSearch.Text.ToLower();
            var filtred = contextCarService.Worker.ToList();
            if (!string.IsNullOrWhiteSpace(searchText))
                filtred = filtred.Where(f => f.Lastname.ToLower().Contains(searchText) || f.Firstname.ToLower().Contains(searchText) || f.Speciality.ToLower().Contains(searchText)).ToList();
            LVWorkers.ItemsSource = filtred;
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
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
