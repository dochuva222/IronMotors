using IronMotorsService.Models;
using IronMotorsService.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for WorkerPage.xaml
    /// </summary>
    public partial class WorkerPage : Page
    {
        Worker contextWorker;
        DbPropertyValues oldValues;
        public WorkerPage(Worker worker)
        {
            InitializeComponent();
            contextWorker = worker;
            DataContext = contextWorker;
            if (contextWorker.Id != 0)
                oldValues = App.DB.Entry(contextWorker).CurrentValues.Clone();
        }

        private void Letters_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"[А-я]"))
                e.Handled = true;
        }

        private void Digits_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"[0-9]"))
                e.Handled = true;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";
            if (!MyValidator.Validate(contextWorker, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (contextWorker.Id == 0)
                App.DB.Worker.Add(contextWorker);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            if (oldValues != null)
                App.DB.Entry(contextWorker).CurrentValues.SetValues(oldValues);
            NavigationService.GoBack();
        }
    }
}
