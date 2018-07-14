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
using HR_BusinessLogicLayer;
using HR_Entities;
using System.Configuration;

namespace HR_PresentationLayer
{
    /// <summary>
    /// Interaction logic for CategoriesControl.xaml
    /// </summary>
    public partial class CategoriesControl : UserControl
    {
        HRCategoryBusinessLogicLayer bll = null;
        public CategoriesControl()
        {
            InitializeComponent();
            bll=new HRCategoryBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {




                Category c = new Category();
                c = (Category)lsSearch.SelectedValue;


                txtCategoryId.Text = c.CategoryID.ToString();
                txtCategoryName.Text = c.CategoryName;
                txtCategoryDesc.Text = c.CategoryDescription;

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
                Category c = new Category();
                c.CategoryID = int.Parse(txtCategoryId.Text);
                c.CategoryName = txtCategoryName.Text;
                c.CategoryDescription = txtCategoryDesc.Text;
                bll.Modify(c);
                MessageBox.Show("Updated Sucessfully");
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "CategoryID";

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

                bll.Remove(int.Parse(txtCategoryId.Text));
                txtCategoryId.Text = bll.GetCategoryID().ToString();
                ClearWindow();
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "CategoryID";

                dgRecords.ItemsSource = bll.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }
        private void ClearWindow()
        {
            txtCategoryName.Text = "";
            txtCategoryDesc.Text = "";

        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Category c = new Category();
                c.CategoryName = txtCategoryName.Text;
                c.CategoryDescription = txtCategoryDesc.Text;
                bll.Add(c);
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "CategoryID";
                txtCategoryId.Text = bll.GetCategoryID().ToString();

                dgRecords.ItemsSource = bll.GetAll();
                ClearWindow();
                MessageBox.Show("Category Added Sucessfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtCategoryId.Text = bll.GetCategoryID().ToString();
            lsSearch.ItemsSource = bll.GetAll();
            lsSearch.DisplayMemberPath = "CategoryID";

            dgRecords.ItemsSource = bll.GetAll();
        }
    }
}
