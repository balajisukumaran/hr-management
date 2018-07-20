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
    public partial class ProjectControl : System.Web.UI.Page
    {
        HRProjectBusinessLogicLayer bll = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            bll = new HRProjectBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Project project = new Project();
                project.ProjectName = txtProjName.Text;
                project.StartDate=DateTime.Parse(txtStartDate.Text);
                project.EndDate = DateTime.Parse(txtEndDate.Text);
                project.Client = txtClient.Text;
                project.Description = txtDescription.Text;
                
                bll.Add(project);
                Response.Write("<script type='text/javascript'>alert('Details Inserted Successfully');</script>");
                Response.Redirect("Projectsearch.aspx");
            }
            catch (ProjectException ex)
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