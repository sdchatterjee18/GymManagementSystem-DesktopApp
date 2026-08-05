using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.MembershipPlan;

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


        public List<MembershipPlanBLL> RetrieveMembershipPlansDetails()
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
    }
}
