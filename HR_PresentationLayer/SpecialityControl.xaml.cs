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
    /// Interaction logic for SpecialityControl.xaml
    /// </summary>
    public partial class SpecialityControl : UserControl
    {
        HRSpecialityBusinessLogicLayer bll = null;
        public SpecialityControl()
        {
            InitializeComponent();
            bll = new HRSpecialityBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtSpecialityId.Text = bll.GetSpecialityId().ToString();
            lsSearch.ItemsSource = bll.GetAll();
            lsSearch.DisplayMemberPath = "SpecialityID";

            dgRecords.ItemsSource = bll.GetAll();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Speciality s = new Speciality();
                s.SpecialityName = txtSpecialityName.Text;
                bll.Add(s);
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "SpecialityID";
                txtSpecialityId.Text = bll.GetSpecialityId().ToString();

                dgRecords.ItemsSource = bll.GetAll();
                ClearWindow();
                MessageBox.Show("Speciality Added Sucessfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearWindow()
        {
            txtSpecialityName.Text = "";
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                bll.Remove(int.Parse(txtSpecialityId.Text));
                txtSpecialityId.Text = bll.GetSpecialityId().ToString();
                ClearWindow();
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "SpecialityID";

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
                Speciality s = new Speciality();
               s.SpecialityID = int.Parse(txtSpecialityId.Text);
                s.SpecialityName = txtSpecialityName.Text;
                bll.Modify(s);
                MessageBox.Show("Updated Sucessfully");
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "SpecialityID";

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




                Speciality s = new Speciality();
                s = (Speciality)lsSearch.SelectedValue;


                txtSpecialityId.Text = s.SpecialityID.ToString();
                txtSpecialityName.Text = s.SpecialityName;

                dgRecords.ItemsSource = bll.GetAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
