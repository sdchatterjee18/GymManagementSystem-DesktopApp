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

            RetrieveAllExpenses();
        }
        private void RetrieveAllExpenses()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                using (SqlCommand sqlCommand = new SqlCommand("spGetAllExpenses", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    DataRowCollection dataRows = dataTable.Rows;
                    int SerialNo = 1;
                    foreach (DataRow dataRow in dataRows)
                    {
                        int RowIndex = dgvExpenses.Rows.Add();
                        dgvExpenses.Rows[RowIndex].Cells["colSLNo"].Value = SerialNo++;
                        dgvExpenses.Rows[RowIndex].Cells["colSLNo"].Style.ForeColor = Color.RoyalBlue;
                        dgvExpenses.Rows[RowIndex].Cells["colCategoryName"].Value = dataRow["CategoryName"].ToString();
                        dgvExpenses.Rows[RowIndex].Cells["colCategory"].Value = dataRow["Category"].ToString();
                        dgvExpenses.Rows[RowIndex].Cells["colExpenseAmount"].Value = dataRow["ExpenseAmount"].ToString();
                        dgvExpenses.Rows[RowIndex].Cells["colExpenseDate"].Value = dataRow["ExpenseDate"].ToString();
                        dgvExpenses.Rows[RowIndex].Cells["colNotes"].Value = dataRow["Notes"].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                dgvExpenses.DataSource = null;
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

        private void pnlAddExpenseCategory_Click(object sender, EventArgs e)
        {
            FrmAddExpenseCategory frmAddExpenseCategory = new FrmAddExpenseCategory();
            frmAddExpenseCategory.ShowDialog();


        }

        private void pnlAddExpenseCategory_MouseEnter(object sender, EventArgs e)
        {
            pnlAddExpenseCategory.BackColor = Color.FromArgb(220,225,230);
        }

        private void pnlAddExpenseCategory_MouseHover(object sender, EventArgs e)
        {
            pnlAddExpenseCategory.BackColor = Color.FromArgb(220, 225, 230);
        }

        private void pnlAddExpenseCategory_MouseLeave(object sender, EventArgs e)
        {
            pnlAddExpenseCategory.BackColor = Color.FromArgb(236, 240, 243);
        }

        private void tlpAddExpenses_Click(object sender, EventArgs e)
        {
            dgvExpenses.ClearSelection();
        }
        
    }
}
