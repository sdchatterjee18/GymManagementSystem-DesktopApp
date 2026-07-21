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
            int RowEffected=InsertExpensesCategory();
            if(RowEffected > 0)
            {
                MessageBox.Show("Expenses Category is Added Successfully", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" Fail to add Expenses Category", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
           
        }
        private int InsertExpensesCategory()
        {
            string CS=ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            int RowsEffected = 0;
            try
            {
                sqlConnection = new SqlConnection(CS);
                using (SqlCommand sqlCommand = new SqlCommand("spAddExpenseCategory", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    if (string.IsNullOrWhiteSpace(txtNewExpensesCategoryName.Text))
                    {
                        txtCategoryNameErrorMessage.Text = "Enter Expense Category Name";
                        txtCategoryNameErrorMessage.ForeColor = Color.Red;
                        txtCategoryNameErrorMessage.Focus();
                        return RowsEffected;
                    }
                    if (string.IsNullOrWhiteSpace(txtCategory.Text))
                    {
                        txtCategoryErrorMessage.Text = "Enter Expense Category";
                        txtCategoryErrorMessage.ForeColor = Color.Red;
                        txtCategoryErrorMessage.Focus();
                        return RowsEffected;
                    }
                    sqlCommand.Parameters.AddWithValue("@CategoryName", this.txtNewExpensesCategoryName.Text);
                    sqlCommand.Parameters.AddWithValue("@Category", this.txtCategory.Text);
                    sqlConnection.Open();
                    RowsEffected = sqlCommand.ExecuteNonQuery();
                    

                }
                return RowsEffected;
            }
            catch (Exception Ex)
            {
                return RowsEffected;
            }
            finally
            {
                sqlConnection.Close();
            }
            
        }
    }
}
