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

namespace GymManagementSystem.FormsSuperAdmin.Salary
{
    public partial class FrmSASalaryPayment : Form
    {
        public FrmSASalaryPayment()
        {
            InitializeComponent();
        }

        private void FrmSASalaryPayment_Load(object sender, EventArgs e)
        {
            
            
            RetrieveAllEmployeeSalary();
            dgvEmployeeSalaryDetails.ClearSelection();
        }

        private void txtSearchBar_Click(object sender, EventArgs e)
        {
            int TextBoxClick = 1;
            if (TextBoxClick == 1)
            {
                txtSearchBar.Clear();
                txtSearchBar.ForeColor = Color.Black;
            }
            dgvEmployeeSalaryDetails.ClearSelection();
        }

        private void RetrieveAllEmployeeSalary()
        {
            string CS=ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                using (SqlCommand sqlCommand = new SqlCommand("spGetAllEmployeeSalaryPaymentDetails", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlConnection.Open();
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    DataRowCollection DataRows = dataTable.Rows;
                    int SerialNo = 1;
                    foreach (DataRow dataRow in DataRows)
                    {
                        int RowIndex = dgvEmployeeSalaryDetails.Rows.Add();
                        
                        dgvEmployeeSalaryDetails.Rows[RowIndex].Cells["colSLNo"].Value = SerialNo++;
                        dgvEmployeeSalaryDetails.Rows[RowIndex].Cells["colSLNo"].Style.ForeColor = Color.RoyalBlue;
                        dgvEmployeeSalaryDetails.Rows[RowIndex].Cells["colEmployeeFullName"].Value = dataRow["FullName"].ToString();
                        dgvEmployeeSalaryDetails.Rows[RowIndex].Cells["colPhoneNo"].Value = dataRow["PhoneNo"].ToString();
                        dgvEmployeeSalaryDetails.Rows[RowIndex].Cells["colSalary"].Value = dataRow["SalaryAmount"].ToString();

                    }


                }
            }
            catch (Exception ex)
            {
                dgvEmployeeSalaryDetails.DataSource = null;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void dgvEmployeeSalaryDetails_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvEmployeeSalaryDetails.Columns["ColAction"].Index)
            {
             e.PaintBackground(e.CellBounds, true);

        ButtonRenderer.DrawButton(e.Graphics, e.CellBounds,
            System.Windows.Forms.VisualStyles.PushButtonState.Normal);

        // Explicit fixed font — won't change regardless of selection/hover state
        Font fixedFont = new Font("Segoe UI", 10F, FontStyle.Bold);

        TextRenderer.DrawText(
            e.Graphics,
            "₹ Pay",
            fixedFont,
            e.CellBounds,
            Color.Green,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

        e.Handled = true;
    
            }
        


        }

        private void dgvEmployeeSalaryDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvEmployeeSalaryDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }

        }

        private void dgvEmployeeSalaryDetails_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvEmployeeSalaryDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
            }

        }

        private void tlpSalary_Click(object sender, EventArgs e)
        {
            dgvEmployeeSalaryDetails.ClearSelection();
        }

        private void FrmSASalaryPayment_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
