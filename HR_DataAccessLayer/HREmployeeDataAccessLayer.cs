using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_DataAccessLayer;
using HR_Entities;
using HR_Exception;
using System.Data.SqlClient;

namespace HR_DataAccessLayer
{
    public class HREmployeeDataAccessLayer
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        public HREmployeeDataAccessLayer(string conString)
        {
            con = new SqlConnection(conString);
        }

        public object NextEmployeeId()
        {
            int nextEmployeeId;
            string NextEmployeeId = "balaji.SP_NEXTID_Employee_HR_Batch4";
            try
            {
                cmd = new SqlCommand(NextEmployeeId, con);
                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@aEmployeeID";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();

                cmd.ExecuteNonQuery();
                nextEmployeeId = (int)outputParameter.Value;
            }
            catch (EmployeeException)
            {
                throw;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return nextEmployeeId;
        }

        public IEnumerable SelectAll()
        {
            List<Employee> employeeList = new List<Employee>();
            string selectAll = "balaji.SP_SELECTALL_Employee_HR_Batch4";


            try
            {

                cmd = new SqlCommand(selectAll, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        Employee emp = new Employee();


                        emp.EmployeeID = (int)dr[0];
                        emp.FirstName = dr[1].ToString();
                        emp.MiddleName = dr[2].ToString();
                        emp.LastName = dr[3].ToString();
                        emp.BirthDate = DateTime.Parse(dr[4].ToString());
                        emp.Age = dr[5].ToString();

                        emp.Gender = dr[6].ToString();


                        emp.CivilStatusId = (int)dr[7];
                        emp.Religion = dr[8].ToString();
                        emp.Citizenship = dr[9].ToString();
                        emp.MobileNo = dr[10].ToString();
                        emp.HomePhoneNo = dr[11].ToString();
                        emp.Street1 = dr[12].ToString();
                        emp.Street2 = dr[13].ToString();
                        emp.City = dr[14].ToString();
                        emp.UserState = dr[15].ToString();
                        emp.Zip = dr[16].ToString();
                        emp.Country = dr[17].ToString();
                        emp.ProjectId = (int)dr[18];
                        emp.SkillId = (int)dr[19];
                        emp.EducationalBackground = dr[20].ToString();


                        employeeList.Add(emp);
                    }
                }
            }
            catch (SkillException)
            {

                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dr.Close();
                con.Close();
            }

            return employeeList;
        }

        public IEnumerable SelectAllCivilStatus()
        {
            List<CivilStatus> civilstatusList = new List<CivilStatus>();
            string selectAll = "balaji.SP_SELECTALL_CivilStatus_HR_Batch4";
            try
            {
                cmd = new SqlCommand(selectAll, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        CivilStatus c = new CivilStatus();
                        c.StatusId = (int)dr[0];
                        c.StatusDescription = dr[1].ToString();
                        civilstatusList.Add(c);
                    }
                }
            }
            catch (CivilStatusException)
            {

                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

                dr.Close();
                con.Close();
            }
            return civilstatusList;

        }

        public IEnumerable SelectAllProject()
        {
            List<Project> projectList = new List<Project>();
            string selectAll = "balaji.SP_SELECTALL_Project_HR_Batch4";
            try
            {
                cmd = new SqlCommand(selectAll, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {

                        Project p = new Project();


                        p.ProjectId = (int)dr[0];
                        p.ProjectName = dr[1].ToString();
                        p.Description = dr[2].ToString();
                        p.Client = dr[3].ToString();
                        p.StartDate = DateTime.Parse(dr[4].ToString());
                        p.EndDate = DateTime.Parse(dr[5].ToString());
                        projectList.Add(p);
                    }
                }
            }
            catch (ProjectException)
            {

                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

                dr.Close();
                con.Close();
            }
            return projectList;

        }

        public IEnumerable SelectAllSkill()
        {
            List<Skill> skillList = new List<Skill>();
            string selectAll = "balaji.SP_SELECTALL_Skill_HR_Batch4";
            try
            {
                cmd = new SqlCommand(selectAll, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {

                        Skill s = new Skill();


                        s.SkillId = (int)dr[0];
                        s.SkillName = dr[1].ToString();
                        s.SkillDescription = dr[2].ToString();
                        s.CategoryId = (int)dr[3];
                        skillList.Add(s);
                    }
                }
            }
            catch (SkillException)
            {

                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

                dr.Close();
                con.Close();
            }
            return skillList;

        }

        public void Insert(Employee emp)
        {
            string insert = "balaji.SP_INSERT_Employee_HR_Batch4";
            try
            {
                cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@aFirstName",emp.FirstName);
                cmd.Parameters.AddWithValue("@aMiddleName",emp.MiddleName);
                cmd.Parameters.AddWithValue("@aLastName", emp.LastName);
                cmd.Parameters.AddWithValue("@aBirthDate", emp.BirthDate);
                cmd.Parameters.AddWithValue("@aAge", emp.Age);
                cmd.Parameters.AddWithValue("@aGender", emp.Gender);
                cmd.Parameters.AddWithValue("@aCivilStatusId", emp.CivilStatusId);
                cmd.Parameters.AddWithValue("@aReligion",emp.Religion);
                cmd.Parameters.AddWithValue("@aCitizenship",emp.Citizenship);
                cmd.Parameters.AddWithValue("@aMobileNo",emp.MobileNo);
                cmd.Parameters.AddWithValue("@aHomePhoneNo",emp.HomePhoneNo);
                cmd.Parameters.AddWithValue("@aStreet1", emp.Street1);
                cmd.Parameters.AddWithValue("@aStreet2",emp.Street2);
                cmd.Parameters.AddWithValue("@aCity",emp.City);
                cmd.Parameters.AddWithValue("@aUserState",emp.UserState);
                cmd.Parameters.AddWithValue("@aZip",emp.Zip);
                cmd.Parameters.AddWithValue("@aCountry",emp.Country);
                cmd.Parameters.AddWithValue("@aProjectId",emp.ProjectId);
                cmd.Parameters.AddWithValue("@aSkillId",emp.SkillId);
                cmd.Parameters.AddWithValue("@aEducationalBackground",emp.EducationalBackground);
                
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (EmployeeException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                con.Close();
            }
        }

        public void Delete(int id)
        {
            string delete = "balaji.SP_DELETE_Employee_HR_Batch4";
            try
            {
                cmd = new SqlCommand(delete, con);
                cmd.Parameters.AddWithValue("@aEmployeeID", id);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (EmployeeException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public void Update(Employee emp)
        {
            int qn;
            string update = "balaji.SP_UPDATE_Employee_HR_Batch4";
            try
            {
                cmd = new SqlCommand(update, con);
                cmd.Parameters.AddWithValue("@aEmployeeID", emp.EmployeeID);
                cmd.Parameters.AddWithValue("@aFirstName", emp.FirstName);
                cmd.Parameters.AddWithValue("@aMiddleName", emp.MiddleName);
                cmd.Parameters.AddWithValue("@aLastName", emp.LastName);
                cmd.Parameters.AddWithValue("@aBirthDate", emp.BirthDate);
                cmd.Parameters.AddWithValue("@aAge", emp.Age);
                cmd.Parameters.AddWithValue("@aGender", emp.Gender);
                cmd.Parameters.AddWithValue("@aCivilStatusId", emp.CivilStatusId);
                cmd.Parameters.AddWithValue("@aReligion", emp.Religion);
                cmd.Parameters.AddWithValue("@aCitizenship", emp.Citizenship);
                cmd.Parameters.AddWithValue("@aMobileNo", emp.MobileNo);
                cmd.Parameters.AddWithValue("@aHomePhoneNo", emp.HomePhoneNo);
                cmd.Parameters.AddWithValue("@aStreet1", emp.Street1);
                cmd.Parameters.AddWithValue("@aStreet2", emp.Street2);
                cmd.Parameters.AddWithValue("@aCity", emp.City);
                cmd.Parameters.AddWithValue("@aUserState", emp.UserState);
                cmd.Parameters.AddWithValue("@aZip", emp.Zip);
                cmd.Parameters.AddWithValue("@aCountry", emp.Country);
                cmd.Parameters.AddWithValue("@aProjectId", emp.ProjectId);
                cmd.Parameters.AddWithValue("@aSkillId", emp.SkillId);
                cmd.Parameters.AddWithValue("@aEducationalBackground", emp.EducationalBackground);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                qn = cmd.ExecuteNonQuery();

            }
            catch (EmployeeException)
            {
                throw;

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                con.Close();
            }
        }

        public CivilStatus SelectByCivilStatus(int civilStatusId)
        {
            CivilStatus c = new CivilStatus();
            string selectBy =
              "balaji.SP_SEARCHBY_CivilStatus_HR_Batch4";
            try
            {
                cmd = new SqlCommand(selectBy, con);
                cmd.Parameters.AddWithValue("@aStatusId", civilStatusId);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    c.StatusId = civilStatusId;
                    c.StatusDescription= dr[1].ToString();
                }

            }
            catch (CivilStatusException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dr.Close();
                con.Close();
            }
            return c;
        }

        public Project SelectByProject(int projectId)
        {
            Project p = new Project();
            string selectBy =
              "balaji.SP_SELECTBY_Project_HR_Batch4";
            try
            {
                cmd = new SqlCommand(selectBy, con);
                cmd.Parameters.AddWithValue("@aProjectID", projectId);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    p.ProjectId = projectId;
                    p.ProjectName= dr[1].ToString();
                    p.Description= dr[2].ToString();
                    p.Client= dr[3].ToString();
                    p.StartDate = DateTime.Parse(dr[4].ToString());
                    p.EndDate = DateTime.Parse(dr[5].ToString());
                 }

            }
            catch (ProjectException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dr.Close();
                con.Close();
            }
            return p;
        }

        public Skill SelectBySkill(int skillId)
        {
            Skill s = new Skill();
            string selectBy =
              "balaji.SP_SELECTBY_Skill_HR_Batch4";
            try
            {
                cmd = new SqlCommand(selectBy, con);
                cmd.Parameters.AddWithValue("@aSkillID", skillId);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    s.SkillId = skillId;
                    s.SkillName= dr[1].ToString();
                    s.SkillDescription= dr[2].ToString();
                    s.CategoryId = (int)dr[3];
                }

            }
            catch (SkillException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dr.Close();
                con.Close();
            }
            return s;
        }
    }
}
