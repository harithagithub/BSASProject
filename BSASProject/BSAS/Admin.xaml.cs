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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {

        DBEntities db = new DBEntities("metadata=res://*/DBModel.csdl|res://*/DBModel.ssdl|res://*/DBModel.msl;provider=System.Data.SqlClient;provider connection string='data source=192.168.178.48;initial catalog=DB;user id=Suser;password=password2015;MultipleActiveResultSets=True;App=EntityFramework'");

        List<User> users = new List<User>();
        List<Log> logs = new List<Log>();
        User selectedUser = new User();
        enum DBOperation
            {
              Add, 
              Modify,
              Delete
             }

        DBOperation dbOperation = new DBOperation();

        public Admin()
        {
            InitializeComponent();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Products_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void frmMain_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void lstUserList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstUserList.SelectedIndex > 0)
            {
                User selectedUser = users.ElementAt(lstUserList.SelectedIndex);
                modiftselectedUser.IsEnabled = true;
                deleteselectedUser.IsEnabled = true;

                if (dbOperation == DBOperation.Add)
                {
                    ClearUserDetails();
                }

                if (dbOperation == DBOperation.Modify)
                {
                   
                    txtForeName.Text = selectedUser.Forename;
                    txtSurname.Text = selectedUser.Surname;
                    txtUserName.Text = selectedUser.UserName;
                    txtPassword.Text = selectedUser.Password;
                    cbAccesslevel.SelectedIndex = selectedUser.LevelId;
                }
            }
        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       /* private void TabControl_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }*/

        private void cbAccesslevel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtPassword_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

       /* private void cbAccesslevel_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }*/

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            if (dbOperation == DBOperation.Add)
            {

                User user = new User();
                user.Forename = txtForeName.Text.Trim();
                user.Surname = txtSurname.Text.Trim();
                user.UserName = txtUserName.Text.Trim();
                user.Password = txtPassword.Text.Trim();
                user.LevelId = cbAccesslevel.SelectedIndex;
                int saveSuccess = SaveUser(user);

                if (saveSuccess == 1)
                {
                    MessageBox.Show("User saved Successfully", "Save to database", MessageBoxButton.OK, MessageBoxImage.Information);
                    RefreshUserList();
                    ClearUserDetails();
                    stkUserPanel.Visibility = Visibility.Collapsed;
                }
                else
                {
                    MessageBox.Show("Problem saving User Record", "Save to database", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

            if ( dbOperation == DBOperation.Modify)
            {
                foreach(var item in db.Users.Where(t=> t.UserId == selectedUser.UserId))
                {
                    item.Forename = txtForeName.Text.Trim();
                    item.Surname = txtSurname.Text.Trim();
                    item.UserName = txtUserName.Text.Trim();
                    item.Password = txtPassword.Text.Trim();
                    item.LevelId = cbAccesslevel.SelectedIndex;
                }
                int saveSuccess = db.SaveChanges();

                if( saveSuccess == 1)
                {
                    MessageBox.Show("User Modified Successfully", "Save to database", MessageBoxButton.OK, MessageBoxImage.Information);
                    RefreshUserList();
                    ClearUserDetails();
                    stkUserPanel.Visibility = Visibility.Collapsed;
                }

                else
                {
                    MessageBox.Show("Problem saving User Record", "Save to database", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        public int SaveUser(User user)
        {
            db.Entry(user).State = System.Data.Entity.EntityState.Added;
            int saveSuccess = db.SaveChanges();
            return saveSuccess;
        } 

        private void RefreshUserList()
        {
            lstUserList.ItemsSource = users;
            users.Clear();
            foreach(var user in db.Users)
            {
                users.Add(user);
            }
            lstUserList.Items.Refresh();
        }

        private void Accesslevel_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshUserList();
            lstLogsList.ItemsSource = logs;
           

            foreach (var log in db.Logs)
            {
                logs.Add(log);

            }
        }

        private void ClearUserDetails()
        {
            txtForeName.Text = "";
            txtSurname.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            cbAccesslevel.SelectedIndex = 0;
        }
        
        private void addNewUser_Click(object sender, RoutedEventArgs e)
        {
            stkUserPanel.Visibility = Visibility.Visible;
        }

        private void modifySelectedUser_Click(object sender, RoutedEventArgs e)
        {
            stkUserPanel.Visibility = Visibility.Visible;
            dbOperation = DBOperation.Modify;

        }

        private void deleteSelectedUser_Click(object sender, RoutedEventArgs e)
        {
            //stkUserPanel.Visibility = Visibility.Visible;
            //User selectedUser = users.ElementAt(lstUserList.SelectedIndex);

            db.Users.RemoveRange(db.Users.Where(t => t.UserId == selectedUser.UserId));
            int saveSuccess = db.SaveChanges();
            if (saveSuccess == 1)
            {
                MessageBox.Show("User Deleted Successfully", "Save to database", MessageBoxButton.OK, MessageBoxImage.Information);
                RefreshUserList();
                ClearUserDetails();
                stkUserPanel.Visibility = Visibility.Collapsed;
            }

            else
            {
                MessageBox.Show("Problem saving User Record", "Delete from database", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            RefreshUserList();
        }
    }
}
