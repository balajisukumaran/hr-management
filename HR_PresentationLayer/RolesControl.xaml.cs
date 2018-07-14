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
    /// Interaction logic for RolesControl.xaml
    /// </summary>
    public partial class RolesControl : UserControl
    {
        HRRolesBusinessLogicLayer bll = null;
        public RolesControl()
        {

            InitializeComponent();
            bll = new HRRolesBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Roles r = new Roles();
                r.RoleName = txtRoleName.Text;
                bll.Add(r);
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "RoleId";

                dgRecords.ItemsSource = bll.GetAll();
                txtRoleId.Text = bll.GetRoleId().ToString();
                ClearWindow();
                MessageBox.Show("Role Added Sucessfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearWindow()
        {
            txtRoleName.Text = "";

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                bll.Remove(int.Parse(txtRoleId.Text));
                txtRoleId.Text = bll.GetRoleId().ToString();
                ClearWindow();
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "RoleId";

                dgRecords.ItemsSource = bll.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Roles r = new Roles();
                r.RoleId = int.Parse(txtRoleId.Text);
                r.RoleName = txtRoleName.Text;
                bll.Modify(r);
                MessageBox.Show("Updated Sucessfully");
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "RoleId";

                dgRecords.ItemsSource = bll.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {




                Roles r = new Roles();
                r = (Roles)lsSearch.SelectedValue;


                txtRoleId.Text = r.RoleId.ToString();
                txtRoleName.Text = r.RoleName;

                dgRecords.ItemsSource = bll.GetAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            txtRoleId.Text = bll.GetRoleId().ToString();
            lsSearch.ItemsSource = bll.GetAll();
            lsSearch.DisplayMemberPath = "RoleId";

            dgRecords.ItemsSource = bll.GetAll();
        }
    }
}
