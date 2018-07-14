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
    public class HRSpecialityDataAccessLayer
    {

        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        public HRSpecialityDataAccessLayer(string conString)
        {
            con = new SqlConnection(conString);
        }
        public object NextSpecialityId()
        {
            int nextSpecialityId;
            string NextSpecialityId = "balaji.SP_NEXTID_Speciality_HR_Batch4";
            try
            {
                cmd = new SqlCommand(NextSpecialityId, con);
                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@aNextSpecialityID";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                

                cmd.ExecuteNonQuery();
                nextSpecialityId = (int)outputParameter.Value;
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
                con.Close();
            }
            return nextSpecialityId;

        }

        public IEnumerable SelectAll()
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

        public void Insert(Speciality s)
        {
            string insert = "balaji.SP_INSERT_Speciality_HR_Batch4";
            try
            {
                cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@aSpecialityName", s.SpecialityName);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();

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
                con.Close();
            }
        }

        public void Update(Speciality s)
        {
            int qn;
            string update = "balaji.SP_UPDATE_Speciality_HR_Batch4";
            try
            {
                cmd = new SqlCommand(update, con);
                cmd.Parameters.AddWithValue("@aSpecialityID", s.SpecialityID);
                cmd.Parameters.AddWithValue("@aSpecialityName ", s.SpecialityName);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                qn = cmd.ExecuteNonQuery();

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
                con.Close();
            }
        }

        public void Delete(int id)
        {
            string delete = "balaji.SP_DELETE_Speciality_HR_Batch4";
            try
            {
                cmd = new SqlCommand(delete, con);
                cmd.Parameters.AddWithValue("@aSpecialityID", id);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
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
                con.Close();
            }
        }
    }
}
