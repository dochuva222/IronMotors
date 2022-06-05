﻿using IronMotors.AppWindows;
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
        public static IronMotorsEntities DB = new IronMotorsEntities(); //подключение к бд
        public static Client LoggedClient; //залогиненный клиент
        public static LoginWindow LoginWindowInstance; //для хранения окна логина
        public static MainWindow MainWindowInstance; //для хранения главного окна 
        public static string BingMapsToken = "4avPgdF53ME4SYSkWQBa~tgoNZczGM6VLZ7821dO6dg~Ak1c_TvUfkTSj_NBm1xa_0YdU6PgqfhSSTI9dGhuEVFk8zg2148LPQMo54zVvJnU"; //токен который необходим работы карты, карта скачана через Nuget

        public App()
        {
            DispatcherUnhandledException += App_DispatcherUnhandledException;//обработчик ошибок, обрабатывает все ошибки которые могут возникнуть без вылета приложения
            RegisterAnnotations();
        }

        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;
        }
        //регистрация метадаты смотреть в Caretadata.cs
        private void RegisterAnnotations()
        {
            AddDescriptor<Client, ClientMetadata>();
            AddDescriptor<Car, CarMetadata>();
        }

        private void AddDescriptor<T, A>()
        {
            var provider = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(T), typeof(A));
            TypeDescriptor.AddProviderTransparent(provider, typeof(T));
        }
    }
}
