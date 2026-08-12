using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Drawing2D;
using GymManagementSystem.FormsSuperAdmin.Dashboard.UI;

namespace GymManagementSystem.FormsSuperAdmin.Dashboard
{
    public partial class FrmSADashboard : Form
    {
        public FrmSADashboard()
        {
            InitializeComponent();  
        }
        private void FrmSADashboard_Load(object sender, EventArgs e)
        {
             // Load Current Shift
            LoadCurrentShift();
            //Load Active EmployeeCount
            LoadActiveEmployeeCount();
            // LoadbCurrent Month TotalExpense
            LoadCurrentMonthTotalExpense();
            // Load Active Trainer Count
            LoadActiveTrainerCount();
            // Load Current Month Total Income
            LoadCurrentMonthTotalIncome();
            // Load Monthly Income, Expense & Net Revenue
            LoadCurrentMonthIncomeExpenseNetRevenue();
            // Load Yearly Income, Expense & Net Revenue
            LoadCurrentYearIncomeExpenseNetRevenue();

            // Load Income Expense Chart
            LoadIncomeExpenseChart();
            // Load Monthly RevenueC hart
            LoadMonthlyRevenueChart();
            timer.Start();
        }
        private void timer_Tick_1(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        // Load Current Shift
        private void LoadCurrentShift()
        {
            SuperAdminDashboardUI superAdminDashboardUI = new SuperAdminDashboardUI();
            DataTable dataTable =
                superAdminDashboardUI.GetCurrentShiftUI();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                lblRunningShift.Text =
                    dataTable.Rows[0]["ShiftName"].ToString()
                    + " Shift is Running";
            }
            else
            {
                lblRunningShift.Text =
                    "No Shift is Running";
            }
        }
        // Load Active Employee Count
        private void LoadActiveEmployeeCount()
        {
            SuperAdminDashboardUI superAdminDashboardUI =
                new SuperAdminDashboardUI();
            int activeEmployeeCount =
                superAdminDashboardUI.GetActiveEmployeeCountUI();
            lblActiveEmployeesValue.Text =
                activeEmployeeCount.ToString();
        }
        // LoadbCurrent Month TotalExpense
        private void LoadCurrentMonthTotalExpense()
        {
            SuperAdminDashboardUI superAdminDashboardUI =
                new SuperAdminDashboardUI();
            decimal totalExpense =
                superAdminDashboardUI.GetCurrentMonthTotalExpenseUI();
            lblExpensevalue.Text = totalExpense.ToString("N2");
        }
        // Load Active Trainer Count
        private void LoadActiveTrainerCount()
        {
            SuperAdminDashboardUI superAdminDashboardUI =
                new SuperAdminDashboardUI();
            int activeTrainerCount =
                superAdminDashboardUI.GetActiveTrainerCountUI();
            lblTrainerValues.Text =
                activeTrainerCount.ToString();
        }
        // Load Current Month Total Income
        private void LoadCurrentMonthTotalIncome()
        {
            SuperAdminDashboardUI superAdminDashboardUI =
                new SuperAdminDashboardUI();
            decimal totalIncome =
                superAdminDashboardUI.GetCurrentMonthTotalIncomeUI();
            lblTotalIncomeValue.Text = totalIncome.ToString("N2");
        }
        // Load Current Month Income Expense Net Revenue
        private void LoadCurrentMonthIncomeExpenseNetRevenue()
        {
            SuperAdminDashboardUI superAdminDashboardUI =
                new SuperAdminDashboardUI();

            DataTable dataTable =
                superAdminDashboardUI
                .GetCurrentMonthIncomeExpenseNetRevenueUI();

            if (dataTable != null &&
                dataTable.Rows.Count > 0)
            {
                decimal totalIncome =
                    Convert.ToDecimal(
                        dataTable.Rows[0]["TotalIncome"]);

                decimal totalExpense =
                    Convert.ToDecimal(
                        dataTable.Rows[0]["TotalExpense"]);

                decimal netRevenue =
                    Convert.ToDecimal(
                        dataTable.Rows[0]["NetRevenue"]);

                lblMonthlyTotalIncomeValue.Text =
                    "₹" + totalIncome.ToString("N2");

                lblMonthlyTotalExpenseValue.Text =
                    "₹" + totalExpense.ToString("N2");

                lblMonthlyNetRevenueValue.Text =
                    "₹" + netRevenue.ToString("N2");
            }
            else
            {
                lblMonthlyTotalIncomeValue.Text = "₹0.00";
                lblMonthlyTotalExpenseValue.Text = "₹0.00";
                lblMonthlyNetRevenueValue.Text = "₹0.00";
            }
        }
        // Load Current Year Income Expense Net Revenue
        private void LoadCurrentYearIncomeExpenseNetRevenue()
        {
            SuperAdminDashboardUI superAdminDashboardUI =
                new SuperAdminDashboardUI();

            DataTable dataTable =
                superAdminDashboardUI
                .GetCurrentYearIncomeExpenseNetRevenueUI();

            if (dataTable != null &&
                dataTable.Rows.Count > 0)
            {
                decimal totalIncome =
                    Convert.ToDecimal(
                        dataTable.Rows[0]["TotalIncome"]);

                decimal totalExpense =
                    Convert.ToDecimal(
                        dataTable.Rows[0]["TotalExpense"]);

                decimal netRevenue =
                    Convert.ToDecimal(
                        dataTable.Rows[0]["NetRevenue"]);

                lblYearlyTotalIncomeValue.Text =
                    "₹" + totalIncome.ToString("N2");

                lblYearlyTotalExpenseValue.Text =
                    "₹" + totalExpense.ToString("N2");

                lblYearlyNetRevenueValue.Text =
                    "₹" + netRevenue.ToString("N2");
            }
            else
            {
                lblYearlyTotalIncomeValue.Text = "₹0.00";
                lblYearlyTotalExpenseValue.Text = "₹0.00";
                lblYearlyNetRevenueValue.Text = "₹0.00";
            }
        }
        
        // Load Income Expense Chart
        private void LoadIncomeExpenseChart()
        {
            SuperAdminDashboardUI dashboardUI =
                new SuperAdminDashboardUI();
            DataTable dataTable =
                dashboardUI.GetCurrentMonthFinancialSummaryUI();
            chartIncomeExpense.Series.Clear();
            Series series =
                new Series("IncomeExpenseSeries");
            series.ChartType =
                SeriesChartType.Doughnut;
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                decimal income =
                    Convert.ToDecimal(row["Income"]);
                decimal expense =
                    Convert.ToDecimal(row["Expense"]);
                decimal salary =
                    Convert.ToDecimal(row["Salary"]);
                series.Points.AddXY("Income", income);
                series.Points.AddXY("Expense", expense);
                series.Points.AddXY("Salary", salary);
                series.Points[0].Color =
                     Color.FromArgb(16, 185, 129); 
                series.Points[1].Color =
                    Color.FromArgb(239, 68, 68); 
                series.Points[2].Color =
                   Color.FromArgb(186, 230, 253); 
                series.Label =
                    "₹#VAL{N0}";

                series.LegendText =
                    "#AXISLABEL";
            }

            chartIncomeExpense.Series.Add(series);
        }
        // Load Monthly Revenue Chart
        private void LoadMonthlyRevenueChart()
        {
            SuperAdminDashboardUI dashboardUI =
                new SuperAdminDashboardUI();

            DataTable dataTable =
                dashboardUI.GetMonthlyRevenueUI();

            chartMonthlyRevenue.Series.Clear();
            chartMonthlyRevenue.ChartAreas.Clear();
            chartMonthlyRevenue.Legends.Clear();

            //==========================
            // Chart Area
            //==========================
            ChartArea area =
                new ChartArea("ChartArea1");

            area.BackColor =
                Color.White;

            chartMonthlyRevenue.ChartAreas.Add(area);

            //==========================
            // X Axis
            //==========================
            area.AxisX.Interval = 1;

            area.AxisX.MajorGrid.Enabled =
                false;

            area.AxisX.LineColor =
                Color.FromArgb(180, 180, 180);

            area.AxisX.LabelStyle.Font =
                new Font("Segoe UI", 9);

            area.AxisX.LabelStyle.ForeColor =
                Color.FromArgb(70, 70, 70);

            //==========================
            // Y Axis
            //==========================
            area.AxisY.Minimum = 0;

            area.AxisY.MajorGrid.Enabled =
                true;

            area.AxisY.MajorGrid.LineColor =
                Color.FromArgb(235, 238, 242);

            area.AxisY.LineColor =
                Color.FromArgb(180, 180, 180);

            area.AxisY.LabelStyle.Font =
                new Font("Segoe UI", 9);

            area.AxisY.LabelStyle.ForeColor =
                Color.FromArgb(70, 70, 70);

            //==========================
            // Revenue Series
            //==========================
            Series revenue =
                new Series("Revenue");

            revenue.ChartType =
                SeriesChartType.Spline;

            revenue.BorderWidth = 3;

            revenue.Color =
                Color.FromArgb(59, 130, 246);

            // Marker
            revenue.MarkerStyle =
                MarkerStyle.Circle;

            revenue.MarkerSize = 8;

            revenue.MarkerColor =
                Color.FromArgb(59, 130, 246);

            revenue.MarkerBorderColor =
                Color.White;

            revenue.MarkerBorderWidth = 2;

            //==========================
            // Value Label
            //==========================
            revenue.IsValueShownAsLabel =
                true;

            revenue.LabelForeColor =
                Color.Black;

            revenue.Font =
                new Font(
                    "Segoe UI",
                    8,
                    FontStyle.Bold
                );

            revenue.LabelFormat =
                "#,##0";

            //==========================
            // Add Database Data
            //==========================
            if (dataTable != null &&
                dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string monthName =
                        row["MonthName"].ToString();

                    decimal revenueValue =
                        Convert.ToDecimal(
                            row["Revenue"]
                        );

                    DataPoint point =
                        new DataPoint();

                    point.AxisLabel =
                        monthName;

                    point.YValues =
                        new double[]
                {
                    Convert.ToDouble(
                        revenueValue
                    )
                };

                    // Show Value
                    point.Label =
                        revenueValue.ToString("N0");

                    point.LabelForeColor =
                        Color.Black;

                    point.Font =
                        new Font(
                            "Segoe UI",
                            8,
                            FontStyle.Bold
                        );

                    revenue.Points.Add(point);
                }
            }

            chartMonthlyRevenue.Series.Add(
                revenue
            );

            //==========================
            // Dynamic Y-Axis
            //==========================
            if (revenue.Points.Count > 0)
            {
                double highestValue = 0;

                double lowestValue =
                    Double.MaxValue;

                // Find Highest and Lowest Revenue
                foreach (DataPoint point in revenue.Points)
                {
                    double value =
                        point.YValues[0];

                    if (value > highestValue)
                    {
                        highestValue =
                            value;
                    }

                    if (value < lowestValue)
                    {
                        lowestValue =
                            value;
                    }
                }

                double range =
                    highestValue - lowestValue;

                // Handle Same Values
                if (range == 0)
                {
                    range =
                        highestValue;
                }

                // Handle Zero Values
                if (range == 0)
                {
                    range = 1;
                }

                // Approximate Interval
                double roughInterval =
                    range / 5;

                double magnitude =
                    Math.Pow(
                        10,
                        Math.Floor(
                            Math.Log10(
                                roughInterval
                            )
                        )
                    );

                double normalizedInterval =
                    roughInterval / magnitude;

                double interval;

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

                // Calculate Maximum
                double maximum =
                    Math.Ceiling(
                        highestValue / interval
                    ) * interval
                    + interval;

                area.AxisY.Minimum = 0;

                area.AxisY.Maximum =
                    maximum;

                area.AxisY.Interval =
                    interval;
            }

            //==========================
            // Legend
            //==========================
            Legend legend =
                new Legend();

            legend.Enabled = false;

            chartMonthlyRevenue.Legends.Add(
                legend
            );

            //==========================
            // Chart Background
            //==========================
            chartMonthlyRevenue.BackColor =
                Color.White;
        }

        private void pnlTotalIncome_Paint(object sender, PaintEventArgs e)
        {

        }

        

       
    }

}
