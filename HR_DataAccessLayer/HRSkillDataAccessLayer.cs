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
    public class HRSkillDataAccessLayer
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        public Category SelectByCategory(int id)
        {
            Category c = new Category();
            string selectBy =
              "balaji.SP_SELECTBY_Category_HR_Batch4";
            try
            {
                cmd = new SqlCommand(selectBy, con);
                cmd.Parameters.AddWithValue("@aCategoryID", id);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    c.CategoryID = id;
                    c.CategoryName = dr[1].ToString();
                    c.CategoryDescription = dr[2].ToString();
                }

            }
            catch (CategoryException)
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
        public IEnumerable SelectAll()
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
                        s.SkillId= (int)dr[0];
                        s.SkillName= dr[1].ToString();
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


        public IEnumerable SelectAllCategory()
        {
            List<Category> categoryList = new List<Category>();
            string selectAll = "balaji.SP_SELECTALL_Category_HR_Batch4";
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

                        Category c = new Category();
                        c.CategoryID = (int)dr[0];
                        c.CategoryName = dr[1].ToString();
                        c.CategoryDescription = dr[2].ToString();
                        categoryList.Add(c);
                    }
                }
            }
            catch (CategoryException)
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
            return categoryList;

        }

        public HRSkillDataAccessLayer(string conString)
        {
            con = new SqlConnection(conString);

        }
        public void Insert(Skill s)
        {
            string insert = "balaji.SP_INSERT_Skill_HR_Batch4";
            try
            {
                cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@aSkillName", s.SkillName);
                cmd.Parameters.AddWithValue("@aSkillDescription", s.SkillDescription);
                cmd.Parameters.AddWithValue("@aCategoryId", s.CategoryId);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();

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
                con.Close();
            }
        }

        public void Delete(int id)
        {
            string delete = "balaji.SP_DELETE_Skill_HR_Batch4";
            try
            {
                cmd = new SqlCommand(delete, con);
                cmd.Parameters.AddWithValue("@aSkillID", id);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
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
                con.Close();
            }
        }

        public void Update(Skill s)
        {
            int qn;
            string update = "balaji.SP_UPDATE_Skill_HR_Batch4";
            try
            {
                cmd = new SqlCommand(update, con);
                cmd.Parameters.AddWithValue("@aSkillID",s.SkillId);
                cmd.Parameters.AddWithValue("@aSkillName", s.SkillName);
                cmd.Parameters.AddWithValue("@aSkillDescription", s.SkillDescription);
                cmd.Parameters.AddWithValue("@aCategoryId", s.CategoryId);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                qn = cmd.ExecuteNonQuery();

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
                con.Close();
            }
        }

        public object NextSkillId()
        {
            int nextSkillId;
            string NextSkillId = "balaji.SP_NEXTID_Skill_HR_Batch4";
            try
            {
                cmd = new SqlCommand(NextSkillId, con);
                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@aNextSkillID";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();

                cmd.ExecuteNonQuery();
                nextSkillId = (int)outputParameter.Value;
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
                con.Close();
            }
            return nextSkillId;
        }
    }
}
