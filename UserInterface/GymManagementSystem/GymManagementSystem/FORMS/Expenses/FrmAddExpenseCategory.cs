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
            this.Text = "";
            this.ShowIcon = false;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
