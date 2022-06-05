using IronMotorsService.Models;
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

namespace IronMotorsService.Pages.MaintenancesPages
{
    /// <summary>
    /// Interaction logic for AppointWorkersPage.xaml
    /// </summary>
    public partial class AppointWorkersPage : Page
    {
        Maintenance contextMaintenance;
        public AppointWorkersPage(Maintenance maintenance)
        {
            InitializeComponent();
            contextMaintenance = maintenance;
        }
    }
}
