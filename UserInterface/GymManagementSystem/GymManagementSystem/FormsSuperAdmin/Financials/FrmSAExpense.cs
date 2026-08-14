using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GymManagementSystem.FormsSuperAdmin.Financials
{
    public partial class FrmSAExpense : Form
    {
        public FrmSAExpense()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvExpensesHistory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvExpensesHistory.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvExpensesHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvExpensesHistory_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvExpensesHistory.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvExpensesHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;



            }
        }

        private void dgvExpensesHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvExpensesHistory.Columns[e.ColumnIndex].Name == "colSLNo")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Navy;

                }
            }

            if (dgvExpensesHistory.Columns[e.ColumnIndex].Name == "colExpenseDate")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Green;

                }
            }

            if (dgvExpensesHistory.Columns[e.ColumnIndex].Name == "colExpenseAmount")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Navy;

                }
            }
        }

        private void RetrieveAllExpenses()
        {
            string CS = ConfigurationManager
                .ConnectionStrings["DBCS"]
                .ConnectionString;

            try
            {
                using (SqlConnection sqlConnection =
                    new SqlConnection(CS))
                {
                    using (SqlCommand sqlCommand =
                        new SqlCommand(
                            "spRetrieveAllExpenseStatement",
                            sqlConnection))
                    {
                        sqlCommand.CommandType =
                            CommandType.StoredProcedure;

                        SqlDataAdapter sqlDataAdapter =
                            new SqlDataAdapter(sqlCommand);

                        DataTable dataTable =
                            new DataTable();

                        sqlDataAdapter.Fill(dataTable);



                        dgvExpensesHistory.AutoGenerateColumns = false;

                        dgvExpensesHistory.Rows.Clear();

                        int serialNo = 1;


                        foreach (DataRow dataRow
                            in dataTable.Rows)
                        {
                            int rowIndex =
                                dgvExpensesHistory.Rows.Add();


                            // SL No
                            dgvExpensesHistory.Rows[rowIndex]
                                .Cells["colSLNo"]
                                .Value = serialNo++;


                            // Category Name
                            dgvExpensesHistory.Rows[rowIndex]
                                .Cells["colCategoryName"]
                                .Value =
                                dataRow["CategoryName"]
                                .ToString();


                            // Category
                            dgvExpensesHistory.Rows[rowIndex]
                                .Cells["colCategory"]
                                .Value =
                                dataRow["Category"]
                                .ToString();


                            // Expense Amount
                            dgvExpensesHistory.Rows[rowIndex]
                                .Cells["colExpenseAmount"]
                                .Value =
                                Convert.ToDecimal(
                                    dataRow["ExpenseAmount"])
                                .ToString("0.00");


                            // Expense Date
                            dgvExpensesHistory.Rows[rowIndex]
                                .Cells["colExpenseDate"]
                                .Value =
                                Convert.ToDateTime(
                                    dataRow["ExpenseDate"])
                                .ToString("dd-MM-yyyy");


                            // Notes
                            dgvExpensesHistory.Rows[rowIndex]
                                .Cells["colNotes"]
                                .Value =
                                dataRow["Notes"].ToString();


                            // Expense ID
                            if (dgvExpensesHistory.Columns
                                .Contains("colExpenseId"))
                            {
                                dgvExpensesHistory.Rows[rowIndex]
                                    .Cells["colExpenseId"]
                                    .Value =
                                    Convert.ToInt32(
                                        dataRow["ExpenseId"]);
                            }
                        }


                        dgvExpensesHistory.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void FrmSAExpense_Load(object sender, EventArgs e)
        {
            dgvExpensesHistory.ClearSelection();
            RetrieveAllExpenses();
        }

        private void FrmSAExpense_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

       
    }
}
