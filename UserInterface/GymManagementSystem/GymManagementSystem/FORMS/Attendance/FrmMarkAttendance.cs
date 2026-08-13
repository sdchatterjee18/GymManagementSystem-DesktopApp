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
    public partial class FrmMarkAttendance : Form
    {
        public FrmMarkAttendance()
        {
            InitializeComponent();
        }

        private void FrmMarkAttendance_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
           
           
            RetrieveShift();
            RetrieveCurrentShiftData();
        }

        //Retrieve Shift Shift
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
                        row["ShiftName"].ToString()
                     );
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
                        row["ShiftName"].ToString()
                      );
                }
               
            }
            catch (Exception ex)
            {
                ShiftWiseMemberAttendanceData = null;
            }
        }

        private void RetrieveAbsentMemberOnCurrentShiftByPhoneNo()
        {
            DataTable AbsentMemberOnCurrentShift = null;
            try
            {
                string PhoneNo = txtMarkMemberMobileNumber.Text;
                AttendanceUI AttendanceUI = new AttendanceUI();
                AbsentMemberOnCurrentShift = AttendanceUI.RetrieveAbsentMemberOnCurrentShiftByPhoneNoUI(PhoneNo);
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
                         row["ShiftName"].ToString()
                       );
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
            RetrieveAbsentMemberOnCurrentShiftByPhoneNo();
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
            try
            {
                AttendanceUI AttendanceUI = new AttendanceUI();
                AttendanceMessage = AttendanceUI.MarkAttendanceUI(MemberId, ShiftId);
               DialogResult Result= MessageBox.Show(AttendanceMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
               if (Result == DialogResult.OK)
               {
                   
                   if (cmbMarkAttendanceShiftSearch.SelectedValue == null)
                       return;

                   int shiftId = Convert.ToInt32(cmbMarkAttendanceShiftSearch.SelectedValue);
                   RetrieveCurrentShiftData();
                   RetrieveShiftWiseMemberAttendance(shiftId);
                   
               }
            }
            catch (Exception ex)
            {
                 AttendanceMessage = null;
            }
        }
    }
}
