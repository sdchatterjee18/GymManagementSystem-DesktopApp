using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Expense;
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystem.FORMS.Expenses.UI
{
   public class ExpensesUI
    {

        //Properties
        public string CategoryName { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
        public decimal ExpenseAmount { get; set; }
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
       public ValidationResult InsertExpenseCategoryUI()
       {
           ExpensesBLL expensesBLL = new ExpensesBLL();

           expensesBLL.CategoryName = this.CategoryName;
           expensesBLL.Category = this.Category;

           return expensesBLL.InsertExpenseCategoryBLL();
       }

       //Insert Expense
       public ValidationResult InsertExpenseUI()
       {
        
           ExpensesBLL ExpenseBLL = new ExpensesBLL();
           ExpenseBLL.CategoryId = this.CategoryId;
           ExpenseBLL.ExpenseAmount = this.ExpenseAmount;
           ExpenseBLL.Notes = this.Notes; 

           return ExpenseBLL.InsertExpenseBLL();
         
       }
    }
}
