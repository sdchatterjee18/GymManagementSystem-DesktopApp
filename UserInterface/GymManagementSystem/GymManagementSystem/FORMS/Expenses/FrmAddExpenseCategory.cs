using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.FORMS.Expenses.UI;
using GymManagementSystem.FORMS.Expenses;
using GymManagementSystem.Common;

namespace GymManagementSystem.FORMS.Expenses
{
    public partial class FrmAddExpenseCategory : Form
    {
        public FrmAddExpenseCategory()
        {
            InitializeComponent();
        }
        int clickCountCategory = 0;
        int clickCountCategoryName = 0;
        private void lblClear_Click(object sender, EventArgs e)
        {
            txtRequiredCategoryName.Clear();
            txtInputCategory.Clear();
        }

        private void txtRequiredCategoryName_Click(object sender, EventArgs e)
        {
            clickCountCategoryName = ValidationUI.ClearTextBoxWhenClicked(txtRequiredCategoryName,clickCountCategoryName);
        }

        private void txtInputCategory_Click(object sender, EventArgs e)
        {
            clickCountCategory = ValidationUI.ClearTextBoxWhenClicked(txtInputCategory, clickCountCategory);
        }

        private void FrmAddExpenseCategory_Load(object sender, EventArgs e)
        {
            txtInputCategory.Select(0, 0);
            txtInputCategory.DeselectAll();

            txtRequiredCategoryName.Select(0, 0);
            txtRequiredCategoryName.DeselectAll();
            this.Text = "";
            this.ShowIcon = false;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void InsertExpenseCatogory()
        {
            string InsertionMessage = null;
            try
            {
                ExpensesUI ExpenseUI = new ExpensesUI();
                InsertionMessage = ExpenseUI.InsertExpenseCategoryUI(txtRequiredCategoryName.Text, txtInputCategory.Text);
                DialogResult Result = MessageBox.Show(InsertionMessage, "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (Result == DialogResult.OK)
                {
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                InsertionMessage = null; 
            }
        }
        private void tlpSubmit_MouseEnter_1(object sender, EventArgs e)
        {
            tlpSubmit.BackColor = Color.White;
            lblSubmit.ForeColor = Color.MidnightBlue;
            picSubmit.Image = Properties.Resources.paper_planeHOVER;
        }

        private void tlpSubmit_MouseLeave_1(object sender, EventArgs e)
        {
            tlpSubmit.BackColor = Color.MidnightBlue;
            lblSubmit.ForeColor = Color.White;
            picSubmit.Image = Properties.Resources.paper_plane;
        }

        private void tlpSubmit_Click_1(object sender, EventArgs e)
        {
            ValidationUI.ClearDefaultPlaceholderText(txtRequiredCategoryName,clickCountCategoryName);
            ValidationUI.ClearDefaultPlaceholderText(txtInputCategory,clickCountCategory);
            if(!ValidationUI.ValidateRequiredTextBoxes(txtInputCategory,txtRequiredCategoryName))
            {
                return;
            }
            InsertExpenseCatogory();      
        }
    }
}
