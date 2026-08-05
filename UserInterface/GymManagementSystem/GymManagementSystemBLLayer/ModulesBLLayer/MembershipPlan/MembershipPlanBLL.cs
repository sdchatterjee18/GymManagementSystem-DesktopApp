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
        public bool IsActive { get; set; }


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
            ValidationBll validationBll = new ValidationBll();

            ValidationBll.CommonValidationMessage result;

            result = validationBll.ValidatePrice(this.Price);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return "Price must be greater than zero.";
            }

            result = validationBll.ValidateDescription(this.Description);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return "Description is required.";
            }

            MembershipPlanDAL membershipPlanDAL = new MembershipPlanDAL();

            return membershipPlanDAL.UpdateMembershipPlanDescriptionAndPriceByMembershipPlanIdDAL(
                this.MembershipPlanId,
                this.Price,
                this.Description);
        }
    }
}
