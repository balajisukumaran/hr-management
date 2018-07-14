using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_DataAccessLayer;
using HR_Entities;
using HR_Exception;
using Microsoft.VisualBasic;
namespace HR_BusinessLogicLayer
{
    public class HREmployeeBusinessLogicLayer
    {
        
        HREmployeeDataAccessLayer dal = null;
        public HREmployeeBusinessLogicLayer(string conString)
        {
            try
            {
                dal = new HREmployeeDataAccessLayer(conString);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Validate Employee

        public bool validateEmployee(Employee employee)
        {
            double num;
            bool validate = true;
            StringBuilder builderObj = new StringBuilder();

            try
            {


                if (employee.FirstName == string.Empty)
                {
                    builderObj.AppendLine("First name Should be Provided..");
                    validate = false;
                }
                if (employee.LastName == string.Empty)
                {
                    builderObj.AppendLine("Last Name Should be Provided..");
                    validate = false;
                }
                if (employee.MiddleName == string.Empty)
                {
                    builderObj.AppendLine("Middle Name Should be Provided..");
                    validate = false;
                }

                if (employee.BirthDate == DateTime.MinValue)
                {
                    builderObj.AppendLine("Hired Date Should be Provided..");
                    validate = false;

                }
                if (employee.Age == string.Empty)
                {
                    builderObj.AppendLine("Age cannot be blank");
                    validate = false;
                }
              
                else if (double.TryParse(employee.Age, out num) == false)
                {
                    builderObj.AppendLine("Age must be of only digits");
                    validate = false;
                }
            
                //if (employee.Age.ToString() == null)
                //{
                //    builderObj.AppendLine("Age Should be Provided..");
                //    validate = false;
                //}

                if (employee.Religion == string.Empty)
                {
                    builderObj.AppendLine("Religion Should be Provided..");
                    validate = false;
                }
                if (employee.Citizenship == string.Empty)
                {
                    builderObj.AppendLine("CitizenShip Should be Provided..");
                    validate = false;
                }

                if (!Information.IsNumeric(employee.MobileNo.ToString()))
                {
                    builderObj.AppendLine("Enter Valid Mobile No");
                    validate = false;
                }
                if (!Information. IsNumeric(employee.HomePhoneNo.ToString()))
                {
                    builderObj.AppendLine("Enter Valid Home Phone No");
                    validate = false;
                }
                if (employee.MobileNo == string.Empty)
                {
                    builderObj.AppendLine("Mobile number cannot be blank");
                    validate = false;
                }

                else if (double.TryParse(employee.MobileNo, out num) == false)
                {
                    builderObj.AppendLine("Mobile no must be of only digits");
                    validate = false;
                }
                else if (employee.MobileNo.Length != 10)
                {
                    builderObj.AppendLine("Mobile no must have have exactly 10 digits");
                    validate = false;
                }

                //if (employee.MobileNo.ToString() == string.Empty)
                //{
                //    builderObj.AppendLine("Mobile Number Should be Provided..");
                //    validate = false;
                //}

                if (employee.HomePhoneNo == string.Empty)
                {
                    builderObj.AppendLine("Home number cannot be blank");
                    validate = false;
                }

                else if (double.TryParse(employee.HomePhoneNo, out num) == false)
                {
                    builderObj.AppendLine("Home number must be of only digits");
                    validate = false;
                }
                else if (employee.HomePhoneNo.Length != 10)
                {
                    builderObj.AppendLine("Home number must have have exactly 10 digits");
                    validate = false;
                }
                //if (employee.HomePhoneNo.ToString() == string.Empty)
                //{
                //    builderObj.AppendLine("Home Phone Number Should be Provided..");
                //    validate = false;
                //}
                if (employee.Street1 == string.Empty)
                {
                    builderObj.AppendLine("Street1 details Should be Provided..");
                    validate = false;
                }
                if (employee.Street2 == string.Empty)
                {
                    builderObj.AppendLine("Street2 details Should be Provided..");
                    validate = false;
                }
                if (employee.City == string.Empty)
                {
                    builderObj.AppendLine("City  Should be Provided..");
                    validate = false;
                }
                if (employee.UserState == string.Empty)
                {
                    builderObj.AppendLine("User State details Should be Provided..");
                    validate = false;
                }
                if (employee.Zip == string.Empty)
                {
                    builderObj.AppendLine("Zip cannot be blank");
                    validate = false;
                }

                else if (double.TryParse(employee.Zip, out num) == false)
                {
                    builderObj.AppendLine("Zip must be of only digits");
                    validate = false;
                }
                else if (employee.Zip.Length != 6)
                {
                    builderObj.AppendLine("Zip must have have exactly 6 digits");
                    validate = false;
                }
                //if (employee.Zip.ToString() == string.Empty)
                //{
                //    builderObj.AppendLine("Zip code Should be Provided..");
                //    validate = false;
                //}
                if (employee.Country == string.Empty)
                {
                    builderObj.AppendLine("Country Should be Provided..");
                    validate = false;
                }

                if (employee.EducationalBackground == string.Empty)
                {
                    builderObj.AppendLine("Educational Background Should be Provided..");
                    validate = false;
                }
                if (validate == false)
                {
                    throw new EmployeeException(builderObj.ToString());
                }

            }

            catch (EmployeeException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return validate;
        }
        #endregion

        #region GetEmployeeId

        public object GetEmployeeId()
        {
            try
            {
                return dal.NextEmployeeId();
            }
            catch (EmployeeException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw;
            }
        }
        #endregion

        #region GetAll

        public IEnumerable GetAll()
        {
            try
            {
                return dal.SelectAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region GetAllCivilStatus

        public IEnumerable GetAllCivilStatus()
        {
            try
            {
                return dal.SelectAllCivilStatus();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region GetAllProject

        public IEnumerable GetAllProject()
        {
            try
            {
                return dal.SelectAllProject();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region GetAllSkill

        public IEnumerable GetAllSkill()
        {
            try
            {
                return dal.SelectAllSkill();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Add

        public void Add(Employee emp)
        {
            try
            {
                if (validateEmployee(emp))
                {
                    dal.Insert(emp);
                }
                else
                    throw new EmployeeException("Invalid Data");


            }
            catch (EmployeeException ex)
            {
                throw;

            }
            catch (SystemException ex)
            {
                throw;
            }
        }
        #endregion

        #region Remove
        public void Remove(int id)
        {

            try
            {
                dal.Delete(id);


            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Modify

        public void Modify(Employee emp)
        {
            try
            {
                if (validateEmployee(emp))
                {
                    dal.Update(emp);
                }
                else
                    throw new EmployeeException("Invalid Data");


            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region SelectCivilStatus
        public CivilStatus SelectCivilStatus(int civilStatusId)
        {
            try
            {
                return dal.SelectByCivilStatus(civilStatusId);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region SelectProject

        public Project SelectProject(int projectId)
        {
            try
            {
                return dal.SelectByProject(projectId);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region SelectSkill

        public Skill SelectSkill(int skillId)
        {
            try
            {
                return dal.SelectBySkill(skillId);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    
}
}
