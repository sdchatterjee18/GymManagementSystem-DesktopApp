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
using GymManagementSystemBLLayer.Common;

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
        private void txtRequiredCategoryName_Click(object sender, EventArgs e)
        {
            if (clickCountCategoryName != 1)
            {
                clickCountCategoryName = ValidationUI.ClearTextBoxWhenClicked(txtRequiredCategoryName, clickCountCategoryName);
            }
        }
        private void txtInputCategory_Click(object sender, EventArgs e)
        {
            if (clickCountCategory != 1)
            {
                clickCountCategory = ValidationUI.ClearTextBoxWhenClicked(txtInputCategory, clickCountCategory);
            }
        }

        private void FrmAddExpenseCategory_Load(object sender, EventArgs e)
        {
            this.Text = "";
            this.ShowIcon = false;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertExpenseCatogory()
        {
            ValidationUI.ClearDefaultPlaceholderText(
                txtRequiredCategoryName, clickCountCategoryName);

            ValidationUI.ClearDefaultPlaceholderText(
                txtInputCategory, clickCountCategory);

            // VALIDATION
            ValidationUI.ValidationResult result;
            bool isValid = true;
            errorProvider1.Clear();

            // Category Name
            result = ValidationUI.ValidateRequiredTextBox(
                txtRequiredCategoryName);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    txtRequiredCategoryName,
                    "Category Name " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }

            // Category
            result = ValidationUI.ValidateRequiredTextBox(
                txtInputCategory);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    txtInputCategory,
                    "Category " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }

            if (!isValid)
            {
                DialogResult Result = MessageBox.Show(
                    "Please fill in all required fields.",
                    "Required Fields",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                if (Result == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(txtRequiredCategoryName.Text))
                    {
                        txtRequiredCategoryName.Text = "---Enter category name---";
                        clickCountCategoryName = 0;
                        txtRequiredCategoryName.ForeColor = Color.Gray;
                    }

                    if (string.IsNullOrWhiteSpace(txtInputCategory.Text))
                    {
                        txtInputCategory.Text = "---Enter category---";
                        clickCountCategory = 0;
                        txtInputCategory.ForeColor = Color.Gray;
                    }
                }

                this.ActiveControl = null;
                return;
            }

            // ASSIGN UI VALUES
            ExpensesUI expenseUI = new ExpensesUI();

            expenseUI.CategoryName = txtRequiredCategoryName.Text.Trim();
            expenseUI.Category = txtInputCategory.Text.Trim();

            // INSERT
            ValidationResult finalResult =
                expenseUI.InsertExpenseCategoryUI();

            HandleExpenseCategoryResult(finalResult);
        }
        private void HandleExpenseCategoryResult(ValidationResult result)
        {
            errorProvider1.Clear();

            if (result.Result == ValidationBll.CommonValidationMessage.Valid)
            {
                MessageBox.Show(
                    result.Message,
                    "Expense Category",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            switch (result.FieldName)
            {
                case "CategoryName":
                    errorProvider1.SetError(
                        txtRequiredCategoryName,
                        result.Message);
                    break;

                case "Category":
                    errorProvider1.SetError(
                        txtInputCategory,
                        result.Message);
                    break;
            }

            MessageBox.Show(
                result.Message,
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            this.ActiveControl = null;
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
            InsertExpenseCatogory();      
        }
        private void pnlClear_Click(object sender, EventArgs e)
        {
            txtRequiredCategoryName.Text = "---Enter category name---";
            txtRequiredCategoryName.ForeColor = Color.Gray;
            clickCountCategoryName = 0;

            txtInputCategory.Text = "---Enter category---";
            txtInputCategory.ForeColor = Color.Gray;
            clickCountCategory = 0;

            errorProvider1.Clear();
        }

        private void pnlClear_MouseEnter(object sender, EventArgs e)
        {
            tlpClear.BackColor = Color.White;
            lblClear.ForeColor = Color.MidnightBlue;
        }

        private void pnlClear_MouseLeave(object sender, EventArgs e)
        {
            tlpClear.BackColor = Color.MidnightBlue;
            lblClear.ForeColor = Color.White;
        }

        private void txtRequiredCategoryName_Enter(object sender, EventArgs e)
        {
            if (clickCountCategoryName != 1)
            {
                clickCountCategoryName = ValidationUI.ClearTextBoxWhenClicked(txtRequiredCategoryName, clickCountCategoryName);
            }
        }
        private bool ignoreFirstEnter = true;
        private void txtInputCategory_Enter(object sender, EventArgs e)
        {
            if (ignoreFirstEnter)
            {
                ignoreFirstEnter = false;
                return;
            }
            if (clickCountCategory != 1)
            {
                clickCountCategory = ValidationUI.ClearTextBoxWhenClicked(txtInputCategory, clickCountCategory);
            }
        }

        private void txtRequiredCategoryName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRequiredCategoryName.Text))
            {
                txtRequiredCategoryName.Text = "---Enter category name---";
                txtRequiredCategoryName.ForeColor = Color.Gray;
                clickCountCategoryName = 0;
            }
        }

        private void txtInputCategory_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputCategory.Text))
            {
                txtInputCategory.Text = "---Enter category---";
                txtInputCategory.ForeColor = Color.Gray;
                clickCountCategory = 0;
            }
        }

        private void FrmAddExpenseCategory_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
