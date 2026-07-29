using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace GymManagementSystem.FORMS.DietPlan
{
    public partial class FrmShowDietPlans : Form
    {
        private Color originalColor;
        private Color hoverColor = Color.FromArgb(220,225,230);
        private Color MouseLeave = Color.FromArgb(236,240,243);
        private Color clickColor = Color.FromArgb(184, 195, 179);

        public FrmShowDietPlans()
        {
            InitializeComponent();


            originalColor = pnlAddNewDietPlan.BackColor;
        }

        private void FrmShowDietPlans_Load(object sender, EventArgs e)
        {
            dgvDietPlan.AllowUserToResizeRows = false;
            dgvDietPlan.AllowUserToResizeColumns = false;
            dgvDietPlan.RowHeadersVisible = false;
            dgvDietPlan.AllowUserToAddRows = false;
            dgvDietPlan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDietPlan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDietPlan.EnableHeadersVisualStyles = false;
            
            RetrieveAllDietPlan();
            
        }
        private void RetrieveAllDietPlan()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnetion = null;
            try
            {
                sqlConnetion = new SqlConnection(CS);
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spDisplayAllDietPlans", sqlConnetion))
                {
                    sqlDataAdapter.SelectCommand.CommandType =
                        CommandType.StoredProcedure;
                    sqlConnetion.Open();
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dgvDietPlan.AutoGenerateColumns = false;
                    DataRowCollection dataRows = dataTable.Rows;

                    dgvDietPlan.Rows.Clear();

                    int serialNo = 1;

                    foreach (DataRow dataRow in dataRows)
                    {
                        int rowIndex = dgvDietPlan.Rows.Add();

                        dgvDietPlan.Rows[rowIndex].Cells["colSLNo"].Value = serialNo++;
                        dgvDietPlan.Rows[rowIndex].Cells["colSLNo"].Style.ForeColor = Color.FromArgb(30, 60, 220); 
                        dgvDietPlan.Rows[rowIndex].Cells["ColCaloriesPerDay"].Value = dataRow["CaloriesPerDay"] + " Kcal";
                        dgvDietPlan.Rows[rowIndex].Cells["ColDocument"].Value =dataRow["DietPlanDocument"].ToString();
                        dgvDietPlan.Rows[rowIndex].Cells["ColCondition"].Value =dataRow["ConditionStatus"].ToString();

                    }
             


                    //for (int i = 0; i < dgvDietPlan.Rows.Count; i++)
                    //{
                    //    dgvDietPlan.Rows[i].Cells["Action"].Value ="📝Update";
                    //}

                }
                dgvDietPlan.ClearSelection();
            }
            catch (Exception ex)
            {
                dgvDietPlan.DataSource = null;
            }
            finally
            {
                sqlConnetion.Close();
            }
        }
        private void pnlAddNewDietPlan_MouseEnter(object sender, EventArgs e)
        {
            pnlAddNewDietPlan.BackColor = hoverColor;

        }
        private void pnlAddNewDietPlan_MouseLeave(object sender, EventArgs e)
        {
                pnlAddNewDietPlan.BackColor = MouseLeave;
        }
        private void pnlAddNewDietPlan_Click(object sender, EventArgs e)
        {

            pnlAddNewDietPlan.BackColor = clickColor;
            FrmAddNewDietPlan FrmAddNewDietPlan = new FrmAddNewDietPlan();
            FrmAddNewDietPlan.ShowDialog();
        }

        private void pnlAddNewDietPlan_Enter(object sender, EventArgs e)
        {

            pnlAddNewDietPlan.BackColor = hoverColor;
        }

        private void pnlAddNewDietPlan_Leave(object sender, EventArgs e)
        {


            pnlAddNewDietPlan.BackColor = originalColor;
        }

        private void dgvDietPlan_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        { 
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvDietPlan.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvDietPlan_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvDietPlan.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;

                string colName = dgvDietPlan.Columns[e.ColumnIndex].Name;

                if (colName == "colSl_No")
                {
                    dgvDietPlan.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.FromArgb(30, 60, 220);
                }
            }
        }

        private void dgvDietPlan_Click(object sender, EventArgs e)
        {
            Point clientPoint = dgvDietPlan.PointToClient(Cursor.Position);
            var hitTest = dgvDietPlan.HitTest(clientPoint.X, clientPoint.Y);

            if (hitTest.Type == DataGridViewHitTestType.None)
            {
                dgvDietPlan.ClearSelection();
            }

        }

        private void tlpShowDietPlanAndAddNewDietPlan_Click(object sender, EventArgs e)
        {
            dgvDietPlan.ClearSelection();
        }

        private void pnlDietHeader_Click(object sender, EventArgs e)
        {
            dgvDietPlan.ClearSelection();

        }

        private void pnlDietDetails_Click(object sender, EventArgs e)
        {
            dgvDietPlan.ClearSelection();
        }

        private void lblDietPlan_Click(object sender, EventArgs e)
        {
            dgvDietPlan.ClearSelection();
        }

        private void tlpShowDietPlan_Click(object sender, EventArgs e)
        {
            dgvDietPlan.ClearSelection();
        }

        private void tlpAddDietPlanAndAddButton_Click(object sender, EventArgs e)
        {
            dgvDietPlan.ClearSelection();
        }
        private void tlpDietPlanHeader_Click(object sender, EventArgs e)
        {
            dgvDietPlan.ClearSelection();
        }

        private void dgvDietPlan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void tlpTitleAndSubTitleBar_Paint(object sender, PaintEventArgs e)
        {
            dgvDietPlan.ClearSelection();
        }

        private void tlpDietPlanTitleAndSubTitle_Paint(object sender, PaintEventArgs e)
        {
            dgvDietPlan.ClearSelection();
        }

        private void picDietPlan_Click(object sender, EventArgs e)
        {
            dgvDietPlan.ClearSelection();
        }

        private void tlpDietPlanHeader_Paint(object sender, PaintEventArgs e)
        {
            dgvDietPlan.ClearSelection();
        }

        private void tlpTitleAndSubTitleBar_Click(object sender, EventArgs e)
        {
            dgvDietPlan.ClearSelection();
        }

        private void tlpDietPlanTitleAndSubTitle_Click(object sender, EventArgs e)
        {
            dgvDietPlan.ClearSelection();
        }

       
           private void dgvDietPlan_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
           {
             if (e.RowIndex >= 0 && e.ColumnIndex == dgvDietPlan.Columns["ColAction"].Index)
            {
             e.PaintBackground(e.CellBounds, true);

        ButtonRenderer.DrawButton(e.Graphics, e.CellBounds,
            System.Windows.Forms.VisualStyles.PushButtonState.Normal);

        // Explicit fixed font — won't change regardless of selection/hover state
        Font fixedFont = new Font("Segoe UI", 10F, FontStyle.Bold);

        TextRenderer.DrawText(
            e.Graphics,
            "✏️Update",
            fixedFont,
            e.CellBounds,
            Color.Green,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

        e.Handled = true;
    
            }
        }

           private void tlpTitleAndSubTitleBar_Click_1(object sender, EventArgs e)
           {
               dgvDietPlan.ClearSelection();
           }

        
  
       }
        
}
