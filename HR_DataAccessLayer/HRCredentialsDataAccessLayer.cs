using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Entities;
using System.Data.SqlClient;
using HR_Exception;
namespace HR_DataAccessLayer
{
    public class HRCredentialsDataAccessLayer
    {
        static Users u = null;
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        public HRCredentialsDataAccessLayer(string conString)
        {
            con = new SqlConnection(conString);
            u = new Users();
        }
      
        public bool FindUserRecord(Credentials c)
        {

            try {
                cmd = new SqlCommand("balaji.SP_LoginCheck_Users_HR_Batch4", con);
                cmd.Parameters.AddWithValue("@aUsername", c.Username);
                cmd.Parameters.AddWithValue("@aPassword", c.Password);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        u.UserId = (int)dr[0];
                        u.UserName = dr[1].ToString();
                            u.Password = dr[2].ToString();
                        u.Firstname = dr[3].ToString();
                        u.Lastname = dr[4].ToString();
                        
                    }
                    return true;

                }
                else {
                    return false;
                }


            }


            catch (CredentialsException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dr.Close();
                con.Close();
            }

        }

        public bool UserTypeHrClerk()
        {
            try
            {
                cmd = new SqlCommand("balaji.SP_UserType_Users_HR_Batch4", con);
                cmd.Parameters.AddWithValue("@aUserId", u.UserId);
                cmd.Parameters.AddWithValue("@aRoleId", 101);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;

                }
                else
                {
                    return false;
                }


            }


            catch (CredentialsException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dr.Close();
                con.Close();
            }
        }

        public bool UserTypeAdmin()
        {
            try
            {
                cmd = new SqlCommand("balaji.SP_UserType_Users_HR_Batch4", con);
                cmd.Parameters.AddWithValue("@aUserId", u.UserId);
                cmd.Parameters.AddWithValue("@aRoleId", 100);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;

                }
                else
                {
                    return false;
                }


            }


            catch (CredentialsException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dr.Close();
                con.Close();
            }
        }
    }
}
