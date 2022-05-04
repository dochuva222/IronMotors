using IronMotors.Pages.MainWindowPages.ProfilePages;
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
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
            ProfileFrame.Navigate(new MyDataPage());
        }

        private void BMyProfile_Click(object sender, RoutedEventArgs e)
        {
            ProfileFrame.Navigate(new MyDataPage());
        }

        private void BCalendar_Click(object sender, RoutedEventArgs e)
        {
            ProfileFrame.Navigate(new CalendarPage());
        }

        private void BMessages_Click(object sender, RoutedEventArgs e)
        {
            ProfileFrame.Navigate(new MessagesPage());
        }

        private void BMyCars_Click(object sender, RoutedEventArgs e)
        {
            ProfileFrame.Navigate(new MyCarsPage());
        }
    }
}
