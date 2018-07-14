using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_DataAccessLayer;
using HR_Entities;
using HR_Exception;
namespace HR_BusinessLogicLayer
{
    public class HRProjectBusinessLogicLayer
    {

        HRProjectDataAccessLayer dal = null;
        public HRProjectBusinessLogicLayer(string conString)
        {

            try
            {
                dal = new HRProjectDataAccessLayer(conString);
            }
            catch (Exception)
            {
                throw;
            }

        }
        #region Validate Project
        public bool validateProject(Project proj)
        {
            bool validate = true;
            StringBuilder builderObj = new StringBuilder();

            try
            {

                if (proj.ProjectName == string.Empty)
                {
                    builderObj.AppendLine("Project Name Should be Provided..");
                    validate = false;
                }
                if (proj.Description == string.Empty)
                {
                    builderObj.AppendLine("Project Description Should be Provided..");
                    validate = false;
                }
                if (proj.Client == string.Empty)
                {
                    builderObj.AppendLine("Client Name Should be Provided..");
                    validate = false;
                }
                if (proj.StartDate == DateTime.MinValue)
                {
                    builderObj.AppendLine("Start Date Should be Provided..");
                    validate = false;

                }
                //if (proj.StartDate.ToString() == string.Empty)
                //{
                //    builderObj.AppendLine("Start Date Should be Provided..");
                //    validate = false;
                //}

                if (proj.EndDate == DateTime.MinValue)
                {
                    builderObj.AppendLine("End Date Should be Provided..");
                    validate = false;

                }
                //if (proj.EndDate.ToString() == string.Empty)
                //{
                //    builderObj.AppendLine("End Date Should be Provided..");
                //    validate = false;
                //}
                if (proj.StartDate >= proj.EndDate)
                {
                    builderObj.AppendLine("End Date should be after Start Date..");
                    validate = false;
                }
                if (validate == false)
                {
                    throw new ProjectException(builderObj.ToString());
                }

            }
            catch (ProjectException ex)
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

        #region Modify

        public void Modify(Project p)
        {

            try
            {

                if (validateProject(p))
                {
                    dal.Update(p);
                }
                else
                    throw new ProjectException("Invalid Data");


            }
            catch (Exception)
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

        #region GetProjectId
        public object GetProjectId()
        {
            try
            {
                return dal.NextProjectId();
            }
            catch (ProjectException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw;
            }
        }
        #endregion

        #region Add

        public void Add(Project p)
        {

            try
            {
                if (validateProject(p))
                {
                    dal.Insert(p);
                }
                else
                    throw new ProjectException("Invalid Data");


            }
            catch (ProjectException ex)
            {
                throw;

            }
            catch (SystemException ex)
            {
                throw;
            }
        }
        #endregion
    }
}
