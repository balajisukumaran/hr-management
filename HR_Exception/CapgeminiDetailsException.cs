using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Exception
{
   public class CapgeminiDetailsException:Exception
    {
        public CapgeminiDetailsException()
        {

        }
        public CapgeminiDetailsException(string message):base(message)
        {

        }

    }
}
