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
    public partial class CategoriesControl : System.Web.UI.Page
    {
        HRCategoryBusinessLogicLayer bll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            bll = new HRCategoryBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);


        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category();
                category.CategoryName = txtCatName.Text;
                category.CategoryDescription = txtCatDesc.Text;

                bll.Add(category);
                Response.Write("<script type='text/javascript'>alert('Details Inserted Successfully');</script>");
                Response.Redirect("CategoriesSearch.aspx");
            }
            catch (CategoryException ex)
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