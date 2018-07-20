using HR_BusinessLogicLayer;
using HR_Entities;
using HR_Exception;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR_PresentationLayer_ASP.NET
{
    public partial class HRClerkLogin : System.Web.UI.Page
    {
        HRCredentialsBusinessLogicLayer c = new HRCredentialsBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Credentials user = new Credentials();
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                string UserName = c.CheckHrClerk(user).ToString();
                if (UserName != "")
                {
                    Session["user"] = UserName;
                    //Response.Redirect("Welcome.aspx");
                    FormsAuthentication.RedirectFromLoginPage(user.Username, false);
                }
                else
                {
                    throw new CredentialsException("UserName/Password is Incorrect ");
                }
            }
            catch (CredentialsException ex)
            {
                lblerror.Text = ex.Message;
            }
            catch (SystemException ex)
            {
                lblerror.Text = ex.Message;
            }
        }
    }
}