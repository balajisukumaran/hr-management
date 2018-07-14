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
using HR_Entities;
using HR_BusinessLogicLayer;

using System.Windows.Shapes;
using System.Configuration;

namespace HR_PresentationLayer
{
    /// <summary>
    /// Interaction logic for UsersControl.xaml
    /// </summary>
    public partial class UsersControl : UserControl
    {
        HRUsersBusinessLogicLayer bll = null;
        public UsersControl()
        {
            InitializeComponent();
            bll = new HRUsersBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Users u = new Users();
                u.UserName = txtUsername.Text;
                u.Password = txtPassword.Text;
                u.Firstname = txtFirstname.Text;
                u.Lastname = txtLastname.Text;


                bll.Add(u);
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "UserId";

                dgRecords.ItemsSource = bll.GetAll();
                txtUserId.Text = bll.GetUserId().ToString();
                ClearWindow();
                MessageBox.Show("User Added Sucessfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearWindow()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";

        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                bll.Remove(int.Parse(txtUserId.Text));
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "UserId";
                txtUserId.Text = bll.GetUserId().ToString();

                dgRecords.ItemsSource = bll.GetAll();
                ClearWindow();
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


                Users u = new Users();

                u = (Users)lsSearch.SelectedValue;
                txtUserId.Text = u.UserId.ToString();
                txtUsername.Text = u.UserName;
                txtPassword.Text = u.Password;
                txtFirstname.Text = u.Firstname;
                txtLastname.Text = u.Lastname;

                dgRecords.ItemsSource = bll.GetAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Users u = new Users();

                u.UserId = int.Parse(txtUserId.Text);
                u.UserName = txtUsername.Text;
                u.Password = txtPassword.Text;
                u.Firstname = txtFirstname.Text;
                u.Lastname = txtLastname.Text;


                bll.Modify(u);
                MessageBox.Show("Updated Sucessfully");
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "UserId";

                dgRecords.ItemsSource = bll.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            lsSearch.ItemsSource = bll.GetAll();
            lsSearch.DisplayMemberPath = "UserId";
            txtUserId.Text = bll.GetUserId().ToString();

            dgRecords.ItemsSource = bll.GetAll();
        }
    }
}
