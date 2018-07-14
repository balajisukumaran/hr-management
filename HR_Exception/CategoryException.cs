using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Exception
{
    public class CategoryException:Exception
    {
        public CategoryException()
        {

        }
        public CategoryException(string message):base(message)
        {

        }
    }
}
