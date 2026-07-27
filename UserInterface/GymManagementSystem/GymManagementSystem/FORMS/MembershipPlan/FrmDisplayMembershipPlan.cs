using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Configuration;
using System.Data.SqlClient;


namespace GymManagementSystem.FORMS.MembershipPlan
{
    public partial class FrmDisplayMembershipPlan : Form
    { 
        public FrmDisplayMembershipPlan()
        {
            InitializeComponent();
        }

       
      
        private void FrmDisplayMembershipPlan_Load(object sender, EventArgs e)
        {




          
            LoadMembershipPlans();

            dgvMembershipPlan.ClearSelection();

          

        
        }

        private void LoadMembershipPlans()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("spRetrieveMembershipPlans", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            dgvMembershipPlan.Rows.Clear();

                            int serialNo = 1;

                            while (dr.Read())
                            {
                                dgvMembershipPlan.Rows.Add(
                                    serialNo,
                                    dr["MembershipPlanName"].ToString(),
                                    dr["PlanType"].ToString(),
                                   Convert.ToInt32(dr["DurationInDays"]),
                                    Convert.ToDecimal(dr["Price"]),
                                    dr["Description"].ToString(),
                                    dr["IsActive"].ToString()
                                );

                                serialNo++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }



       

       

        private void pnlMembershipPlanGridview_Click(object sender, EventArgs e)
        {
            dgvMembershipPlan.ClearSelection();
        }

        private void tlpAllMembershipPlanTitle_Click(object sender, EventArgs e)
        {
            dgvMembershipPlan.ClearSelection();
        }

        private void tlpMembershipPlanSearch_Click(object sender, EventArgs e)
        {
            dgvMembershipPlan.ClearSelection();
        }

        private void tlpMembershipPlanEntireForm_Click(object sender, EventArgs e)
        {
            dgvMembershipPlan.ClearSelection();
        }

        private void txtMembershipPlanSearchBox_Click(object sender, EventArgs e)
        {
            dgvMembershipPlan.ClearSelection();
        }

        private void pnlAddNewMembarshipPlan_Click(object sender, EventArgs e)
        {
            dgvMembershipPlan.ClearSelection();
        }

        private void FrmDisplayMembershipPlan_Click(object sender, EventArgs e)
        {
            dgvMembershipPlan.ClearSelection();
        }

     
        private void dgvMembershipPlan_CellMouseEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvMembershipPlan.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvMembershipPlan.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvMembershipPlan.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
           

        }

        private void dgvMembershipPlan_CellMouseLeave_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvMembershipPlan.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvMembershipPlan.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvMembershipPlan.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;

       

            }
        }

        private void dgvMembershipPlan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMembershipPlan.Columns[e.ColumnIndex].Name == "colIsActive")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    if (status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                    {
                        e.CellStyle.ForeColor = Color.Green;
                        e.CellStyle.Font = new Font(dgvMembershipPlan.Font, FontStyle.Bold);
                    }
                    else if (status.Equals("Inactive", StringComparison.OrdinalIgnoreCase))
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.Font = new Font(dgvMembershipPlan.Font, FontStyle.Bold);
                    }
                }
            }

            if (dgvMembershipPlan.Columns[e.ColumnIndex].Name == "colUpdate")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                        e.CellStyle.ForeColor = Color.Blue;
                     
                }
            }

            if (dgvMembershipPlan.Columns[e.ColumnIndex].Name == "colDeactivate")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Blue;

                }
            }

            if (dgvMembershipPlan.Columns[e.ColumnIndex].Name == "colSerialNo")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Navy;

                }
            }

        }

        private void dgvMembershipPlan_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMembershipPlan.Columns["colUpdate"].Index)
            {
                e.PaintBackground(e.CellBounds, true);

                ButtonRenderer.DrawButton(e.Graphics, e.CellBounds,
                    System.Windows.Forms.VisualStyles.PushButtonState.Normal);

                TextRenderer.DrawText(
                    e.Graphics,
                    "✏️Update",
                    dgvMembershipPlan.Font,
                    e.CellBounds,
                    Color.SlateBlue, // Your desired text color
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMembershipPlan.Columns["colDeactivate"].Index)
            {
                e.PaintBackground(e.CellBounds, true);

                ButtonRenderer.DrawButton(e.Graphics, e.CellBounds,
                    System.Windows.Forms.VisualStyles.PushButtonState.Normal);

                TextRenderer.DrawText(
                    e.Graphics,
                    "Deactivate",
                    dgvMembershipPlan.Font,
                    e.CellBounds,
                    Color.Brown, // Your desired text color
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;
            }

        }

        private void pnlClickAddNewMembershipPlan_Click(object sender, EventArgs e)
        {

            FrmAddMembershipPlans frm = new FrmAddMembershipPlans();
            frm.Show();
            frm.StartPosition = FormStartPosition.CenterParent;
        }

        private void picSearchIcon_Click(object sender, EventArgs e)
        {

        }

        private void txtEnterPlanName_Click(object sender, EventArgs e)
        {
            txtEnterPlanName.Clear();
            txtEnterPlanName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            txtEnterPlanName.ForeColor = Color.Black;
        }

        private void picSearchIcon_Click_1(object sender, EventArgs e)
        {

        }

        private void txtEnterPlanName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvMembershipPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblViewPlans_Click(object sender, EventArgs e)
        {

        }

        private void pnlClickAddNewMembershipPlan_MouseEnter(object sender, EventArgs e)
        {
            //pnlClickAddNewMembershipPlan.ForeColor = Color.FromArgb(220,225,230);
            //pnlClickAddNewMembershipPlan.BackColor = Color.FromArgb(220,225,230);
        }

        private void tlpAddNewMembershipPlan_MouseEnter(object sender, EventArgs e)
        {
            //pnlClickAddNewMembershipPlan.BackColor = Color.Red;
            pnlClickAddNewMembershipPlan.BackColor = Color.FromArgb(220, 225, 230);
        }

        private void lblAddNewPlan_MouseEnter(object sender, EventArgs e)
        {
            //pnlClickAddNewMembershipPlan.BackColor = Color.Red;
        }

        private void tlpAddNewMembershipPlan_MouseLeave(object sender, EventArgs e)
        {
            pnlClickAddNewMembershipPlan.BackColor = Color.FromArgb(236,240,243);
        }
       
    }
}
