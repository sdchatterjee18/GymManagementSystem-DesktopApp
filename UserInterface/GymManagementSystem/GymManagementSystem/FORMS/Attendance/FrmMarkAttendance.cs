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

namespace GymManagementSystem.FORMS.Attendance
{
    public partial class FrmMarkAttendance : Form
    {
        public FrmMarkAttendance()
        {
            InitializeComponent();
        }
        int clickCountSearch = 0;
        private void FrmMarkAttendance_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            RetrieveShift();
            RetrieveCurrentShiftData();
        }

        //Retrieve Shift 
        private void RetrieveShift()
        {
            
            try
            {
                AttendanceUI AttendanceUI = new AttendanceUI();
               cmbMarkAttendanceShiftSearch.DataSource= AttendanceUI.RetrieveShiftUI();
               cmbMarkAttendanceShiftSearch.DisplayMember = "ShiftName";
               cmbMarkAttendanceShiftSearch.ValueMember = "ShiftId";
               cmbMarkAttendanceShiftSearch.SelectedIndex = -1;
            }
            catch (Exception Ex)
            {
                cmbMarkAttendanceShiftSearch.DataSource = null;
            }
        }

        private void RetrieveCurrentShiftData()
        {
            DataTable CurrentShiftData = null;
            try
            {
                AttendanceUI AttendanceUI = new AttendanceUI();
                CurrentShiftData = AttendanceUI.RetrieveCurrentShiftDataUI();
                int SerialNo = 1;
                dgvMarkAttendance.Rows.Clear();
                foreach (DataRow row in CurrentShiftData.Rows)
                {
                    dgvMarkAttendance.Rows.Add
                     (
                        SerialNo++,
                        Convert.ToInt32(row["MemberId"]),
                        row["MemberName"].ToString(),
                        row["PhoneNo"].ToString(),
                        Convert.ToInt32(row["ShiftId"]),
                        row["ShiftName"].ToString(),
                        row["AttendanceStatus"].ToString()
                     );
                    int rowIndex = dgvMarkAttendance.Rows.Count - 1;

                    string attendanceStatus = row["AttendanceStatus"].ToString();

                    if (attendanceStatus.Equals("Present", StringComparison.OrdinalIgnoreCase))
                    {
                        dgvMarkAttendance.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Green;

                        // Checkbox Check
                        dgvMarkAttendance.Rows[rowIndex].Cells["colMarkAttendance"].Value = true;
                    }
                    else
                    {
                        dgvMarkAttendance.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;

                        dgvMarkAttendance.Rows[rowIndex].Cells["colMarkAttendance"].Value = false;
                    }
                }
               
            }
            catch (Exception ex)
            {
                 CurrentShiftData = null;
            }
        }

        private void RetrieveShiftWiseMemberAttendance(int ShiftId)
        {

            DataTable ShiftWiseMemberAttendanceData = null;
            try
            {
                int SerialNo = 1;
                AttendanceUI AttendanceUI = new AttendanceUI();
                ShiftWiseMemberAttendanceData = AttendanceUI.RetrieveShiftWiseMemberAttendanceUI(ShiftId);
                dgvMarkAttendance.Rows.Clear();
                foreach (DataRow row in ShiftWiseMemberAttendanceData.Rows)
                {
                   dgvMarkAttendance.Rows.Add
                    (
                        SerialNo++,
                        Convert.ToInt32(row["MemberId"]),
                        row["MemberName"].ToString(),
                        row["PhoneNo"].ToString(),
                        Convert.ToInt32(row["ShiftId"]),
                        row["ShiftName"].ToString(),
                        row["AttendanceStatus"].ToString()
                      );
                   int rowIndex = dgvMarkAttendance.Rows.Count - 1;

                   string attendanceStatus = row["AttendanceStatus"].ToString();

                   if (attendanceStatus.Equals("Present", StringComparison.OrdinalIgnoreCase))
                   {
                       dgvMarkAttendance.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Green;

                       // Checkbox Check
                       dgvMarkAttendance.Rows[rowIndex].Cells["colMarkAttendance"].Value = true;
                   }
                   else
                   {
                       dgvMarkAttendance.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;

                       dgvMarkAttendance.Rows[rowIndex].Cells["colMarkAttendance"].Value = false;
                   }
                }
               
            }
            catch (Exception ex)
            {
                ShiftWiseMemberAttendanceData = null;
            }
        }

        private void SearchMembersByPhoneNoAndName()
        {
            DataTable AbsentMemberOnCurrentShift = null;
            try
            {
                string PhoneNo = txtMarkMemberMobileNumber.Text;
                AttendanceUI AttendanceUI = new AttendanceUI();
                AbsentMemberOnCurrentShift = AttendanceUI.SearchMembersByPhoneNoAndNameUI(PhoneNo);
                dgvMarkAttendance.Rows.Clear();
                int SerialNo = 1;
                foreach (DataRow row in AbsentMemberOnCurrentShift.Rows)
                {
                    dgvMarkAttendance.Rows.Add
                     (
                         SerialNo++,
                         Convert.ToInt32(row["MemberId"]),
                         row["MemberName"].ToString(),
                         row["PhoneNo"].ToString(),
                         Convert.ToInt32(row["ShiftId"]),
                         row["ShiftName"].ToString(),
                         row["AttendanceStatus"].ToString()
                       );
                    int rowIndex = dgvMarkAttendance.Rows.Count - 1;

                    string attendanceStatus = row["AttendanceStatus"].ToString();

                    if (attendanceStatus.Equals("Present", StringComparison.OrdinalIgnoreCase))
                    {
                        dgvMarkAttendance.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Green;

                        // Checkbox Check
                        dgvMarkAttendance.Rows[rowIndex].Cells["colMarkAttendance"].Value = true;
                    }
                    else
                    {
                        dgvMarkAttendance.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;

                        dgvMarkAttendance.Rows[rowIndex].Cells["colMarkAttendance"].Value = false;
                    }
                }
            }
            catch (Exception ex)
            {
               AbsentMemberOnCurrentShift = null;
            }
        }

        private void cmbMarkAttendanceShiftSearch_Enter(object sender, EventArgs e)
        {
            if (cmbMarkAttendanceShiftSearch.Text.Trim() == "---Select Shift---")
            {
                cmbMarkAttendanceShiftSearch.Text = "";
                cmbMarkAttendanceShiftSearch.ForeColor = Color.Gray;
            }
        }

        private void cmbMarkAttendanceShiftSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbMarkAttendanceShiftSearch.Text))
            {
                cmbMarkAttendanceShiftSearch.Text = "---Select Shift---";
                cmbMarkAttendanceShiftSearch.ForeColor = Color.Gray;
            }
        }

        private void txtMarkMemberMobileNumber_Enter(object sender, EventArgs e)
        {
            if (txtMarkMemberMobileNumber.Text.Trim() == "Enter Mobile No.")
            {
                txtMarkMemberMobileNumber.Text = "";
               
                txtMarkMemberMobileNumber.ForeColor = Color.Black;
            }
        }

        private void txtMarkMemberMobileNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarkMemberMobileNumber.Text))
            {
                txtMarkMemberMobileNumber.Text = "Enter Mobile No.";
                
                txtMarkMemberMobileNumber.ForeColor = Color.Gray;
            }
        }

        private void btnMarkAttendanceSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbMarkAttendanceShiftSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMarkAttendanceShiftSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbMarkAttendanceShiftSearch.SelectedValue == null)
                return;

            int shiftId = Convert.ToInt32(cmbMarkAttendanceShiftSearch.SelectedValue);

            RetrieveShiftWiseMemberAttendance(shiftId);
            
            
        }

        private void dgvMarkAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvMarkAttendance.Columns[e.ColumnIndex].Name == "colMarkAttendance")
            {
                int memberId = Convert.ToInt32(
                    dgvMarkAttendance.Rows[e.RowIndex].Cells["colMemberId"].Value
                );

                int shiftId = Convert.ToInt32(
                    dgvMarkAttendance.Rows[e.RowIndex].Cells["colShiftId"].Value
                );

                MarkAttendance(memberId, shiftId);
            }
        }
 
        private void MarkAttendance(int MemberId, int ShiftId)
        {
            string AttendanceMessage = null;
            string MarkAttendanceConfirmation = "Are you sure you want to mark attendance?";
            string ConfirmMessage = "Confirm Attendance";
            string Attendance = "Attendance";
            string ErrorMessage = "Error";

            try
            {
                
                // Before Attendance Mark  Confirmation
                DialogResult ConfirmationResult = MessageBox.Show(
                    MarkAttendanceConfirmation,
                    ConfirmMessage,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (ConfirmationResult != DialogResult.Yes)
                {
                    return;
                }

                AttendanceUI AttendanceUI = new AttendanceUI();

                bool isShiftSelected =
                    cmbMarkAttendanceShiftSearch.SelectedIndex >= 0;

                int selectedShiftId = 0;

                if (isShiftSelected)
                {
                    selectedShiftId =
                        Convert.ToInt32(
                            cmbMarkAttendanceShiftSearch.SelectedValue
                        );
                }

                // Attendance Mark
                AttendanceMessage =
                    AttendanceUI.MarkAttendanceUI(MemberId, ShiftId);

                MessageBox.Show(
                    AttendanceMessage,
                    Attendance,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                if (isShiftSelected)
                {
                    RetrieveShiftWiseMemberAttendance(selectedShiftId);
                }
                else
                {
                    RetrieveCurrentShiftData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    ErrorMessage,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txtMarkMemberMobileNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtMarkMemberMobileNumber == null)
            {
                RetrieveCurrentShiftData();
            }
            else
            {
                SearchMembersByPhoneNoAndName();
            }
            cmbMarkAttendanceShiftSearch.SelectedIndex = -1;
        }

        private void txtMarkMemberMobileNumber_Click(object sender, EventArgs e)
        {
            clickCountSearch = ValidationUI.ClearTextBoxWhenClicked(txtMarkMemberMobileNumber,clickCountSearch);
            txtMarkMemberMobileNumber.ForeColor = Color.Black;
        }

    }
}
