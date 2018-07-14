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
    public class HRCapgeminiDetailsBusinessLogicLayer
    {


        HRCapgeminiDetailsDataAccessLayer dal = null;
        public HRCapgeminiDetailsBusinessLogicLayer(string conString)
        {
            try
            {
                dal = new HRCapgeminiDetailsDataAccessLayer(conString);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region validate CapgeminiDetails
        public bool validateCapDetails(CapgeminiDetails cap)
        {
            bool validate = true;
            StringBuilder builderObj = new StringBuilder();

            try
            {
              
                if (cap.Email.ToString() == string.Empty)
                {
                    builderObj.AppendLine("Email ID Should be Provided..");
                    validate = false;
                }
                if (cap.DateHired==DateTime.MinValue)
                {
                    builderObj.AppendLine("Hired Date Should be Provided..");
                    validate = false;
                  
                }


                



                if (validate == false)
                {
                    throw new CapgeminiDetailsException(builderObj.ToString());
                }






            }

            catch (CapgeminiDetailsException ex)
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

        #region GetAllStatus

        public IEnumerable GetAllStatus()
        {
            try
            {
                return dal.SelectAllStatus();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region GetAllSpeciality

        public IEnumerable GetAllSpeciality()
        {
            try
            {
                return dal.SelectAllSpeciality();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region GetAllEmployee

        public IEnumerable GetAllEmployee()
        {
            try
            {
                return dal.SelectAllEmployee();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region GetAllLevel

        public IEnumerable GetAllLevel()
        {
            try
            {
                return dal.SelectAllLevel();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region SelectLevel

        public Level SelectLevel(int levelId)
        {
            try
            {
                return dal.SelectByLevel(levelId);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region SelectSpeciality

        public Speciality SelectSpeciality(int specialityId)
        {
            try
            {
                return dal.SelectBySpeciality(specialityId);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region SelectStatus

        public CivilStatus SelectStatus(int statusId)
        {
            try
            {
                return dal.SelectByStatus(statusId);
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

        #region Add

        public void Add(CapgeminiDetails c)
        {
            try
            {

                if (validateCapDetails(c))
                {
                    dal.Insert(c);
                }
                else
                    throw new CapgeminiDetailsException("Invalid Data");


            }
            catch (CapgeminiDetailsException ex)
            {
                throw;

            }
            catch (SystemException ex)
            {
                throw;
            }
        }
        #endregion

        #region SelectEmployee
        public Employee SelectEmployee(int employeeId)
        {
            try
            {
                return dal.SelectByEmployee(employeeId);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Modify
        public void Modify(CapgeminiDetails c)
        {

            try
            {
                if (validateCapDetails(c))
                {
                    dal.Update(c);
                }
                else
                    throw new CapgeminiDetailsException("Invalid Data");



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

    }
}
