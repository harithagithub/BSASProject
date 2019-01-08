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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ManagerDashboard : Window
    {

        public User user = new User();

        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            frmMain.Navigate(admin);
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            Products p = new Products();
          
            frmMain.Navigate(p);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged_3(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged_4(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Products_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void frmMain_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void btnAppointments_Click(object sender, RoutedEventArgs e)
        {
            ManagerAppointments MApp = new ManagerAppointments();
           
            frmMain.Navigate(MApp);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            Products P = new Products();
            frmMain.Navigate(P);
        }

        

        
    }
}
