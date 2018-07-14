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
    /// Interaction logic for SkillsControl.xaml
    /// </summary>
    public partial class SkillsControl : UserControl
    {

        HRSkillBusinessLogiclayer bll = null;

        public SkillsControl()
        {
            InitializeComponent();
            bll = new HRSkillBusinessLogiclayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtSkillId.Text = bll.GetSkillId().ToString();
            lsSearch.ItemsSource = bll.GetAll();
            lsSearch.DisplayMemberPath = "SkillId";
            cbCategory.ItemsSource = bll.GetAllCategory();
            cbCategory.DisplayMemberPath = "CategoryName";

            dgRecords.ItemsSource = bll.GetAll();

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Skill s = new Skill();
                s.SkillName = txtSkillName.Text;
                s.SkillDescription = txtSkillName.Text;
                s.CategoryId = ((Category)cbCategory.SelectedItem).CategoryID;
                bll.Add(s);
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "SkillId";
                cbCategory.ItemsSource = bll.GetAllCategory();
                cbCategory.DisplayMemberPath = "CategoryName";

                dgRecords.ItemsSource = bll.GetAll();
                ClearWindow();
                MessageBox.Show("Skill Added Sucessfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ClearWindow()
        {
            txtSkillDescription.Text = "";
            txtSkillName.Text = "";
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                bll.Remove(int.Parse(txtSkillId.Text));
                txtSkillId.Text = bll.GetSkillId().ToString();
                ClearWindow();
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "SkillId";
                cbCategory.ItemsSource = bll.GetAllCategory();
                cbCategory.DisplayMemberPath = "CategoryName";

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
                
                Skill s = new Skill();
                s = (Skill)lsSearch.SelectedValue;


                txtSkillId.Text = s.SkillId.ToString();
                txtSkillName.Text = s.SkillName;
                txtSkillDescription.Text = s.SkillDescription;
                cbCategory.ItemsSource = bll.GetAllCategory();
                cbCategory.DisplayMemberPath = "CategoryName";
                cbCategory.Text = (bll.SelectCategory(s.CategoryId)).CategoryName;

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
                Skill s = new Skill();
                s.SkillId = int.Parse(txtSkillId.Text);
                s.SkillName = txtSkillName.Text;
                s.SkillDescription = txtSkillDescription.Text;
                s.CategoryId = ((Category)cbCategory.SelectedItem).CategoryID;
                bll.Modify(s);
                MessageBox.Show("Updated Sucessfully");
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "SkillId";
                cbCategory.ItemsSource = bll.GetAllCategory();
                cbCategory.DisplayMemberPath = "CategoryName";

                dgRecords.ItemsSource = bll.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgRecords_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
