using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using GymManagementSystem.FORMS.Main;
using GymManagementSystem.FORMS.Member.UI;
using GymManagementSystem.Common;

namespace GymManagementSystem.FORMS.Member
{
    public partial class FrmDisplayAllMembers : Form
    {
        private int searchMemberClickCount = 0;
        private FrmMainLayout AdminMainForm;
        private MemberUI memberUI = new MemberUI();
        private int slNo = 1;
        public FrmDisplayAllMembers(FrmMainLayout mainform)
        {
            InitializeComponent();
            AdminMainForm = mainform;
        }

        public FrmDisplayAllMembers()
        {
            // TODO: Complete member initialization
        }

        private void FrmDisplayAllMembers_Load(object sender, EventArgs e)
        {
            // DataGridView editable
            dgvDisplayMemberInformation.ReadOnly = false;

            // Only Phone No and Email Id will be editable
            dgvDisplayMemberInformation.Columns["colPhoneNo"].ReadOnly = false;
            dgvDisplayMemberInformation.Columns["colEmailId"].ReadOnly = false;

            // Other columns will remain read-only
            dgvDisplayMemberInformation.Columns["colSlNo"].ReadOnly = true;
            dgvDisplayMemberInformation.Columns["colMemberId"].ReadOnly = true;
            dgvDisplayMemberInformation.Columns["colMemberName"].ReadOnly = true;
            dgvDisplayMemberInformation.Columns["colIsActive"].ReadOnly = true;
            dgvDisplayMemberInformation.Columns["colMemberProfile"].ReadOnly = true;
            dgvDisplayMemberInformation.Columns["colUpdate"].ReadOnly = true;
            dgvDisplayMemberInformation.Columns["colDeactivate"].ReadOnly = true;

            // Start editing when user starts typing
            dgvDisplayMemberInformation.EditMode =
                DataGridViewEditMode.EditOnKeystrokeOrF2;

            RetrieveMemberDetails();
        }

        private void RetrieveMemberDetails()
        {
            try
            {
                DataTable dataTable =
                    memberUI.RetrieveAllMemberDetailsUI();

                dgvDisplayMemberInformation.Rows.Clear();

                slNo = 1;

                foreach (DataRow row in dataTable.Rows)
                {
                    string status =
                        Convert.ToInt32(row["MemberIsActive"]) == 1
                        ? "Active"
                        : "Inactive";

                    dgvDisplayMemberInformation.Rows.Add(
                        slNo,
                        Convert.ToInt32(row["MemberId"]),
                        row["MemberName"].ToString(),
                        row["PhoneNo"].ToString(),
                        row["EmailId"].ToString(),
                        status
                    );

                    slNo++;
                }

                dgvDisplayMemberInformation.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvDisplayMemberInformation.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Member Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void SearchMember()
        {
            try
            {
                string search =
                    txtSearchMember.Text.Trim();

                DataTable dataTable =
                    memberUI.RetrieveMembersByPhoneNumberAndNameUI(
                        search);

                dgvDisplayMemberInformation.Rows.Clear();

                slNo = 1;

                foreach (DataRow row in dataTable.Rows)
                {
                    string status =
                        Convert.ToInt32(row["MemberIsActive"]) == 1
                        ? "Active"
                        : "Inactive";

                    dgvDisplayMemberInformation.Rows.Add(
                        slNo,
                        Convert.ToInt32(row["MemberId"]),
                        row["MemberName"].ToString(),
                        row["PhoneNo"].ToString(),
                        row["EmailId"].ToString(),
                        status
                    );

                    slNo++;
                }

                dgvDisplayMemberInformation.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Search Member",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tlpAddNewMember_MouseEnter(object sender, EventArgs e)
        {
            this.tlpAddNewMember.BackColor = Color.FromArgb(220, 225, 230);
        }
        private void dgvDisplayMemberInformation_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvDisplayMemberInformation.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
               
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvDisplayMemberInformation.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
            }
        }

        private void dgvDisplayMemberInformation_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvDisplayMemberInformation.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                //dgvShowAllAddRegistrationFees.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvDisplayMemberInformation.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvDisplayMemberInformation_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDisplayMemberInformation.Columns["colUpdate"].Index)
            {
                e.PaintBackground(e.CellBounds, true);

                ButtonRenderer.DrawButton(e.Graphics, e.CellBounds,
                    System.Windows.Forms.VisualStyles.PushButtonState.Normal);

                TextRenderer.DrawText(
                    e.Graphics,
                    "✏️Update",
                    dgvDisplayMemberInformation.Font,
                    e.CellBounds,
                    Color.SlateBlue, // Your desired text color
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;

            }

           


            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDisplayMemberInformation.Columns["colDeactivate"].Index)
            {
                e.PaintBackground(e.CellBounds, true);

                ButtonRenderer.DrawButton(e.Graphics, e.CellBounds,
                    System.Windows.Forms.VisualStyles.PushButtonState.Normal);

                TextRenderer.DrawText(
                    e.Graphics,
                    "Deactivate",
                    dgvDisplayMemberInformation.Font,
                    e.CellBounds,
                    Color.Brown, // Your desired text color
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDisplayMemberInformation.Columns["colMemberProfile"].Index)
            {
                e.PaintBackground(e.CellBounds, true);

                ButtonRenderer.DrawButton(e.Graphics, e.CellBounds,
                    System.Windows.Forms.VisualStyles.PushButtonState.Normal);

                TextRenderer.DrawText(
                    e.Graphics,
                    "🙎‍Profile",
                    dgvDisplayMemberInformation.Font,
                    e.CellBounds,
                    Color.Orange, // Your desired text color
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;
            }

        }

      

        private void txtSearchMember_Click(object sender, EventArgs e)
        {
            searchMemberClickCount =
                ValidationUI.ClearTextBoxWhenClicked(
                    txtSearchMember,
                    searchMemberClickCount);

            txtSearchMember.ForeColor = Color.Black;
        }

        private void picSearchMember_Click(object sender, EventArgs e)
        {
            dgvDisplayMemberInformation.ClearSelection();
         
        }

        private void btnSearchMemberByPhoneNumber_Click(object sender, EventArgs e)
        {
            dgvDisplayMemberInformation.ClearSelection();
        }

        private void picSearchMember_Click_1(object sender, EventArgs e)
        {
            dgvDisplayMemberInformation.ClearSelection();
        }

    

        private void btnSearchMemberByPhoneNumber_Click_1(object sender, EventArgs e)
        {
            dgvDisplayMemberInformation.ClearSelection();
        }

        private void tlpTopTitleAndMemberIconPanal_Click_1(object sender, EventArgs e)
        {
            dgvDisplayMemberInformation.ClearSelection();
        }

        private void tlpDisplayMemberHeaderSection_Click(object sender, EventArgs e)
        {
            dgvDisplayMemberInformation.ClearSelection();
        }

       

        private void lblSubtitleDisplayAllMember_Click_1(object sender, EventArgs e)
        {
            dgvDisplayMemberInformation.ClearSelection();
        }

        private void tlpTopTitleAndSubTitleAndIconInDisplayMember_Click_1(object sender, EventArgs e)
        {
            dgvDisplayMemberInformation.ClearSelection();
        }

      

        private void lblTitleDisplayAllMember_Click(object sender, EventArgs e)
        {
            dgvDisplayMemberInformation.ClearSelection();
        }

        private void tlpMainDisplayMembers_Click(object sender, EventArgs e)
        {
            dgvDisplayMemberInformation.ClearSelection();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpAddNewMember_MouseEnter_1(object sender, EventArgs e)
        {
            this.tlpAddNewMember.BackColor = Color.FromArgb(220, 225, 230);
        }

        private void picAddIcon_MouseEnter(object sender, EventArgs e)
        {
            this.tlpAddNewMember.BackColor = Color.FromArgb(220, 225, 230);
        }

        private void tlpAddNewMember_MouseLeave(object sender, EventArgs e)
        {
            this.tlpAddNewMember.BackColor = Color.FromArgb(236, 240, 243);
        }

        private void picDisplayMemberIcon_Click(object sender, EventArgs e)
        {
            dgvDisplayMemberInformation.ClearSelection();
        }

        private void tlpMemberSearchArea_Click(object sender, EventArgs e)
        {
            dgvDisplayMemberInformation.ClearSelection();
        }

        private void tlpAddNewMember_Enter(object sender, EventArgs e)
        {
            dgvDisplayMemberInformation.ClearSelection();
        }

        private void picAddIcon_Click(object sender, EventArgs e)
        {
            dgvDisplayMemberInformation.ClearSelection();
        }

        private void tlpAddNewMember_Click(object sender, EventArgs e)
        {
            AdminMainForm.OpenChildForm(new FrmMemberRegistration());
        }

        private void dgvDisplayMemberInformation_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string columnName =
                dgvDisplayMemberInformation.Columns[e.ColumnIndex].Name;

            // ==========================================
            // Phone No / Email Id Edit
            // ==========================================
            if (columnName == "colPhoneNo" ||
                columnName == "colEmailId")
            {
                dgvDisplayMemberInformation.CurrentCell =
                    dgvDisplayMemberInformation.Rows[e.RowIndex]
                    .Cells[e.ColumnIndex];

                dgvDisplayMemberInformation.BeginEdit(true);
            }

            // ==========================================
            // Update Member
            // ==========================================
            else if (columnName == "colUpdate")
            {
                try
                {
                    dgvDisplayMemberInformation.EndEdit();

                    int memberId = Convert.ToInt32(
                        dgvDisplayMemberInformation.Rows[e.RowIndex]
                        .Cells["colMemberId"]
                        .Value
                    );

                    string phoneNo =
                        dgvDisplayMemberInformation.Rows[e.RowIndex]
                        .Cells["colPhoneNo"]
                        .Value == null
                        ? ""
                        : dgvDisplayMemberInformation.Rows[e.RowIndex]
                        .Cells["colPhoneNo"]
                        .Value.ToString()
                        .Trim();

                    string emailId =
                        dgvDisplayMemberInformation.Rows[e.RowIndex]
                        .Cells["colEmailId"]
                        .Value == null
                        ? ""
                        : dgvDisplayMemberInformation.Rows[e.RowIndex]
                        .Cells["colEmailId"]
                        .Value.ToString()
                        .Trim();

                    string message =
                        memberUI.UpdateMemberContactInfoUI(
                            memberId,
                            phoneNo,
                            emailId
                        );

                    MessageBox.Show(
                        message,
                        "Update Member",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    RetrieveMemberDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Update Member",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }

            // ==========================================
            // Deactivate Member
            // ==========================================
            else if (columnName == "colDeactivate")
            {
                try
                {
                    int memberId = Convert.ToInt32(
                        dgvDisplayMemberInformation.Rows[e.RowIndex]
                        .Cells["colMemberId"]
                        .Value
                    );

                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to deactivate this member?",
                        "Deactivate Member",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        string message =
                            memberUI.DeactivateMemberUI(memberId);

                        MessageBox.Show(
                            message,
                            "Deactivate Member",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        RetrieveMemberDetails();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Deactivate Member",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }

            // ==========================================
            // Member Profile
            // ==========================================
            else if (columnName == "colMemberProfile")
            {
                try
                {
                    int memberId = Convert.ToInt32(
                        dgvDisplayMemberInformation.Rows[e.RowIndex]
                        .Cells["colMemberId"]
                        .Value
                    );

                    MemberAllDetailsUI memberAllDetailsUI =
                        new MemberAllDetailsUI();

                    MemberAllDetailsUI member =
                        memberAllDetailsUI.GetMemberDetailsByMemberId(
                            memberId
                        );

                    FrmMemberProfile frmMemberProfile =
                        new FrmMemberProfile(member);

                    AdminMainForm.OpenChildForm(
                        frmMemberProfile
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error:\n\n" +
                        ex.Message +
                        "\n\nStack Trace:\n" +
                        ex.StackTrace,
                        "Profile Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            SearchMember();
        }
    }
}
