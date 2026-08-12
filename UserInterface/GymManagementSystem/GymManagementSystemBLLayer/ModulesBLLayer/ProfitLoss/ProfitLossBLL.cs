using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.ProfitLoss;

namespace GymManagementSystemBLLayer.ModulesBLLayer.ProfitLoss
{
    public class ProfitLossBLL
    {
        private ProfitLossDAL profitLossDAL;
        public ProfitLossBLL()
        {
            profitLossDAL = new ProfitLossDAL();
        }

        // Monthly Income Expense Net Revenue By Selected Year
        public DataTable GetMonthlyIncomeExpenseNetRevenueByYearBLL(int year)
        {
            return profitLossDAL
                .GetMonthlyIncomeExpenseNetRevenueByYearDAL(year);
        }

        // Revenue Section Summary By Selected Year
        public DataTable GetIncomeExpenseNetRevenueForRevenueSectionByYearBLL(int year)
        {
            return profitLossDAL
                .GetIncomeExpenseNetRevenueForRevenueSectionByYearDAL(year);
        }
    }
}
