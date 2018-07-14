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
    /// Interaction logic for CivilStatusControl.xaml
    /// </summary>
    public partial class CivilStatusControl : UserControl
    {
        HRCivilStatusBusinessLogicLayer bll = null;
        public CivilStatusControl()
        {
            InitializeComponent();
            bll = new HRCivilStatusBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtStatusId.Text = bll.GetStatusId().ToString();
            lsSearch.ItemsSource = bll.GetAll();
            lsSearch.DisplayMemberPath = "StatusId";

            dgRecords.ItemsSource = bll.GetAll();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CivilStatus c = new CivilStatus();
                c.StatusDescription = txtStatusDesc.Text;
                bll.Add(c);
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "StatusId";
                txtStatusId.Text = bll.GetStatusId().ToString();

                dgRecords.ItemsSource = bll.GetAll();
                ClearWindow();
                MessageBox.Show("Civil Status Added Sucessfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearWindow()
        {
            txtStatusDesc.Text = "";

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CivilStatus c = new CivilStatus();
                c.StatusId = int.Parse(txtStatusId.Text);
                c.StatusDescription = txtStatusDesc.Text;
                bll.Modify(c);
                MessageBox.Show("Updated Sucessfully");
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "StatusId";

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

                bll.Remove(int.Parse(txtStatusId.Text));
                txtStatusId.Text = bll.GetStatusId().ToString();
                ClearWindow();
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "StatusId";

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




                CivilStatus c = new CivilStatus();
                c = (CivilStatus)lsSearch.SelectedValue;


                txtStatusId.Text = c.StatusId.ToString();
                txtStatusDesc.Text = c.StatusDescription;


                dgRecords.ItemsSource = bll.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
    }
}
