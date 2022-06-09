using IronMotors.Pages;
using IronMotors.Pages.MainWindowPages;
using IronMotors.Pages.MainWindowPages.DirectorPages;
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

namespace IronMotors.AppWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.MainWindowInstance = this; //запись окна на хранение см. App.xaml.cs
            if (App.LoggedAdmin != null)
                MainFrame.Navigate(new MenuPage());
            else
                MainFrame.Navigate(new DirectorMenuPage());
        }
    }
}
