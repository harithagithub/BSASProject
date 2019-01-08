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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class UserDashboard : Window
    {

        public User user = new User();
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            Products P = new Products();
            frmMain.Navigate(P);
                      
        }

        private void btnAppointments_Clik(object sender, RoutedEventArgs e)
        {
            UserAppointments ua = new UserAppointments();
            frmMain.Navigate(ua);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            Products p= new Products();
            frmMain.Navigate(p);
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}
 