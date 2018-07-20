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
    public partial class LevelControl : System.Web.UI.Page
    {
        HRLevelBusinessLogicLayer bll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            bll = new HRLevelBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            try
            {
                Level level = new Level();
                level.LevelDescription = txtLevelDes.Text;
                bll.Add(level);
                Response.Write("<script type='text/javascript'>alert('Details Inserted Successfully');</script>");
                Response.Redirect("LevelSearch.aspx");
            }
            catch (LevelException ex)
            {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");
            }
            catch (SystemException ex)
            {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");

            }


        }

        protected void btnIns_Click(object sender, EventArgs e)
        {
            try
            {
                Level level = new Level();
                level.LevelDescription = txtLevelDes.Text;
                bll.Add(level);
                Response.Write("<script type='text/javascript'>alert('Details Inserted Successfully');</script>");
                Response.Redirect("LevelSearch.aspx");
            }
            catch (LevelException ex)
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