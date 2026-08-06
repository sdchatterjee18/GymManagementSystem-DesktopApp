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
        public int MembershipPlanId { get; set; }
        public string MembershipPlanName { get; set; }
        public int PlanTypeId { get; set; }
        public string PlanType { get; set; }
        public int DurationInDays { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string IsActive { get; set; }


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
        public string UpdateMembershipPlanDescriptionAndPriceByMembershipPlanIdBLL()
        {
            ValidationBll.CommonValidationMessage result;

            result = ValidationBll.ValidatePrice(this.Price.ToString());

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }


            result = ValidationBll.ValidateDescription(this.Description);

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
        public string DeactivateMembershipPlanByMembershipPlanIdBLL()
        {
            MembershipPlanDAL membershipPlanDAL = new MembershipPlanDAL();

            return membershipPlanDAL.DeactivateMembershipPlanByMembershipPlanIdDAL(
                this.MembershipPlanId);
        }
        public DataTable RetrieveMembershipPlanDetailsByMembershipPlanIdBLL(int membershipPlanId)
        {
            MembershipPlanDAL membershipPlanDAL = new MembershipPlanDAL();

            DataTable dataTableMembershipPlanBLL =
                membershipPlanDAL.RetrieveMembershipPlanDetailsByMembershipPlanIdDal(membershipPlanId);

            return dataTableMembershipPlanBLL;
        }
        public DataTable GetMembershipPlanDetailsForComboBox()
        {
            MembershipPlanDAL membershipPlanDAL = new MembershipPlanDAL();
            DataTable dataTable = membershipPlanDAL.GetMembershipPlanDetailsForComboBox();
            return dataTable;
        }
        public DataTable GetMembershipPlanTypeDetailsForComboBox()
        {
            MembershipPlanDAL membershipPlanDAL = new MembershipPlanDAL();
            return membershipPlanDAL.GetMembershipPlanTypeDetailsForComboBox();
        }
        public string InsertMembershipPlanBLL()
        {
            ValidationBll.CommonValidationMessage result;

            result = ValidationBll.ValidateMembershipPlanName(this.MembershipPlanName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            result = ValidationBll.ValidateDuration(this.DurationInDays.ToString());

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            result = ValidationBll.ValidatePrice(this.Price.ToString());

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            result = ValidationBll.ValidateDescription(this.Description);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            MembershipPlanDAL membershipPlanDAL = new MembershipPlanDAL();

            membershipPlanDAL.MembershipPlanName = this.MembershipPlanName;
            membershipPlanDAL.PlanTypeId = this.PlanTypeId;
            membershipPlanDAL.DurationInDays = this.DurationInDays;
            membershipPlanDAL.Price = this.Price;
            membershipPlanDAL.Description = this.Description;
            return membershipPlanDAL.InsertMembershipPlanDAL();
        }
    }
}
