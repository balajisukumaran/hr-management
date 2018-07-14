using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Exception
{
    public class SpecialityException:Exception
    {
        public SpecialityException()
        {

        }
        public SpecialityException(string message):base(message)
        {

        }
    }
}
