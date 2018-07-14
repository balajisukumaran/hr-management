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


    public class HRUserRolesBusinessLogicLayer
    {

        HRUserRolesDataAccessLayer dal = null;
        public HRUserRolesBusinessLogicLayer(string conString)
        {
            try
            {
                dal = new HRUserRolesDataAccessLayer(conString);
            }
            catch (Exception)
            {
                throw;
            }


        }
        public IEnumerable GetAllUser()
        {
            try
            {
                return dal.SelectAllUser();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable GetAllRoles()
        {
            try
            {
                return dal.SelectAllRoles();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Modify(UserRoles u)
        {
            try
            {
                dal.update(u);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public Roles SelectRole(int roleId)
        {
            try
            {
                return dal.SelectByRole(roleId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<UserRoles> GetAll()
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

        public void Create(UserRoles u)
        {
            try
            {
                dal.add(u);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
