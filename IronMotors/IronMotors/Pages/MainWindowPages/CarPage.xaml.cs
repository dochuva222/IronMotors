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
            //if (contextCar.Id == 0)
            //    DPPhotos.IsEnabled = false;
            if (contextCar.Id != 0)
            {
                LHeader.Content = "Редактированание автомобиля";
                CBBrands.SelectedItem = car.Model.CarBrand;
                CBModels.ItemsSource = App.DB.Model.Where(m => m.CarBrandId == contextCar.Model.CarBrandId).ToList();
                CBModels.SelectedItem = car.Model;
                oldValues = App.DB.Entry(contextCar).CurrentValues.Clone();
                Refresh();
            }
            else
            {
                LHeader.Content = "Добавление автомобиля";
            }
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";
            contextCar.Model = CBModels.SelectedItem as Model;
            if (!MyValidator.Validate(contextCar, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (contextCar.Id == 0)
                App.DB.Car.Add(contextCar);
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
                contextCar.CarImage.Add(carImage);
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
            LVCarImages.ItemsSource = contextCar.CarImage.ToList();
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

        private void CBBrands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedBrand = CBBrands.SelectedItem as CarBrand;
            if (selectedBrand == null)
                return;
            CBModels.SelectedItem = null;
            CBModels.ItemsSource = App.DB.Model.Where(m => m.CarBrandId == selectedBrand.Id).ToList();
        }
    }
}
