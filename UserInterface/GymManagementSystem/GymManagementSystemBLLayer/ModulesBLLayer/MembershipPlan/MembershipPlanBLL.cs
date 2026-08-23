using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.MembershipPlan;
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystemBLLayer.ModulesBLLayer.MembershipPlan
{
    public class MembershipPlanBLL
    {
        // Properties
        public int MembershipPlanId { get; set; }
        public string MembershipPlanName { get; set; }
        public int PlanTypeId { get; set; }
        public string PlanType { get; set; }
        public int DurationInDays { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string IsActive { get; set; }

        // Validates and updates the price and description
        public string UpdateMembershipPlanDescriptionAndPriceByMembershipPlanIdBLL()
        {
            ValidationBll.CommonValidationMessage result;

            result = ValidationBll.ValidatePrice(this.Price);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }


            //result = ValidationBll.ValidateDescription(this.Description);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }


            MembershipPlanDAL membershipPlanDAL = new MembershipPlanDAL();

            return membershipPlanDAL.UpdateMembershipPlanDescriptionAndPriceByMembershipPlanIdDAL(
                this.MembershipPlanId,
                this.Price,
                this.Description);
        }
        // Inserts a new membership plan after receiving
        public ValidationResult InsertMembershipPlanBLL()
        {
            ValidationBll.CommonValidationMessage result;

            // Plan Name
            result = ValidationBll.ValidateName(this.MembershipPlanName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "PlanName",
                    Result = result,
                    Message = ValidationBll.GetValidationMessage(result)
                };
            }

            // Duration
            result = ValidationBll.ValidateDuration(this.DurationInDays);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "Duration",
                    Result = result,
                    Message = ValidationBll.GetValidationMessage(result)
                };
            }

            // Amount
            result = ValidationBll.ValidatePrice(this.Price);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "Amount",
                    Result = result,
                    Message = ValidationBll.GetValidationMessage(result)
                };
            }
            MembershipPlanDAL membershipPlanDAL =new MembershipPlanDAL();
            // PASS BLL PROPERTIES TO DAL
            membershipPlanDAL.MembershipPlanName =this.MembershipPlanName;
            membershipPlanDAL.DurationInDays =this.DurationInDays;
            membershipPlanDAL.PlanTypeId = this.PlanTypeId;
            membershipPlanDAL.Price =this.Price;
            membershipPlanDAL.Description =this.Description;

            // CALL DAL INSERT METHOD
            string message =membershipPlanDAL.InsertMembershipPlanDAL();
            return new ValidationResult
            {
                FieldName = "",
                Result = ValidationBll.CommonValidationMessage.Valid,
                Message = message
            };
        }
         // Deactivates an existing membership plan
        public string DeactivateMembershipPlanByMembershipPlanIdBLL()
        {
            MembershipPlanDAL membershipPlanDAL = new MembershipPlanDAL();

            return membershipPlanDAL.DeactivateMembershipPlanByMembershipPlanIdDAL(
                this.MembershipPlanId);
        }
        // Retrieves the details of a specific membership plan
        public DataTable RetrieveMembershipPlanDetailsByMembershipPlanDetailsBLL(string search)
        {
            MembershipPlanDAL membershipPlanDAL = new MembershipPlanDAL();

            DataTable dataTableMembershipPlanBLL =
                membershipPlanDAL.RetrieveMembershipPlanDetailsByMembershipPlanByDetailDal(search);

            return dataTableMembershipPlanBLL;
        }
        // Retrieves membership plan details for a ComboBox.
        public DataTable GetMembershipPlanDetailsForComboBox()
        {
            MembershipPlanDAL membershipPlanDAL = new MembershipPlanDAL();
            DataTable dataTable = membershipPlanDAL.GetMembershipPlanDetailsForComboBox();
            return dataTable;
        }
        // Retrieves membership plan type details for a ComboBox.
        public DataTable GetMembershipPlanTypeDetailsForComboBox()
        {
            MembershipPlanDAL membershipPlanDAL = new MembershipPlanDAL();
            return membershipPlanDAL.GetMembershipPlanTypeDetailsForComboBox();
        }
        // Retrieves all membership plan details from the DAL
        public List<MembershipPlanBLL> RetrieveMembershipPlansDetailsBLL()
        {
            List<MembershipPlanBLL> membershipPlansBll = null;
            try
            {
                membershipPlansBll = new List<MembershipPlanBLL>();
                MembershipPlanDAL membershipPlanDal = new MembershipPlanDAL();
                List<MembershipPlanDAL> membershipPlansDal = membershipPlanDal.RetrieveMembershipPlansDetailsDAL();
                foreach (MembershipPlanDAL membershipPlan in membershipPlansDal)
                {
                    MembershipPlanBLL membershipPlanBLL = new MembershipPlanBLL();
                    membershipPlanBLL.MembershipPlanId = membershipPlan.MembershipPlanId;
                    membershipPlanBLL.MembershipPlanName = membershipPlan.MembershipPlanName;
                    membershipPlanBLL.PlanTypeId = membershipPlan.PlanTypeId;
                    membershipPlanBLL.PlanType = membershipPlan.PlanType;
                    membershipPlanBLL.DurationInDays = membershipPlan.DurationInDays;
                    membershipPlanBLL.Price = membershipPlan.Price;
                    membershipPlanBLL.Description = membershipPlan.Description;
                    membershipPlanBLL.IsActive = membershipPlan.IsActive;
                    membershipPlansBll.Add(membershipPlanBLL);

                }
                return membershipPlansBll;

            }
            catch (Exception ex)
            {
                return membershipPlansBll;
            }

        }
       public static decimal GetPriceByMembershipPlanId(int membershipPlanId)
       {
           return MembershipPlanDAL.GetPriceByMembershipPlanId(membershipPlanId);
       }
    }
}
