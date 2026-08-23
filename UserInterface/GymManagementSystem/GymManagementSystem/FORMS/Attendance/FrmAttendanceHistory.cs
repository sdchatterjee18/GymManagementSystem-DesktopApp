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
    public partial class FrmAttendanceHistory : Form
    {
        public FrmAttendanceHistory()
        {
            InitializeComponent();
        }

        private void FrmAttendanceHistory_Load(object sender, EventArgs e)
        {

            dtpStartDateAttendanceHistory.Format = DateTimePickerFormat.Custom;
            dtpStartDateAttendanceHistory.CustomFormat = "MMMM dd, yyyy";

            dtpEndDateAttendanceHistory.Format = DateTimePickerFormat.Custom;
            dtpEndDateAttendanceHistory.CustomFormat = "MMMM dd, yyyy";
                  

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

        private void tlpAttendanceHistory_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
