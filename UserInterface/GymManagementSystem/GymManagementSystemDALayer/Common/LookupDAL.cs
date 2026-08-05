using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.Shift;
using GymManagementSystemDALayer.ModulesDALayer.MembershipPlan;
using GymManagementSystemDALayer.SqlHelper;

namespace GymManagementSystemDALayer.Common
{
    public class LookupDAL
    {
        public static List<ShiftDAL> GetShifts()
        {
            List<ShiftDAL> Shifts = null;
            SqlConnection sqlConnection = null;
            try
            {
                Shifts = new List<ShiftDAL>();
                //throw new Exception("Testing exception");
                using (sqlConnection = DBconnection.GetSqlConnection())
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
                    return Shifts;
                }
            }
            catch(Exception ex)
            {
                return Shifts;
            }
            finally
            {
                if(sqlConnection!=null)
                {
                    sqlConnection.Close();
                }
            }
            
            //return Shifts;
        }
        public static List<MembershipPlanDAL> GetMembershipPlans()
        {
            List<MembershipPlanDAL> MembershipPlans = null;
            SqlConnection sqlConnection = null;
            try
            {
                using (sqlConnection = DBconnection.GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand("spRetrieveMembershipPlans", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        MembershipPlanDAL membershipPlanDAL = new MembershipPlanDAL();
                        membershipPlanDAL.MembershipPlanId = Convert.ToInt32(reader["MembershipPlanId"]);
                        membershipPlanDAL.MembershipPlanName = Convert.ToInt32(reader["MembershipPlanName"]);
                        MembershipPlans.Add(membershipPlanDAL);
                    }
                    return MembershipPlans;
                }
            }
            catch(Exception ex)
            {
                return MembershipPlans;
            }
            finally
            {
                if(sqlConnection!=null)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}