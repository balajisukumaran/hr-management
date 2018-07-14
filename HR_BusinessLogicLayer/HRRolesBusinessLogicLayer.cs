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
    public class HRRolesBusinessLogicLayer
    {
        HRRolesDataAccessLayer dal = null;
        public HRRolesBusinessLogicLayer(string conString)
        {
            try
            {
                dal = new HRRolesDataAccessLayer(conString);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Add(Roles r)
        {

            try
            {

                dal.Insert(r);
            }
            catch (RolesException ex)
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

        public object GetRoleId()
        {
            try
            {
                return dal.NextRoleId();
            }
            catch (RolesException ex)
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

        public void Modify(Roles r)
        {

            try
            {
                dal.Update(r);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
