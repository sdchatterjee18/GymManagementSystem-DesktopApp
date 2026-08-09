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
    public partial class FrmMarkAttendance : Form
    {
        public FrmMarkAttendance()
        {
            InitializeComponent();
        }

        private void FrmMarkAttendance_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
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
    }
}
