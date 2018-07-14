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
    /// Interaction logic for ProjectControl.xaml
    /// </summary>
    public partial class ProjectControl : UserControl
    {
        HRProjectBusinessLogicLayer bll = null;
        public ProjectControl()
        {
            InitializeComponent();
            bll = new HRProjectBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Project p = new Project();
                p = (Project)lsSearch.SelectedValue;
                txtProjectId.Text = p.ProjectId.ToString();
                txtProjectName.Text = p.ProjectName.ToString();
                txtDescription.Text = p.Description.ToString();
                txtClient.Text = p.Client.ToString();
                dpStartDate.Text = p.StartDate.ToString();
                dpEndDate.Text = p.EndDate.ToString();

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
                Project p = new Project();
               

                p.ProjectId = int.Parse(txtProjectId.Text);
                p.ProjectName = txtProjectName.Text;
                p.Description = txtDescription.Text;
                p.Client = txtClient.Text;
                p.StartDate = DateTime.Parse(dpStartDate.Text);
                p.EndDate = DateTime.Parse(dpEndDate.Text);
                bll.Modify(p);
                MessageBox.Show("Updated Sucessfully");
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "ProjectID";

                dgRecords.ItemsSource = bll.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                bll.Remove(int.Parse(txtProjectId.Text));
                txtProjectId.Text = bll.GetProjectId().ToString();
                ClearWindow();
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "ProjectID";

                dgRecords.ItemsSource = bll.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Project p = new Project();
                p.ProjectName = txtProjectName.Text;
                p.Description = txtProjectName.Text;
                p.Client = txtClient.Text;
                p.StartDate=DateTime.Parse(dpStartDate.Text);

                p.EndDate = DateTime.Parse(dpEndDate.Text);
             
                bll.Add(p);
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "ProjectID";
                txtProjectId.Text = bll.GetProjectId().ToString();

                dgRecords.ItemsSource = bll.GetAll();
                ClearWindow();
                MessageBox.Show("Project Added Sucessfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearWindow()
        {
            txtProjectName.Text = "";
            txtDescription.Text = "";
            txtClient.Text = "";
            dpStartDate.Text = "";
            dpEndDate.Text = "";
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dpStartDate.Text = DateTime.MinValue.ToString();

            dpEndDate.Text = DateTime.MinValue.ToString();
            txtProjectId.Text = bll.GetProjectId().ToString();

            lsSearch.ItemsSource = bll.GetAll();
            lsSearch.DisplayMemberPath = "ProjectId";


            dgRecords.ItemsSource = bll.GetAll();
        }
    }
}
