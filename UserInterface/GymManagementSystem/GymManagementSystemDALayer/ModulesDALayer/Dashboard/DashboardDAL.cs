using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.Common;
using System.Data.SqlClient;

namespace GymManagementSystemDALayer.ModulesDALayer.Dashboard
{
    public class DashboardDAL
    {

        public int ShiftId { get; set; }
        public string ShiftName { get; set; }
        public int MembershipPlanId { get; set; }
        public string MembershipPlanName { get; set; }
        public int Count { get; set; }

        // Get Current Shift Dal
        public DataTable GetCurrentShiftDAL()
        {
            string spName = "spGetCurrentShift";

            DataTable dataTable =
                LookupDAL.RetrieveSpecificItem(spName);

            return dataTable;
        }
        // Get Active Members Dal
        public int GetActiveMemberCountDAL()
        {
            string spName = "spGetActiveMemberCount";
            SqlParameter[] sqlParameter = null;
            object result = LookupDAL.GetSingleData(spName, sqlParameter);
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }

            return 0;
        }
        // Get Active Membership Plans DAL
        public int GetActiveMembershipPlanCountDAL()
        {
            string spName = "spGetActiveMembershipPlanCount";
            SqlParameter[] sqlParameter = null;
            object result = LookupDAL.GetSingleData(
                spName,
                sqlParameter
            );

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
           return 0;
        }
        // Get Active Trainers DAL
        public int GetActiveTrainerCountDAL()
        {
            string spName = "spGetActiveTrainerCount";
            SqlParameter[] sqlParameter = null;
            object result = LookupDAL.GetSingleData(spName,sqlParameter);
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }

            return 0;
        }
        // Get Current Shift Personal Trainer Count DAL
        public int GetCurrentShiftPersonalTrainerCountDAL()
        {
            string spName = "spGetCurrentShiftPersonalTrainerCount";
            SqlParameter[] sqlParameter = null;
            object result = LookupDAL.GetSingleData(spName, sqlParameter);

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            return 0;
        }
        // Retrieve Free Trainer By Shift DAL
        public DataTable RetrieveFreeTrainerByShiftDAL()
        {
            string spName = "spRetrieveFreeTrainerByShift";
            DataTable dataTable = LookupDAL.RetrieveSpecificItem(spName);
            return dataTable;
        }
        // Retrieve Top Three Membership Plans DAL
        public DataTable RetrieveTopThreeMembershipPlansDAL()
        {
            string spName = "spRetrieveTopThreeMembershipPlans";
            DataTable dataTable = LookupDAL.RetrieveSpecificItem(spName);
            return dataTable;
        }
        // Get Current Month Total Expense DAL
        public decimal GetCurrentMonthTotalExpenseDAL()
        {
            string spName = "spRetrieveCurrentMonthTotalExpense";
            SqlParameter[] sqlParameter = null;
            object result =
                LookupDAL.GetSingleData(spName, sqlParameter);
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToDecimal(result);
            }
            return 0;
        }
        // Retrieve Current Month New Members DAL
        public int RetrieveCurrentMonthNewMembersDAL()
        {
            string spName = "spRetrieveCurrentMonthNewMembers";
            DataTable dt = LookupDAL.RetrieveSpecificItem(spName);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["NewMembers"]);
            }

            return 0;
        }
        // Retrieve Current Month Subscription No DAL
        public int RetrieveCurrentMonthSubscriptionNoDAL()
        {
            DataTable dt = LookupDAL.GetComboBoxDetails("spRetrieveCurrentMonthSubscriptionNo");
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["SubscriptionNo"]);
            }
            return 0;
        }

        // Retrieve Shift Wise Member Numbers DAL
        public DataTable RetrieveShiftWiseMemberNumbersDAL()
        {
            DataTable dataTable =
                LookupDAL.GetComboBoxDetails("spRetrieveShiftWiseMemberNumbers");
            return dataTable;
        }
        // Retrieve Today Member Attendance DAL
        public DataTable RetrieveTodayMemberAttendanceDAL()
        {
            DataTable dataTable =
                LookupDAL.GetComboBoxDetails(
                    "spRetrieveTodayMemberAttendance");
            return dataTable;
        }

        //  SUPER ADMIN SECTION
        // Get Active Employee Count DAL
        public int GetActiveEmployeeCountDAL()
        {
            string spName = "spGetActiveEmployeeCount";
            SqlParameter[] sqlParameter = null;
            object result =
                LookupDAL.GetSingleData(
                    spName,sqlParameter);
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            return 0;
        }
        // Get Current Month Total Income DAL
        public decimal GetCurrentMonthTotalIncomeDAL()
        {
            string spName = "spTotalMontlyIncome";
            SqlParameter[] sqlParameter = null;
            object result =
                LookupDAL.GetSingleData(spName,sqlParameter);
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToDecimal(result);
            }
            return 0;
        }
        // Get Current Month Income Expense Net Revenue DAL
        public DataTable GetCurrentMonthIncomeExpenseNetRevenueDAL()
        {
            string spName =
                "spGetCurrentMonthIncomeExpenseNetRevenue";
            DataTable dataTable =
                LookupDAL.RetrieveSpecificItem(spName);
            return dataTable;
        }
        // Get Current Year Income Expense Net Revenue DAL
        public DataTable GetCurrentYearIncomeExpenseNetRevenueDAL()
        {
            string spName =
                "spGetCurrentYearIncomeExpenseNetRevenue";
            DataTable dataTable =
                LookupDAL.RetrieveSpecificItem(spName);
            return dataTable;
        }

        // Get Current Month Financial SummaryDAL
        public DataTable GetCurrentMonthFinancialSummaryDAL()
        {
            return LookupDAL.RetrieveSpecificItem(
                "spGetCurrentMonthFinancialSummary");
        }
        // Get Monthly Revenue DAL
        public DataTable GetMonthlyRevenueDAL()
        {
            string spName = "spGetMonthlyRevenue";
            DataTable dataTable =
                LookupDAL.RetrieveSpecificItem(spName);
            return dataTable;
        }
       
    }
}
