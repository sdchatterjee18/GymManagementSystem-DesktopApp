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

namespace GymManagementSystem.FormsSuperAdmin.Employee
{
    public partial class FrmSADisplayAllEmployee : Form
    {
        public FrmSADisplayAllEmployee()
        {
            InitializeComponent();
        }

        private void getEmployeeDetails()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = new SqlConnection(connectionString);
                string queryStr = "spDisplayAllEmployeeDetails";

                using (SqlCommand sqlCommand = new SqlCommand(queryStr, sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dtEmployees = new DataTable();
                        adapter.Fill(dtEmployees);

                        DataRowCollection dataRows = dtEmployees.Rows;

                        dvgEmployeeDetails.Rows.Clear();

                        int serialNo = 1;

                        foreach (DataRow dataRow in dataRows)
                        {
                            int rowIndex = dvgEmployeeDetails.Rows.Add();

                            dvgEmployeeDetails.Rows[rowIndex].Cells["colSlNo"].Value = serialNo++;
                            dvgEmployeeDetails.Rows[rowIndex].Cells["colSlNo"].Style.ForeColor = Color.Blue;
                            dvgEmployeeDetails.Rows[rowIndex].Cells["colName"].Value = dataRow["FullName"].ToString();
                            dvgEmployeeDetails.Rows[rowIndex].Cells["colGender"].Value = dataRow["GenderName"].ToString();
                            dvgEmployeeDetails.Rows[rowIndex].Cells["colPhoneNo"].Value = dataRow["PhoneNo"].ToString();
                            dvgEmployeeDetails.Rows[rowIndex].Cells["colEmail"].Value = dataRow["EmailId"].ToString();

                            object joiningDateValue = dataRow["JoiningDate"];
                            if (joiningDateValue != null && joiningDateValue != DBNull.Value)
                            {
                                DateTime joiningDate = Convert.ToDateTime(joiningDateValue);
                                dvgEmployeeDetails.Rows[rowIndex].Cells["colJoiningDate"].Value = joiningDate.ToString("dd-MM-yyyy");
                            }
                            else
                            {
                                dvgEmployeeDetails.Rows[rowIndex].Cells["colJoiningDate"].Value = "";
                            }

                            dvgEmployeeDetails.Rows[rowIndex].Cells["colRole"].Value = dataRow["RoleName"].ToString();
                            dvgEmployeeDetails.Rows[rowIndex].Cells["colBankAccount"].Value = dataRow["BankAccountNo"].ToString();

                            bool isActive = Convert.ToBoolean(dataRow["IsActive"]);

                            dvgEmployeeDetails.Rows[rowIndex].Cells["colStatus"].Value = isActive ? "Active" : "Inactive";
                            dvgEmployeeDetails.Rows[rowIndex].Cells["colStatus"].Style.ForeColor = isActive ? Color.Green : Color.Red;

                            if (isActive)
                            {
                                dvgEmployeeDetails.Rows[rowIndex].Cells["colUpdate"].Value = "📝Update";
                                dvgEmployeeDetails.Rows[rowIndex].Cells["colUpdate"].Style.ForeColor = Color.RoyalBlue;
                                dvgEmployeeDetails.Rows[rowIndex].Cells["colDeactivate"].Value = "Deactivate";
                                dvgEmployeeDetails.Rows[rowIndex].Cells["colDeactivate"].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                dvgEmployeeDetails.Rows[rowIndex].Cells["colUpdate"].Value = "";
                                dvgEmployeeDetails.Rows[rowIndex].Cells["colDeactivate"].Value = "";
                            }

                            dvgEmployeeDetails.Rows[rowIndex].Tag = dataRow["EmployeeId"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void FrmSADisplayAllEmployee_Load(object sender, EventArgs e)
        {
            getEmployeeDetails();
            this.dvgEmployeeDetails.ClearSelection();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter Mobile No")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Enter Mobile No";
                txtSearch.ForeColor = SystemColors.GrayText;
            }
        }

        private void FrmSADisplayAllEmployee_Click(object sender, EventArgs e)
        {
            this.dvgEmployeeDetails.ClearSelection();
        }

        private void dvgEmployeeDetails_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dvgEmployeeDetails.Columns["colUpdate"].Index || e.ColumnIndex == dvgEmployeeDetails.Columns["colDeactivate"].Index))
            {
                object cellValue = dvgEmployeeDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                e.PaintBackground(e.CellBounds, true);

                if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString()))
                {
                    TextRenderer.DrawText(
                        e.Graphics,
                        cellValue.ToString(),
                        e.CellStyle.Font,
                        e.CellBounds,
                        e.CellStyle.ForeColor,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }

                e.Handled = true; 
            }
        }

        private void dvgEmployeeDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dvgEmployeeDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dvgEmployeeDetails_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = dvgEmployeeDetails.Columns[e.ColumnIndex].Name;
                var cell = dvgEmployeeDetails.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (colName == "colSlNo")
                {
                    cell.Style.ForeColor = Color.Blue;
                    cell.Style.BackColor = Color.Empty;
                }
                else if (colName == "colStatus")
                {
                    string status = cell.Value.ToString();
                    if (status != null && status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                        cell.Style.ForeColor = Color.Green;
                    else if (status != null && status.Equals("Inactive", StringComparison.OrdinalIgnoreCase))
                        cell.Style.ForeColor = Color.Red;

                    cell.Style.BackColor = Color.Empty;
                }
                else if (colName == "colUpdate")
                {
                    cell.Style.ForeColor = Color.RoyalBlue;
                    cell.Style.BackColor = Color.Empty;
                }
                else if (colName == "colDeactivate")
                {
                    cell.Style.ForeColor = Color.Red;
                    cell.Style.BackColor = Color.Empty;
                }
                else
                {
                    cell.Style.ForeColor = Color.Empty;
                    cell.Style.BackColor = Color.Empty;
                }
            }
        }

        private void pnlAddNewEmployee_MouseEnter(object sender, EventArgs e)
        {
            this.pnlAddNewEmployee.BackColor = Color.FromArgb(220,225,230);
        }

        private void pnlAddNewEmployee_MouseLeave(object sender, EventArgs e)
        {
            this.pnlAddNewEmployee.BackColor = Color.FromArgb(236, 240, 243);
        }
    }
}
