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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BSASGUI
{
    /// <summary>
    /// Interaction logic for Products.xaml
    /// </summary>
    public partial class Products : Page
    {
        DBEntities db = new DBEntities("metadata=res://*/DBModel.csdl|res://*/DBModel.ssdl|res://*/DBModel.msl;provider=System.Data.SqlClient;provider connection string='data source=192.168.178.48;initial catalog=DB;user id=Suser;password=password2015;MultipleActiveResultSets=True;App=EntityFramework'");
        List<Product> Pro = new List<Product>();

        public Products()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ProductsList.ItemsSource = Pro;

            foreach (var item in db.Products)
            {
                Pro.Add(item);

            }

        }
    }
}
