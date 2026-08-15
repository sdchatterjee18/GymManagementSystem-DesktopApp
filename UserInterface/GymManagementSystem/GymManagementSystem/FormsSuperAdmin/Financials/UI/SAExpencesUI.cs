using System;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Expense;

namespace GymManagementSystem.FormsSuperAdmin.Financials.UI
{
    public class SAExpencesUI
    {
        public DataTable SARetrieveAllExpensesUI()
        {
            ExpensesBLL expensesBLL = new ExpensesBLL();

            DataTable dataTable =
                expensesBLL.SARetrieveAllExpensesBLL();

            return dataTable;
        }
        public DataTable SARetrieveExpenseStatementByMonthUI(int month, int year)
        {
            ExpensesBLL expensesBLL = new ExpensesBLL();

            DataTable dataTable =
                expensesBLL.SARetrieveExpenseStatementByMonthBLL(month, year);

            return dataTable;
        }
        // UI
        public DataTable SARetrieveTotalExpenseByMonthUI(int month, int year)
        {
            ExpensesBLL expensesBLL = new ExpensesBLL();

            DataTable dataTable =
                expensesBLL.SARetrieveTotalExpenseByMonthBLL(
                    month,
                    year);

            return dataTable;
        }
        // UI
        public DataTable SARetrieveExpenseStatementByDateRangeUI(DateTime fromDate,DateTime toDate)
        {
            ExpensesBLL expensesBLL = new ExpensesBLL();

            DataTable dataTable =
                expensesBLL.SARetrieveExpenseStatementByDateRangeBLL(
                    fromDate,
                    toDate);

            return dataTable;
        }
        public DataTable SARetrieveTotalExpenseByDateRangeUI(DateTime fromDate,DateTime toDate)
        {
            ExpensesBLL expensesBLL = new ExpensesBLL();

            DataTable dataTable =
                expensesBLL.SARetrieveTotalExpenseByDateRangeBLL(
                    fromDate,
                    toDate);

            return dataTable;
        }
    }
}