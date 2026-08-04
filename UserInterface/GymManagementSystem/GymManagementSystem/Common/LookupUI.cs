using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystem.FORMS.Shift.UI;
using GymManagementSystemBLLayer.ModulesBLLayer.Shift;
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
    }
}
