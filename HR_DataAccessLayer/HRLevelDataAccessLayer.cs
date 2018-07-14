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
    public class HRLevelDataAccessLayer
    {

        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        public HRLevelDataAccessLayer(string conString)
        {
            con = new SqlConnection(conString);

        }
        public void Insert(Level l)
        {
            string insert = "balaji.SP_INSERT_Level_HR_Batch4";
            try
            {
                cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@aLevelDescription", l.LevelDescription);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();

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
                con.Close();
            }
        }

        public IEnumerable SelectAll()
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

        public void Delete(int id)
        {
            string delete = "balaji.SP_DELETE_Level_HR_Batch4";
            try
            {
                cmd = new SqlCommand(delete, con);
                cmd.Parameters.AddWithValue("@aLevelId", id);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
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
                con.Close();
            }
        }

        public void Update(Level l)
        {
            int qn;
            string update = "balaji.SP_UPDATE_Level_HR_Batch4";
            try
            {
                cmd = new SqlCommand(update, con);
                cmd.Parameters.AddWithValue("@aLevelId", l.LevelId);
                cmd.Parameters.AddWithValue("@aLevelDescription", l.LevelDescription);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                qn = cmd.ExecuteNonQuery();

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
                con.Close();
            }
        }

        public object NextLevelId()
        {
            int nextLevelId;
            string NextLevelId = "balaji.SP_NEXTID_Level_HR_Batch4";
            try
            {
                cmd = new SqlCommand(NextLevelId, con);
                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@aNextLevelId";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();

                cmd.ExecuteNonQuery();
                nextLevelId = (int)outputParameter.Value;
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
                con.Close();
            }
            return nextLevelId;
        }
    }
}
