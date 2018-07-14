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
    /// Interaction logic for LevelControl.xaml
    /// </summary>
    public partial class LevelControl : UserControl
    {
        HRLevelBusinessLogicLayer bll = null;

        public LevelControl()
        {
            InitializeComponent();
            bll = new HRLevelBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }
        private void ClearWindow()
        {
            txtLevelDescription.Text = "";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try {
                Level l = new Level();
                l.LevelDescription = txtLevelDescription.Text;
                bll.Add(l);
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "LevelId";
                txtLevelId.Text = bll.GetLevelId().ToString();
                ClearWindow();
                MessageBox.Show("Level Added Sucessfully");


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

                bll.Remove(int.Parse(txtLevelId.Text));
                txtLevelId.Text = bll.GetLevelId().ToString();
                ClearWindow();
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "LevelId";

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
                
                Level l = new Level();
                l = (Level)lsSearch.SelectedValue;


                txtLevelId.Text = l.LevelId.ToString();
                txtLevelDescription.Text = l.LevelDescription;


                dgRecords.ItemsSource = bll.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try {
                Level l = new Level();
                l.LevelId = int.Parse(txtLevelId.Text);
                l.LevelDescription = txtLevelDescription.Text;
                bll.Modify(l);
                MessageBox.Show("Updated Successfully");
                lsSearch.ItemsSource = bll.GetAll();
                lsSearch.DisplayMemberPath = "LevelId";

                dgRecords.ItemsSource = bll.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtLevelId.Text = bll.GetLevelId().ToString();
            lsSearch.ItemsSource = bll.GetAll();
            lsSearch.DisplayMemberPath = "LevelId";

            dgRecords.ItemsSource = bll.GetAll();
        }
    }
}
