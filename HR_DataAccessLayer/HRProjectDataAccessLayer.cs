using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Exception;
using HR_Entities;
using System.Collections;
using System.Data.SqlClient;

namespace HR_DataAccessLayer
{
    public class HRProjectDataAccessLayer
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        public HRProjectDataAccessLayer(string conString)
        {
            con = new SqlConnection(conString);
        }
        public void Update(Project p)
        {
            int qn;
            string update = "balaji.SP_UPDATE_Project_HR_Batch4";
            try
            {
                cmd = new SqlCommand(update, con);
                cmd.Parameters.AddWithValue("@aProjectID", p.ProjectId);
                cmd.Parameters.AddWithValue("@aProjectName ", p.ProjectName);
                cmd.Parameters.AddWithValue("@aDescription", p.Description);
                cmd.Parameters.AddWithValue("@aClient", p.Client);
                cmd.Parameters.AddWithValue("@aStartDate", p.StartDate);
                cmd.Parameters.AddWithValue("@aEndDate", p.EndDate);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                qn = cmd.ExecuteNonQuery();

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
                con.Close();
            }
        }

        public IEnumerable SelectAll()
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
                        p.StartDate = DateTime.Parse( dr[4].ToString());
                        p.EndDate = DateTime.Parse( dr[5].ToString());
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

        public void Delete(int id)
        {
            string delete = "balaji.SP_DELETE_Project_HR_Batch4";
            try
            {
                cmd = new SqlCommand(delete, con);
                cmd.Parameters.AddWithValue("@aProjectID", id);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
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
                con.Close();
            }
        }

        public object NextProjectId()
        {
            int nextProjectId;
            string NextProjectId = "balaji.SP_NEXTID_Project_HR_Batch4";
            try
            {
                cmd = new SqlCommand(NextProjectId, con);
                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@aNextProjectID";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();

                cmd.ExecuteNonQuery();
                nextProjectId = (int)outputParameter.Value;
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
                con.Close();
            }
            return nextProjectId;
        }

        public void Insert(Project p)
        {
            string insert = "balaji.SP_INSERT_Project_HR_Batch4";
            try
            {
                cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@aProjectName ", p.ProjectName);
                cmd.Parameters.AddWithValue("@aDescription", p.Description);
                cmd.Parameters.AddWithValue("@aClient", p.Client);
                cmd.Parameters.AddWithValue("@aStartDate", p.StartDate);
                cmd.Parameters.AddWithValue("@aEndDate", p.EndDate);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();

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
                con.Close();
            }
        }
    }
}
