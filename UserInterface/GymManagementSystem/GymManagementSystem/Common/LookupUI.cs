using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystem.FORMS.Shift.UI;
using GymManagementSystem.FORMS.MembershipPlan.UI;
using GymManagementSystemBLLayer.ModulesBLLayer.Shift;
using GymManagementSystemBLLayer.ModulesBLLayer.MembershipPlan;
using GymManagementSystemBLLayer.ModulesBLLayer.DietPlan;
using GymManagementSystem.FORMS.DietPlan.UI;

using GymManagementSystemBLLayer.Common;
namespace GymManagementSystem.Common
{
    public class LookupUI
    {
        public static List<ShiftUI> GetShifts()
        {
            List<ShiftBLL> ShiftsBLL= LookupBLL.GetShifts();
            List<ShiftUI> ShiftsUI = new List<ShiftUI>();
            foreach (ShiftBLL item in ShiftsBLL)
            {
                ShiftUI shift = new ShiftUI();
                shift.ShiftId = item.ShiftId;
                shift.ShiftName = item.ShiftName;
                ShiftsUI.Add(shift);
            }
            return ShiftsUI;
        }
        public static List<MembershipPlanUI> GetMembershipPlans()
        {
            List<MembershipPlanBLL> MembershipPlansBLL = LookupBLL.GetMembershipPlans();
            List<MembershipPlanUI> MembershipPlansUI = new List<MembershipPlanUI>();
            foreach (MembershipPlanBLL item in MembershipPlansBLL)
            {
                MembershipPlanUI MembershipPlanUI = new MembershipPlanUI();
                MembershipPlanUI.MembershipPlanId = item.MembershipPlanId;
                MembershipPlanUI.MembershipPlanName = item.MembershipPlanName;
                MembershipPlansUI.Add(MembershipPlanUI);
            }
            return MembershipPlansUI;
        }
        public static List<DietPlanUI> GetDietPlans()
        {
            List<DietPlanBLL> dietPlansBLL = LookupBLL.GetDietPlans();
            List<DietPlanUI> dietPlansUI = new List<DietPlanUI>();

            foreach (DietPlanBLL item in dietPlansBLL)
            {
                DietPlanUI dietPlan = new DietPlanUI();

                dietPlan.DietPlanId = item.DietPlanId;
                dietPlan.CaloriesPerDay = item.CaloriesPerDay;
                dietPlan.DietPlanDocument = item.DietPlanDocument;
                dietPlan.ConditionStatus = item.ConditionStatus;

                dietPlansUI.Add(dietPlan);
            }

            return dietPlansUI;
        }
        public static DataTable GetGenderDetails()
        {
            return LookupBLL.GetGenderDetails();
        }
        public static List<string> GetPaymentMethods()
        {
            return LookupBLL.GetPaymentMethods();
        }
    }
}
