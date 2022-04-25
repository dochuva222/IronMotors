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

namespace IronMotors.Pages.MainWindowPages.ProfilePages
{
    /// <summary>
    /// Interaction logic for MyDataPage.xaml
    /// </summary>
    public partial class MyDataPage : Page
    {
        public MyDataPage()
        {
            InitializeComponent();
            DataContext = App.LoggedClient;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
