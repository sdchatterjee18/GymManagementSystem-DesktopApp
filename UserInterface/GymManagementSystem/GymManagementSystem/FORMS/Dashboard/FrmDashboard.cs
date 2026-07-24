using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GymManagementSystem.FORMS.Dashboard
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

            LoadShiftWiseMembersChart();
            LoadTodayMemberAttendanceChart();

            pnlShiftWiseMembers.Invalidate();
        }
        private void LoadShiftWiseMembersChart()
        {
            Series series = chartShiftWiseMembers.Series["MemberCountSeries"];

            series.Points.Clear();

            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(210, 210, 235);
            series.BorderWidth = 0;
            series.IsValueShownAsLabel = true;
            series.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            series["PointWidth"] = "0.65";

            series.Points.AddXY("Early\nMorning", 80);
            series.Points.AddXY("Morning", 150);
            series.Points.AddXY("Afternoon", 120);
            series.Points.AddXY("Evening", 200);

            ChartArea area = chartShiftWiseMembers.ChartAreas["ShiftWiseChartArea"];

            area.BackColor = Color.White;

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(235, 238, 242);

            area.AxisX.LineColor = Color.FromArgb(180, 180, 180);
            area.AxisY.LineColor = Color.FromArgb(180, 180, 180);

            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);

            area.AxisX.LabelStyle.ForeColor = Color.FromArgb(70, 70, 70);
            area.AxisY.LabelStyle.ForeColor = Color.FromArgb(70, 70, 70);

            chartShiftWiseMembers.BackColor = Color.White;

            chartShiftWiseMembers.Legends["ShiftWiseLegend"].Enabled = false;
        }
        private void LoadTodayMemberAttendanceChart()
        {
            Series series = chartTodayMemberAttendance.Series["AttendanceCountSeries"];

            series.Points.Clear();

            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(250, 228, 235);
            series.BorderWidth = 0;
            series.IsValueShownAsLabel = true;
            series.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            series["PointWidth"] = "0.65";

            series.Points.AddXY("Early\nMorning", 65);
            series.Points.AddXY("Morning", 120);
            series.Points.AddXY("Afternoon", 90);
            series.Points.AddXY("Evening", 180);

            ChartArea area = chartTodayMemberAttendance.ChartAreas["TodayAttendanceChartArea"];

            area.BackColor = Color.White;

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(235, 238, 242);

            area.AxisX.LineColor = Color.FromArgb(180, 180, 180);
            area.AxisY.LineColor = Color.FromArgb(180, 180, 180);

            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);

            chartTodayMemberAttendance.BackColor = Color.White;

            chartTodayMemberAttendance.Legends["TodayAttendanceLegend"].Enabled = false;
        }

        private void pnlTrainers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmDashboard_Resize(object sender, EventArgs e)
        {

        }

        private void pnlShiftWiseMembers_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                0,
                0,
                pnlShiftWiseMembers.Width - 1,
                pnlShiftWiseMembers.Height - 1);

            using (Pen pen = new Pen(Color.FromArgb(225, 229, 235), 1))
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void pnlTodayActiveMembers_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                1,
                1,
                pnlTodayActiveMembers.Width - 3,
                pnlTodayActiveMembers.Height - 3);

            using (Pen pen = new Pen(Color.FromArgb(225, 229, 235), 1))
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void pnlFreePersonalTrainers_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                0,
                0,
                pnlFreePersonalTrainers.Width - 1,
                pnlFreePersonalTrainers.Height - 1);

            using (Pen pen = new Pen(Color.FromArgb(245, 214, 220), 1))
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void pnlSellMembershipSubscription_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                0,
                0,
                pnlSellMembershipSubscription.Width - 1,
                pnlSellMembershipSubscription.Height - 1);

            using (Pen pen = new Pen(Color.FromArgb(215, 225, 240), 1))
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void pnlKeyMonthyFinancials_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                0,
                0,
                pnlKeyMonthyFinancials.Width - 1,
                pnlKeyMonthyFinancials.Height - 1);

            using (Pen pen = new Pen(Color.FromArgb(220, 220, 220), 1))
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
       
       
    }
}