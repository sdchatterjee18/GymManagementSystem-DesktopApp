using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystem.FORMS.Shift.UI;
using GymManagementSystem.FORMS.MembershipPlan.UI;
using GymManagementSystemBLLayer.ModulesBLLayer.Shift;
using GymManagementSystemBLLayer.ModulesBLLayer.MembershipPlan;
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
    }
}
