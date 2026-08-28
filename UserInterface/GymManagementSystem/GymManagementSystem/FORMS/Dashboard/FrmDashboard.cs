using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using GymManagementSystem.FORMS.Dashboard;
using GymManagementSystem.FORMS.Dashboard.UI;

namespace GymManagementSystem.FORMS.Dashboard
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");

        }
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            // Load Current Shift
            LoadCurrentShiftName();
            // Load Active Number Count
            LoadActiveMemberCount();
            // Load Actie Membership Plan
            LoadActiveMembershipPlanCount();
            // Load Active Trainer 
            LoadActiveTrainerCount();
            // Load Free personal Trainer
            LoadCurrentShiftPersonalTrainerCount();
            // Load Free Trainer By Shift
            LoadFreeTrainerByShift();
            // Load Top Three Membership Plans
            LoadTopThreeMembershipPlans();
            // Load Current Month Total Expense
            LoadCurrentMonthTotalExpense();
            // Load Current Month New Members
            LoadCurrentMonthNewMembers();
            // Load Current Month Subscription No
            LoadCurrentMonthSubscriptionNo();
            timer.Start();
            // Load Shift Wise Members Chart
            LoadShiftWiseMembersChart();
            // Load Today Member Attendance Chart
            LoadTodayMemberAttendanceChart();

            pnlShiftWiseMembers.Invalidate();
        }
        // Load Current ShiftName
        private void LoadCurrentShiftName()
        {
            DashboardUI dashboardUI = new DashboardUI();
            DataTable dataTable = dashboardUI.GetCurrentShiftUI();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                lblRunningShift.Text =
                    dataTable.Rows[0]["ShiftName"].ToString() + "  Shift is Running";
            }
            else
            {
                lblRunningShift.Text = "No" + "  Shift is Running";
            }
        }
        // Load ActiveMembers Count
        private void LoadActiveMemberCount()
        {
            DashboardUI dashboardUI = new DashboardUI();

            int activeMemberCount = dashboardUI.GetActiveMemberCountUI();
            lblActiveMembersValue.Text = activeMemberCount.ToString();
        }
        // Load Active Membership Plan Count
        private void LoadActiveMembershipPlanCount()
        {
            DashboardUI dashboardUI = new DashboardUI();

            int activeMembershipPlanCount =
                dashboardUI.GetActiveMembershipPlanCountUI();

            lblActivePlansValues.Text =
                activeMembershipPlanCount.ToString();
        }
        // Load Active Trainers Count
        private void LoadActiveTrainerCount()
        {
            DashboardUI dashboardUI = new DashboardUI();
            int activeTrainerCount = dashboardUI.GetActiveTrainerCountUI();
            lblTrainerValues.Text = activeTrainerCount.ToString();
        }
        // Load Current Shift Personal Trainer Count
        private void LoadCurrentShiftPersonalTrainerCount()
        {
            DashboardUI dashboardUI = new DashboardUI();

            int currentShiftPersonalTrainerCount =
                dashboardUI.GetCurrentShiftPersonalTrainerCountUI();
            lblFreePersonalTrainerValue.Text =
                currentShiftPersonalTrainerCount.ToString();
        }
        // Load Free Trainer By Shift
        private void LoadFreeTrainerByShift()
        {
            DashboardUI dashboardUI = new DashboardUI();

            DataTable dataTable =
                dashboardUI.RetrieveFreeTrainerByShiftUI();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    int shiftId =
                        Convert.ToInt32(row["ShiftId"]);

                    string shiftName =
                        row["ShiftName"].ToString();

                    string totalFreeTrainer =
                        row["TotalFreeTrainer"].ToString();

                    if (shiftId == 1)
                    {
                        lblEarlyMorning.Text = shiftName;
                        lblEarlyMorningValue.Text =
                            totalFreeTrainer;
                    }
                    else if (shiftId == 2)
                    {
                        lblMorning.Text = shiftName;
                        lblMorningValue.Text =
                            totalFreeTrainer;
                    }
                    else if (shiftId == 3)
                    {
                        lblAfternoon.Text = shiftName;
                        lblAfternoonValue.Text =
                            totalFreeTrainer;
                    }
                    else if (shiftId == 4)
                    {
                        lblEvening.Text = shiftName;
                        lblEveningValue.Text =
                            totalFreeTrainer;
                    }
                }
            }
        }
        // Load Top Three Membership Plans
        private void LoadTopThreeMembershipPlans()
        {
            DashboardUI dashboardUI = new DashboardUI();
            DataTable dataTable =
                dashboardUI.RetrieveTopThreeMembershipPlansUI();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count && i < 3; i++)
                {
                    string planName =
                        dataTable.Rows[i]["MembershipPlanName"].ToString();

                    string totalSubscriptions =
                        dataTable.Rows[i]["TotalSubscriptions"].ToString();

                    if (i == 0)
                    {
                        lblFirstHighestMembershipPlans.Text = planName;
                        lblFirstHighestMembershipPlansValues.Text =
                            totalSubscriptions;
                    }
                    else if (i == 1)
                    {
                        lblSecondHighestMembershipPlan.Text = planName;
                        lblSecondHighestMembershipPlans.Text =
                            totalSubscriptions;
                    }
                    else if (i == 2)
                    {
                        lblThirdHighestMembershipPlans.Text = planName;
                        lblThirdHighestMembershipPlansValues.Text =
                            totalSubscriptions;
                    }
                }
            }
        }
        // Load Current Month Total Expense
        private void LoadCurrentMonthTotalExpense()
        {
            DashboardUI dashboardUI = new DashboardUI();
            decimal totalExpense =
                dashboardUI.GetCurrentMonthTotalExpenseUI();
            lblMonthExpensesValue.Text =
                totalExpense.ToString("0.00");
        }
        // Load Current Month New Members
        private void LoadCurrentMonthNewMembers()
        {
            DashboardUI dashboardUI = new DashboardUI();
            int newMembers =
                dashboardUI.RetrieveCurrentMonthNewMembersUI();
            lblNewMembersInthisMonthValue.Text =
                newMembers.ToString();
        }
        // Load Current Month Subscription No
        private void LoadCurrentMonthSubscriptionNo()
        {
            DashboardUI dashboardUI = new DashboardUI();
            int subscriptionNo =
                dashboardUI.RetrieveCurrentMonthSubscriptionNoUI();
            lblThisMonthSubcriptionNoValue.Text = subscriptionNo.ToString();
        }
        // Load Shift Wise Members Chart
        private void LoadShiftWiseMembersChart()
        {
            DashboardUI dashboardUI = new DashboardUI();

            DataTable dataTable =
                dashboardUI.RetrieveShiftWiseMemberNumbersUI();

            Series series =
                chartShiftWiseMembers.Series["MemberCountSeries"];

            ChartArea area =
                chartShiftWiseMembers.ChartAreas["ShiftWiseChartArea"];

            series.Points.Clear();

            // Series Properties
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(24, 40, 84);
            series.BorderWidth = 0;
            series.IsValueShownAsLabel = true;
            series.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            series["PointWidth"] = "0.65";

            // Add Shift Wise Member Data
            foreach (DataRow row in dataTable.Rows)
            {
                string shiftName =
                    row["ShiftName"].ToString();

                int memberCount =
                    Convert.ToInt32(row["MemberCount"]);

                series.Points.AddXY(
                    shiftName,
                    memberCount
                );
            }

            // Dynamic Y-Axis
            if (series.Points.Count > 0)
            {
                double highestValue = 0;
                double lowestValue = Double.MaxValue;

                // Find Highest and Lowest Values
                foreach (DataPoint point in series.Points)
                {
                    double value = point.YValues[0];

                    if (value > highestValue)
                    {
                        highestValue = value;
                    }

                    if (value < lowestValue)
                    {
                        lowestValue = value;
                    }
                }

                double range =
                    highestValue - lowestValue;

                // Handle same values
                if (range == 0)
                {
                    range = highestValue;
                }

                // Handle zero values
                if (range == 0)
                {
                    range = 1;
                }

                // Calculate approximate interval
                double roughInterval =
                    range / 5;

                double magnitude =
                    Math.Pow(
                        10,
                        Math.Floor(
                            Math.Log10(roughInterval)
                        )
                    );

                double normalizedInterval =
                    roughInterval / magnitude;

                double interval;

                if (normalizedInterval <= 1)
                {
                    interval = 1 * magnitude;
                }
                else if (normalizedInterval <= 2)
                {
                    interval = 2 * magnitude;
                }
                else if (normalizedInterval <= 5)
                {
                    interval = 5 * magnitude;
                }
                else
                {
                    interval = 10 * magnitude;
                }

                // Calculate maximum with one extra interval
                double maximum =
                    Math.Ceiling(
                        highestValue / interval
                    ) * interval
                    + interval;

                area.AxisY.Minimum = 0;
                area.AxisY.Maximum = maximum;
                area.AxisY.Interval = interval;
            }

            // Chart Area
            area.BackColor = Color.White;

            // X Axis
            area.AxisX.MajorGrid.Enabled = false;

            area.AxisX.LineColor =
                Color.FromArgb(180, 180, 180);

            area.AxisX.LabelStyle.Font =
                new Font("Segoe UI", 9);

            area.AxisX.LabelStyle.ForeColor =
                Color.FromArgb(70, 70, 70);

            // Y Axis
            area.AxisY.MajorGrid.LineColor =
                Color.FromArgb(235, 238, 242);

            area.AxisY.LineColor =
                Color.FromArgb(180, 180, 180);

            area.AxisY.LabelStyle.Font =
                new Font("Segoe UI", 9);

            area.AxisY.LabelStyle.ForeColor =
                Color.FromArgb(70, 70, 70);

            // Chart Background
            chartShiftWiseMembers.BackColor =
                Color.White;

            // Hide Legend
            chartShiftWiseMembers.Legends[
                "ShiftWiseLegend"
            ].Enabled = false;
        }
        // Load Today Member Attendance Chart
        private void LoadTodayMemberAttendanceChart()
        {
            DashboardUI dashboardUI = new DashboardUI();

            DataTable dataTable =
                dashboardUI.RetrieveTodayMemberAttendanceUI();

            Series series =
                chartTodayMemberAttendance.Series[
                    "AttendanceCountSeries"];

            ChartArea area =
                chartTodayMemberAttendance.ChartAreas[
                    "TodayAttendanceChartArea"];

            series.Points.Clear();

            // Series Properties
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(24, 40, 84);
            series.BorderWidth = 0;
            series.IsValueShownAsLabel = true;
            series.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
            series["PointWidth"] = "0.65";

            // Add Today Attendance Data
            foreach (DataRow row in dataTable.Rows)
            {
                string shiftName =
                    row["ShiftName"].ToString();

                int attendanceCount =
                    Convert.ToInt32(row["AttendanceCount"]);

                series.Points.AddXY(
                    shiftName,
                    attendanceCount);
            }

            // Dynamic Y-Axis
            if (series.Points.Count > 0)
            {
                double highestValue = 0;
                double lowestValue = Double.MaxValue;

                // Find Highest and Lowest Values
                foreach (DataPoint point in series.Points)
                {
                    double value = point.YValues[0];

                    if (value > highestValue)
                    {
                        highestValue = value;
                    }

                    if (value < lowestValue)
                    {
                        lowestValue = value;
                    }
                }

                double range =
                    highestValue - lowestValue;

                // Handle same values
                if (range == 0)
                {
                    range = highestValue;
                }

                // Handle zero values
                if (range == 0)
                {
                    range = 1;
                }

                // Calculate approximate interval
                double roughInterval =
                    range / 5;

                double magnitude =
                    Math.Pow(
                        10,
                        Math.Floor(
                            Math.Log10(roughInterval)
                        )
                    );

                double normalizedInterval =
                    roughInterval / magnitude;

                double interval;

                if (normalizedInterval <= 1)
                {
                    interval = 1 * magnitude;
                }
                else if (normalizedInterval <= 2)
                {
                    interval = 2 * magnitude;
                }
                else if (normalizedInterval <= 5)
                {
                    interval = 5 * magnitude;
                }
                else
                {
                    interval = 10 * magnitude;
                }

                // Maximum with one extra interval
                double maximum =
                    Math.Ceiling(
                        highestValue / interval
                    ) * interval
                    + interval;

                area.AxisY.Minimum = 0;
                area.AxisY.Maximum = maximum;
                area.AxisY.Interval = interval;
            }

            // Chart Area
            area.BackColor = Color.White;

            // X Axis
            area.AxisX.MajorGrid.Enabled = false;

            area.AxisX.LineColor =
                Color.FromArgb(180, 180, 180);

            area.AxisX.LabelStyle.Font =
                new Font("Segoe UI", 9);

            area.AxisX.LabelStyle.ForeColor =
                Color.FromArgb(70, 70, 70);

            // Y Axis
            area.AxisY.MajorGrid.LineColor =
                Color.FromArgb(235, 238, 242);

            area.AxisY.LineColor =
                Color.FromArgb(180, 180, 180);

            area.AxisY.LabelStyle.Font =
                new Font("Segoe UI", 9);

            area.AxisY.LabelStyle.ForeColor =
                Color.FromArgb(70, 70, 70);

            // Chart Background
            chartTodayMemberAttendance.BackColor =
                Color.White;

            // Hide Legend
            chartTodayMemberAttendance.Legends[
                "TodayAttendanceLegend"].Enabled = false;
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