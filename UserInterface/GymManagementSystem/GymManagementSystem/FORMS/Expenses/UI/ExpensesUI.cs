using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Expense;

namespace GymManagementSystem.FORMS.Expenses.UI
{
   public class ExpensesUI
    {

        //Properties
        public string CategoryName { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
        public string ExpenseAmount { get; set; }
        public string Notes { get; set; }

       //Retrieve Category Name for combobox
       public DataTable RetrieveCategoryNameUI()
       {
           DataTable CategoryName = null;
           try
           {
               ExpensesBLL ExpenseBLL = new ExpensesBLL();
               CategoryName = ExpenseBLL.RetrieveCategoryNameBLL();
               return CategoryName;
           }
           catch (Exception Ex)
           {
               return CategoryName;
           }
       }

       //Retrieve All Expenses
       public DataTable RetrieveAllExpensesUI()
       {
           DataTable AllExpenses = null;
           try
           {
               ExpensesBLL ExpenseBLL = new ExpensesBLL();
               AllExpenses = ExpenseBLL.RetrieveAllExpensesBLL();
               return AllExpenses;
           }
           catch (Exception ex)
           {
               return AllExpenses;
           }
       }

       //Insert Expeses Category 
       public string InsertExpenseCategoryUI(string categoryName, string category)
       {
           string InsertionMessage = null;
           CategoryName = categoryName;
           Category = category;
           try
           {
               ExpensesBLL ExpenseBLL = new ExpensesBLL();
               InsertionMessage = ExpenseBLL.InsertExpenseCategoryBLL(CategoryName, Category);
               return InsertionMessage;
           }
           catch (Exception ex)
           {
               return InsertionMessage;
           }

       }

       //Insert Expense
       public string InsertExpenseUI(int categoryId, string expenseAmount, string notes)
       {
           string InsertionMessage = null;
           CategoryId = categoryId;
           ExpenseAmount = expenseAmount;
           Notes = notes;
           try
           {
               ExpensesBLL ExpenseBLL = new ExpensesBLL();
               InsertionMessage = ExpenseBLL.InsertExpenseBLL(CategoryId, ExpenseAmount, Notes);
               return InsertionMessage;
           }
           catch (Exception ex)
           {
               return InsertionMessage;
           }

       }
    }
}
