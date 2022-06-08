using IronMotors.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
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

namespace IronMotors.Pages.MainWindowPages
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
            if (contextWorker.Id == 0)
            {
                LHeader.Content = "Добавление работника";
            }
            else
            {
                LHeader.Content = "Редактрование работника";
                oldValues = App.DB.Entry(contextWorker).CurrentValues.Clone();
            }
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";

            MyValidator.Validate(contextWorker, out errorMessage);
            if (!string.IsNullOrWhiteSpace(errorMessage))
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

        private void FullNameTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"[А-я]"))
                e.Handled = true;
        }

        private void BChangePhoto_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                contextWorker.Photo = File.ReadAllBytes(dialog.FileName);
                WorkerPhoto.Source = new BitmapImage(new Uri(dialog.FileName));
            }
        }
    }
}
