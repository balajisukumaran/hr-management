using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Entities;
using HR_Exception;
using HR_DataAccessLayer;
namespace HR_BusinessLogicLayer
{
    public class HRCredentialsBusinessLogicLayer
    {
        HRCredentialsDataAccessLayer dal = null;

        public HRCredentialsBusinessLogicLayer(string conString)
        {
            try
            {
                dal = new HRCredentialsDataAccessLayer(conString);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Check(Credentials c)
        {
            try
            {
                if (dal.FindUserRecord(c))
                {
                    if (dal.UserTypeAdmin())
                    {
                        return true;
                    }
                    else
                        throw new CredentialsException("Not an Admin");
                }
                else
                    throw new CredentialsException("No Such Record");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool CheckHrClerk(Credentials c)
        {
            try
            {
                if (dal.FindUserRecord(c))
                {
                    if (dal.UserTypeHrClerk())
                    {
                        return true;
                    }
                    else
                        throw new CredentialsException("Not HR Clerk");
                }
                else
                    throw new CredentialsException("No Such Record");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
