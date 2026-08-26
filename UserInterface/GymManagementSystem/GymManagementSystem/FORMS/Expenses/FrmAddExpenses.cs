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
using GymManagementSystem.Common;
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystem.FORMS.Expenses
{
    public partial class FrmAddExpenses : Form
    {
        public FrmAddExpenses()
        {
            InitializeComponent();
            SetErrorProviderAlignment();
        }

        int clickCountTxtAmount = 0;
        int clickCountTxtNote = 0;
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
        // Set Error Provider Alignment
        private void SetErrorProviderAlignment()
        {
            Control[] controls =
            {
               this.txtAmount,
               this.cmbCateogory,
               this.txtExpenseDefination
            };
            foreach (Control control in controls)
            {
                errorProvider1.SetIconAlignment(
                    control,
                    ErrorIconAlignment.MiddleRight);

                errorProvider1.SetIconPadding(
                    control,
                    150);
            }
        }

        //Retrieve Category Name for combobox
        public void RetrieveCategoryName()
        {
            DataTable CategoryName = null;
            try
            {
                ExpensesUI ExpenseUI = new ExpensesUI();
                CategoryName = ExpenseUI.RetrieveCategoryNameUI();
                cmbCateogory.DataSource = CategoryName;
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
                    "₹ " +
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
                //InsertionMessage = ExpenseUI.InsertExpenseUI(Convert.ToInt32(cmbCateogory.SelectedValue), txtAmount.Text,txtExpenseDefination.Text);
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
            
            
            
        }

        private void tlpSelectCategory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpSearchBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            ValidationUI.ClearDefaultPlaceholderText(txtExpenseDefination, clickCountTxtNote);
            ValidationUI.ClearDefaultPlaceholderText(txtAmount, clickCountTxtAmount);
          
            // VALIDATION
            ValidationUI.ValidationResult result;
            bool isValid = true;
            errorProvider1.Clear();

            // Amount
            result = ValidationUI.ValidateRequiredTextBox(txtAmount);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    txtAmount,
                    "Amount " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }

            //select combo box
            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    cmbCateogory,
                    "Category " +
                    ValidationUI.GetValidationMessage(result));
                isValid = false;
            }
            //  Expense Defination
            result = ValidationUI.ValidateRequiredTextBox(txtExpenseDefination);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    txtExpenseDefination,
                    "Description " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }
            
            if (!isValid)
            {
                MessageBox.Show(
                    "Please fill up all required fields.",
                    "Required Fields",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.ActiveControl = null;
                return;
            }
            decimal price;
            if (!decimal.TryParse(txtAmount.Text.Trim(), out price))
            {
                errorProvider1.SetError(
                    txtAmount,
                    "Price must contain a valid numeric value.");

                MessageBox.Show(
                    "Price must contain a valid numeric value.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            ExpensesUI expenseUI = new ExpensesUI();
            expenseUI.ExpenseAmount = Convert.ToDecimal(this.txtAmount.Text.Trim());
            expenseUI.CategoryId = Convert.ToInt32(cmbCateogory.SelectedValue);
            expenseUI.Notes = this.txtExpenseDefination.Text.Trim();

            ValidationResult finalResult = expenseUI.InsertExpenseUI();

            if (finalResult.FieldName == "")
            {
                MessageBox.Show(finalResult.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            RetrieveAllExpense();

        }

        private void pnlAddExpenseCategory_MouseEnter(object sender, EventArgs e)
        {
            pnlAddExpenseCategory.BackColor = Color.White;
            picAddIcon.Image = Properties.Resources.plusHOVER;
            lblAddNewExpenseCategory.ForeColor = Color.MidnightBlue;
        }

        private void pnlAddExpenseCategory_MouseLeave(object sender, EventArgs e)
        {
            pnlAddExpenseCategory.BackColor = Color.MidnightBlue;
            picAddIcon.Image = Properties.Resources.plus;
            lblAddNewExpenseCategory.ForeColor = Color.White;
        }

        private void pnlAddExpenseCategory_Click(object sender, EventArgs e)
        {
            FrmAddExpenseCategory frmAddExpenseCategory = new FrmAddExpenseCategory();
            frmAddExpenseCategory.ShowDialog();
            RetrieveCategoryName();
        }

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.White;
            btnSubmit.ForeColor = Color.MidnightBlue;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.MidnightBlue;
            btnSubmit.ForeColor = Color.White;
        }

        private void txtAmount_Click_1(object sender, EventArgs e)
        {
           clickCountTxtAmount= ValidationUI.ClearTextBoxWhenClicked(txtAmount, clickCountTxtAmount);
           txtAmount.ForeColor = Color.Black;
        }

        private void txtExpenseDefination_Click_1(object sender, EventArgs e)
        {
            clickCountTxtNote=ValidationUI.ClearTextBoxWhenClicked(txtExpenseDefination, clickCountTxtNote);
            txtExpenseDefination.ForeColor = Color.Black;
        }

        private void dgvExpenses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvExpenses.Columns[e.ColumnIndex].Name == "colNotes")
            {
                e.CellStyle.ForeColor = Color.Green;
            }

            if (dgvExpenses.Columns[e.ColumnIndex].Name == "colExpenseAmount")
            {
                e.CellStyle.ForeColor = Color.Red;
            }

            if (dgvExpenses.Columns[e.ColumnIndex].Name == "colSLNo")
            {
                e.CellStyle.ForeColor = Color.Blue;
            }
            if (dgvExpenses.Columns[e.ColumnIndex].Name == "ExpenseDate")
            {
                e.CellStyle.ForeColor = Color.Blue;
            }
            
        } 

    }
}
