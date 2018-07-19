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

  
    public partial class RolesControl : System.Web.UI.Page
    {
        HRRolesBusinessLogicLayer bll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            bll = new HRRolesBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Roles role = new Roles();
              
                bll.Add(role);
                Response.Write("<script type='text/javascript'>alert('Details Inserted Successfully');</script>");
                Response.Redirect("RolesSearch.aspx");
            }
            catch (RolesException ex)
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
                Roles role = new Roles();
                role.RoleName = txtRoleName.Text;
                bll.Add(role);
                Response.Write("<script type='text/javascript'>alert('Details Inserted Successfully');</script>");
                Response.Redirect("RolesSearch.aspx");
            }
            catch (RolesException ex)
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