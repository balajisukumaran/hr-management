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
    /// Interaction logic for EmployeeControl.xaml
    /// </summary>
    public partial class EmployeeControl : UserControl
    {
        HREmployeeBusinessLogicLayer bll = null;

        public EmployeeControl()
        {
            InitializeComponent();
            bll = new HREmployeeBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {


            dpBirthDate.Text = DateTime.MinValue.ToString();
            txtEmployeeId.Text = bll.GetEmployeeId().ToString();

            lsSearch.ItemsSource = bll.GetAll();
            lsSearch.DisplayMemberPath = "EmployeeID";


            cbCivilStatus.ItemsSource = bll.GetAllCivilStatus();
            cbCivilStatus.DisplayMemberPath = "StatusDescription";

            cbProject.ItemsSource = bll.GetAllProject();
            cbProject.DisplayMemberPath = "ProjectName";

            cbSkill.ItemsSource = bll.GetAllSkill();
            cbSkill.DisplayMemberPath = "SkillName";

            dgRecords.ItemsSource = bll.GetAll();

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Employee emp = new Employee();
                emp.FirstName = txtFirstName.Text;
                emp.MiddleName = txtMiddleName.Text;
                emp.LastName = txtLastName.Text;
                emp.BirthDate = DateTime.Parse(dpBirthDate.Text);
                emp.Age = txtAge.Text;
                if(rdMale.IsChecked==true)
                emp.Gender = rdMale.Content.ToString();

                if (rdFemale.IsChecked == true)
                    emp.Gender = rdFemale.Content.ToString();
                emp.CivilStatusId = ((CivilStatus)cbCivilStatus.SelectedItem).StatusId;
                emp.Religion = txtReligion.Text;
                emp.Citizenship = txtCitizenship.Text;
                emp.MobileNo = txtMobile.Text;
                emp.HomePhoneNo = txtHomePhoneNo.Text;
                emp.Street1 = txtStreet1.Text;
                emp.Street2 = txtStreet2.Text;
                emp.City = txtCity.Text;
                emp.UserState = txtUserState.Text;
                emp.Zip = txtZip.Text;
                emp.Country = txtCountry.Text;
                emp.ProjectId = ((Project)cbProject.SelectedItem).ProjectId;
                emp.SkillId = ((Skill)cbSkill.SelectedItem).SkillId;
                emp.EducationalBackground = txtEducationalBackground.Text;
                bll.Add(emp);

                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "EmployeeID";


                cbCivilStatus.ItemsSource = bll.GetAllCivilStatus();
                cbCivilStatus.DisplayMemberPath = "StatusDescription";

                cbProject.ItemsSource = bll.GetAllProject();
                cbProject.DisplayMemberPath = "ProjectName";

                cbSkill.ItemsSource = bll.GetAllSkill();
                cbSkill.DisplayMemberPath = "SkillName";

                dgRecords.ItemsSource = bll.GetAll();
                ClearWindow();
                MessageBox.Show("Employee Added Sucessfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearWindow()
        {
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            dpBirthDate.Text = "";
            txtAge.Text = "";
            rdMale.IsChecked = true;
            txtReligion.Text = "";
            txtCitizenship.Text = "";
            txtMobile.Text = "";
            txtHomePhoneNo.Text = "";
            txtStreet1.Text = "";
            txtStreet2.Text = "";
            txtCity.Text = "";
            txtUserState.Text = "";
            txtZip.Text = "";
            txtCountry.Text = "";
            txtEducationalBackground.Text = "";
      

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                bll.Remove(int.Parse(txtEmployeeId.Text));
                txtEmployeeId.Text = bll.GetEmployeeId().ToString();
                ClearWindow();

                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "EmployeeID";


                cbCivilStatus.ItemsSource = bll.GetAllCivilStatus();
                cbCivilStatus.DisplayMemberPath = "StatusDescription";

                cbProject.ItemsSource = bll.GetAllProject();
                cbProject.DisplayMemberPath = "ProjectName";

                cbSkill.ItemsSource = bll.GetAllSkill();
                cbSkill.DisplayMemberPath = "SkillName";

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
                Employee emp = new Employee();

                emp.EmployeeID = int.Parse(txtEmployeeId.Text);
                emp.FirstName = txtFirstName.Text;
                emp.MiddleName = txtMiddleName.Text;
                emp.LastName = txtLastName.Text;
                emp.BirthDate = DateTime.Parse(dpBirthDate.Text);
                emp.Age =txtAge.Text;
                if (rdMale.IsChecked == true)
                    emp.Gender = rdMale.Content.ToString();

                if (rdFemale.IsChecked == true)
                    emp.Gender = rdFemale.Content.ToString();
                emp.CivilStatusId = ((CivilStatus)cbCivilStatus.SelectedItem).StatusId;
                emp.Religion = txtReligion.Text;
                emp.Citizenship = txtCitizenship.Text;
                emp.MobileNo = txtMobile.Text;
                emp.HomePhoneNo = txtHomePhoneNo.Text;
                emp.Street1 = txtStreet1.Text;
                emp.Street2 = txtStreet2.Text;
                emp.City = txtCity.Text;
                emp.UserState = txtUserState.Text;
                emp.Zip = txtZip.Text;
                emp.Country = txtCountry.Text;
                emp.ProjectId = ((Project)cbProject.SelectedItem).ProjectId;
                emp.SkillId = ((Skill)cbSkill.SelectedItem).SkillId;
                emp.EducationalBackground = txtEducationalBackground.Text;

               

                bll.Modify(emp);
                MessageBox.Show("Updated Sucessfully");

                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "EmployeeID";


                cbCivilStatus.ItemsSource = bll.GetAllCivilStatus();
                cbCivilStatus.DisplayMemberPath = "StatusDescription";

                cbProject.ItemsSource = bll.GetAllProject();
                cbProject.DisplayMemberPath = "ProjectName";

                cbSkill.ItemsSource = bll.GetAllSkill();
                cbSkill.DisplayMemberPath = "SkillName";

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
                Employee emp = new Employee();
                emp = (Employee)lsSearch.SelectedValue;
                txtEmployeeId.Text = emp.EmployeeID.ToString();
                txtFirstName.Text = emp.FirstName;
                txtMiddleName.Text = emp.MiddleName;
                txtLastName.Text =emp.LastName;
                dpBirthDate.Text = emp.BirthDate.ToString();
                txtAge.Text = emp.Age.ToString();
                if(emp.Gender=="Male")
                rdMale.IsChecked = true;
                else if (emp.Gender == "Female")
                    rdFemale.IsChecked = true;
                txtReligion.Text = emp.Religion;
                txtCitizenship.Text = emp.Citizenship;
                txtMobile.Text = emp.MobileNo;
                txtHomePhoneNo.Text = emp.HomePhoneNo;
                txtStreet1.Text = emp.Street1;
                txtStreet2.Text = emp.Street2;
                txtCity.Text = emp.City;
                txtUserState.Text = emp.UserState;
                txtZip.Text = emp.Zip.ToString();
                txtCountry.Text = emp.Country;
                txtEducationalBackground.Text = emp.EducationalBackground;


                cbCivilStatus.ItemsSource = bll.GetAllCivilStatus();
                cbCivilStatus.DisplayMemberPath = "StatusDescription";
                cbCivilStatus.Text = (bll.SelectCivilStatus(emp.CivilStatusId)).StatusDescription;


                cbProject.ItemsSource = bll.GetAllProject();
                cbProject.DisplayMemberPath = "ProjectName";
                cbProject.Text= (bll.SelectProject(emp.ProjectId)).ProjectName;


                cbSkill.ItemsSource = bll.GetAllSkill();
                cbSkill.DisplayMemberPath = "SkillName";
                cbSkill.Text= (bll.SelectSkill(emp.SkillId)).SkillName;

                dgRecords.ItemsSource = bll.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
