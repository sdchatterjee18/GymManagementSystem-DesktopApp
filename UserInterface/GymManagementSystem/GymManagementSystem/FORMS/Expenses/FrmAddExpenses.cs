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
    public partial class FrmAddExpenses : Form
    {
        public FrmAddExpenses()
        {
            InitializeComponent();
        }

        private void tlpExpensesCategorySection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbSelcetCatogory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void RetrieveCategoryName()
        {
            Dictionary<int, string> ExpensesCategories = new Dictionary<int, string>();
            ExpensesCategories.Add(0, " Select Category");
            string CS=ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                using (SqlCommand sqlCommand = new SqlCommand("spRetrieveExpensesCategories", sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        int CategoryId = Convert.ToInt32(sqlDataReader["ExpenseCategoryID"]);
                        string CategoryName = sqlDataReader["CategoryName"].ToString();
                        ExpensesCategories.Add(CategoryId, CategoryName);
                    }
                    
                    cmbSelcetCatogory.DataSource = new BindingSource(ExpensesCategories.Values, null);
                    
                }
            }
            catch (Exception Ex)
            {
                cmbSelcetCatogory.DataSource = null;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void txtAmount_Click(object sender, EventArgs e)
        {
            int AmountClick = 1;
            if (AmountClick == 1)
            {
                txtAmount.Clear();
            }
        }

        private void txtExpensesDefination_Click(object sender, EventArgs e)
        {
            int DefinationClick = 1;
            if (DefinationClick == 1)
            {
                txtExpensesDefination.Clear();
            }
        }

        private void pnlAddNewExpensesCategory_MouseEnter(object sender, EventArgs e)
        {
            pnlAddNewExpensesCategory.BackColor = Color.LightGray;
            pnlAddNewExpensesCategory.ForeColor = Color.Black;
        }

        private void pnlAddNewExpensesCategory_MouseHover(object sender, EventArgs e)
        {
            pnlAddNewExpensesCategory.BackColor = Color.LightGray;
            pnlAddNewExpensesCategory.ForeColor = Color.Black;
        }

        private void pnlAddNewExpensesCategory_MouseLeave(object sender, EventArgs e)
        {
            pnlAddNewExpensesCategory.BackColor = Color.Transparent;
            pnlAddNewExpensesCategory.ForeColor = Color.Black;
        }

        private void pnlAddNewExpensesCategory_Click(object sender, EventArgs e)
        {
            FrmAddExpenseCategory frmAddExpensesCategory = new FrmAddExpenseCategory();
            frmAddExpensesCategory.ShowDialog();
        }

        private void FrmAddExpenses_Load(object sender, EventArgs e)
        {
            dgvExpenses.AutoGenerateColumns = false;
            
            RetrieveExpenses();
            RetrieveCategoryName();
        }
        private void RetrieveExpenses()
        {
            string CS=ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                using (SqlCommand sqlCommand = new SqlCommand("spGetAllExpenses", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dgvExpenses.DataSource = dataTable;
                    dgvExpenses.Columns["ExpensesId"].DataPropertyName = "ExpenseId";
                    dgvExpenses.Columns["CategoryName"].DataPropertyName = "CategoryName";
                    dgvExpenses.Columns["ExpensesCategory"].DataPropertyName = "Category";
                    dgvExpenses.Columns["Amount"].DataPropertyName = "ExpenseAmount";
                    dgvExpenses.Columns["Date"].DataPropertyName = "ExpenseDate";
                    dgvExpenses.Columns["Note"].DataPropertyName = "Notes";
                }
            }
            catch (Exception Ex)
            {
                dgvExpenses.DataSource = null;
            }
            finally
            {
                sqlConnection.Close();
            }

        }

        private void dgvExpenses_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void dgvExpenses_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvExpenses.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.DimGray;
                dgvExpenses.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.White;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvExpenses.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvExpenses_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvExpenses.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.LightGray;
                dgvExpenses.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvExpenses.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
                dgvExpenses.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Empty;
            }

        }

        private void tlpAddExpenses_Click(object sender, EventArgs e)
        {
            dgvExpenses.ClearSelection();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
        }
        

        private void picRefresh_Click(object sender, EventArgs e)
        {
            ReFreshData();
        }
        private void ReFreshData()
        {
            RetrieveExpenses();
            RetrieveCategoryName();
        }
    }
}
