using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using GymManagementSystem.FORMS.Expenses.UI;

namespace GymManagementSystem.FORMS.Expenses
{
    public partial class FrmAddExpenses : Form
    {
        public FrmAddExpenses()
        {
            InitializeComponent();
        }
        

        private void FrmAddExpenses_Load(object sender, EventArgs e)
        {
            //for Amount Text
            txtAmount.Select(0, 0);
            txtAmount.DeselectAll();

            //For Expense Defination 
            txtExpenseDefination.Select(0, 0);
            txtExpenseDefination.DeselectAll();

            RetrieveCategoryName();
            RetrieveAllExpense();
            dgvExpenses.ClearSelection();
        }


        //Retrieve Category Name for combobox
        public void RetrieveCategoryName()
        {
            DataTable CategoryName = null;
            try
            {
                ExpensesUI ExpenseUI = new ExpensesUI();
                cmbCateogory.DataSource = ExpenseUI.RetrieveCategoryNameUI();
                cmbCateogory.DisplayMember = "CategoryName";
                cmbCateogory.ValueMember = "ExpenseCategoryID";
                cmbCateogory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                CategoryName = null;
            }
        }
        //Retrieve All Expenses
        private void RetrieveAllExpense()
        {
            dgvExpenses.Rows.Clear();
            DataTable AllExpenses = null;
            try
            {
                ExpensesUI ExpenseUI = new ExpensesUI();
                AllExpenses = ExpenseUI.RetrieveAllExpensesUI();
                int SerialNo = 1;
                foreach (DataRow row in AllExpenses.Rows)
                {
                    dgvExpenses.Rows.Add(
                    SerialNo++,
                    row["CategoryName"].ToString(),
                    row["Category"].ToString(),
                   Convert.ToDecimal(row["ExpenseAmount"]),
                  Convert.ToDateTime( row["ExpenseDate"]).ToString("dd-MM-yyyy"),
                   row["Notes"].ToString()
                    );
                }
                
            }
            catch (Exception ex)
            {
                AllExpenses = null;
            }
        }

        //Retrieve Expense
        private void InsertExpense()
        {
            string InsertionMessage = null;
            try
            {
                ExpensesUI ExpenseUI = new ExpensesUI();
                InsertionMessage = ExpenseUI.InsertExpenseUI(Convert.ToInt32(cmbCateogory.SelectedValue), txtAmount.Text,txtExpenseDefination.Text);
                DialogResult Result = MessageBox.Show(InsertionMessage, "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                InsertionMessage = null;
            }
        }
        

        private void txtAmount_Click(object sender, EventArgs e)
        {
            int AmountClick = 1;
            if (AmountClick == 1)
            {
                txtAmount.Clear();
                txtAmount.ForeColor = Color.Black;
                
            }
        }

        private void cmbCateogory_Click(object sender, EventArgs e)
        {
            
        }

        private void txtExpenseDefination_Click(object sender, EventArgs e)
        {
            int ClickDefination = 1;
            if (ClickDefination == 1)
            {
                txtExpenseDefination.Clear();
                txtExpenseDefination.ForeColor = Color.Black;
            }
        }

        private void dgvExpenses_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvExpenses.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }

        }

        private void dgvExpenses_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvExpenses.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;

                string colName = dgvExpenses.Columns[e.ColumnIndex].Name;

                if (colName == "colSlNo")
                {
                    dgvExpenses.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.FromArgb(30, 60, 220);
                }

            }
        }


        private void tlpAddExpenses_Click(object sender, EventArgs e)
        {
            dgvExpenses.ClearSelection();
           
        }



        private void pnlAddExpenseCategory_Click_1(object sender, EventArgs e)
        {
            FrmAddExpenseCategory frmAddExpenseCategory = new FrmAddExpenseCategory();
            frmAddExpenseCategory.ShowDialog();
            RetrieveCategoryName();
        }

        private void tlpAddButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpAddButton.BackColor = Color.FromArgb(220, 225, 230);
        }

        private void tlpAddButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpAddButton.BackColor = Color.FromArgb(236, 240, 243);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            InsertExpense();
            RetrieveAllExpense();
            
        } 
    }
}
