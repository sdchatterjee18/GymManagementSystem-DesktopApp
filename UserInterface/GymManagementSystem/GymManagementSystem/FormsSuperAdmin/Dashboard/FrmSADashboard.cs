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
            LoadIncomeExpenseChart();
            LoadMonthlyRevenueChart();
            timer.Start();
        }
        private void timer_Tick_1(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
       
        private void LoadIncomeExpenseChart()
        {
            chartIncomeExpense.Series.Clear();

            Series series = new Series("IncomeExpenseSeries");
            series.ChartType = SeriesChartType.Doughnut;

            // Data
            series.Points.AddXY("Income", 50000);
            series.Points.AddXY("Expense", 20000);
            series.Points.AddXY("Salary", 15000);

            // Color
            series.Points[0].Color = Color.FromArgb(16, 185, 129);    // Income - Green
            series.Points[1].Color = Color.FromArgb(239, 68, 68);   // Expense - Red
            series.Points[2].Color = Color.FromArgb(186, 230, 253);  // Salary - Blue

            // Percentage / Value Label
            series.Label = "₹#VAL{N0}";
            series.LegendText = "#AXISLABEL";

            chartIncomeExpense.Series.Add(series);
        }
        private void LoadMonthlyRevenueChart()
        {
            chartMonthlyRevenue.Series.Clear();
            chartMonthlyRevenue.ChartAreas.Clear();
            chartMonthlyRevenue.Legends.Clear();

            //==========================
            // Chart Area
            //==========================
            ChartArea area = new ChartArea("ChartArea1");
            area.BackColor = Color.White;

            // X Axis
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisX.LineColor = Color.LightGray;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);

            // Y Axis
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 50000;
            area.AxisY.Interval = 5000;
            area.AxisY.LineColor = Color.LightGray;
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisY.MajorGrid.Enabled = true;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(235, 235, 235);

            chartMonthlyRevenue.ChartAreas.Add(area);

            //==========================
            // Revenue Series
            //==========================
            Series revenue = new Series("Revenue");
            revenue.ChartType = SeriesChartType.Spline;
            revenue.BorderWidth = 3;
            revenue.Color = Color.FromArgb(59, 130, 246);

            // Marker
            revenue.MarkerStyle = MarkerStyle.Circle;
            revenue.MarkerSize = 8;
            revenue.MarkerColor = Color.FromArgb(59, 130, 246);
            revenue.MarkerBorderColor = Color.White;
            revenue.MarkerBorderWidth = 2;

            // Show Value
            revenue.IsValueShownAsLabel = true;
            revenue.LabelForeColor = Color.Black;
            revenue.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            revenue.LabelFormat = "#,##0";

            //==========================
            // Data
            //==========================
            string[] months =
                {
                    "Jan","Feb","Mar","Apr","May","Jun",
                    "Jul","Aug","Sep","Oct","Nov","Dec"
                };

                        int[] revenueValue =
                {
                    12000,15000,13500,18000,17000,20000,
                    22500,25000,24000,23500,25500,28000
                };

            for (int i = 0; i < months.Length; i++)
            {
                DataPoint point = new DataPoint();
                point.AxisLabel = months[i];
                point.YValues = new double[] { revenueValue[i] };

                // Show Value
                point.Label = revenueValue[i].ToString("N0");
                point.LabelForeColor = Color.Black;
                point.Font = new Font("Segoe UI", 8, FontStyle.Bold);

                revenue.Points.Add(point);
            }

            chartMonthlyRevenue.Series.Add(revenue);

            //==========================
            // Legend
            //==========================
            Legend legend = new Legend();
            legend.Enabled = false;
            chartMonthlyRevenue.Legends.Add(legend);

            //==========================
            // Chart Background
            //==========================
            chartMonthlyRevenue.BackColor = Color.White;
        }

        private void pnlTotalIncome_Paint(object sender, PaintEventArgs e)
        {

        }

        

       
    }

}
