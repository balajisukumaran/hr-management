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
    public partial class CapgeminiDetailsControl : System.Web.UI.Page
    {
        HRCapgeminiDetailsBusinessLogicLayer bll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            bll = new HRCapgeminiDetailsBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                CapgeminiDetails det = new CapgeminiDetails();
                det.EmployeeId = int.Parse(ddEmployeeID.SelectedValue);
                det.Email = txtEmail.Text;
                det.LevelId = int.Parse(ddlevel.SelectedValue);
                det.DateHired = DateTime.Parse(dpDateHired.Text);
                det.SpecialityId = int.Parse(ddSpeciality.SelectedValue);
                det.StatusId = int.Parse(DropDownList1.SelectedValue);
                bll.Add(det);
                Response.Write("<script type='text/javascript'>alert('Details Inserted Successfully');</script>");
                Response.Redirect("CapgeminiDetailSearch.aspx");
            }
            catch (CapgeminiDetailsException ex)
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