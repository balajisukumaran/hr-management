using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Entities
{
    public class Employee
    {

        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public int CivilStatusId { get; set; }
        public string Religion { get; set; }
        public string Citizenship { get; set; }
        public string MobileNo { get; set; }
        public string HomePhoneNo { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string UserState { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public int ProjectId { get; set; }
        public int SkillId { get; set; }
        public string EducationalBackground { get; set; }
    }
}
