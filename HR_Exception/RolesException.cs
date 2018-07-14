using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Exception
{
    public class RolesException:Exception
    {
        public RolesException()
        {

        }
        public RolesException(string message):base(message)
        {

        }
    }
}
