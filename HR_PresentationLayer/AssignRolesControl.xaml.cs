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
using HR_Entities;
using HR_BusinessLogicLayer;
using System.Configuration;

namespace HR_PresentationLayer
{
    /// <summary>
    /// Interaction logic for AssignRolesControl.xaml
    /// </summary>
    public partial class AssignRolesControl : UserControl
    {
        HRUserRolesBusinessLogicLayer bll = null;
        public AssignRolesControl()
        {
            InitializeComponent();
            bll = new HRUserRolesBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
            cbUserId.ItemsSource = bll.GetAllUser();
            cbUserId.DisplayMemberPath = "UserId";
            cbRoles.ItemsSource = bll.GetAllRoles();
            cbRoles.DisplayMemberPath = "RoleName";
            dgRecords.ItemsSource = bll.GetAll();
        }

        private void btnAssgin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool flag = false;
                UserRoles u = new UserRoles();
                u.UserId = ((Users)cbUserId.SelectedItem).UserId;

                u.RoleId = ((Roles)cbRoles.SelectedItem).RoleId;

                List<UserRoles> userRolesList = bll.GetAll();
                foreach (var userRole in userRolesList)
                {
                    if (u.UserId == userRole.UserId) flag = true;

                }
                if (flag == true)
                    bll.Modify(u);
                else
                    bll.Create(u);

                MessageBox.Show("Updated Sucessfully");
                cbUserId.ItemsSource = bll.GetAllUser();
                cbUserId.DisplayMemberPath = "UserId";
                cbRoles.ItemsSource = bll.GetAllRoles();
                cbRoles.DisplayMemberPath = "RoleName";
                dgRecords.ItemsSource = bll.GetAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
