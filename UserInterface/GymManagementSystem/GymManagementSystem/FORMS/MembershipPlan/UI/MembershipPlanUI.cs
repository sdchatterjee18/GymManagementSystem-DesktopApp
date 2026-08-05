using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemBLLayer.ModulesBLLayer.MembershipPlan;

namespace GymManagementSystem.FORMS.MembershipPlan.UI
{
    public class MembershipPlanUI
    {
        public int MembershipPlanId { get; set; }
        public string MembershipPlanName { get; set; }
        public int PlanTypeId { get; set; }
        public string PlanType { get; set; }
        public int DurationInDays { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }


        public List<MembershipPlanUI> RetrieveMembershipPlansDetailsUI()
        {
            List<MembershipPlanUI> membershipPlansUi = null;
            try
            {
                membershipPlansUi = new List<MembershipPlanUI>();
                List<MembershipPlanBLL> membershipPlansBll = new List<MembershipPlanBLL>();
                MembershipPlanBLL membershipPlanBll = new MembershipPlanBLL();
                membershipPlansBll = membershipPlanBll.RetrieveMembershipPlansDetailsBLL();
                foreach (MembershipPlanBLL membershipPlan in membershipPlansBll)
                {
                    MembershipPlanUI membershipPlanUI = new MembershipPlanUI();

                    membershipPlanUI.MembershipPlanId = membershipPlan.MembershipPlanId;
                    membershipPlanUI.MembershipPlanName = membershipPlan.MembershipPlanName;
                    membershipPlanUI.PlanTypeId = membershipPlan.PlanTypeId;
                    membershipPlanUI.PlanType = membershipPlan.PlanType;
                    membershipPlanUI.DurationInDays = membershipPlan.DurationInDays;
                    membershipPlanUI.Price = membershipPlan.Price;
                    membershipPlanUI.Description = membershipPlan.Description;
                    membershipPlanUI.IsActive = membershipPlan.IsActive;

                    membershipPlansUi.Add(membershipPlanUI);
                }

                return membershipPlansUi;

            }
            catch (Exception ex)
            {
                return membershipPlansUi;
            }
           
        }
        public string UpdateMembershipPlanDescriptionAndPriceByMembershipPlanIdUI()
        {
            MembershipPlanBLL membershipPlanBLL = new MembershipPlanBLL();

            membershipPlanBLL.MembershipPlanId = this.MembershipPlanId;
            membershipPlanBLL.Price = this.Price;
            membershipPlanBLL.Description = this.Description;

            return membershipPlanBLL.UpdateMembershipPlanDescriptionAndPriceByMembershipPlanIdBLL();
        }
    
    }
}
