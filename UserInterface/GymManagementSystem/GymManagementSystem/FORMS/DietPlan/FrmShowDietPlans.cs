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
using GymManagementSystem.FORMS.DietPlan.UI;


namespace GymManagementSystem.FORMS.DietPlan
{
    public partial class FrmShowDietPlans : Form
    {
        private byte[] dietPlanDocument = null;
        // Constructor
        public FrmShowDietPlans()
        {
            InitializeComponent();
        }
        // Load Form
        private void FrmShowDietPlans_Load(object sender, EventArgs e)  
        {
            RetrieveAllDietPlan();
        }
        private void pnlAddNewDietPlan_Click(object sender, EventArgs e)
        {
            FrmAddNewDietPlan FrmAddNewDietPlan = new FrmAddNewDietPlan();
            FrmAddNewDietPlan.ShowDialog();
            RetrieveAllDietPlan();
        }

        private void dgvDietPlan_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        { 
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvDietPlan.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }
        // DataGridView Cell Mouse Leave
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
        // DataGridView Click
        private void dgvDietPlan_Click(object sender, EventArgs e)
        {
            Point clientPoint = dgvDietPlan.PointToClient(Cursor.Position);
            var hitTest = dgvDietPlan.HitTest(clientPoint.X, clientPoint.Y);
            if (hitTest.Type == DataGridViewHitTestType.None)
            {
                dgvDietPlan.ClearSelection();
            }
        }
        // DataGridView Action Button Painting
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
        // Clear DataGridView Selection
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
        private void picDietPlan_Click(object sender, EventArgs e)
        {
            dgvDietPlan.ClearSelection();
        }
        private void tlpShowDietPlanAndAddNewDietPlan_Click(object sender, EventArgs e)
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
        private void tlpTitleAndSubTitleBar_Paint(object sender, PaintEventArgs e)
        {
            dgvDietPlan.ClearSelection();
        }
        private void tlpDietPlanTitleAndSubTitle_Paint(object sender, PaintEventArgs e)
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
        

        //RetrieveAllDietPlan
        private void RetrieveAllDietPlan()
           {
               try
               {
                   DietPlanUI dietPlanUI = new DietPlanUI();

                   DataTable dataTable = dietPlanUI.RetrieveDietPlansUI();

                   dgvDietPlan.AutoGenerateColumns = false;
                   dgvDietPlan.Rows.Clear();

                   int serialNo = 1;

                   foreach (DataRow dataRow in dataTable.Rows)
                   {
                       int rowIndex = dgvDietPlan.Rows.Add();

                       dgvDietPlan.Rows[rowIndex].Cells["colSLNo"].Value = serialNo++;
                       dgvDietPlan.Rows[rowIndex].Cells["colSLNo"].Style.ForeColor = Color.FromArgb(30, 60, 220);

                       dgvDietPlan.Rows[rowIndex].Cells["ColCaloriesPerDay"].Value =
                           dataRow["CaloriesPerDay"] + " Kcal";

                       dgvDietPlan.Rows[rowIndex].Cells["ColDocument"].Value =
                           dataRow["DietPlanDocument"].ToString();

                       dgvDietPlan.Rows[rowIndex].Cells["ColCondition"].Value =
                           dataRow["ConditionStatus"].ToString();

                       dgvDietPlan.Rows[rowIndex].Cells["colDietPlanId"].Value =
                           Convert.ToInt32(dataRow["DietPlanId"]);
                   }

                   dgvDietPlan.ClearSelection();
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
           }
           private void tlpAddButton_MouseEnter(object sender, EventArgs e)
           {
               this.tlpAddButton.BackColor = Color.FromArgb(220, 225, 230);
           }

           private void tlpAddButton_MouseLeave(object sender, EventArgs e)
           {
               this.tlpAddButton.BackColor = Color.FromArgb(236, 240, 243);
           }
        //SelectDietPlanDocument Method
        private void SelectDietPlanDocument(int rowIndex)
           {
               OpenFileDialog openFileDialog = new OpenFileDialog();
               openFileDialog.Title = "Select Diet Plan Image";
               openFileDialog.Filter =
                   "Image Files|*.jpg;*.jpeg;*.png;*.bmp";


               if (openFileDialog.ShowDialog() == DialogResult.OK)
               {
                   dietPlanDocument =
                       System.IO.File.ReadAllBytes(openFileDialog.FileName);


                   dgvDietPlan.Rows[rowIndex]
                   .Cells["ColDocument"].Value =
                   openFileDialog.FileName;
               }
           }
        // Update Data On DataGridView
        private void dgvDietPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               if (e.RowIndex < 0)
                   return;

               //if (dgvDietPlan.Columns[e.ColumnIndex].Name == "ColDocument")
               //{
               //    SelectDietPlanDocument(e.RowIndex);
               //    return;
               //}

               if (dgvDietPlan.Columns[e.ColumnIndex].Name == "ColAction")
               {
                   //dgvDietPlan.EndEdit();
                   DialogResult result = MessageBox.Show("Are you sure you want to update this diet plan?","Confirm Update",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                   if (result == DialogResult.Yes)
                   {
                       try
                       {
                           int dietPlanId = Convert.ToInt32(
                               dgvDietPlan.Rows[e.RowIndex]
                               .Cells["colDietPlanId"].Value);

                           string calories = dgvDietPlan.Rows[e.RowIndex]
                               .Cells["ColCaloriesPerDay"].Value.ToString();

                           calories = calories.Replace(" Kcal", "");

                           int caloriesPerDay = Convert.ToInt32(calories);

                           string conditionStatus = dgvDietPlan.Rows[e.RowIndex]
                               .Cells["ColCondition"].Value.ToString();

                           DietPlanUI dietPlanUI = new DietPlanUI();

                           string message = dietPlanUI.UpdateDietPlanUI(dietPlanId,caloriesPerDay,dietPlanDocument,conditionStatus);

                           MessageBox.Show(message);

                           RetrieveAllDietPlan();

                           //dietPlanDocument = null;
                       }
                       catch (Exception ex)
                       {
                           MessageBox.Show(ex.Message);
                       }
                   }
               }
           }
        //Image Insert or Update On Data Gridview
        private void dgvDietPlan_CellClick(object sender, DataGridViewCellEventArgs e)
           {
               if (e.RowIndex < 0)
                   return;

               if (dgvDietPlan.Columns[e.ColumnIndex].Name == "ColDocument")
               {
                   SelectDietPlanDocument(e.RowIndex);
               }
           }
       }  
}
