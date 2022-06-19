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
    /// Interaction logic for CarServiceChart.xaml
    /// </summary>
    public partial class CarServiceChart : Page
    {
        CarService contextCarService;
        public CarServiceChart(CarService carService)
        {
            InitializeComponent();
            var mainArea = MainChart.ChartAreas.Add("mainArea");
            mainArea.AxisY.Interval = 500;
            contextCarService = carService;
            LHeader.Content = new AccessText() { Text = $"Прибыль автосервиса {contextCarService.Address}", TextWrapping = TextWrapping.WrapWithOverflow };
        }

        private void DPFromDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DPToDate.BlackoutDates.Clear();
            DPToDate.SelectedDate = null;
            var selectedDate = DPFromDate.SelectedDate;
            if (!selectedDate.HasValue)
                return;
            DPToDate.BlackoutDates.Add(new CalendarDateRange(DateTime.MinValue.Date, selectedDate.Value.AddDays(-1)));
        }
        private void BFormChart_Click(object sender, RoutedEventArgs e)
        {
            MainChart.Series.Clear();
            var fromDate = DPFromDate.SelectedDate;
            var toDate = DPToDate.SelectedDate;
            var filtred = contextCarService.Maintenance.ToList();
            if (fromDate.HasValue)
                filtred = filtred.Where(f => f.DateTime.Date >= fromDate.Value.Date).ToList();
            if (toDate.HasValue)
                filtred = filtred.Where(f => f.DateTime.Date <= toDate.Value.Date).ToList();
            var chartData = filtred.GroupBy(f => f.DateTime.Date).ToDictionary(key => key.Key, value => value.Sum(c => c.ServiceSum));
            var seria = MainChart.Series.Add("MainSeria");
            seria.Points.DataBindXY(chartData.Keys, chartData.Values);
        }
    }
}
