using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Dashboard;

namespace GymManagementSystem.FORMS.Dashboard.UI
{
    class DashboardUI
    {
        public int ShiftId { get; set; }
        public string ShiftName { get; set; }
        public int MembershipPlanId { get; set; }
        public string MembershipPlanName { get; set; }
        public int Count { get; set; }

        // Get Current Shift Ui
        public DataTable GetCurrentShiftUI()
        {
            DashboardBLL dashboardBLL = new DashboardBLL();
            DataTable dataTable = dashboardBLL.GetCurrentShiftBLL();
            return dataTable;
        }
        // Get Active Members Ui
        public int GetActiveMemberCountUI()
        {
            DashboardBLL dashboardBLL = new DashboardBLL();

            int activeMemberCount = dashboardBLL.GetActiveMemberCountBLL();

            return activeMemberCount;
        }
        // Get Active Membership Plan Count UI
        public int GetActiveMembershipPlanCountUI()
        {
            DashboardBLL dashboardBLL = new DashboardBLL();

            int activeMembershipPlanCount =
                dashboardBLL.GetActiveMembershipPlanCountBLL();

            return activeMembershipPlanCount;
        }
        // Get Active Trainers UI
        public int GetActiveTrainerCountUI()
        {
            DashboardBLL dashboardBLL = new DashboardBLL();

            int activeTrainerCount =
                dashboardBLL.GetActiveTrainerCountBLL();

            return activeTrainerCount;
        }
        // Get Current Shift Personal Trainer Count UI
        public int GetCurrentShiftPersonalTrainerCountUI()
        {
            DashboardBLL dashboardBLL = new DashboardBLL();

            int currentShiftPersonalTrainerCount =
                dashboardBLL.GetCurrentShiftPersonalTrainerCountBLL();

            return currentShiftPersonalTrainerCount;
        }
        // Retrieve Free Trainer By Shift UI
        public DataTable RetrieveFreeTrainerByShiftUI()
        {
            DashboardBLL dashboardBLL = new DashboardBLL();
            DataTable dataTable =  dashboardBLL.RetrieveFreeTrainerByShiftBLL();
            return dataTable;
        }
        // Retrieve Top Three Membership Plans UI
        public DataTable RetrieveTopThreeMembershipPlansUI()
        {
            DashboardBLL dashboardBLL = new DashboardBLL();
            DataTable dataTable =
                dashboardBLL.RetrieveTopThreeMembershipPlansBLL();
            return dataTable;
        }
        // Get Current Month Total Expense UI
        public decimal GetCurrentMonthTotalExpenseUI()
        {
            DashboardBLL dashboardBLL = new DashboardBLL();
            decimal totalExpense =
                dashboardBLL.GetCurrentMonthTotalExpenseBLL();
            return totalExpense;
        }
        // Retrieve Current Month New Members UI
        public int RetrieveCurrentMonthNewMembersUI()
        {
            DashboardBLL dashboardBLL = new DashboardBLL();
            int newMembers =
                dashboardBLL.RetrieveCurrentMonthNewMembersBLL();
            return newMembers;
        }
        // Retrieve Current Month Subscription No UI
        public int RetrieveCurrentMonthSubscriptionNoUI()
        {
            DashboardBLL dashboardBLL = new DashboardBLL();
            int subscriptionNo =
                dashboardBLL.RetrieveCurrentMonthSubscriptionNoBLL();
            return subscriptionNo;
        }

        // Retrieve Shift Wise Member Numbers UI
        public DataTable RetrieveShiftWiseMemberNumbersUI()
        {
            DashboardBLL dashboardBLL = new DashboardBLL();
            DataTable dataTable =
                dashboardBLL.RetrieveShiftWiseMemberNumbersBLL();
            return dataTable;
        }
        // Retrieve Today Member Attendance UI
        public DataTable RetrieveTodayMemberAttendanceUI()
        {
            DashboardBLL dashboardBLL = new DashboardBLL();
            DataTable dataTable =
                dashboardBLL.RetrieveTodayMemberAttendanceBLL();
            return dataTable;
        }
    }
}
