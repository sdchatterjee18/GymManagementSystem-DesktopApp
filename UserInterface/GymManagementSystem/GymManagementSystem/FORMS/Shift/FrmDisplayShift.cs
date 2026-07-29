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
using System.Drawing.Drawing2D;

namespace GymManagementSystem.FORMS .Shift
{
    public partial class FrmDisplayShift : Form
    {
        private int currentRow;
        private int currentColumn;
        private DateTimePicker dtpTime = new DateTimePicker();


        public FrmDisplayShift()
        {
            InitializeComponent();
          
        }

        private void FrmDisplayShift_Load(object sender, EventArgs e)
        {

        }

        private void pnlMorningShiftTitle_MouseEnter(object sender, EventArgs e)
        {
            pnlMorningShiftTitle.BackColor = Color.MidnightBlue;
            lblMorningShift.ForeColor = Color.White;
        }

        private void pnlMorningShiftTitle_MouseLeave(object sender, EventArgs e)
        {
            pnlMorningShiftTitle.BackColor = Color.Azure;
            lblMorningShift.ForeColor = Color.FromArgb(0, 0, 64);
        }

        private void pnlNoonShiftTitle_MouseEnter(object sender, EventArgs e)
        {
            pnlNoonShiftTitle.BackColor = Color.MidnightBlue;
            lblNoonShift.ForeColor = Color.White;
        }

        private void pnlNoonShiftTitle_MouseLeave(object sender, EventArgs e)
        {
            pnlNoonShiftTitle.BackColor = Color.Azure;
            lblNoonShift.ForeColor = Color.FromArgb(0, 0, 64);
        }

        private void pnlAfternoonShiftTitle_MouseEnter(object sender, EventArgs e)
        {
            pnlAfternoonShiftTitle.BackColor = Color.MidnightBlue;
            lblAfternoonShift.ForeColor = Color.White;
        }

        private void pnlAfternoonShiftTitle_MouseLeave(object sender, EventArgs e)
        {
            pnlAfternoonShiftTitle.BackColor = Color.Azure;
            lblAfternoonShift.ForeColor = Color.FromArgb(0, 0, 64);
        }

        private void pnlEveningShiftTitle_MouseEnter(object sender, EventArgs e)
        {
            pnlEveningShiftTitle.BackColor = Color.MidnightBlue;
            lblEveningShift.ForeColor = Color.White;
        }

        private void pnlEveningShiftTitle_MouseLeave(object sender, EventArgs e)
        {
            pnlEveningShiftTitle.BackColor = Color.Azure;
            lblEveningShift.ForeColor = Color.FromArgb(0, 0, 64);
        }

       
       
    }
}
