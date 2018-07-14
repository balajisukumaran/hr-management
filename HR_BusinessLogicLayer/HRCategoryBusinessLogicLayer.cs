using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Entities;
using HR_Exception;
using HR_DataAccessLayer;
using System.Collections;

namespace HR_BusinessLogicLayer
{
    public class HRCategoryBusinessLogicLayer
    {
        HRCategoryDataAccessLayer dal = null;
        public HRCategoryBusinessLogicLayer(string conString)
        {
            try
            {
                dal = new HRCategoryDataAccessLayer(conString);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region validate Category
        public bool validateCategory(Category cat)
        {
            bool validate = true;
            StringBuilder builderObj = new StringBuilder();

            try
            {
                if (cat.CategoryID.ToString() == string.Empty)
                {
                    builderObj.AppendLine("Category Id Should be Provided..");
                    validate = false;
                }
                if (cat.CategoryName == string.Empty)
                {
                    builderObj.AppendLine("Category Name Should be Provided..");
                    validate = false;
                }
                if (cat.CategoryDescription == string.Empty)
                {
                    builderObj.AppendLine("Category Description Should be Provided..");
                    validate = false;
                }
                if (validate == false)
                {
                    throw new CategoryException(builderObj.ToString());
                }

            }

            catch (CategoryException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return validate;
        }
        #endregion

        #region Modify

        public void Modify(Category c)
        {
            try
            {
                if (validateCategory(c))
                {
                    dal.Update(c);
                }
                else
                    throw new CategoryException("Invalid Data");



            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region GetAll

        public IEnumerable GetAll()
        {
            try
            {

                return dal.SelectAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Remove

        public void Remove(int id)
        {
            try
            {
                dal.Delete(id);


            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region GetCategoryID

        public object GetCategoryID()
        {
            try
            {
                return dal.NextCategoryId();
            }
            catch (CategoryException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw;
            }

        }
        #endregion

        #region Add

        public void Add(Category c)
        {
            try
            {
                if (validateCategory(c))
                {
                    dal.Insert(c);
                }
                else
                    throw new CategoryException("Invalid Data");


            }
            catch (CategoryException ex)
            {
                throw ex;

            }
            catch (SystemException ex)
            {
                throw ex;
            }
        }
        #endregion

    }
    }
