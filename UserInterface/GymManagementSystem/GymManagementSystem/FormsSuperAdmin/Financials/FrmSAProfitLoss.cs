using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            LoadRevenueChart();
            SetPlaceholder(this);
            this.ActiveControl = null;   
        }
        private void LoadRevenueChart()
        {
            //=========================
            // Clear Previous Data
            //=========================
            chartRevenue.Series["Income"].Points.Clear();
            chartRevenue.Series["Expense"].Points.Clear();
            chartRevenue.Series["Revenue"].Points.Clear();

            //=========================
            // Chart Type
            //=========================
            chartRevenue.Series["Income"].ChartType = SeriesChartType.Column;
            chartRevenue.Series["Expense"].ChartType = SeriesChartType.Column;
            chartRevenue.Series["Revenue"].ChartType = SeriesChartType.Column;

            //=========================
            // Sample Data
            //=========================
            string[] months =
            {
                "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

             int[] income =
            {
                50000,
                60000,
                75000,
                90000,
                85000,
                95000,
                100000,
                110000,
                120000,
                130000,
                140000,
                150000
            };

              int[] expense =
            {
                20000,
                25000,
                30000,
                40000,
                35000,
                45000,
                50000,
                55000,
                60000,
                30000,
                50000,
                80000
            };

            int[] revenue = new int[income.Length];

            for (int i = 0; i < income.Length; i++)
            {
                revenue[i] = income[i] - expense[i];
            }

            //=========================
            // Insert Data
            //=========================
            for (int i = 0; i < months.Length; i++)
            {
                chartRevenue.Series["Income"].Points.AddXY(months[i], income[i]);
                chartRevenue.Series["Expense"].Points.AddXY(months[i], expense[i]);
                chartRevenue.Series["Revenue"].Points.AddXY(months[i], revenue[i]);
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
            ChartArea area = chartRevenue.ChartAreas[0];

            area.BackColor = Color.White;

            area.AxisX.LineColor = Color.LightGray;
            area.AxisY.LineColor = Color.LightGray;

            area.AxisX.LineWidth = 1;
            area.AxisY.LineWidth = 1;

            area.AxisX.MajorGrid.Enabled = false;

            area.AxisY.MajorGrid.Enabled = true;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(235, 235, 235);
            area.AxisY.MajorGrid.LineWidth = 1;

            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);

            area.AxisX.LabelStyle.ForeColor = Color.Gray;
            area.AxisY.LabelStyle.ForeColor = Color.Gray;

            area.AxisX.IsMarginVisible = true;

            //=========================
            // Y Axis
            //=========================
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 100000;
            area.AxisY.Interval = 20000;

            //=========================
            // Chart Border
            //=========================
            chartRevenue.BorderlineWidth = 0;
            chartRevenue.BorderlineColor = Color.White;

            //=========================
            // Legend
            //=========================
            chartRevenue.Legends[0].Docking = Docking.Top;
            chartRevenue.Legends[0].Alignment = StringAlignment.Center;
            chartRevenue.Legends[0].BackColor = Color.Transparent;
            chartRevenue.Legends[0].Font = new Font("Segoe UI", 9, FontStyle.Bold);
        }
        private void SetPlaceholder(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = (TextBox)c;

                    txt.Tag = txt.Text;
                    txt.ForeColor = Color.Gray;

                    txt.Enter += Placeholder_Enter;
                    txt.Leave += Placeholder_Leave;
                }

                if (c.HasChildren)
                    SetPlaceholder(c);
            }
        }
        private void Placeholder_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text == txt.Tag.ToString())
            {
                txt.Clear();
                txt.ForeColor = Color.Black;
            }
        }

        private void Placeholder_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = txt.Tag.ToString();
                txt.ForeColor = Color.Gray;
            }
        }
        private void Placeholder_Click(object sender, MouseEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text == txt.Tag.ToString())
            {
                txt.Clear();
                txt.ForeColor = Color.Black;
            }
        }

        private void FrmSAProfitLoss_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }


    }
}
