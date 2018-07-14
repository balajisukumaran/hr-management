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
    public class HRSkillBusinessLogiclayer
    {
        HRSkillDataAccessLayer dal = null;
        public HRSkillBusinessLogiclayer(string conString)
        {
            try
            {
                dal = new HRSkillDataAccessLayer(conString);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #region Validate Skill
        public bool validateSkill(Skill skill)
        {
            bool validate = true;
            StringBuilder builderObj = new StringBuilder();

            try
            {

                if (skill.SkillName == string.Empty)
                {
                    builderObj.AppendLine("Skill Name Should be Provided..");
                    validate = false;
                }
                if (skill.SkillDescription == string.Empty)
                {
                    builderObj.AppendLine("Skill Description Should be Provided..");
                    validate = false;
                }

                if (validate == false)
                {
                    throw new SkillException(builderObj.ToString());
                }

            }

            catch (SkillException ex)
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

        #region GetAllCategory
        public IEnumerable GetAllCategory()
        {
            try
            {
                return dal.SelectAllCategory();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Add

        public void Add(Skill s)
        {
            try
            {
                if (validateSkill(s))
                {
                    dal.Insert(s);
                }
                else
                    throw new SkillException("Invalid Data");


            }
            catch (SkillException ex)
            {
                throw;

            }
            catch (SystemException ex)
            {
                throw;
            }
        }
        #endregion

        #region remove

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

        #region GetSkillId
        public object GetSkillId()
        {

            try
            {
                return dal.NextSkillId();
            }
            catch (SkillException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw;
            }
        }
        #endregion

        #region Modify

        public void Modify(Skill s)
        {
            try
            {
                if (validateSkill(s))
                {
                    dal.Update(s);
                }
                else
                    throw new SkillException("Invalid Data");


            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region SelectCategory
        public Category SelectCategory(int categoryId)
        {
            try
            {
                return dal.SelectByCategory(categoryId);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
