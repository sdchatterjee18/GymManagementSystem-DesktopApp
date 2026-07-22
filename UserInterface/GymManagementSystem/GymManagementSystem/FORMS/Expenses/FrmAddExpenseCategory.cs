using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace GymManagementSystem.FORMS.Expenses
{
    public partial class FrmAddExpenseCategory : Form
    {
        public FrmAddExpenseCategory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void lblCancel_MouseEnter(object sender, EventArgs e)
        {
            lblCancel.BackColor = Color.Maroon;
            lblCancel.ForeColor = Color.White;
        }

        private void lblCancel_MouseHover(object sender, EventArgs e)
        {
            lblCancel.BackColor = Color.Maroon;
            lblCancel.ForeColor = Color.White;
        }

        private void lblCancel_MouseLeave(object sender, EventArgs e)
        {
            lblCancel.BackColor = Color.Transparent;
            lblCancel.ForeColor = Color.Black;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            
           
        }
        
    }
}
