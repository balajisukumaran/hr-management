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
    public class HRSpecialityBusinessLogicLayer
    {

        HRSpecialityDataAccessLayer dal = null;
        public HRSpecialityBusinessLogicLayer(string conString)
        {
            try
            {
                dal = new HRSpecialityDataAccessLayer(conString);
            }
            catch (Exception)
            {
                throw;
            }

        }


        #region Validate Speciality
        public bool validateSpeciality(Speciality spec)
        {
            bool validate = true;
            StringBuilder builderObj = new StringBuilder();

            try
            {
                if (spec.SpecialityName == string.Empty)
                {
                    builderObj.AppendLine("Speciality Name Should be Provided..");
                    validate = false;
                }
                if (validate == false)
                {
                    throw new SpecialityException(builderObj.ToString());
                }

            }

            catch (SpecialityException ex)
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

        #region GetSpecialityId

        public object GetSpecialityId()
        {
            try
            {
                return dal.NextSpecialityId();
            }
            catch (SpecialityException ex)
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

        #region Add
        public void Add(Speciality s)
        {
            try
            {
                if (validateSpeciality(s))
                {
                    dal.Insert(s);
                }
                else
                    throw new SpecialityException("Invalid Data");


            }
            catch (SpecialityException ex)
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

        #region Modify
        public void Modify(Speciality s)
        {
            try
            {
                if (validateSpeciality(s))
                {
                    dal.Update(s);
                }
                else
                    throw new SpecialityException("Invalid Data");

            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
