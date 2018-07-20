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
    public partial class AssignRoles : System.Web.UI.Page
    {
        HRUserRolesBusinessLogicLayer bll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            bll = new HRUserRolesBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                bool flag = false;
                UserRoles u = new UserRoles();
                u.UserId = int.Parse(ddUserId.SelectedValue);

                u.RoleId = int.Parse(ddRole.SelectedValue);

                List<UserRoles> userRolesList = bll.GetAll();
                foreach (var userRole in userRolesList)
                {
                    if (u.UserId == userRole.UserId) flag = true;

                }
                if (flag == true)
                    bll.Modify(u);
                else
                    bll.Create(u);
                Response.Write("<script type='text/javascript'>alert('Details Inserted Successfully');</script>");
                Response.Redirect("AssignRolesSearch.aspx");


            }
            catch (UserRolesException ex)
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