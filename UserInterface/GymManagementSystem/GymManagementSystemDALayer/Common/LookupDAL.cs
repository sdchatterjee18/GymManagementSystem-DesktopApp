using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.Shift;
using GymManagementSystemDALayer.SqlHelper;

namespace GymManagementSystemDALayer.Common
{
    public static class LookupDAL
    {
        public static List<ShiftDAL> GetShifts()
        {
            List<ShiftDAL> Shifts = new List<ShiftDAL>();
            using (SqlConnection sqlConnection = DBconnection.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand("spRetrieveShiftTimeTable", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ShiftDAL shift = new ShiftDAL();
                    shift.ShiftId = Convert.ToInt32(reader["ShiftId"]);
                    shift.ShiftName = reader["ShiftName"].ToString();
                    Shifts.Add(shift);
                }
            }
            return Shifts;
        }
    }
}