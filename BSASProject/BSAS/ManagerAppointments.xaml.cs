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
using ClassLibrary3;

namespace BSASGUI
{
    /// <summary>
    /// Interaction logic for ManagerAppointments.xaml
    /// </summary>
    public partial class ManagerAppointments : Page
    {

        DBEntities db = new DBEntities("metadata=res://*/DBModel.csdl|res://*/DBModel.ssdl|res://*/DBModel.msl;provider=System.Data.SqlClient;provider connection string='data source=192.168.178.48;initial catalog=DB;user id=Suser;password=password2015;MultipleActiveResultSets=True;App=EntityFramework'");
        List <Appointment> App = new List<Appointment>();
        
        public ManagerAppointments()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lstAppointmetsList.ItemsSource =App;
            
            foreach (var item in db.Appointments)
            {
                App.Add(item);

            }
            
        }
    }
}
