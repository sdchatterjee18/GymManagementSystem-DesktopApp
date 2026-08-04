using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Shift;
using GymManagementSystemDALayer.Common;
using GymManagementSystemDALayer.ModulesDALayer.Shift;

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
    }
}
