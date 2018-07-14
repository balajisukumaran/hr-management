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
    public class HRUsersBusinessLogicLayer
    {
        HRUsersDataAccessLayer dal = null;
        

        public HRUsersBusinessLogicLayer(string conString)
        {
            try
            {
                dal = new HRUsersDataAccessLayer(conString);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Add(Users u)
        {
            try
            {

                dal.Insert(u);
            }
            catch (UsersException ex)
            {
                throw;

            }
            catch (SystemException ex)
            {
                throw;
            }
        }

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

        public object GetUserId()
        {
            try
            {
                return dal.NextUserId();
            }
            catch (UsersException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw;
            }
        }

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

        public void Modify(Users u)
        {
            try
            {
                dal.Update(u);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
