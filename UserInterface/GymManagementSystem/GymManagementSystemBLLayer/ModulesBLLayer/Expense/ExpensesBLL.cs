using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.Expense;
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Expense
{
    public class ExpensesBLL
    {
        //Properties
        public string CategoryName { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
        public string ExpenseAmount { get; set; }
        public string Notes { get; set; }

        //Retrieve Category Name for combobox
        public DataTable RetrieveCategoryNameBLL()
        {
            DataTable CategoryName = null;
            try
            {
                ExpensesDAL ExpenseDAL = new ExpensesDAL();
                CategoryName = ExpenseDAL.RetrieveCategoryNameDAL();
                return CategoryName;
            }
            catch (Exception Ex)
            {
                return CategoryName;
            }
        }

        //Retrieve All Expenses
        public DataTable RetrieveAllExpensesBLL()
        {
            DataTable AllExpenses = null;
            try
            {
                ExpensesDAL ExpenseDAL = new ExpensesDAL();
                AllExpenses = ExpenseDAL.RetrieveAllExpensesDAL();
                return AllExpenses;
            }
            catch (Exception ex)
            {
                return AllExpenses;
            }
        }

        //Insert Expense Category 
        public string InsertExpenseCategoryBLL(string categoryName,string category) 
        {
            string InsertionMessage = null;
            CategoryName = categoryName;
            Category = category;
            ValidationBll.CommonValidationMessage CategoryNameResult = ValidationBll.ValidateName(CategoryName);
            ValidationBll.CommonValidationMessage CategoryResult = ValidationBll.ValidateName(Category);
            if (CategoryNameResult != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(CategoryNameResult).ToString();
            }
            if (CategoryResult != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(CategoryResult).ToString();
            }
            try
            {
                ExpensesDAL ExpenseDAL = new ExpensesDAL();
                InsertionMessage = ExpenseDAL.InsertExpenseCategoryDAL(CategoryName, Category);
                return InsertionMessage;
            }
            catch (Exception Ex)
            {
                return InsertionMessage;
            }

        }

        //Insert Expense
        public string InsertExpenseBLL(int categoryId, string expenseAmount, string notes)
        {
            string InsertionMessage = null;
            CategoryId = categoryId;
            ExpenseAmount = expenseAmount;
            Notes = notes;
            ValidationBll.CommonValidationMessage ExpenseAmountResult = ValidationBll.ValidatePrice(ExpenseAmount);
            ValidationBll.CommonValidationMessage NotesResult = ValidationBll.ValidateName(Notes);
            if (ExpenseAmountResult != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(ExpenseAmountResult).ToString();
            }
            if (NotesResult != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(NotesResult).ToString();
            }
            try
            {
                ExpensesDAL ExpenseDAL = new ExpensesDAL();

                InsertionMessage = ExpenseDAL.InsertExpenseDAL(CategoryId, Convert.ToDecimal(ExpenseAmount), Notes);
                return InsertionMessage;
            }
            catch (Exception Ex)
            {
                return InsertionMessage;
            }

        }

        // Super Admin
        public DataTable SARetrieveAllExpensesBLL()
        {
            DataTable dataTable = null;

            try
            {
                ExpensesDAL ExpenseDAL = new ExpensesDAL();
                dataTable = ExpenseDAL.SARetrieveAllExpensesDAL();

                return dataTable;
            }
            catch (Exception)
            {
                return dataTable;
            }
        }
        // BLL
        public DataTable SARetrieveExpenseStatementByMonthBLL(int month, int year)
        {
            DataTable dataTable = null;

            try
            {
                if (month < 1 || month > 12)
                    return dataTable;

                if (year < 2000 || year > DateTime.Now.Year)
                    return dataTable;

                ExpensesDAL ExpenseDAL = new ExpensesDAL();

                dataTable = ExpenseDAL.SARetrieveExpenseStatementByMonthDAL(
                    month,
                    year
                );

                return dataTable;
            }
            catch (Exception)
            {
                return dataTable;
            }
        }
        // BLL
        public DataTable SARetrieveTotalExpenseByMonthBLL(int month, int year)
        {
            DataTable dataTable = null;

            try
            {
                if (month < 1 || month > 12)
                    return dataTable;

                if (year < 2000 || year > DateTime.Now.Year)
                    return dataTable;

                ExpensesDAL ExpenseDAL = new ExpensesDAL();

                dataTable =
                    ExpenseDAL.SARetrieveTotalExpenseByMonthDAL(
                        month,
                        year);

                return dataTable;
            }
            catch (Exception)
            {
                return dataTable;
            }
        }
        // BLL
        public DataTable SARetrieveExpenseStatementByDateRangeBLL(DateTime fromDate,DateTime toDate)
        {
            DataTable dataTable = null;

            try
            {
                if (fromDate > DateTime.Today)
                    return dataTable;

                if (toDate > DateTime.Today)
                    return dataTable;

                if (fromDate > toDate)
                    return dataTable;

                ExpensesDAL ExpenseDAL = new ExpensesDAL();

                dataTable =
                    ExpenseDAL.SARetrieveExpenseStatementByDateRangeDAL(
                        fromDate,
                        toDate);

                return dataTable;
            }
            catch (Exception)
            {
                return dataTable;
            }
        }
        public DataTable SARetrieveTotalExpenseByDateRangeBLL(DateTime fromDate,DateTime toDate)
        {
            DataTable dataTable = null;

            try
            {
                if (fromDate > DateTime.Today)
                    return dataTable;

                if (toDate > DateTime.Today)
                    return dataTable;

                if (fromDate > toDate)
                    return dataTable;

                ExpensesDAL ExpenseDAL = new ExpensesDAL();

                dataTable =
                    ExpenseDAL.SARetrieveTotalExpenseByDateRangeDAL(
                        fromDate,
                        toDate);

                return dataTable;
            }
            catch (Exception)
            {
                return dataTable;
            }
        }
    }
}
