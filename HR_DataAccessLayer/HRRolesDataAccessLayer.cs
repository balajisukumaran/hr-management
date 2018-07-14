using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Exception;
using HR_Entities;
using System.Data.SqlClient;

namespace HR_DataAccessLayer
{
    public class HRRolesDataAccessLayer
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        public HRRolesDataAccessLayer(string conString)
        {

            con = new SqlConnection(conString);
        }
        public void Insert(Roles r)
        {
            string insert = "balaji.SP_INSERT_Roles_HR_Batch4";
            try
            {
                cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@aRoleName", r.RoleName);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (RolesException)
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
            List<Roles> rolesList = new List<Roles>();
            string selectAll = "balaji.SP_SELECTALL_Roles_HR_Batch4";
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

                        Roles r = new Roles();
                        r.RoleId = (int)dr[0];
                        r.RoleName = dr[1].ToString();
                        rolesList.Add(r);
                    }
                }
            }
            catch (RolesException)
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
            return rolesList;
        }

        public object NextRoleId()
        {
            int nextRoleId;
            string NextRoleId = "balaji.SP_NEXTID_Roles_HR_Batch4";
            try
            {
                cmd = new SqlCommand(NextRoleId, con);
                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@aRoleId";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();

                cmd.ExecuteNonQuery();
                nextRoleId = (int)outputParameter.Value;
            }
            catch (RolesException)
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
            return nextRoleId;
        }

        public void Delete(int id)
        {
            string delete = "balaji.SP_DELETE_Roles_HR_Batch4";
            try
            {
                cmd = new SqlCommand(delete, con);
                cmd.Parameters.AddWithValue("@aRoleId", id);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (RolesException)
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

        public void Update(Roles r)
        {
            int qn;
            string update = "balaji.SP_UPDATE_Roles_HR_Batch4";
            try
            {
                cmd = new SqlCommand(update, con);
                cmd.Parameters.AddWithValue("@aRoleId", r.RoleId);
                cmd.Parameters.AddWithValue("@aRoleName", r.RoleName);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                qn = cmd.ExecuteNonQuery();

            }
            catch (RolesException)
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
