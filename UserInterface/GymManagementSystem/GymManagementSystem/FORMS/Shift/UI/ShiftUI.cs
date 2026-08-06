using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Shift;

namespace GymManagementSystem.FORMS.Shift.UI
{
    public class ShiftUI
    {
        public int ShiftId { get; set; }
        public string ShiftName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public DataTable GetShiftDetailsForComboBox()
        {
            ShiftBLL shiftBLL = new ShiftBLL();
            DataTable dataTable = shiftBLL.GetShiftDetailsForComboBox();
            return dataTable;
        }
    }
}
