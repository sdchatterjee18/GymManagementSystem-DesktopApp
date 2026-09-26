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
        public decimal ExpenseAmount { get; set; }
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
        public ValidationResult InsertExpenseCategoryBLL()
        {
            ValidationBll.CommonValidationMessage result;

            // Category Name
            result = ValidationBll.ValidateOnlyLettersAndSpaces(this.CategoryName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "CategoryName",
                    Result = result,
                    Message = ValidationBll.GetValidationMessage(result)
                };
            }

            // Category
            result = ValidationBll.ValidateOnlyLettersAndSpaces(this.Category);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "Category",
                    Result = result,
                    Message = ValidationBll.GetValidationMessage(result)
                };
            }

            ExpensesDAL expensesDAL = new ExpensesDAL();

            // PASS BLL PROPERTIES TO DAL
            expensesDAL.CategoryName = this.CategoryName;
            expensesDAL.Category = this.Category;

            // CALL DAL INSERT METHOD
            string message = expensesDAL.InsertExpenseCategoryDAL();

            return new ValidationResult
            {
                FieldName = "",
                Result = ValidationBll.CommonValidationMessage.Valid,
                Message = message
            };
        }

        //Insert Expense
        public ValidationResult InsertExpenseBLL()
        {
            ValidationBll.CommonValidationMessage result;

            // Amount
            result = ValidationBll.ValidatePrice(this.ExpenseAmount);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "Amount",
                    Result = result,
                    Message = ValidationBll.GetValidationMessage(result)
                };
            }
           ExpensesDAL expenseDAL = new ExpensesDAL();
            // PASS BLL PROPERTIES TO DAL
            expenseDAL.CategoryId = this.CategoryId;
            expenseDAL.ExpenseAmount = this.ExpenseAmount;
            expenseDAL.Notes = this.Notes;

            // CALL DAL INSERT METHOD
            string message =expenseDAL.InsertExpenseDAL();
            return new ValidationResult
            {
                FieldName = "",
                Result = ValidationBll.CommonValidationMessage.Valid,
                Message = message
            };
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
