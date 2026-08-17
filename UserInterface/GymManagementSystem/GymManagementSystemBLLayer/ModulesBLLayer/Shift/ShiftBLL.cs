using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.Shift;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Shift
{
    public class ShiftBLL
    {
        public int ShiftId { get; set; }
        public string ShiftName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public DataTable GetShiftDetailsForComboBox()
        {
            ShiftDAL shiftDAL = new ShiftDAL();
            DataTable dataTable = shiftDAL.GetShiftDetailsForComboBox();
            return dataTable;
        }

        // Retrieves all Shift Time for displaying in the DataGridView.
        public DataTable RetrieveShiftDetailsBLL()
        {
            ShiftDAL shiftDAL = new ShiftDAL();
            return shiftDAL.RetrieveShiftDetailsDAL();
        }
        public bool UpdateShiftDetailsBLL(int shiftId, TimeSpan startTime, TimeSpan endTime)
        {
            ShiftDAL shiftDAL = new ShiftDAL();
            return shiftDAL.UpdateShiftDetailsDAL(shiftId, startTime, endTime);
        }
    }
}
