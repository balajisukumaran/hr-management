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
    public partial class EmployeeControl : System.Web.UI.Page
    {
        HREmployeeBusinessLogicLayer bll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            bll = new HREmployeeBusinessLogicLayer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);


        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                Employee emp = new Employee();
                emp.FirstName = txtFirstName.Text;
                emp.MiddleName = txtMiddleName.Text;
                emp.LastName = txtLastName.Text;
                emp.BirthDate = DateTime.Parse(dpDOB.Text);
                emp.Age = txtAge.Text;
                emp.Gender = rdGender.SelectedValue;
               
                emp.CivilStatusId = int.Parse(ddCivilStatus.SelectedValue);
                emp.Religion = txtReligion.Text;
                emp.Citizenship = txtCitizen.Text;
                emp.MobileNo = txtMobileNo.Text;
                emp.HomePhoneNo = txtHomePhoneNo.Text;
                emp.Street1 = txtStreet1.Text;
                emp.Street2 = txtStreet2.Text;
                emp.City = txtCity.Text;
                emp.UserState = txtUserState.Text;
                emp.Zip = txtZip.Text;
                emp.Country = txtCountry.Text;
                emp.ProjectId = int.Parse(ddProject.SelectedValue);
                emp.SkillId = int.Parse(ddSkills.SelectedValue);
                emp.EducationalBackground = txtEducationalBackground.Text;
                bll.Add(emp);
                Response.Write("<script type='text/javascript'>alert('Details Inserted Successfully');</script>");
                Response.Redirect("EmployeeSearch.aspx");


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