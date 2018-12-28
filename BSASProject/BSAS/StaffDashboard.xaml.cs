using ClassLibrary3;
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
using System.Windows.Shapes;

namespace BSASGUI
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class StaffDashboard : Window
    {

        public User user = new User();
        public StaffDashboard()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            Products pd = new Products();
            frmMain.Navigate(pd);
        }

       

        private void btnAppointments_Click(object sender, RoutedEventArgs e)
        {
            StaffAppointments sa = new StaffAppointments();
            frmMain.Navigate(sa);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            Products P = new Products();
            frmMain.Navigate(P);

        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}
