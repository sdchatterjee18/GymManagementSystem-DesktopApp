using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Shift;
using GymManagementSystemDALayer.Common;
using GymManagementSystemDALayer.ModulesDALayer.Shift;
using GymManagementSystemBLLayer.ModulesBLLayer.MembershipPlan;
using GymManagementSystemDALayer.ModulesDALayer.MembershipPlan;
using GymManagementSystemBLLayer.ModulesBLLayer.DietPlan;
using GymManagementSystemDALayer.ModulesDALayer.DietPlan;

namespace GymManagementSystemBLLayer.Common
{
    public class LookupBLL
    {
        public static List<ShiftBLL> GetShifts()
        {
            List<ShiftDAL> ShiftsDAL=LookupDAL.GetShifts();
            List<ShiftBLL> ShiftsBLL = new List<ShiftBLL>();
            foreach (ShiftDAL item in ShiftsDAL)
            {
                ShiftBLL shift = new ShiftBLL();
                shift.ShiftId = item.ShiftId;
                shift.ShiftName = item.ShiftName;
                ShiftsBLL.Add(shift);
            }
            return ShiftsBLL;
        }
        public static List<MembershipPlanBLL> GetMembershipPlans()
        {
            List<MembershipPlanDAL> membershipPlansDAL = LookupDAL.GetMembershipPlans();
            List<MembershipPlanBLL> membershipPlansBLL = new List<MembershipPlanBLL>();
            foreach (MembershipPlanDAL item in membershipPlansDAL)
            {
                MembershipPlanBLL membershipPlanBLL = new MembershipPlanBLL();
                membershipPlanBLL.MembershipPlanId = item.MembershipPlanId;
                membershipPlanBLL.MembershipPlanName = item.MembershipPlanName;
                membershipPlansBLL.Add(membershipPlanBLL);
            }
            return membershipPlansBLL;
        }
        public static List<DietPlanBLL> GetDietPlans()
        {
            List<DietPlanDAL> dietPlansDAL = LookupDAL.GetDietPlans();
            List<DietPlanBLL> dietPlansBLL = new List<DietPlanBLL>();

            foreach (DietPlanDAL item in dietPlansDAL)
            {
                DietPlanBLL dietPlan = new DietPlanBLL();

                dietPlan.DietPlanId = item.DietPlanId;
                dietPlan.CaloriesPerDay = item.CaloriesPerDay;
                dietPlansBLL.Add(dietPlan);
            }
            return dietPlansBLL;
        }
        public static DataTable GetGenderDetails()
        {
            return LookupDAL.GetGenderDetails();
        }
        public static List<string> GetPaymentMethods()
        {
            return new List<string>
            {
               "Cash",
               "UPI",
               "Debit Card",
               "Credit Card",
               "Net Banking"
            };
        }
    }
}
