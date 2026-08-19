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
using GymManagementSystem.FORMS.MembershipPlan.UI;
using GymManagementSystem.FORMS.MembershipPlan;
using GymManagementSystemBLLayer.ModulesBLLayer.MembershipPlan;
using GymManagementSystem.Common;



namespace GymManagementSystem.FORMS.MembershipPlan
{
    public partial class FrmDisplayMembershipPlan : Form
    {

        // Constructor
        public FrmDisplayMembershipPlan()
        {
            InitializeComponent();
        }
        // Form Load
        private void FrmDisplayMembershipPlan_Load(object sender, EventArgs e)
        {
            dgvMembershipPlan.AutoGenerateColumns = false;
            dgvMembershipPlan.ClearSelection();
            this.ActiveControl = null;
            LoadMembershipPlans();
        }

        // Clear DataGridView Selection
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

        // DataGridView Mouse Enter
        private void dgvMembershipPlan_CellMouseEnter_1(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvMembershipPlan.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }
        // DataGridView Mouse Leave
        private void dgvMembershipPlan_CellMouseLeave_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvMembershipPlan.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
            }
        }
        // DataGridView Cell Formatting
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
        // DataGridView Button Painting
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
        // Add New Membership Plan
        private void pnlClickAddNewMembershipPlan_Click(object sender, EventArgs e)
        {
            FrmAddMembershipPlans frm = new FrmAddMembershipPlans();
            frm.ShowDialog();
            LoadMembershipPlans();
            //FrmAddMembershipPlans frm = new FrmAddMembershipPlans();
            //frm.Show();
            //frm.StartPosition = FormStartPosition.CenterParent;
            //LoadMembershipPlans();
        }
        // Add New Membership Plan Mouse Enter
        // Add New Membership Plan Mouse Leave

        // Load Membership Plans
        private void LoadMembershipPlans()
        {
            
            dgvMembershipPlan.Rows.Clear();
            dgvMembershipPlan.ReadOnly = false;

            // Make all columns read-only first
            foreach (DataGridViewColumn col in dgvMembershipPlan.Columns)
            {
                col.ReadOnly = true;
            }

            // Only these two columns can be edited
            dgvMembershipPlan.Columns["colPrice"].ReadOnly = false;
            dgvMembershipPlan.Columns["colDescription"].ReadOnly = false;

            dgvMembershipPlan.EditMode = DataGridViewEditMode.EditOnEnter;

            MembershipPlanUI membershipPlanUI = new MembershipPlanUI();

            List<MembershipPlanUI> membershipPlans =
                membershipPlanUI.RetrieveMembershipPlansDetailsUI();
            int SlNo = 1;
            foreach (MembershipPlanUI plan in membershipPlans)
            {
                dgvMembershipPlan.Rows.Add(
                    SlNo++,
                    plan.MembershipPlanName,
                    plan.PlanType,
                    plan.DurationInDays + " Days",
                    "₹ " + plan.Price,
                    plan.Description,
                    plan.IsActive,
                    plan.MembershipPlanId
                );
            }

            dgvMembershipPlan.ClearSelection();
        }
        private void dgvMembershipPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Update
            if (dgvMembershipPlan.Columns[e.ColumnIndex].Name == "colUpdate")
            {
                dgvMembershipPlan.EndEdit();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to update this membership plan?",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        MembershipPlanUI membershipPlanUI = new MembershipPlanUI();

                        membershipPlanUI.MembershipPlanId = Convert.ToInt32(
                            dgvMembershipPlan.Rows[e.RowIndex].Cells["colMembershipPlanId"].Value);

                        membershipPlanUI.Description =
                            dgvMembershipPlan.Rows[e.RowIndex].Cells["colDescription"].Value.ToString();

                        membershipPlanUI.Price = Convert.ToDecimal(
                            dgvMembershipPlan.Rows[e.RowIndex].Cells["colPrice"].Value);

                        string message = membershipPlanUI
                            .UpdateMembershipPlanDescriptionAndPriceByMembershipPlanIdUI();

                        MessageBox.Show(
                            message,
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LoadMembershipPlans();
                    }
                    catch
                    {
                        MessageBox.Show(
                            "Incorrect Input Format.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        LoadMembershipPlans();
                    }
                }
                else
                {
                    LoadMembershipPlans();
                }
            }

            // Deactivate
            else if (dgvMembershipPlan.Columns[e.ColumnIndex].Name == "colDeactivate")
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to deactivate this membership plan?",
                    "Confirm Deactivate",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        MembershipPlanUI membershipPlanUI = new MembershipPlanUI();

                        membershipPlanUI.MembershipPlanId = Convert.ToInt32(
                            dgvMembershipPlan.Rows[e.RowIndex].Cells["colMembershipPlanId"].Value);

                        string message = membershipPlanUI
                            .DeactivateMembershipPlanByMembershipPlanIdUI();

                        MessageBox.Show(
                            message,
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                        LoadMembershipPlans();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        LoadMembershipPlans();
                    }
                }
                else
                {
                    LoadMembershipPlans();
                }
            }
        }
        private void pnlClickAddNewMembershipPlan_MouseEnter_1(object sender, EventArgs e)
        {
            pnlClickAddNewMembershipPlan.BackColor = Color.White;
            picAddButton.Image = Properties.Resources.plusHOVER;
            lblAddNewPlan.ForeColor = Color.MidnightBlue;
        }

        private void pnlClickAddNewMembershipPlan_MouseLeave(object sender, EventArgs e)
        {
            pnlClickAddNewMembershipPlan.BackColor = Color.MidnightBlue;
            picAddButton.Image = Properties.Resources.plus;
            lblAddNewPlan.ForeColor = Color.White;
        }

        private void txtSearchPlan_TextChanged(object sender, EventArgs e)
        {
            string Search = txtSearchPlan.Text;
            LoadMembershipPlansWhenSearched(Search);
        }
        private void LoadMembershipPlansWhenSearched(string search)
        {
            dgvMembershipPlan.Rows.Clear();
            MembershipPlanUI membershipPlanUI = new MembershipPlanUI();
            DataTable dataTable = null;
            dataTable = membershipPlanUI.RetrieveMembershipPlanDetailsByMembershipPlanDetails(search);
            int SlNo = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                dgvMembershipPlan.Rows.Add(
                    SlNo++,
                    row["MembershipPlanName"].ToString(),
                    row["PlanType"].ToString(),
                    row["DurationInDays"].ToString(),
                    row["Price"].ToString(),
                    row["Description"].ToString(),
                    row["IsActive"].ToString(),
                    row["MembershipPlanId"].ToString()
                    );
            }

            dgvMembershipPlan.ClearSelection();
        }
    }
}
