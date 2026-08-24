using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.FORMS.Attendance.UI;
using GymManagementSystem.Common;
using GymManagementSystem.FORMS.Main;

namespace GymManagementSystem.FORMS.Attendance
{
    public partial class FrmViewAttendance : Form
    {
        int monthNumber;
        FrmMainLayout frmMainLayout = null;
        public FrmViewAttendance(FrmMainLayout frmMainLayout)
        {
            this.frmMainLayout = frmMainLayout;
            InitializeComponent();
            LookupUI.EnableDoubleBuffering(dgvViewAttendance);   
        }

        private void FrmViewAttendance_Load(object sender, EventArgs e)
        {
            LoadAllMemberDetails();
        }

        private void FrmViewAttendance_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
          
        }      
        private void txtViewMemberMobileNumber_Enter(object sender, EventArgs e)
        {
            if (txtViewMemberMobileNumber.Text.Trim() == "Enter Mobile No.")
            {
                txtViewMemberMobileNumber.Text = "";
                txtViewMemberMobileNumber.ForeColor = Color.Black;
            }
        }

        private void txtViewMemberMobileNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtViewMemberMobileNumber.Text))
            {
                txtViewMemberMobileNumber.Text = "Enter Mobile No.";
                txtViewMemberMobileNumber.ForeColor = Color.Gray;
            }
        }

      
        private void dgvViewAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvViewAttendance.Columns[e.ColumnIndex].Name == "colSerialNo")
            {
                e.CellStyle.ForeColor = Color.Navy;
            }    
        }

        private void dgvViewAttendance_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvViewAttendance.Columns["colAction"].Index)
            {
                e.PaintBackground(e.CellBounds, true);

                ButtonRenderer.DrawButton(e.Graphics, e.CellBounds,
                    System.Windows.Forms.VisualStyles.PushButtonState.Normal);

                TextRenderer.DrawText(
                    e.Graphics,
                    "View",
                    dgvViewAttendance.Font,
                    e.CellBounds,
                    Color.Blue, // Your desired text color
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;
            }
        }
        private void LoadAllMemberDetails()
        {
            try
            {
                AttendanceUI attendanceUI = new AttendanceUI();

                DataTable dt = attendanceUI.RetrieveAllMemberDetailsWithShiftUI();

                dgvViewAttendance.Rows.Clear();

                if (dt == null || dt.Rows.Count == 0)
                    return;

                int serialNo = 1;

                foreach (DataRow row in dt.Rows)
                {
                    int rowIndex = dgvViewAttendance.Rows.Add();

                    dgvViewAttendance.Rows[rowIndex].Cells["colSerialNo"].Value =
                        serialNo++;

                    dgvViewAttendance.Rows[rowIndex].Cells["colMemberId"].Value =
                        row["MemberId"].ToString();

                    dgvViewAttendance.Rows[rowIndex].Cells["colMemberName"].Value =
                        row["MemberName"].ToString();

                    dgvViewAttendance.Rows[rowIndex].Cells["colPhoneNo"].Value =
                        row["PhoneNo"].ToString();

                    dgvViewAttendance.Rows[rowIndex].Cells["colShiftName"].Value =
                        row["ShiftName"].ToString();

                    dgvViewAttendance.Rows[rowIndex].Cells["colAction"].Value =
                        "View";
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
        private void txtViewMemberMobileNumber_TextChanged(object sender, EventArgs e)
        {
            AttendanceUI AttendanceUI = new AttendanceUI();

            DataTable dt =
                AttendanceUI.SearchMemberDetailsWithShiftUI(
                    txtViewMemberMobileNumber.Text.Trim()
                );

            dgvViewAttendance.Rows.Clear();

            if (dt == null || dt.Rows.Count == 0)
                return;

            int serialNo = 1;

            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dgvViewAttendance.Rows.Add();

                dgvViewAttendance.Rows[rowIndex].Cells["colSerialNo"].Value =
                    serialNo++;

                dgvViewAttendance.Rows[rowIndex].Cells["colMemberId"].Value =
                    row["MemberId"].ToString();

                dgvViewAttendance.Rows[rowIndex].Cells["colMemberName"].Value =
                    row["MemberName"].ToString();

                dgvViewAttendance.Rows[rowIndex].Cells["colPhoneNo"].Value =
                    row["PhoneNo"].ToString();

                dgvViewAttendance.Rows[rowIndex].Cells["colShiftName"].Value =
                    row["ShiftName"].ToString();

                dgvViewAttendance.Rows[rowIndex].Cells["colAction"].Value =
                    "View";
            }
        }
        private void dgvViewAttendance_CellContentClick(object sender,DataGridViewCellEventArgs e)
        {
            try
            {
                // =========================================================
                // Ignore Header Row
                // =========================================================

                if (e.RowIndex < 0)
                    return;


                // =========================================================
                // Check Action Column
                // =========================================================

                if (e.ColumnIndex < 0)
                    return;

                if (dgvViewAttendance.Columns[e.ColumnIndex].Name != "colAction")
                    return;


                // =========================================================
                // Get MemberId From colMemberId
                // =========================================================

                object memberIdValue =
                    dgvViewAttendance.Rows[e.RowIndex]
                        .Cells["colMemberId"]
                        .Value;


                // =========================================================
                // Validate MemberId
                // =========================================================

                if (memberIdValue == null ||
                    memberIdValue == DBNull.Value ||
                    string.IsNullOrWhiteSpace(memberIdValue.ToString()))
                {
                    MessageBox.Show(
                        "Member ID not found.",
                        "Attendance History",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                int memberId =
                    Convert.ToInt32(memberIdValue);


                if (memberId <= 0)
                {
                    MessageBox.Show(
                        "Invalid Member ID.",
                        "Attendance History",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                // =========================================================
                // Open Attendance History Form
                // =========================================================

                //FrmAttendanceHistory frmAttendanceHistory =
                //    new FrmAttendanceHistory(memberId);

                frmMainLayout.OpenChildForm(new FrmAttendanceHistory(memberId));

                
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
    }
}
