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
    public partial class SkillsControl : System.Web.UI.Page
    {

        HRSkillBusinessLogiclayer bll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            bll = new HRSkillBusinessLogiclayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);


        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Skill skill=new Skill();
                skill.SkillName = txtSkillName.Text;
                skill.SkillDescription = txtSkillDes.Text;
                skill.CategoryId = int.Parse(ddCategory.SelectedValue);


                bll.Add(skill);
                Response.Write("<script type='text/javascript'>alert('Details Inserted Successfully');</script>");
                Response.Redirect("SkillSearch.aspx");
            }
            catch (SkillException ex)
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