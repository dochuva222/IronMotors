using IronMotors.Models;
using Microsoft.Office.Interop.Word;
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

namespace IronMotors.Pages.MainWindowPages.CarServicePages
{
    public partial class MaintenancesPage : System.Windows.Controls.Page
    {
        CarService contextCarService;
        public MaintenancesPage(CarService carService)
        {
            InitializeComponent();
            contextCarService = carService;
            if (App.LoggedAdmin == null)
            {
                BCreateMaintenance.Visibility = Visibility.Collapsed;
            }
        }

        private void Refresh()
        {
            var fromDate = DPFromDate.SelectedDate;
            var toDate = DPToDate.SelectedDate;
            var filtred = contextCarService.Maintenance.ToList();
            if (fromDate.HasValue)
                filtred = filtred.Where(f => f.DateTime.Date >= fromDate.Value.Date).ToList();
            if (toDate.HasValue)
                filtred = filtred.Where(f => f.DateTime.Date <= toDate.Value.Date).ToList();

            LVMaintenances.ItemsSource = filtred;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void BAbout_Click(object sender, RoutedEventArgs e)
        {
            var selectedMaintenance = (sender as Button).DataContext as Maintenance;
            if (selectedMaintenance == null)
                return;
            NavigationService.Navigate(new MaintenancePage(selectedMaintenance));
        }

        private void BCreateMaintenance_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MaintenancePage(new Maintenance() { CarServiceId = contextCarService.Id }));
        }

        private void DPFromDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DPToDate.BlackoutDates.Clear();
            DPToDate.SelectedDate = null;
            var selectedDate = DPFromDate.SelectedDate;
            if (!selectedDate.HasValue)
                return;
            DPToDate.BlackoutDates.Add(new CalendarDateRange(DateTime.MinValue.Date, selectedDate.Value.AddDays(-1)));
            Refresh();
        }

        private void DPToDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void BClear_Click(object sender, RoutedEventArgs e)
        {
            DPToDate.SelectedDate = null;
            DPFromDate.SelectedDate = null;
            Refresh();
        }

        private void BPrintCheck_Click(object sender, RoutedEventArgs e)
        {
            var selectedMaintenance = (sender as Button).DataContext as Maintenance;
            if (selectedMaintenance == null)
                return;
            var report = new WordReport();
            var selectedType = ReportType.docx;
            var dict = new Dictionary<String, String>();
            dict.Add(nameof(Service.Name), "Название услуги");
            dict.Add(nameof(Service.Price), "Стоимость");

            report.AddParagraph("IronMotors", WdBuiltinStyle.wdStyleHeader);
            report.AddParagraph($"Счет для {selectedMaintenance.Car.Client.Fullname}", WdBuiltinStyle.wdStyleBodyText);
            report.AddParagraph($"Дата и время:  {selectedMaintenance.DateTime}", WdBuiltinStyle.wdStyleBodyText);
            report.AddParagraph($"Машина {selectedMaintenance.Car.CarFullname}", WdBuiltinStyle.wdStyleBodyText);
            report.AddParagraph($"Услуги", WdBuiltinStyle.wdStyleBodyText);
            report.AddTable(selectedMaintenance.MaintenanceService.ToList().Select(c => new
            {
                c.Service.Name,
                c.Service.Price
            }).ToList(), dict);
            report.AddParagraph($"Скидка постоянного клиента: {selectedMaintenance.Discount} %", WdBuiltinStyle.wdStyleBodyText);
            report.AddParagraph($"Итоговая сумма: {selectedMaintenance.ServiceSum}", WdBuiltinStyle.wdStyleBodyText);
            report.SaveReport(selectedType);
        }
    }
}
