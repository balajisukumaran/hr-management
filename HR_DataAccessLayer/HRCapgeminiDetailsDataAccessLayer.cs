using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Entities;
using HR_Exception;
using System.Data.SqlClient;

namespace HR_DataAccessLayer
{
    public class HRCapgeminiDetailsDataAccessLayer
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;


        public HRCapgeminiDetailsDataAccessLayer(string conString)
        {
            con = new SqlConnection(conString);
        }

        public IEnumerable SelectAllStatus()
        {
            List<CivilStatus> civilStatusList = new List<CivilStatus>();
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
                        civilStatusList.Add(c);
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
            return civilStatusList;
        }

        public IEnumerable SelectAllEmployee()
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

        public IEnumerable SelectAllSpeciality()
        {
            List<Speciality> specialityList = new List<Speciality>();

            string selectAll = "balaji.SP_SELECTALL_Speciality_HR_Batch4";
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

                        Speciality s = new Speciality();
                        s.SpecialityID = (int)dr[0];

                        s.SpecialityName = dr[1].ToString();
                        specialityList.Add(s);
                    }
                }
            }
            catch (SpecialityException)
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
            return specialityList;
        }

        public IEnumerable SelectAll()
        {
            List<CapgeminiDetails> capgeminiDetailslist = new List<CapgeminiDetails>();
            string selectAll = "balaji.SP_SELECTALL_CapgeminiDetails_HR_Batch4";


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
                        CapgeminiDetails c = new CapgeminiDetails();
                        c.EmployeeId = (int)dr[0];
                        c.Email = dr[1].ToString();
                        c.LevelId = (int)dr[2];
                        c.DateHired = DateTime.Parse(dr[3].ToString());
                        c.SpecialityId = (int)dr[4];
                        c.StatusId = (int)dr[5];
                        
                        capgeminiDetailslist.Add(c);
                    }
                }
            }
            catch (CapgeminiDetailsException)
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

            return capgeminiDetailslist;
        }

        public Employee SelectByEmployee(int employeeId)
        {
            Employee emp = new Employee();
            string selectBy =
              "balaji.SP_SELECTBY_Employee_HR_Batch4";
            try
            {
                cmd = new SqlCommand(selectBy, con);
                cmd.Parameters.AddWithValue("@aEmployeeID", employeeId);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

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


                }

            }
            catch (LevelException)
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
            return emp;

        }

        public IEnumerable SelectAllLevel()
        {
            List<Level> levelList = new List<Level>();
            string selectAll = "balaji.SP_SELECTALL_Level_HR_Batch4";
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

                        Level l = new Level();
                        l.LevelId = (int)dr[0];
                        l.LevelDescription = dr[1].ToString();
                        levelList.Add(l);
                    }
                }
            }
            catch (LevelException)
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
            return levelList;
        }

        public Level SelectByLevel(int levelId)
        {
            Level l = new Level();
            string selectBy =
              "balaji.SP_SEARCHBY_Level_HR_Batch4";
            try
            {
                cmd = new SqlCommand(selectBy, con);
                cmd.Parameters.AddWithValue("@aLevelId", levelId);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    l.LevelId = levelId;
                    l.LevelDescription = dr[1].ToString();
                   
                }

            }
            catch (LevelException)
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
            return l;
        }

        public Speciality SelectBySpeciality(int specialityId)
        {
            Speciality s = new Speciality();
            string selectBy =
              "balaji.SP_SELECTBY_Speciality_HR_Batch4";
            try
            {
                cmd = new SqlCommand(selectBy, con);
                cmd.Parameters.AddWithValue("@aSpecialityID", specialityId);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    s.SpecialityID = specialityId;
                    s.SpecialityName = dr[1].ToString();
                }

            }
            catch (SpecialityException)
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

        public CivilStatus SelectByStatus(int statusId)
        {
            CivilStatus c = new CivilStatus();
            string selectBy =
              "balaji.SP_SEARCHBY_CivilStatus_HR_Batch4";
            try
            {
                cmd = new SqlCommand(selectBy, con);
                cmd.Parameters.AddWithValue("@aStatusId", statusId);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    c.StatusId = statusId;
                    c.StatusDescription = dr[1].ToString();
                  
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

        public void Delete(int id)
        {
            string delete = "balaji.SP_DELETE_CapgeminiDetails_HR_Batch4";
            try
            {
                cmd = new SqlCommand(delete, con);
                cmd.Parameters.AddWithValue("@aEmployeeID", id);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (CapgeminiDetailsException)
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

       

        public void Insert(CapgeminiDetails c)
        {
            string insert = "balaji.SP_INSERT_CapgeminiDetails_HR_Batch4";
            try
            {
                cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@aEmployeeID", c.EmployeeId);
                cmd.Parameters.AddWithValue("@aEmail", c.Email);
                cmd.Parameters.AddWithValue("@aLevelId", c.LevelId);
                cmd.Parameters.AddWithValue("@aDateHired", c.DateHired);
                cmd.Parameters.AddWithValue("@aSpecialityId", c.SpecialityId);
                cmd.Parameters.AddWithValue("@aStatusId", c.StatusId);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (CapgeminiDetailsException)
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

        public void Update(CapgeminiDetails c)
        {
            int qn;
            string update = "balaji.SP_UPDATE_CapgeminiDetails_HR_Batch4";
            try
            {
                cmd = new SqlCommand(update, con);
                cmd.Parameters.AddWithValue("@aEmployeeID", c.EmployeeId);
                cmd.Parameters.AddWithValue("@aEmail", c.Email);
                cmd.Parameters.AddWithValue("@aLevelId", c.LevelId);
                cmd.Parameters.AddWithValue("@aDateHired", c.DateHired);
                cmd.Parameters.AddWithValue("@aSpecialityId", c.SpecialityId);
                cmd.Parameters.AddWithValue("@aStatusId", c.StatusId);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                qn = cmd.ExecuteNonQuery();

            }
            catch (CapgeminiDetailsException)
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
    }
}
