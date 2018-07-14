using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Exception
{
    public class CredentialsException:Exception
    {
        public CredentialsException()
        {

        }
        public CredentialsException(string message):base(message)
        {

        }
    }
}
