using IronMotorsService.AppWindows;
using IronMotorsService.Models;
using IronMotorsService.Models.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace IronMotorsService
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IronMotorsEntities DB = new IronMotorsEntities();
        public static Administrator LoggedAdmin;
        public static LoginWindow LoginWindowInstance;
        public static MainWindow MainWindowInstance;

        public App()
        {
            DispatcherUnhandledException += App_DispatcherUnhandledException;
            RegisterAnnotations();
        }

        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;
        }

        private void RegisterAnnotations()
        {
            AddDescriptor<Worker, WorkerMetadata>();
        }

        private void AddDescriptor<T, A>()
        {
            var provider = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(T), typeof(A));
            TypeDescriptor.AddProviderTransparent(provider, typeof(T));
        }
    }
}
