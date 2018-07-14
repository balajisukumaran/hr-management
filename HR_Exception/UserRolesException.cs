using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Exception
{
    public class UserRolesException:Exception
    {
        public UserRolesException()
        {

        }
        public UserRolesException(string message):base(message)
        {

        }
    }
}
