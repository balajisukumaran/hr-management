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
    public class HRCategoryDataAccessLayer
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        public HRCategoryDataAccessLayer(string conString)
        {
            con = new SqlConnection(conString);
        }
        public void Update(Category c)
        {
            int qn;
            string update = "balaji.SP_UPDATE_Category_HR_Batch4";
            try
            {
                cmd = new SqlCommand(update, con);
                cmd.Parameters.AddWithValue("@aCategoryID", c.CategoryID);
                cmd.Parameters.AddWithValue("@aCategoryName", c.CategoryName);
                cmd.Parameters.AddWithValue("@aCategoryDescription ", c.CategoryDescription);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                qn = cmd.ExecuteNonQuery();

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
                con.Close();
            }

        }

        public IEnumerable SelectAll()
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

        public void Delete(int id)
        {
            string delete = "balaji.SP_DELETE_Category_HR_Batch4";
            try
            {
                cmd = new SqlCommand(delete, con);
                cmd.Parameters.AddWithValue("@aCategoryID ", id);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
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
                con.Close();
            }
        }

        public object NextCategoryId()
        {
            int nextCategoryId;
            string NextCategoryId = "balaji.SP_NEXTID_Category_HR_Batch4";
            try
            {
                cmd = new SqlCommand(NextCategoryId, con);
                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@aNextCategoryID";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();

                cmd.ExecuteNonQuery();
                nextCategoryId = (int)outputParameter.Value;
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
                con.Close();
            }
            return nextCategoryId;
        }

        public void Insert(Category c)
        {
            string insert = "balaji.SP_INSERT_Category_HR_Batch4";
            try
            {
                cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@aCategoryName", c.CategoryName);
                cmd.Parameters.AddWithValue("@aCategoryDescription", c.CategoryDescription);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();

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
                con.Close();
            }
        }
    }
}
