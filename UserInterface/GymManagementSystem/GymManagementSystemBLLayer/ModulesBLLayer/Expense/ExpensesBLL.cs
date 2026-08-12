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
    }
}
