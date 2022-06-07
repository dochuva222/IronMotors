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
    /// Interaction logic for CarPage.xaml
    /// </summary>
    public partial class CarPage : Page
    {
        Car contextCar;
        DbPropertyValues oldValues;
        public CarPage(Car car)
        {
            InitializeComponent();
            CBBrands.ItemsSource = App.DB.CarBrand.ToList();
            LoadYears();
            contextCar = car;
            DataContext = contextCar;
            Refresh();
            if (contextCar.Id == 0)
                DPPhotos.IsEnabled = false;
            if (contextCar.Id != 0)
                oldValues = App.DB.Entry(contextCar).CurrentValues.Clone();
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";
            if (!MyValidator.Validate(contextCar, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (contextCar.Id == 0)
            {
                //contextCar.ClientId = App.LoggedClient.Id;
                App.DB.Car.Add(contextCar);
            }
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            if (oldValues != null)
                App.DB.Entry(contextCar).CurrentValues.SetValues(oldValues);
            NavigationService.GoBack();
        }

        private void BAddPhoto_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = ".png, .jpg, jpeg|*.png; *.jpg; *.jpeg" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                var carImage = new CarImage() { CarId = contextCar.Id };
                carImage.Image = File.ReadAllBytes(dialog.FileName);
                App.DB.CarImage.Add(carImage);
                App.DB.SaveChanges();
                Refresh();
            }
        }

        private void BRemovePhoto_Click(object sender, RoutedEventArgs e)
        {
            var selectedPhoto = LVCarImages.SelectedItem as CarImage;
            if (selectedPhoto == null)
            {
                MessageBox.Show("Выберите фото", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            App.DB.CarImage.Remove(selectedPhoto);
            App.DB.SaveChanges();
            Refresh();
        }

        private void Refresh()
        {
            LVCarImages.ItemsSource = App.DB.CarImage.Where(c => c.CarId == contextCar.Id).ToList();
        }

        private void LoadYears()
        {
            for (int i = 1980; i < DateTime.Now.Year; i++)
            {
                CBYears.Items.Add(i);
            }
        }

        private void TBMileage_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"[0-9]"))
                e.Handled = true;
        }
    }
}
