using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Exception
{
   public class SkillException:Exception
    {
        public SkillException()
        {

        }
        public SkillException(string message):base(message)
        {

        }
    }
}
