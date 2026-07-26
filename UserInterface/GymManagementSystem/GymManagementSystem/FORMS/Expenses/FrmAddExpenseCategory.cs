using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem.FORMS.Expenses
{
    public partial class FrmAddExpenseCategory : Form
    {
        public FrmAddExpenseCategory()
        {
            InitializeComponent();
        }

        private void tlpSubmit_Click(object sender, EventArgs e)
        {

        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtRequiredCategoryName.Clear();
            txtInputCategory.Clear();
        }

        private void txtRequiredCategoryName_Click(object sender, EventArgs e)
        {
            int CategoryName = 1;
            if (CategoryName == 1)
            {
                txtRequiredCategoryName.Clear();
                txtRequiredCategoryName.ForeColor = Color.Black;
            }
        }

        private void txtInputCategory_Click(object sender, EventArgs e)
        {
            int Category = 1;
            if (Category == 1)
            {
                txtInputCategory.Clear();
                txtInputCategory.ForeColor = Color.Black;
            }
        }

        private void FrmAddExpenseCategory_Load(object sender, EventArgs e)
        {
            txtInputCategory.Select(0, 0);
            txtInputCategory.DeselectAll();

            txtRequiredCategoryName.Select(0, 0);
            txtRequiredCategoryName.DeselectAll();
        }

        private void lblCancel_MouseEnter(object sender, EventArgs e)
        {
            lblCancel.BackColor = Color.FromArgb(196, 43, 28);
            lblCancel.ForeColor = Color.White;
        }

        private void lblCancel_MouseLeave(object sender, EventArgs e)
        {
            lblCancel.BackColor = Color.FromArgb(250,250,250);
            lblCancel.ForeColor = Color.Black;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
