using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystemDALayer.Common;

namespace GymManagementSystemDALayer.ModulesDALayer.Expense
{
    public class ExpensesDAL
    {
        //Properties
        public int CategoryId{ get; set; }
        public decimal ExpenseAmount { get; set; }
        public string Notes { get; set; }
        public string CategoryName { get; set; }
        public string Category { get; set; }
        public string ComboboxCategorySPName { get; set; }
        public string AllExpenseSPName { get; set; }
        public string InsertExpenseCategorySPName { get; set; }
        public string InsertExpenseSPName { get; set; }

        public ExpensesDAL()
        {
            ComboboxCategorySPName = "spGetAllExpensesCategories";
            AllExpenseSPName = "spRetrieveAllExpenseStatement";
            InsertExpenseCategorySPName = "spAddExpenseCategory";
            InsertExpenseSPName = "spInsertExpense";
        }

        //Retrieve CategoryName for Combobox
        public DataTable RetrieveCategoryNameDAL()
        {
            DataTable CategoryName = null;
            try
            {
                CategoryName = LookupDAL.GetComboBoxDetails(ComboboxCategorySPName);
                return CategoryName;
            }
            catch (Exception Ex)
            {
                return CategoryName;
            }
        }

        //Retrieve All Expenses
        public DataTable RetrieveAllExpensesDAL()
        {
            DataTable AllExpenses = null;
            try
            {
                AllExpenses = LookupDAL.RetrieveSpecificItem(AllExpenseSPName);
                return AllExpenses;
            }
            catch (Exception ex)
            {
                return AllExpenses;
            }
        }

        //Insert Expense Category
        public string InsertExpenseCategoryDAL(string categoryName,string category)
        {
            CategoryName = categoryName;
            Category = category;
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@CategoryName",CategoryName),
                new SqlParameter("@Category",Category)
            };

            string InsertionMessage = null;
            try
            {
                InsertionMessage = LookupDAL.InsertSpecificItem(InsertExpenseCategorySPName, sqlParameters);
                return InsertionMessage;
            }
            catch (Exception ex)
            {
                return InsertionMessage;

            }

        }

        //insert Expense
        public string InsertExpenseDAL()
        {
           
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ExpenseCategoryId",this.CategoryId),
                new SqlParameter("@ExpenseAmount",this.ExpenseAmount),
                new SqlParameter("@Notes",this.Notes)
            };

            string InsertionMessage = null;
            try
            {
                InsertionMessage = LookupDAL.InsertSpecificItem(InsertExpenseSPName, sqlParameters);
                return InsertionMessage;
            }
            catch (Exception ex)
            {
                return InsertionMessage;

            }

        }


        
        // Super Admin
        public DataTable SARetrieveAllExpensesDAL()
        {
            DataTable dataTable = null;

            try
            {
                dataTable = LookupDAL.RetrieveSpecificItem(AllExpenseSPName);
                return dataTable;
            }
            catch (Exception)
            {
                return dataTable;
            }
        }
        // DAL
        public DataTable SARetrieveExpenseStatementByMonthDAL(int month, int year)
        {
            DataTable dataTable = null;

            try
            {
                SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@Month", month),
                    new SqlParameter("@Year", year)
                };

                dataTable = LookupDAL.RetrieveSpecificDetails(
                    "spRetrieveExpenseStatementByMonth",
                    sqlParameters
                );

                return dataTable;
            }
            catch (Exception)
            {
                return dataTable;
            }
        }
        // DAL
        public DataTable SARetrieveTotalExpenseByMonthDAL(int month, int year)
        {
            DataTable dataTable = null;

            try
            {
                SqlParameter[] sqlParameters =
        {
            new SqlParameter("@Month", month),
            new SqlParameter("@Year", year)
        };

                dataTable = LookupDAL.RetrieveSpecificDetails(
                    "spRetrieveTotalExpenseByMonth",
                    sqlParameters);

                return dataTable;
            }
            catch (Exception)
            {
                return dataTable;
            }
        }
        // DAL
        public DataTable SARetrieveExpenseStatementByDateRangeDAL(DateTime fromDate, DateTime toDate)
        {
            DataTable dataTable = null;

            try
            {
                SqlParameter[] sqlParameters =
        {
            new SqlParameter("@FromDate", fromDate),
            new SqlParameter("@ToDate", toDate)
        };

                dataTable = LookupDAL.RetrieveSpecificDetails(
                    "spRetrieveExpenseStatementByDateRange",
                    sqlParameters);

                return dataTable;
            }
            catch (Exception)
            {
                return dataTable;
            }
        }
        public DataTable SARetrieveTotalExpenseByDateRangeDAL(DateTime fromDate,DateTime toDate)
        {
            DataTable dataTable = null;

            try
            {
                SqlParameter[] sqlParameters =
        {
            new SqlParameter("@FromDate", fromDate),
            new SqlParameter("@ToDate", toDate)
        };

                dataTable = LookupDAL.RetrieveSpecificDetails(
                    "spRetrieveTotalExpenseByDateRange",
                    sqlParameters);

                return dataTable;
            }
            catch (Exception)
            {
                return dataTable;
            }
        }
    }
}
