using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.Dashboard;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Dashboard
{
    public class DashboardBLL
    {

        public int ShiftId { get; set; }
        public string ShiftName { get; set; }
        public int MembershipPlanId { get; set; }
        public string MembershipPlanName { get; set; }
        public int Count { get; set; }

        // Get Current Shift Bll
        public DataTable GetCurrentShiftBLL()
        {
            DashboardDAL dashboardDAL = new DashboardDAL();
            DataTable dataTable = dashboardDAL.GetCurrentShiftDAL();
            return dataTable;
        }
        // Get Active Members Bll
        public int GetActiveMemberCountBLL()
        {
            DashboardDAL dashboardDAL = new DashboardDAL();
            int activeMemberCount = dashboardDAL.GetActiveMemberCountDAL();
            return activeMemberCount;
        }
        // Get Active Members BLL
        public int GetActiveMembershipPlanCountBLL()
        {
            DashboardDAL dashboardDAL = new DashboardDAL();

            int activeMembershipPlanCount =
                dashboardDAL.GetActiveMembershipPlanCountDAL();

            return activeMembershipPlanCount;
        }
        // Get Active Trainers BLL
        public int GetActiveTrainerCountBLL()
        {
            DashboardDAL dashboardDAL = new DashboardDAL();
            int activeTrainerCount = dashboardDAL.GetActiveTrainerCountDAL();
            return activeTrainerCount;
        }
        // Get Current Shift Personal Trainer Count BLL
        public int GetCurrentShiftPersonalTrainerCountBLL()
        {
            DashboardDAL dashboardDAL = new DashboardDAL();

            int currentShiftPersonalTrainerCount =
                dashboardDAL.GetCurrentShiftPersonalTrainerCountDAL();

            return currentShiftPersonalTrainerCount;
        }
        // Retrieve Free Trainer By Shift BLL
        public DataTable RetrieveFreeTrainerByShiftBLL()
        {
            DashboardDAL dashboardDAL = new DashboardDAL();
            DataTable dataTable = dashboardDAL.RetrieveFreeTrainerByShiftDAL();
            return dataTable;
        }
        // Retrieve Top Three Membership Plans BLL
        public DataTable RetrieveTopThreeMembershipPlansBLL()
        {
            DashboardDAL dashboardDAL = new DashboardDAL();
            DataTable dataTable = dashboardDAL.RetrieveTopThreeMembershipPlansDAL();
            return dataTable;
        }
        // Get Current Month Total Expense BLL
        public decimal GetCurrentMonthTotalExpenseBLL()
        {
            DashboardDAL dashboardDAL = new DashboardDAL();
            decimal totalExpense =
                dashboardDAL.GetCurrentMonthTotalExpenseDAL();
            return totalExpense;
        }
        // Retrieve Current Month New Members BLL
        public int RetrieveCurrentMonthNewMembersBLL()
        {
            DashboardDAL dashboardDAL = new DashboardDAL();
            int newMembers =
                dashboardDAL.RetrieveCurrentMonthNewMembersDAL();

            return newMembers;
        }
        // Retrieve Current Month Subscription No BLL
        public int RetrieveCurrentMonthSubscriptionNoBLL()
        {
            DashboardDAL dashboardDAL = new DashboardDAL();
            int subscriptionNo =
                dashboardDAL.RetrieveCurrentMonthSubscriptionNoDAL();
            return subscriptionNo;
        }

        // Retrieve Shift Wise Member Numbers BLL
        public DataTable RetrieveShiftWiseMemberNumbersBLL()
        {
            DashboardDAL dashboardDAL = new DashboardDAL();
            DataTable dataTable =
                dashboardDAL.RetrieveShiftWiseMemberNumbersDAL();
            return dataTable;
        }
        // Retrieve Today Member Attendance BLL
        public DataTable RetrieveTodayMemberAttendanceBLL()
        {
            DashboardDAL dashboardDAL = new DashboardDAL();
            DataTable dataTable =
                dashboardDAL.RetrieveTodayMemberAttendanceDAL();
            return dataTable;
        }

        // SUPER ADMIN SECTION
        // Get Active Employee Count BLL
        public int GetActiveEmployeeCountBLL()
        {
            DashboardDAL dashboardDAL =
                new DashboardDAL();
            int activeEmployeeCount =
                dashboardDAL.GetActiveEmployeeCountDAL();
            return activeEmployeeCount;
        }
        // Get Current Month Total Income BLL
        public decimal GetCurrentMonthTotalIncomeBLL()
        {
            DashboardDAL dashboardDAL =
                new DashboardDAL();
            decimal totalIncome =
                dashboardDAL.GetCurrentMonthTotalIncomeDAL();
            return totalIncome;
        }
        // Get Current Month Income Expense Net Revenue BLL
        public DataTable GetCurrentMonthIncomeExpenseNetRevenueBLL()
        {
            DashboardDAL dashboardDAL =
                new DashboardDAL();
            DataTable dataTable =
                dashboardDAL.GetCurrentMonthIncomeExpenseNetRevenueDAL();
            return dataTable;
        }
        // Get Current Year Income Expense Net Revenue BLL
        public DataTable GetCurrentYearIncomeExpenseNetRevenueBLL()
        {
            DashboardDAL dashboardDAL =
                new DashboardDAL();
            DataTable dataTable =
                dashboardDAL.GetCurrentYearIncomeExpenseNetRevenueDAL();
            return dataTable;
        }

        // Get Current Month Financial Summary BLL
        public DataTable GetCurrentMonthFinancialSummaryBLL()
        {
            DashboardDAL dashboardDAL =
                new DashboardDAL();
            DataTable dataTable =
                dashboardDAL.GetCurrentMonthFinancialSummaryDAL();
            return dataTable;
        }
        // Get Monthly Revenue BLL
        public DataTable GetMonthlyRevenueBLL()
        {
            DashboardDAL dashboardDAL =
                new DashboardDAL();
            DataTable dataTable =
                dashboardDAL.GetMonthlyRevenueDAL();
            return dataTable;
        }
    }
}
