using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.MembershipPlan;

namespace GymManagementSystem.FORMS.MembershipPlan.UI
{
    public class MembershipPlanUI
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
        public string search { get; set; }


        // Update Membership Plan
        public string UpdateMembershipPlanDescriptionAndPriceByMembershipPlanIdUI()
        {
            MembershipPlanBLL membershipPlanBLL = new MembershipPlanBLL();

            membershipPlanBLL.MembershipPlanId = this.MembershipPlanId;
            membershipPlanBLL.Price = this.Price;
            membershipPlanBLL.Description = this.Description;

            return membershipPlanBLL.UpdateMembershipPlanDescriptionAndPriceByMembershipPlanIdBLL();
        }
        // Deactivate Membership Plan
        public string DeactivateMembershipPlanByMembershipPlanIdUI()
        {
            MembershipPlanBLL membershipPlanBLL = new MembershipPlanBLL();

            membershipPlanBLL.MembershipPlanId = this.MembershipPlanId;

            return membershipPlanBLL.DeactivateMembershipPlanByMembershipPlanIdBLL();
        }
        // Insert Membership Plan
        public string InsertMembershipPlanUI()
        {
            MembershipPlanBLL membershipPlanBLL = new MembershipPlanBLL();

            membershipPlanBLL.MembershipPlanName = this.MembershipPlanName;
            membershipPlanBLL.PlanTypeId = this.PlanTypeId;
            membershipPlanBLL.DurationInDays = this.DurationInDays;
            membershipPlanBLL.Price = this.Price;
            membershipPlanBLL.Description = this.Description;

            return membershipPlanBLL.InsertMembershipPlanBLL();
        }
        // Validate Membership Plan
        public string ValidateMembershipPlanUI(string membershipPlanName, string duration, string price, string description)
        {
            MembershipPlanBLL membershipPlanBLL = new MembershipPlanBLL();
            return membershipPlanBLL.ValidateMembershipPlanBLL(membershipPlanName, duration, price, description);
        }
        // Retrieve Membership Plan By Id
        public DataTable RetrieveMembershipPlanDetailsByMembershipPlanDetails(string search)
        {
            try
            {
                MembershipPlanBLL membershipPlanBLL = new MembershipPlanBLL();
                DataTable dataTable = membershipPlanBLL.RetrieveMembershipPlanDetailsByMembershipPlanDetailsBLL(search);
                return dataTable;
            }
            catch
            {
                return null;
            }
        }
        // Retrieve All Membership Plans
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
        // Membership Plan ComboBox
        public DataTable GetMembershipPlanDetailsForComboBox()
        {
            MembershipPlanBLL membershipPlanBLL = new MembershipPlanBLL();
            DataTable dataTable = membershipPlanBLL.GetMembershipPlanDetailsForComboBox();
            return dataTable;
        }
        // Membership Plan Type ComboBox
        public DataTable GetMembershipPlanTypeDetailsForComboBox()
        {
            MembershipPlanBLL membershipPlanBLL = new MembershipPlanBLL();
            return membershipPlanBLL.GetMembershipPlanTypeDetailsForComboBox();
        }
        public static decimal GetPriceByMembershipPlanId(int membershipPlanId)
        {
            return MembershipPlanBLL.GetPriceByMembershipPlanId(membershipPlanId);
        }
    }
}
