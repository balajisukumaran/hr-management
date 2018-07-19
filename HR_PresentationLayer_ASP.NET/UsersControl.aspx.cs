using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HR_Entities;
using HR_Exception;
using HR_BusinessLogicLayer;
using System.Configuration;

namespace HR_PresentationLayer_ASP.NET
{
    public partial class UsersControl : System.Web.UI.Page
    {
        HRUsersBusinessLogicLayer bll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            bll = new HRUsersBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }

        //protected void btnInsert_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        Users user = new Users();
        //        user.Firstname = txtFirstName.Text;
        //        user.Lastname = txtLastName.Text;
        //        user.UserName = txtUserName.Text;
        //        user.Password = txtPassword.Text;
        //        bll.Add(user);
        //        Response.Write("<script type='text/javascript'>alert('Details Inserted Successfully');</script>");
        //        Response.Redirect("CapgeminiDetailSearch.aspx");
        //    }
        //    catch (UsersException ex)
        //    {
        //        Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");
        //    }
        //    catch (SystemException ex)
        //    {
        //        Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");

        //    }
        //}

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                Users user = new Users();
                user.Firstname = txtFirstName.Text;
                user.Lastname = txtLastName.Text;
                user.UserName = txtUserName.Text;
                user.Password = txtPassword.Text;
                bll.Add(user);
                Response.Write("<script type='text/javascript'>alert('Details Inserted Successfully');</script>");
                Response.Redirect("CapgeminiDetailSearch.aspx");
            }
            catch (UsersException ex)
            {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");
            }
            catch (SystemException ex)
            {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");

            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            try
            {
                Users user = new Users();
                user.Firstname = txtFirstName.Text;
                user.Lastname = txtLastName.Text;
                user.UserName = txtUserName.Text;
                user.Password = txtPassword.Text;
                bll.Add(user);
                Response.Write("<script type='text/javascript'>alert('Details Inserted Successfully');</script>");
                Response.Redirect("UsersSearch.aspx");
            }
            catch (UsersException ex)
            {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");
            }
            catch (SystemException ex)
            {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");

            }
        }
    }
}