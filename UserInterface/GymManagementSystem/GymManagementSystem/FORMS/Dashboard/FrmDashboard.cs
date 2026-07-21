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
        }
        private void LoadShiftWiseMembersChart()
        {
            // Clear Previous Data
            chartShiftWiseMembers.Series["MemberCountSeries"].Points.Clear();

            // Series Settings
            chartShiftWiseMembers.Series["MemberCountSeries"].ChartType = SeriesChartType.Column;
            chartShiftWiseMembers.Series["MemberCountSeries"].Color = Color.Orange;
            chartShiftWiseMembers.Series["MemberCountSeries"].IsValueShownAsLabel = true;
            chartShiftWiseMembers.Series["MemberCountSeries"].BorderWidth = 1;

            // Add Data
            chartShiftWiseMembers.Series["MemberCountSeries"].Points.AddXY("Early Morning", 80);
            chartShiftWiseMembers.Series["MemberCountSeries"].Points.AddXY("Morning", 150);
            chartShiftWiseMembers.Series["MemberCountSeries"].Points.AddXY("Afternoon", 120);
            chartShiftWiseMembers.Series["MemberCountSeries"].Points.AddXY("Evening", 200);

            // ChartArea Settings
            ChartArea area = chartShiftWiseMembers.ChartAreas["ShiftWiseChartArea"];
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.Gainsboro;
            // Legend
            chartShiftWiseMembers.Legends["ShiftWiseLegend"].Enabled = false;
        }
        private void LoadTodayMemberAttendanceChart()
        {
            Series series = chartTodayMemberAttendance.Series["AttendanceCountSeries"];

            series.Points.Clear();
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.MediumSeaGreen;
            series.IsValueShownAsLabel = true;
            series["PointWidth"] = "0.8";

            series.Points.AddXY("Early Morning", 65);
            series.Points.AddXY("Morning", 120);
            series.Points.AddXY("Afternoon", 90);
            series.Points.AddXY("Evening", 180);

            ChartArea area = chartTodayMemberAttendance.ChartAreas["TodayAttendanceChartArea"];

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.Gainsboro;

            chartTodayMemberAttendance.Legends["TodayAttendanceLegend"].Enabled = false;
        }

        private void pnlTrainers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmDashboard_Resize(object sender, EventArgs e)
        {

        }

       
    }
}