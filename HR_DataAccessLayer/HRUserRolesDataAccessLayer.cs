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
    public class HRUserRolesDataAccessLayer
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        public HRUserRolesDataAccessLayer(string conString)
        {
            con = new SqlConnection(conString);

        }
        public IEnumerable SelectAllUser()
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
                        u.Password = dr[2].ToString();
                        u.Firstname = dr[3].ToString();
                        u.Lastname = dr[4].ToString();
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

        public void add(UserRoles u)
        {
            int qn;
            string update = "balaji.SP_INSERT_UserRoles_HR_Batch4";
            try
            {
                cmd = new SqlCommand(update, con);
                cmd.Parameters.AddWithValue("@aUserId", u.UserId);
                cmd.Parameters.AddWithValue("@aRoleId", u.RoleId);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                qn = cmd.ExecuteNonQuery();

            }
            catch (UserRolesException)
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

        public List<UserRoles> SelectAll()
        {
            List<UserRoles> userRolesList = new List<UserRoles>();
            string selectAll = "balaji.SP_SELECTALL_UserRoles_HR_Batch4";
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

                        UserRoles u = new UserRoles();
                        u.UserId = (int)dr[0];
                        u.RoleId = (int)dr[1];
                        userRolesList.Add(u);
                    }
                }
            }
            catch (UserRolesException)
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
            return userRolesList;
        }

        public IEnumerable SelectAllRoles()
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

        public void update(UserRoles u)
        {
            int qn;
            string update = "balaji.SP_UPDATE_UserRoles_HR_Batch4";
            try
            {
                cmd = new SqlCommand(update, con);
                cmd.Parameters.AddWithValue("@aUserId", u.UserId);
                cmd.Parameters.AddWithValue("@aRoleId", u.RoleId);
              cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                qn = cmd.ExecuteNonQuery();

            }
            catch (UserRolesException)
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

        public Roles SelectByRole(int roleId)
        {
            Roles r = new Roles();
            string selectBy =
              "balaji.SP_SELECTBY_Roles_HR_Batch4";
            try
            {
                cmd = new SqlCommand(selectBy, con);
                cmd.Parameters.AddWithValue("@aRoleId", roleId);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    

                    r.RoleId = roleId;
                    r.RoleName = dr[1].ToString();
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
            return r;
        }
    }
}
