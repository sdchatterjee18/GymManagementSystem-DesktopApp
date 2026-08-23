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
    public partial class FrmViewAttendance : Form
    {
        int monthNumber;
        public FrmViewAttendance()
        {
            InitializeComponent();
            LookupUI.EnableDoubleBuffering(dgvViewAttendance);   
        }

        private void FrmViewAttendance_Load(object sender, EventArgs e)
        {
            CurrentMonthAllPresentAttendace();
            GetMonths();
        }

        private void FrmViewAttendance_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
          
        }

        //Retrieve Current Month All Present Attendance 
        private void  CurrentMonthAllPresentAttendace()
        {
            DataTable AllAttendence = null;
            try
            {
                AttendanceUI AttendanceUI = new AttendanceUI();
                AllAttendence = AttendanceUI.CurrentMonthAllPresentAttendaceUI();
                int SerialNo = 1;
                foreach (DataRow row in AllAttendence.Rows)
                {
                    dgvViewAttendance.Rows.Add
                    (
                        SerialNo++,
                        row["MemberName"].ToString(),
                        row["PhoneNo"].ToString(),
                        row["ShiftName"].ToString(),
                        Convert.ToDateTime(row["AttendanceDate"]).ToString("dd-MM-yyyy")
                    );
                }
                
            }
            catch (Exception ex)
            {
                AllAttendence = null;
            }

        }

        private void GetMonths()
        {
            try
            {
                AttendanceUI AttendanceUI = new AttendanceUI();
                
               cmbViewAttendanceShiftSearch .DataSource = AttendanceUI.GetMonthsUI();
               cmbViewAttendanceShiftSearch.DisplayMember = "MonthName";
               cmbViewAttendanceShiftSearch.ValueMember = "MonthNumber";
               cmbViewAttendanceShiftSearch.SelectedIndex = -1;
            }
            catch (Exception Ex)
            {
                cmbViewAttendanceShiftSearch.DataSource = null;
            }
        }

        private void RetrieveSpecificMemberAttendanceDetails()
        {
            DataTable GetMemberAttendanceDetails = null;
            try
            {
                string PhoneNo = txtViewMemberMobileNumber.Text;
                int MonthNo = monthNumber;
                int Year = Convert.ToInt32(txtYearSearch.Text);
                AttendanceUI AttendanceUI = new AttendanceUI();
                GetMemberAttendanceDetails = AttendanceUI.RetrieveSpecificMemberAttendanceDetailsUI(PhoneNo, MonthNo, Year);
                int SerialNo = 1;
                dgvViewAttendance.Rows.Clear();
                foreach (DataRow row in GetMemberAttendanceDetails.Rows)
                {
                    dgvViewAttendance.Rows.Add
                    (
                        SerialNo++,
                        row["MemberName"].ToString(),
                        row["PhoneNo"].ToString(),
                        row["ShiftName"].ToString(),
                        Convert.ToDateTime(row["AttendanceDate"]).ToString("dd-MM-yyyy")
                    );
                }
               
            }
            catch (Exception ex)
            {
                GetMemberAttendanceDetails = null;
            }
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

        private void cmbViewAttendanceShiftSearch_Enter(object sender, EventArgs e)
        {
            if (cmbViewAttendanceShiftSearch.Text.Trim() == "---Select Month---")
            {
                cmbViewAttendanceShiftSearch.Text = "";
                cmbViewAttendanceShiftSearch.ForeColor = Color.Gray;
            }
        }

        private void cmbViewAttendanceShiftSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbViewAttendanceShiftSearch.Text))
            {
                cmbViewAttendanceShiftSearch.Text = "---Select Month---";
                cmbViewAttendanceShiftSearch.ForeColor = Color.Gray;
            }
        }

        private void txtYearSearch_Enter(object sender, EventArgs e)
        {
            if (txtYearSearch.Text.Trim() == "Enter The Year .")
            {
                txtYearSearch.Text = "";
                txtYearSearch.ForeColor = Color.Black;
            }
        }

        private void txtYearSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYearSearch.Text))
            {
                txtYearSearch.Text = "Enter The Year .";
                txtYearSearch.ForeColor = Color.Gray;
            }
        }


        private void cmbViewAttendanceShiftSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbViewAttendanceShiftSearch.SelectedValue == null)
                return;

            monthNumber = Convert.ToInt32(cmbViewAttendanceShiftSearch.SelectedValue);
        }

        private void btnViewAttendanceSearch_Click(object sender, EventArgs e)
        {
            RetrieveSpecificMemberAttendanceDetails();
        }
    }
}
