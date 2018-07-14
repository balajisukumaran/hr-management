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
    public class HRLevelBusinessLogicLayer
    {
        HRLevelDataAccessLayer dal = null;

        public HRLevelBusinessLogicLayer(string conString)
        {
            try
            {
                dal = new HRLevelDataAccessLayer(conString);
            }
            catch (Exception)
            {
                throw;
            }

        }

        #region Validate Level

        public bool validateLevelStatus(Level level)
        {
            bool validate = true;
            StringBuilder builderObj = new StringBuilder();

            try
            {
                if (level.LevelId.ToString() == string.Empty)
                {
                    builderObj.AppendLine("Level Id Should be Provided..");
                    validate = false;
                }
                if (level.LevelDescription == string.Empty)
                {
                    builderObj.AppendLine("Level Description Should be Provided..");
                    validate = false;
                }
                if (validate == false)
                {
                    throw new LevelException(builderObj.ToString());
                }

            }

            catch (LevelException ex)
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

        #region Add
        public void Add(Level l)
        {
            try
            {
                if (validateLevelStatus(l))
                {
                    dal.Insert(l);
                }
                else
                    throw new LevelException("Invalid Data");



            }
            catch (LevelException ex)
            {
                throw ex;

            }
            catch (SystemException ex)
            {
                throw ex;
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

        #region Modify
        public void Modify(Level l)
        {
            try
            {
                if (validateLevelStatus(l))
                {
                    dal.Update(l);
                }
                else
                    throw new LevelException("Invalid Data");



            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region GetLevelID
        public object GetLevelId()
        {
            try
            {
                return dal.NextLevelId();
            }
            catch (LevelException ex)
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
