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
using GymManagementSystem.FormsSuperAdmin.MainLayout;
using GymManagementSystem.FormsSuperAdmin.Employee.UI;
using GymManagementSystem.Common;

namespace GymManagementSystem.FormsSuperAdmin.Employee
{
    public partial class FrmSADisplayAllEmployee : Form
    {
        private FrmSAMainForm SuperAdmnMainForm;
        private int ClickCountTxtSearch = 0;
        public FrmSADisplayAllEmployee(FrmSAMainForm mainform)
        {
            InitializeComponent();
            SuperAdmnMainForm = mainform;
        }
        private void FrmSADisplayAllEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployeeDetails();
            this.dvgEmployeeDetails.ClearSelection();
        }
        private void LoadEmployeeDetails()
        {
            try
            {
                EmployeeUI employeeUI = new EmployeeUI();

                DataTable dtEmployees =
                    employeeUI.DisplayAllEmployeeDetailsUI();

                dvgEmployeeDetails.Rows.Clear();

                int serialNo = 1;

                foreach (DataRow dataRow in dtEmployees.Rows)
                {
                    int rowIndex =
                        dvgEmployeeDetails.Rows.Add();

                    // =========================
                    // SI No.
                    // =========================

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colSlNo"].Value = serialNo++;

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colSlNo"]
                        .Style.ForeColor = Color.Blue;


                    // =========================
                    // Employee Id
                    // =========================

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colEmployeeId"].Value =
                        dataRow["EmployeeId"];


                    // =========================
                    // Employee Name
                    // =========================

                    string firstName =
                        dataRow["FirstName"].ToString();

                    string middleName =
                        dataRow["MiddleName"] == DBNull.Value
                            ? ""
                            : dataRow["MiddleName"].ToString();

                    string lastName =
                        dataRow["LastName"].ToString();

                    string fullName = string.Join(
                        " ",
                        new string[]
                {
                    firstName,
                    middleName,
                    lastName
                }.Where(x =>
                            !string.IsNullOrWhiteSpace(x))
                    );

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colName"].Value = fullName;


                    // =========================
                    // Gender
                    // =========================

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colGender"].Value =
                        dataRow["GenderName"].ToString();


                    // =========================
                    // Phone
                    // =========================

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colPhoneNo"].Value =
                        dataRow["PhoneNo"].ToString();


                    // =========================
                    // Joining Date
                    // =========================

                    if (dataRow["JoiningDate"] != DBNull.Value)
                    {
                        DateTime joiningDate =
                            Convert.ToDateTime(
                                dataRow["JoiningDate"]
                            );

                        dvgEmployeeDetails.Rows[rowIndex]
                            .Cells["colJoiningDate"].Value =
                            joiningDate.ToString("dd-MM-yyyy");
                    }
                    else
                    {
                        dvgEmployeeDetails.Rows[rowIndex]
                            .Cells["colJoiningDate"].Value = "";
                    }


                    // =========================
                    // Role
                    // =========================

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colRole"].Value =
                        dataRow["RoleName"].ToString();


                    // =========================
                    // Bank Account
                    // =========================

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colBankAccount"].Value =
                        dataRow["BankAccountNo"].ToString();


                    // =========================
                    // Status
                    // =========================

                    bool isActive =
                        Convert.ToBoolean(
                            dataRow["IsActive"]
                        );

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colStatus"].Value =
                        isActive
                            ? "Active"
                            : "Inactive";

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colStatus"]
                        .Style.ForeColor =
                        isActive
                            ? Color.Green
                            : Color.Red;


                    // =========================
                    // Update / Deactivate
                    // =========================

                    if (isActive)
                    {
                        dvgEmployeeDetails.Rows[rowIndex]
                            .Cells["colUpdate"].Value =
                            "📝 Update";

                        dvgEmployeeDetails.Rows[rowIndex]
                            .Cells["colUpdate"]
                            .Style.ForeColor =
                            Color.RoyalBlue;

                        dvgEmployeeDetails.Rows[rowIndex]
                            .Cells["colDeactivate"].Value =
                            "📝 Deactivate";

                        dvgEmployeeDetails.Rows[rowIndex]
                            .Cells["colDeactivate"]
                            .Style.ForeColor =
                            Color.Red;
                    }
                    else
                    {
                        dvgEmployeeDetails.Rows[rowIndex]
                            .Cells["colUpdate"].Value = "";

                        dvgEmployeeDetails.Rows[rowIndex]
                            .Cells["colDeactivate"].Value = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void LoadEmployeeDetailsByPhoneNo(string phoneNo)
        {
            try
            {
                EmployeeUI employeeUI = new EmployeeUI();

                DataTable dtEmployees =
                    employeeUI.DisplayEmployeeDetailsByPhoneNoUI(phoneNo);

                dvgEmployeeDetails.Rows.Clear();

                int serialNo = 1;

                foreach (DataRow dataRow in dtEmployees.Rows)
                {
                    int rowIndex = dvgEmployeeDetails.Rows.Add();

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colSlNo"].Value = serialNo++;

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colSlNo"]
                        .Style.ForeColor = Color.Blue;

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colEmployeeId"].Value =
                        dataRow["EmployeeId"];

                    string firstName =
                        dataRow["FirstName"].ToString();

                    string middleName =
                        dataRow["MiddleName"] == DBNull.Value
                            ? ""
                            : dataRow["MiddleName"].ToString();

                    string lastName =
                        dataRow["LastName"].ToString();

                    string fullName = string.Join(
                        " ",
                        new string[]
                {
                    firstName,
                    middleName,
                    lastName
                }.Where(x =>
                            !string.IsNullOrWhiteSpace(x))
                    );

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colName"].Value = fullName;

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colGender"].Value =
                        dataRow["GenderName"].ToString();

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colPhoneNo"].Value =
                        dataRow["PhoneNo"].ToString();

                    if (dataRow["JoiningDate"] != DBNull.Value)
                    {
                        DateTime joiningDate =
                            Convert.ToDateTime(dataRow["JoiningDate"]);

                        dvgEmployeeDetails.Rows[rowIndex]
                            .Cells["colJoiningDate"].Value =
                            joiningDate.ToString("dd-MM-yyyy");
                    }

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colRole"].Value =
                        dataRow["RoleName"].ToString();

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colBankAccount"].Value =
                        dataRow["BankAccountNo"].ToString();

                    bool isActive =
                        Convert.ToBoolean(dataRow["IsActive"]);

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colStatus"].Value =
                        isActive ? "Active" : "Inactive";

                    dvgEmployeeDetails.Rows[rowIndex]
                        .Cells["colStatus"]
                        .Style.ForeColor =
                        isActive ? Color.Green : Color.Red;

                    if (isActive)
                    {
                        dvgEmployeeDetails.Rows[rowIndex]
                            .Cells["colUpdate"].Value =
                            "📝 Update";

                        dvgEmployeeDetails.Rows[rowIndex]
                            .Cells["colDeactivate"].Value =
                            "📝 Deactivate";

                        dvgEmployeeDetails.Rows[rowIndex]
                            .Cells["colUpdate"]
                            .Style.ForeColor =
                            Color.RoyalBlue;

                        dvgEmployeeDetails.Rows[rowIndex]
                            .Cells["colDeactivate"]
                            .Style.ForeColor =
                            Color.Red;
                    }
                    else
                    {
                        dvgEmployeeDetails.Rows[rowIndex]
                            .Cells["colUpdate"].Value = "";

                        dvgEmployeeDetails.Rows[rowIndex]
                            .Cells["colDeactivate"].Value = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
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

        private void tlpAddNewEmployee_Click(object sender, EventArgs e)
        {
            SuperAdmnMainForm.OpenChildForm(new FrmSAAddNewEmployee());
        }

        private void pnlAddNewEmployee_Click(object sender, EventArgs e)
        {
            SuperAdmnMainForm.OpenChildForm(new FrmSAAddNewEmployee());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phoneNo = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(phoneNo) ||
                phoneNo == "Enter Mobile No")
            {
                MessageBox.Show(
                    "Please Enter Mobile No.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSearch.Focus();
                return;
            }
            LoadEmployeeDetailsByPhoneNo(phoneNo);
            if (dvgEmployeeDetails.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No Employee Found with this Mobile No.",
                    "Search Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadEmployeeDetails();
            }

            dvgEmployeeDetails.ClearSelection();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            ClickCountTxtSearch =
                ValidationUI.ClearTextBoxWhenClicked(txtSearch,ClickCountTxtSearch);
            txtSearch.ForeColor = Color.Black;
        }

        private void dvgEmployeeDetails_CellContentClick(object sender,DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dvgEmployeeDetails.Columns[e.ColumnIndex].Name == "colDeactivate")
            {
                int employeeId = Convert.ToInt32(
                    dvgEmployeeDetails.Rows[e.RowIndex]
                        .Cells["colEmployeeId"].Value
                );

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to change this employee's active status?",
                    "Employee Status",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    EmployeeUI employeeUI = new EmployeeUI();

                    string message =
                        employeeUI.ToggleEmployeeActiveStatusUI(employeeId);

                    MessageBox.Show(
                        message,
                        "Employee Status",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadEmployeeDetails();

                    dvgEmployeeDetails.ClearSelection();
                }
            }
        }
    }
}
