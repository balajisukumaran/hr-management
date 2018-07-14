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
    public class HRCivilStatusDataAccessLayer
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        public HRCivilStatusDataAccessLayer(string conString)
        {
            con = new SqlConnection(conString);
        }
        public IEnumerable SelectAll()
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
            finally {

                dr.Close();
                con.Close();
            }
            return civilStatusList;
        }

        public void Update(CivilStatus c)
        {
            int qn;
            string update = "balaji.SP_UPDATE_CivilStatus_HR_Batch4";
            try
            {
                cmd = new SqlCommand(update, con);
                cmd.Parameters.AddWithValue("@aStatusId", c.StatusId);
                cmd.Parameters.AddWithValue("@aStatusDescription", c.StatusDescription);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                qn = cmd.ExecuteNonQuery();

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
                con.Close();
            }

        }

        public object NextCivilStatusId()
        {
            int nextCivilStatusId;
            string NextStatusId = "balaji.SP_NEXTID_CivilStatus_HR_Batch4";
            try
            {
                cmd = new SqlCommand(NextStatusId, con);
                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@aNextStatusId";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();

                cmd.ExecuteNonQuery();
                nextCivilStatusId = (int)outputParameter.Value;
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
                con.Close();
            }
            return nextCivilStatusId;
        }

        public void Insert(CivilStatus c)
        {
            string insert = "balaji.SP_INSERT_CivilStatus_HR_Batch4";
            try
            {
                cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@aStatusDescription", c.StatusDescription);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();

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
                con.Close();
            }
        }

        public void Delete(int id)
        {
            string delete = "balaji.SP_DELETE_CivilStatus_HR_Batch4";
            try
            {
                cmd = new SqlCommand(delete, con);
                cmd.Parameters.AddWithValue("@aStatusId", id);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
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
                con.Close();
            }
        }

        public CivilStatus SelectBy(int statusId)
        {
            CivilStatus c = new CivilStatus();
            string selectBy = "balaji.SP_SEARCHBY_CivilStatus_HR_Batch4";
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
    }
}
