using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.ProfitLoss;

namespace GymManagementSystem.FormsSuperAdmin.Financials.UI
{
    public class SAProfitLossUI
    {
        private ProfitLossBLL profitLossBLL;
        public SAProfitLossUI()
        {
            profitLossBLL = new ProfitLossBLL();
        }

        // Monthly Income Expense Net Revenue By Selected Year
        public DataTable GetMonthlyIncomeExpenseNetRevenueByYearUI(int year)
        {
            return profitLossBLL
                .GetMonthlyIncomeExpenseNetRevenueByYearBLL(year);
        }

        // Revenue Section Summary By Selected Year
        public DataTable GetIncomeExpenseNetRevenueForRevenueSectionByYearUI(int year)
        {
            return profitLossBLL
                .GetIncomeExpenseNetRevenueForRevenueSectionByYearBLL(year);
        }
    }
}
