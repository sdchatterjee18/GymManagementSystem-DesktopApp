using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystemDALayer.Common;

namespace GymManagementSystemDALayer.ModulesDALayer.Shift
{
    public class ShiftDAL
    {
        public int ShiftId { get; set; }
        public string ShiftName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public DataTable GetShiftDetailsForComboBox()
        {
           DataTable dataTable= LookupDAL.GetComboBoxDetails("spRetrieveShiftTimeTable");
           return dataTable;
        }

        // Retrieves all Shift Time for displaying in the DataGridView.
        public DataTable RetrieveShiftDetailsDAL()
        {
            DataTable dataTable = LookupDAL.RetrieveSpecificItem("spRetrieveShiftTimeTable");
            return dataTable;
        }
        public string  UpdateShiftDetailsDAL(int shiftId, TimeSpan startTime, TimeSpan endTime)
        {
            SqlParameter[] parameters = { new SqlParameter("@ShiftId", shiftId), new SqlParameter("@StartTime", startTime), new SqlParameter("@EndTime", endTime) };

            string message = LookupDAL.UpdateSpecificItem("spUpdateShiftTime", parameters);

          
            return message;
        }
    }
}
