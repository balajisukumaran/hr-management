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
    /// Interaction logic for AdminLoginControl.xaml
    /// </summary>
    public partial class AdminLoginControl : UserControl
    {

        HRCredentialsBusinessLogicLayer bll = null;
   
        public AdminLoginControl()
        {
            InitializeComponent();
            bll = new HRCredentialsBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow adminControls = new MainWindow();
            try {
                Credentials c = new Credentials();
                c.Username = txtUserName.Text;
                c.Password = txtPassword.Password;
                if (bll.Check(c))
                {

                    adminControls.Show();
                    Window.GetWindow(this).Close();


                }
                else {
                    MessageBox.Show("Invalid Username/Password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


}
    }
}
