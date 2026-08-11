using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem.FORMS.Attendance
{
    public partial class FrmViewAttendance : Form
    {
        public FrmViewAttendance()
        {
            InitializeComponent();
        }

        private void FrmViewAttendance_Load(object sender, EventArgs e)
        {
          
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

        private void tlpViewAttendanceEntireForm_Click(object sender, EventArgs e)
        {
            dgvViewAttendance.ClearSelection();
        }

        private void tlpViewAttendanceHeader_Click(object sender, EventArgs e)
        {
            dgvViewAttendance.ClearSelection();
        }

        private void picViewAttendanceMark_Click(object sender, EventArgs e)
        {
            dgvViewAttendance.ClearSelection();
        }

        private void tlpViewAttendanceTitle_Click(object sender, EventArgs e)
        {
            dgvViewAttendance.ClearSelection();
        }

        private void lblViewAttendance_Click(object sender, EventArgs e)
        {
            dgvViewAttendance.ClearSelection();
        }

        private void lblViewMemberAttendance_Click(object sender, EventArgs e)
        {
            dgvViewAttendance.ClearSelection();
        }

        private void tlpViewAttendanceSearchBar_Click(object sender, EventArgs e)
        {
            dgvViewAttendance.ClearSelection();
        }

        private void picViewAttendanceSearch1_Click(object sender, EventArgs e)
        {
            dgvViewAttendance.ClearSelection();
        }

        private void txtViewMemberMobileNumber_Click(object sender, EventArgs e)
        {
            dgvViewAttendance.ClearSelection();
        }

        private void picViewAttendanceSearch2_Click(object sender, EventArgs e)
        {
            dgvViewAttendance.ClearSelection();
        }

        private void cmbViewAttendanceShiftSearch_Click(object sender, EventArgs e)
        {
            dgvViewAttendance.ClearSelection();
        }

        private void txtYearSearch_Click(object sender, EventArgs e)
        {
            dgvViewAttendance.ClearSelection();
        }

        private void btnViewAttendanceSearch_Click(object sender, EventArgs e)
        {
            dgvViewAttendance.ClearSelection();
        }

        private void tlpViewAttendanceMonthAndYearSearch_Click(object sender, EventArgs e)
        {
            dgvViewAttendance.ClearSelection();
        }

       

       
    }
}
