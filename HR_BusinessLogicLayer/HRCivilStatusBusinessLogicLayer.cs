using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_DataAccessLayer;
using HR_Entities;
using HR_Exception;
namespace HR_BusinessLogicLayer
{
    public class HRCivilStatusBusinessLogicLayer
    {
        HRCivilStatusDataAccessLayer dal = null;

        public HRCivilStatusBusinessLogicLayer(string conString)
        {
            try
            {
                dal = new HRCivilStatusDataAccessLayer(conString);
            }
            catch (Exception)
            {
                throw;
            }

        }
        #region Validate CivilStatus

        public bool validateCivilStatus(CivilStatus civil)
        {
            bool validate = true;
            StringBuilder builderObj = new StringBuilder();

            try
            {

                if (civil.StatusDescription == string.Empty)
                {
                    builderObj.AppendLine("Status Description Should be Provided..");
                    validate = false;
                }
                if (validate == false)
                {
                    throw new CivilStatusException(builderObj.ToString());
                }

            }
            catch (CivilStatusException ex)
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

        #region Modify
        public void Modify(CivilStatus c)
        {
            try
            {
                if (validateCivilStatus(c))
                {

                    dal.Update(c);
                }


            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region GetStatusId

        public object GetStatusId()
        {
            try
            {
                return dal.NextCivilStatusId();
            }
            catch (CivilStatusException ex)
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

        public void Add(CivilStatus c)
        {

            try
            {
                if (validateCivilStatus(c))
                {

                    dal.Insert(c);
                }
                else
                    throw new CivilStatusException("Invalid Data");

            }

            catch (CivilStatusException ex)
            {
                throw ex;

            }
            catch (SystemException ex)
            {
                throw ex;
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

        #region GetBy
        public CivilStatus GetBy(int statusId)
        {
            try
            {
                return dal.SelectBy(statusId);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
