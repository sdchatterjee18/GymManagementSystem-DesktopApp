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
        private Color hoverColor = Color.SkyBlue;
        private Color MouseLeave;
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

                    dgvDietPlan.Columns["CaloriesPerDay"].DataPropertyName = "CaloriesPerDay";
                    dgvDietPlan.Columns["Document"].DataPropertyName = "DietPlanDocument";
                    dgvDietPlan.Columns["Condition"].DataPropertyName = "ConditionStatus";
                    dgvDietPlan.DataSource = dataTable;

                    for (int i = 0; i < dgvDietPlan.Rows.Count; i++)
                    {
                        dgvDietPlan.Rows[i].Cells["SL_No"].Value = i + 1;
                    }

                    for (int i = 0; i < dgvDietPlan.Rows.Count; i++)
                    {
                        dgvDietPlan.Rows[i].Cells["Action"].Value ="📝Update";
                    }

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

        private void lblAddNewDietPlan_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAddNewDietPlan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAddNewDietPlan_MouseEnter(object sender, EventArgs e)
        {
            pnlAddNewDietPlan.BackColor = hoverColor;

        }

        private void pnlAddNewDietPlan_MouseHover(object sender, EventArgs e)
        {

        }


        private void pnlAddNewDietPlan_MouseLeave(object sender, EventArgs e)
        {
                pnlAddNewDietPlan.BackColor = MouseLeave;
        }

        private void lblAddNewDietPlan_MouseEnter(object sender, EventArgs e)
        {


        }

        private void lblAddNewDietPlan_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblAddNewDietPlan_MouseLeave(object sender, EventArgs e)
        {


        }

        private void lblAddNewDietPlan_MouseUp(object sender, MouseEventArgs e)
        {

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
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvDietPlan.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.DimGray;
                dgvDietPlan.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.White;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvDietPlan.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }

        }

        private void dgvDietPlan_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvDietPlan.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.LightGray;
                dgvDietPlan.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvDietPlan.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
                dgvDietPlan.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Empty;
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

        private void FrmShowDietPlans_Resize(object sender, EventArgs e)
        {


        }
        private void dgvDietPlan_Resize(object sender, EventArgs e)
        {
            
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

        private void tlpShowDietPlanAndAddNewDietPlan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpDietPlanHeader_Click(object sender, EventArgs e)
        {
            dgvDietPlan.ClearSelection();
        }
       
        

        }
        
}
