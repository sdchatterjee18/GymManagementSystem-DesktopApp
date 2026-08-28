using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.FORMS.Attendance.UI;

namespace GymManagementSystem.FORMS.Attendance
{
    public partial class FrmAttendanceHistory : Form
    {
        private int MemberId;

        public FrmAttendanceHistory(int memberId)
        {
            InitializeComponent();

            MemberId = memberId;
        }

        private void FrmAttendanceHistory_Load(object sender, EventArgs e)
        {

            dtpStartDateAttendanceHistory.Format = DateTimePickerFormat.Custom;
            dtpStartDateAttendanceHistory.CustomFormat = "MMMM dd, yyyy";

            dtpEndDateAttendanceHistory.Format = DateTimePickerFormat.Custom;
            dtpEndDateAttendanceHistory.CustomFormat = "MMMM dd, yyyy";
            LoadMemberAttendanceTillToday();
                  

        }

        private void dgvViewAttendanceHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvViewAttendanceHistory.Columns[e.ColumnIndex].Name == "colSerialNo")
            {
                e.CellStyle.ForeColor = Color.Navy;
            }

            if (dgvViewAttendanceHistory.Columns[e.ColumnIndex].Name == "colAttendanceDate")
            {
                e.CellStyle.ForeColor = Color.Green;
            }
           
        }

        private void dgvViewAttendanceHistory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvViewAttendanceHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvViewAttendanceHistory_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvViewAttendanceHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
            }
        }

        private void FrmAttendanceHistory_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnSearchAttendanceHistory_Click(object sender, EventArgs e)
        {
            try
            {
                // =========================================================
                // Get Start Date and End Date
                // =========================================================

                DateTime fromDate =
                    dtpStartDateAttendanceHistory.Value.Date;

                DateTime toDate =
                    dtpEndDateAttendanceHistory.Value.Date;


                // =========================================================
                // Validate Date Range
                // =========================================================

                if (fromDate > toDate)
                {
                    MessageBox.Show(
                        "Start Date cannot be greater than End Date.",
                        "Invalid Date",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    // Reset Total Attendance
                    lblOutputTotalAttendance.Text = "0";

                    return;
                }


                // =========================================================
                // Create Attendance UI Object
                // =========================================================

                AttendanceUI attendanceUI =
                    new AttendanceUI();


                // =========================================================
                // Retrieve Attendance History
                // =========================================================

                DataTable attendanceData =
                    attendanceUI.RetrieveMemberAttendanceByDateRangeUI(
                        MemberId,
                        fromDate,
                        toDate
                    );


                // =========================================================
                // Retrieve Total Attendance
                // =========================================================

                DataTable totalAttendanceData =
                    attendanceUI.RetrieveMemberTotalAttendanceByDateRangeUI(
                        MemberId,
                        fromDate,
                        toDate
                    );


                // =========================================================
                // Clear Existing Grid Data
                // =========================================================

                dgvViewAttendanceHistory.Rows.Clear();


                // =========================================================
                // Display Total Attendance
                // =========================================================

                if (totalAttendanceData != null &&
                    totalAttendanceData.Rows.Count > 0 &&
                    totalAttendanceData.Columns.Contains("TotalAttendance"))
                {
                    lblOutputTotalAttendance.Text =
                        totalAttendanceData.Rows[0]["TotalAttendance"].ToString();
                }
                else
                {
                    lblOutputTotalAttendance.Text = "0";
                }


                // =========================================================
                // Check Null / Empty Attendance Data
                // =========================================================

                if (attendanceData == null ||
                    attendanceData.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No attendance found for the selected date range.",
                        "Attendance History",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }


                // =========================================================
                // Handle Message Returned From Stored Procedure
                // =========================================================

                if (attendanceData.Columns.Contains("Message"))
                {
                    MessageBox.Show(
                        attendanceData.Rows[0]["Message"].ToString(),
                        "Attendance History",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                // =========================================================
                // Load Attendance Data Into DataGridView
                // =========================================================

                int serialNo = 1;

                foreach (DataRow row in attendanceData.Rows)
                {
                    int rowIndex =
                        dgvViewAttendanceHistory.Rows.Add();


                    // -----------------------------------------------------
                    // Serial No
                    // -----------------------------------------------------

                    dgvViewAttendanceHistory.Rows[rowIndex]
                        .Cells["colSerialNo"].Value =
                        serialNo++;


                    // -----------------------------------------------------
                    // Member ID
                    // -----------------------------------------------------

                    dgvViewAttendanceHistory.Rows[rowIndex]
                        .Cells["colMemberId"].Value =
                        row["MemberId"].ToString();


                    // -----------------------------------------------------
                    // Member Name
                    // -----------------------------------------------------

                    dgvViewAttendanceHistory.Rows[rowIndex]
                        .Cells["colMemberName"].Value =
                        row["MemberName"].ToString();


                    // -----------------------------------------------------
                    // Phone No
                    // -----------------------------------------------------

                    dgvViewAttendanceHistory.Rows[rowIndex]
                        .Cells["colPhoneNo"].Value =
                        row["PhoneNo"].ToString();


                    // -----------------------------------------------------
                    // Shift Name
                    // -----------------------------------------------------

                    dgvViewAttendanceHistory.Rows[rowIndex]
                        .Cells["colShiftName"].Value =
                        row["ShiftName"].ToString();


                    // -----------------------------------------------------
                    // Attendance Date
                    // -----------------------------------------------------

                    if (row["AttendanceDate"] != DBNull.Value)
                    {
                        dgvViewAttendanceHistory.Rows[rowIndex]
                            .Cells["colAttendanceDate"].Value =
                            Convert.ToDateTime(
                                row["AttendanceDate"]
                            ).ToString("MMMM dd, yyyy");
                    }
                    else
                    {
                        dgvViewAttendanceHistory.Rows[rowIndex]
                            .Cells["colAttendanceDate"].Value =
                            "";
                    }
                }
            }
            catch (Exception ex)
            {
                // =========================================================
                // Reset Total Attendance
                // =========================================================

                lblOutputTotalAttendance.Text = "0";


                // =========================================================
                // Exception Handling
                // =========================================================

                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void LoadMemberAttendanceTillToday()
        {
            AttendanceUI attendanceUI =
                new AttendanceUI();

            DataTable attendanceData =
                attendanceUI.RetrieveMemberAttendanceTillTodayUI(
                    MemberId
                );

            // =========================================================
            // Clear Existing Grid
            // =========================================================

            dgvViewAttendanceHistory.Rows.Clear();


            // =========================================================
            // Check Null / Empty Data
            // =========================================================

            if (attendanceData == null ||
                attendanceData.Rows.Count == 0)
            {
                lblOutputTotalAttendance.Text = "0";
                return;
            }


            // =========================================================
            // Handle Message
            // =========================================================

            if (attendanceData.Columns.Contains("Message"))
            {
                MessageBox.Show(
                    attendanceData.Rows[0]["Message"].ToString(),
                    "Attendance History",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                lblOutputTotalAttendance.Text = "0";

                return;
            }


            // =========================================================
            // Display Total Attendance
            // =========================================================

            lblOutputTotalAttendance.Text =
                attendanceData.Rows.Count.ToString();


            // =========================================================
            // Load DataGridView
            // =========================================================

            int serialNo = 1;

            foreach (DataRow row in attendanceData.Rows)
            {
                int rowIndex =
                    dgvViewAttendanceHistory.Rows.Add();


                // -----------------------------------------------------
                // Serial No
                // -----------------------------------------------------

                dgvViewAttendanceHistory.Rows[rowIndex]
                    .Cells["colSerialNo"].Value =
                    serialNo++;


                // -----------------------------------------------------
                // Member ID
                // -----------------------------------------------------

                dgvViewAttendanceHistory.Rows[rowIndex]
                    .Cells["colMemberId"].Value =
                    row["MemberId"].ToString();


                // -----------------------------------------------------
                // Member Name
                // -----------------------------------------------------

                dgvViewAttendanceHistory.Rows[rowIndex]
                    .Cells["colMemberName"].Value =
                    row["MemberName"].ToString();


                // -----------------------------------------------------
                // Phone No
                // -----------------------------------------------------

                dgvViewAttendanceHistory.Rows[rowIndex]
                    .Cells["colPhoneNo"].Value =
                    row["PhoneNo"].ToString();


                // -----------------------------------------------------
                // Shift Name
                // -----------------------------------------------------

                dgvViewAttendanceHistory.Rows[rowIndex]
                    .Cells["colShiftName"].Value =
                    row["ShiftName"].ToString();


                // -----------------------------------------------------
                // Attendance Date
                // -----------------------------------------------------

                if (row["AttendanceDate"] != DBNull.Value)
                {
                    dgvViewAttendanceHistory.Rows[rowIndex]
                        .Cells["colAttendanceDate"].Value =
                        Convert.ToDateTime(
                            row["AttendanceDate"]
                        ).ToString("MMMM dd, yyyy");
                }
                else
                {
                    dgvViewAttendanceHistory.Rows[rowIndex]
                        .Cells["colAttendanceDate"].Value =
                        "";
                }
            }
        }
    }
}
