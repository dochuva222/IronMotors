using IronMotors.Models;
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

namespace IronMotors.Pages.MainWindowPages.DirectorPages
{
    /// <summary>
    /// Interaction logic for ServicePage.xaml
    /// </summary>
    public partial class ServicePage : Page
    {
        Service contextService;
        DbPropertyValues oldValues;
        public ServicePage(Service service)
        {
            InitializeComponent();
            contextService = service;
            DataContext = contextService;
            if (contextService.Id != 0)
            {
                LHeader.Content = "Редактрование услуги";
                oldValues = App.DB.Entry(contextService).CurrentValues.Clone();
            }
            else
            {
                LHeader.Content = "Добавление услуги";
            }
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";

            MyValidator.Validate(contextService, out errorMessage);
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (contextService.Id == 0)
                App.DB.Service.Add(contextService);
            App.DB.SaveChanges();

            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            if (oldValues != null)
                App.DB.Entry(contextService).CurrentValues.SetValues(oldValues);
            NavigationService.GoBack();
        }

        private void Price_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"[0-9]"))
                e.Handled = true;
        }

        private void Name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"[A-zА-я]"))
                e.Handled = true;
        }
    }
}
