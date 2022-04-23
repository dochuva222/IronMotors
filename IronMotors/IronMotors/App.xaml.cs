using IronMotors.Models;
using IronMotors.Models.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace IronMotors
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IronMotorsEntities DB = new IronMotorsEntities();
        public static Client LoggedClient;

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
            AddDescriptor<Client, ClientMetadata>();
        }
        
        private void AddDescriptor<T, A>()
        {
            var provider = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(T), typeof(A));
            TypeDescriptor.AddProviderTransparent(provider, typeof(T));
        }
    }
}
