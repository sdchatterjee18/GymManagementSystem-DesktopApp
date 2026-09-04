using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using GymManagementSystem.FormsSuperAdmin.Financials.UI;


namespace GymManagementSystem.FormsSuperAdmin.Financials
{
    public partial class FrmSAProfitLoss : Form
    {
        public FrmSAProfitLoss()
        {
            InitializeComponent();
        }

        private void FrmSAProfitLoss_Load(object sender, EventArgs e)
        {
            //=================================
            // Set Current Year By Default
            //=================================
            txtSearchYear.Text =
                DateTime.Now.Year.ToString();

            //=================================
            // Load Revenue Chart
            //=================================
            LoadRevenueChart();

            //=================================
            // Load Revenue Data
            //=================================
            LoadRevenueData();

            //=================================
            // Load Revenue Summary
            //=================================
            LoadRevenueSummary();

            //=================================
            // DataGridView Settings
            //=================================
            dgvRevenue.AutoGenerateColumns = false;

            dgvRevenue.ClearSelection();

            this.ActiveControl = null;
        }

        ///Load Revenue Chart
        private void LoadRevenueChart()
        {
            //=========================
            // Get Selected Year
            //=========================
            int year;

            if (!int.TryParse(
                txtSearchYear.Text.Trim(),
                out year))
            {
                year = DateTime.Now.Year;
            }

            //=========================
            // Get Data From UI Layer
            //=========================
            SAProfitLossUI profitLossUI =
                new SAProfitLossUI();

            DataTable dataTable =
                profitLossUI
                    .GetMonthlyIncomeExpenseNetRevenueByYearUI(year);

            //=========================
            // Clear Previous Data
            //=========================
            chartRevenue.Series["Income"]
                .Points.Clear();

            chartRevenue.Series["Expense"]
                .Points.Clear();

            chartRevenue.Series["Revenue"]
                .Points.Clear();

            //=========================
            // Chart Type
            //=========================
            chartRevenue.Series["Income"].ChartType =
                SeriesChartType.Column;

            chartRevenue.Series["Expense"].ChartType =
                SeriesChartType.Column;

            chartRevenue.Series["Revenue"].ChartType =
                SeriesChartType.Column;

            //=========================
            // Insert Database Data
            //=========================
            foreach (DataRow row in dataTable.Rows)
            {
                string monthName =
                    row["MonthName"].ToString();

                decimal income =
                    Convert.ToDecimal(
                        row["TotalIncome"]);

                decimal expense =
                    Convert.ToDecimal(
                        row["TotalExpense"]);

                decimal revenue =
                    Convert.ToDecimal(
                        row["NetRevenue"]);

                chartRevenue.Series["Income"]
                    .Points.AddXY(
                        monthName,
                        income);

                chartRevenue.Series["Expense"]
                    .Points.AddXY(
                        monthName,
                        expense);

                chartRevenue.Series["Revenue"]
                    .Points.AddXY(
                        monthName,
                        revenue);
            }

            //=========================
            // Column Width
            //=========================
            foreach (Series series in chartRevenue.Series)
            {
                series["PointWidth"] = "0.7";
            }

            //=========================
            // Hide Value Labels
            //=========================
            foreach (Series series in chartRevenue.Series)
            {
                series.IsValueShownAsLabel = false;
                series.BorderWidth = 1;
            }

            //=========================
            // Chart Area
            //=========================
            ChartArea area =
                chartRevenue.ChartAreas[0];

            area.BackColor =
                Color.White;

            area.AxisX.LineColor =
                Color.LightGray;

            area.AxisY.LineColor =
                Color.LightGray;

            area.AxisX.LineWidth = 1;
            area.AxisY.LineWidth = 1;

            //=========================
            // X Axis Grid
            //=========================
            area.AxisX.MajorGrid.Enabled =
                false;

            //=========================
            // Y Axis Grid
            //=========================
            area.AxisY.MajorGrid.Enabled =
                true;

            area.AxisY.MajorGrid.LineColor =
                Color.FromArgb(
                    235,
                    235,
                    235);

            area.AxisY.MajorGrid.LineWidth =
                1;

            //=========================
            // Axis Font
            //=========================
            area.AxisX.LabelStyle.Font =
                new Font(
                    "Segoe UI",
                    9);

            area.AxisY.LabelStyle.Font =
                new Font(
                    "Segoe UI",
                    9);

            area.AxisX.LabelStyle.ForeColor =
                Color.Gray;

            area.AxisY.LabelStyle.ForeColor =
                Color.Gray;

            //=========================
            // X Axis - Show All Months
            //=========================
            area.AxisX.Interval = 1;

            area.AxisX.LabelStyle.Interval =
                1;

            area.AxisX.MajorTickMark.Interval =
                1;

            area.AxisX.IsMarginVisible =
                true;

            //=========================
            // Find Highest & Lowest
            //=========================
            double highestValue = 0;
            double lowestValue = 0;

            foreach (Series series in chartRevenue.Series)
            {
                foreach (DataPoint point in series.Points)
                {
                    double value =
                        point.YValues[0];

                    if (value > highestValue)
                    {
                        highestValue = value;
                    }

                    if (value < lowestValue)
                    {
                        lowestValue = value;
                    }
                }
            }

            //=========================
            // Dynamic Y Axis
            //=========================
            if (highestValue == 0 &&
                lowestValue == 0)
            {
                area.AxisY.Minimum = 0;
                area.AxisY.Maximum = 100;
                area.AxisY.Interval = 20;
            }
            else
            {
                // Find largest absolute value
                double largestValue =
                    Math.Max(
                        Math.Abs(highestValue),
                        Math.Abs(lowestValue));

                // Rough interval
                double roughInterval =
                    largestValue / 5;

                // Prevent Log10(0)
                if (roughInterval <= 0)
                {
                    roughInterval = 1;
                }

                // Magnitude
                double magnitude =
                    Math.Pow(
                        10,
                        Math.Floor(
                            Math.Log10(
                                roughInterval)));

                // Normalized interval
                double normalizedInterval =
                    roughInterval / magnitude;

                double interval;

                //=========================
                // Nice Interval
                //=========================
                if (normalizedInterval <= 1)
                {
                    interval =
                        1 * magnitude;
                }
                else if (normalizedInterval <= 2)
                {
                    interval =
                        2 * magnitude;
                }
                else if (normalizedInterval <= 5)
                {
                    interval =
                        5 * magnitude;
                }
                else
                {
                    interval =
                        10 * magnitude;
                }

                //=========================
                // Positive Maximum
                //=========================
                double maximum =
                    Math.Ceiling(
                        highestValue / interval)
                    * interval;

                //=========================
                // Negative Minimum
                //=========================
                double minimum =
                    Math.Floor(
                        lowestValue / interval)
                    * interval;

                // Prevent Same Min & Max
                if (maximum == minimum)
                {
                    maximum += interval;
                }

                //=========================
                // Set Dynamic Y Axis
                //=========================
                area.AxisY.Minimum =
                    minimum;

                area.AxisY.Maximum =
                    maximum;

                area.AxisY.Interval =
                    interval;
            }

            //=========================
            // Chart Border
            //=========================
            chartRevenue.BorderlineWidth =
                0;

            chartRevenue.BorderlineColor =
                Color.White;

            //=========================
            // Legend
            //=========================
            chartRevenue.Legends[0].Docking =
                Docking.Top;

            chartRevenue.Legends[0].Alignment =
                StringAlignment.Center;

            chartRevenue.Legends[0].BackColor =
                Color.Transparent;

            chartRevenue.Legends[0].Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold);
        }
        // Load Revenue Data
        private void LoadRevenueData()
        {
            SAProfitLossUI profitLossUI =
                new SAProfitLossUI();

            int year;

            if (!int.TryParse(
                txtSearchYear.Text.Trim(),
                out year))
            {
                year = DateTime.Now.Year;
            }

            DataTable dataTable =
                profitLossUI
                    .GetMonthlyIncomeExpenseNetRevenueByYearUI(year);

            dgvRevenue.Rows.Clear();

            int slNo = 1;

            foreach (DataRow row in dataTable.Rows)
            {
                int monthId =
                    Convert.ToInt32(row["MonthId"]);

                string month =
                    row["MonthName"].ToString();

                decimal income =
                    Convert.ToDecimal(row["TotalIncome"]);

                decimal expense =
                    Convert.ToDecimal(row["TotalExpense"]);

                decimal revenue =
                    Convert.ToDecimal(row["NetRevenue"]);

                dgvRevenue.Rows.Add(
                    slNo,
                    month,
                    income,
                    expense,
                    revenue);

                slNo++;
            }

            dgvRevenue.ClearSelection();
        }
        // Load Revenue Summary
        private void LoadRevenueSummary()
        {
            SAProfitLossUI profitLossUI =
                new SAProfitLossUI();

            //=========================
            // Get Selected Year
            //=========================
            int year;

            if (!int.TryParse(
                txtSearchYear.Text.Trim(),
                out year))
            {
                year = DateTime.Now.Year;
            }

            //=========================
            // Get Summary Data
            //=========================
            DataTable dataTable =
                profitLossUI
                    .GetIncomeExpenseNetRevenueForRevenueSectionByYearUI(
                        year);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row =
                    dataTable.Rows[0];

                //=========================
                // Year
                //=========================
                lblYear.Text =
                    row["CurrentYear"].ToString();

                //=========================
                // Total Income
                //=========================
                lblTotalIncomeValue.Text =
                    Convert.ToDecimal(
                        row["TotalIncome"])
                    .ToString("N2");

                //=========================
                // Total Expense
                //=========================
                lblTotalExpenseValue.Text =
                    Convert.ToDecimal(
                        row["TotalExpense"])
                    .ToString("N2");

                //=========================
                // Total Revenue
                //=========================
                lblTotalRevenueValue.Text =
                    Convert.ToDecimal(
                        row["NetRevenue"])
                    .ToString("N2");

                //=========================
                // Average Monthly Revenue
                //=========================
                lblAvgMonthlyRevenueValue.Text =
                    Convert.ToDecimal(
                        row["AverageMonthlyNetRevenue"])
                    .ToString("N2");
            }
        }

        private void pnlSearch_Click(object sender, EventArgs e)
        {
            int year;

            if (!int.TryParse(
                txtSearchYear.Text.Trim(),
                out year))
            {
                MessageBox.Show(
                    "Please enter a valid year.",
                    "Invalid Year",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSearchYear.Focus();
                return;
            }

            if (year < 2005)
            {
                MessageBox.Show(
                    "Year must be 2005 or later.",
                    "Invalid Year",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSearchYear.Focus();
                return;
            }

            if (year > DateTime.Now.Year)
            {
                MessageBox.Show(
                    "Future year is not allowed.",
                    "Invalid Year",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSearchYear.Focus();
                return;
            }

            //=================================
            // Load Selected Year Data
            //=================================
            LoadRevenueChart();

            LoadRevenueData();

            LoadRevenueSummary();

            dgvRevenue.ClearSelection();

            this.ActiveControl = null;
        }
       
        private void FrmSAProfitLoss_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void dgvRevenue_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvRevenue.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvRevenue_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvRevenue.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
            }
        }

        private void dgvRevenue_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRevenue.Columns[e.ColumnIndex].Name == "colIncome")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Green;

                }
            }
            if (dgvRevenue.Columns[e.ColumnIndex].Name == "colExpence")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Brown;

                }
            }
            if (dgvRevenue.Columns[e.ColumnIndex].Name == "colRevenue")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Blue;

                }
            } if (dgvRevenue.Columns[e.ColumnIndex].Name == "colSLNo")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Blue;

                }
            }
        }

        private void tlpMonthlyRevenueLabelpic_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void tlpRevenueGraphLabelImage_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void tlpRevenueOverviewTitle_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void lblRevenueOverview_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void picRevenueOverview_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void picRevenueGraph_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void lblRevenueGraph_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void tlpProfitLossForm_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void tlpSearhImageLabel_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void tlpSummaryLabel_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void lblRevenueSummary_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void tlpTotalIncomeValue_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void picTotalIncome_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void picTotalExpense_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void tlpTotalExpenseValue_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void picTotalRevenue_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void tlpTotalRevenueValue_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void tlpAvgMonthlyRevenueValue_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }

        private void picAvgMonthlyRevenue_Click(object sender, EventArgs e)
        {
            dgvRevenue.ClearSelection();
        }
    }
}
