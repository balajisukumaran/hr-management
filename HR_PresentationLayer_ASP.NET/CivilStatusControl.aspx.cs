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
    public partial class CivilStatusControl : System.Web.UI.Page
    {
        HRCivilStatusBusinessLogicLayer bll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            bll = new HRCivilStatusBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            try
            {
                CivilStatus stat = new CivilStatus();
                stat.StatusDescription = txtStatusDes.Text;
                bll.Add(stat);
                Response.Write("<script type='text/javascript'>alert('Details Inserted Successfully');</script>");
                Response.Redirect("CivilStatusSearch.aspx");
            }
            catch (CivilStatusException ex)
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