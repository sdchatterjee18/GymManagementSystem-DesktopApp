using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Dashboard;

namespace GymManagementSystem.FormsSuperAdmin.Dashboard.UI
{
    public class SuperAdminDashboardUI
    {
        // Get Current Shift UI
        public DataTable GetCurrentShiftUI()
        {
            DashboardBLL dashboardBLL = new DashboardBLL();
            DataTable dataTable = dashboardBLL.GetCurrentShiftBLL();
            return dataTable;
        }
        // Get Active Employee Count UI
        public int GetActiveEmployeeCountUI()
        {
            DashboardBLL dashboardBLL =
                new DashboardBLL();
            int activeEmployeeCount =
                dashboardBLL.GetActiveEmployeeCountBLL();
            return activeEmployeeCount;
        }
        // Get Current Month Total Expense UI
        public decimal GetCurrentMonthTotalExpenseUI()
        {
            DashboardBLL dashboardBLL =
                new DashboardBLL();
            decimal totalExpense =
                dashboardBLL.GetCurrentMonthTotalExpenseBLL();
            return totalExpense;
        }
        // Get Active Trainer Count UI
        public int GetActiveTrainerCountUI()
        {
            DashboardBLL dashboardBLL =
                new DashboardBLL();
            int activeTrainerCount =
                dashboardBLL.GetActiveTrainerCountBLL();
            return activeTrainerCount;
        }
        // Get Current Month Total Income UI
        public decimal GetCurrentMonthTotalIncomeUI()
        {
            DashboardBLL dashboardBLL =
                new DashboardBLL();
            decimal totalIncome =
                dashboardBLL.GetCurrentMonthTotalIncomeBLL();
            return totalIncome;
        }
        // Get Current Month Income Expense Net Revenue UI
        public DataTable GetCurrentMonthIncomeExpenseNetRevenueUI()
        {
            DashboardBLL dashboardBLL =
                new DashboardBLL();
            DataTable dataTable =
                dashboardBLL.GetCurrentMonthIncomeExpenseNetRevenueBLL();
            return dataTable;
        }
        // Get Current Year Income Expense Net Revenue UI
        public DataTable GetCurrentYearIncomeExpenseNetRevenueUI()
        {
            DashboardBLL dashboardBLL =
                new DashboardBLL();
            DataTable dataTable =
                dashboardBLL.GetCurrentYearIncomeExpenseNetRevenueBLL();
            return dataTable;
        }

        // Get Current Month Financial Summary UI
        public DataTable GetCurrentMonthFinancialSummaryUI()
        {
            DashboardBLL dashboardBLL =
                new DashboardBLL();
            DataTable dataTable =
                dashboardBLL.GetCurrentMonthFinancialSummaryBLL();
            return dataTable;
        }
        // Get Monthly Revenue UI
        public DataTable GetMonthlyRevenueUI()
        {
            DashboardBLL dashboardBLL =
                new DashboardBLL();
            DataTable dataTable =
                dashboardBLL.GetMonthlyRevenueBLL();
            return dataTable;
        }
    }
}
