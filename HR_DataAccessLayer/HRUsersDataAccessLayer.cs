using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HR_Exception;
using HR_Entities;
namespace HR_DataAccessLayer
{
    public class HRUsersDataAccessLayer
    {

        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        public HRUsersDataAccessLayer(string conString)
        {
            con = new SqlConnection(conString);
        }

        public void Delete(int id)
        {
            string delete = "balaji.SP_DELETE_Users_HR_Batch4";
            try
            {
                cmd = new SqlCommand(delete, con);
                cmd.Parameters.AddWithValue("@aUserId", id);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (UsersException)
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

        public object NextUserId()
        {
            int nextUserId;
            string NextUserId = "balaji.SP_NEXTID_Users_HR_Batch4";
            try
            {
                cmd = new SqlCommand(NextUserId, con);
                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@aUserId";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();

                cmd.ExecuteNonQuery();
                nextUserId = (int)outputParameter.Value;
            }
            catch (UsersException)
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
            return nextUserId;
        }

        public IEnumerable SelectAll()
        {
            List<Users> usersList = new List<Users>();
            string selectAll = "balaji.SP_SELECTALL_Users_HR_Batch4";
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

                        Users u = new Users();
                        u.UserId = (int)dr[0];
                        u.UserName = dr[1].ToString();
                        u.Password= dr[2].ToString();
                        u.Firstname= dr[3].ToString();
                        u.Lastname=dr[4].ToString();
                        usersList.Add(u);
                    }
                }
            }
            catch (UsersException)
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
            return usersList;
        }

        public void Update(Users u)
        {
            int qn;
            string update = "balaji.SP_UPDATE_Users_HR_Batch4";
            try
            {
                cmd = new SqlCommand(update, con);
                cmd.Parameters.AddWithValue ("@aUserId", u.UserId);
                cmd.Parameters.AddWithValue("@aUserName",u.UserName);

                cmd.Parameters.AddWithValue("@aUserPassword", u.Password);

                cmd.Parameters.AddWithValue("@aFirstName", u.Firstname);

                cmd.Parameters.AddWithValue("@aLastName", u.Lastname);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                qn = cmd.ExecuteNonQuery();

            }
            catch (UsersException)
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

        public void Insert(Users u)
        {
            string insert = "balaji.SP_INSERT_Users_HR_Batch4";
            try
            {
                cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@aUserName", u.UserName);
                cmd.Parameters.AddWithValue("@aUserPassword", u.Password);
                cmd.Parameters.AddWithValue("@aFirstName", u.Firstname);

                cmd.Parameters.AddWithValue("@aLastName", u.Lastname);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (UsersException)
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
