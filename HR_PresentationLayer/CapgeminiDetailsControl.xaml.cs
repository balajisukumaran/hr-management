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
    /// Interaction logic for HomeControl.xaml
    /// </summary>
    public partial class HomeControl : UserControl
    {

        HRCapgeminiDetailsBusinessLogicLayer bll = null;
        public HomeControl()
        {
            InitializeComponent();
            bll = new HRCapgeminiDetailsBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }
        private void ClearWindow()
        {
            txtEmail.Text = "";
            dpDateHired.Text = "";

        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CapgeminiDetails c = new CapgeminiDetails();
                c.EmployeeId = ((Employee)cbEmployeeId.SelectedItem).EmployeeID;
                c.Email = txtEmail.Text;
                c.LevelId = ((Level)cbLevel.SelectedItem).LevelId;
                c.DateHired = DateTime.Parse(dpDateHired.Text);
                c.SpecialityId = ((Speciality)cbSpeciality.SelectedItem).SpecialityID;
                c.StatusId = ((CivilStatus)cbStatus.SelectedItem).StatusId;
                bll.Add(c);

                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "EmployeeId";


                cbEmployeeId.ItemsSource = bll.GetAllEmployee();
                cbEmployeeId.DisplayMemberPath = "EmployeeID";

                cbStatus.ItemsSource = bll.GetAllStatus();
                cbStatus.DisplayMemberPath = "StatusDescription";

                cbSpeciality.ItemsSource = bll.GetAllSpeciality();
                cbSpeciality.DisplayMemberPath = "SpecialityName";

                cbLevel.ItemsSource = bll.GetAllLevel();
                cbLevel.DisplayMemberPath = "LevelDescription";

                dgRecords.ItemsSource = bll.GetAll();
                ClearWindow();


                MessageBox.Show("Capgemini Details Added Sucessfully");

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

                CapgeminiDetails c = new CapgeminiDetails();
                c = (CapgeminiDetails)lsSearch.SelectedValue;

                cbEmployeeId.ItemsSource = bll.GetAllEmployee();
                cbEmployeeId.DisplayMemberPath = "EmployeeID";
                cbEmployeeId.Text= (bll.SelectEmployee(c.EmployeeId)).EmployeeID.ToString();

                txtEmail.Text = c.Email;

                cbLevel.ItemsSource = bll.GetAllLevel();
                cbLevel.DisplayMemberPath = "LevelDescription";
                cbLevel.Text= (bll.SelectLevel(c.LevelId)).LevelDescription;

                dpDateHired.Text = c.DateHired.ToString();

                cbSpeciality.ItemsSource = bll.GetAllSpeciality();
                cbSpeciality.DisplayMemberPath = "SpecialityName";
                cbSpeciality.Text = (bll.SelectSpeciality(c.SpecialityId)).SpecialityName;

                cbStatus.ItemsSource = bll.GetAllStatus();
                cbStatus.DisplayMemberPath = "StatusDescription";
                cbStatus.Text = (bll.SelectStatus(c.StatusId)).StatusDescription;


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
        

                CapgeminiDetails c = new CapgeminiDetails();

                c.EmployeeId = ((Employee)cbEmployeeId.SelectedItem).EmployeeID;

                c.Email = txtEmail.Text;
                c.LevelId = ((Level)cbLevel.SelectedItem).LevelId;
                c.DateHired = DateTime.Parse(dpDateHired.Text);
                c.SpecialityId = ((Speciality)cbSpeciality.SelectedItem).SpecialityID;
                c.StatusId = ((CivilStatus)cbStatus.SelectedItem).StatusId;


                bll.Modify(c);
                MessageBox.Show("Updated Sucessfully");


                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "EmployeeId";


                cbEmployeeId.ItemsSource = bll.GetAllEmployee();
                cbEmployeeId.DisplayMemberPath = "EmployeeID";


                cbStatus.ItemsSource = bll.GetAllStatus();
                cbStatus.DisplayMemberPath = "StatusDescription";

                cbSpeciality.ItemsSource = bll.GetAllSpeciality();
                cbSpeciality.DisplayMemberPath = "SpecialityName";

                cbLevel.ItemsSource = bll.GetAllLevel();
                cbLevel.DisplayMemberPath = "LevelDescription";

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

                bll.Remove(int.Parse(cbEmployeeId.Text));



                ClearWindow();


                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "EmployeeId";


                cbEmployeeId.ItemsSource = bll.GetAllEmployee();
                cbEmployeeId.DisplayMemberPath = "EmployeeID";

                cbStatus.ItemsSource = bll.GetAllStatus();
                cbStatus.DisplayMemberPath = "StatusDescription";

                cbSpeciality.ItemsSource = bll.GetAllSpeciality();
                cbSpeciality.DisplayMemberPath = "SpecialityName";

                cbLevel.ItemsSource = bll.GetAllLevel();
                cbLevel.DisplayMemberPath = "LevelDescription";

                dgRecords.ItemsSource = bll.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dpDateHired.Text = DateTime.MinValue.ToString();
            cbEmployeeId.ItemsSource = bll.GetAllEmployee();
            cbEmployeeId.DisplayMemberPath = "EmployeeID";

            lsSearch.ItemsSource = bll.GetAll();
            lsSearch.DisplayMemberPath = "EmployeeId";

            cbStatus.ItemsSource = bll.GetAllStatus();
            cbStatus.DisplayMemberPath = "StatusDescription";

            cbSpeciality.ItemsSource = bll.GetAllSpeciality();
            cbSpeciality.DisplayMemberPath = "SpecialityName";

            cbLevel.ItemsSource = bll.GetAllLevel();
            cbLevel.DisplayMemberPath = "LevelDescription";

            dgRecords.ItemsSource = bll.GetAll();
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
