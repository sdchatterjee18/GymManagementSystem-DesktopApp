using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GymManagementSystemDALayer.ModulesDALayer.ProfitLoss
{
    public class ProfitLossDAL
    {

        // Monthly Income Expense Net Revenue By Selected Year
        public DataTable GetMonthlyIncomeExpenseNetRevenueByYearDAL(int year)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Year", year)
            };

            return Common.LookupDAL.RetrieveSpecificDetails(
                "spGetMonthlyIncomeExpenseNetRevenueByYear",
                sqlParameters
            );
        }
        // Revenue Section Summary By Selected Year
        public DataTable GetIncomeExpenseNetRevenueForRevenueSectionByYearDAL(int year)
        {
            SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@Year", year)
                };

            return Common.LookupDAL.RetrieveSpecificDetails(
                "spGetIncomeExpenseNetRevenueForRevenueSectionByYear",
                sqlParameters
            );
        }
    }
}
