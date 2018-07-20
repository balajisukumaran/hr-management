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
    public partial class SpecialityControl : System.Web.UI.Page
    {
        HRSpecialityBusinessLogicLayer bll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            bll = new HRSpecialityBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Speciality speciality = new Speciality();
                speciality.SpecialityName = txtSpecialityName.Text;
                bll.Add(speciality);
                Response.Write("<script type='text/javascript'>alert('Details Inserted Successfully');</script>");
                Response.Redirect("SpecialitySearch.aspx");
            }
            catch (SpecialityException ex)
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