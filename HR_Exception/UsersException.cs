using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Exception
{
    public class UsersException:Exception
    {
        public UsersException()
        {

        }
        public UsersException(string message):base(message)
        {

        }
    }
}
