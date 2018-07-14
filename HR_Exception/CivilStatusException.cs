using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Exception
{
    public class CivilStatusException:Exception
    {
        public CivilStatusException()
        {

        }
        public CivilStatusException(string message):base(message)
        {

        }
    }
}
