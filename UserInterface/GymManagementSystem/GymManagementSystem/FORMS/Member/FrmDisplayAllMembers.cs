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

namespace GymManagementSystem.FORMS.Member
{
    public partial class FrmDisplayAllMembers : Form
    {
        private FrmMainLayout AdminMainForm;
        public FrmDisplayAllMembers(FrmMainLayout mainform)
        {
            InitializeComponent();
            AdminMainForm = mainform;
        }

        private void FrmDisplayAllMembers_Load(object sender, EventArgs e)
        {
            RetrieveMemberDetails();
        }


        private void RetrieveMemberDetails()
        {

            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;

            DataTable dataTable = new DataTable();
            try
            {
                sqlConnection = new SqlConnection(CS);
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("spRetrieveRegisterMemberDetails", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    int a = 1;
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        string status = Convert.ToInt32(sqlDataReader["MemberIsActive"]) == 1
                   ? "Active"
                   : "Inactive";
                        dgvDisplayMemberInformation.Rows.Add(a,
                            (sqlDataReader["MemberName"]).ToString(),
                            (sqlDataReader["PhoneNo"]).ToString(),
                           status
                            );
                        a++;
                    }


                }
                dgvDisplayMemberInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
               
                dgvDisplayMemberInformation.ClearSelection();
            }

            catch (Exception exc)
            {

            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }

        }



        private void tlpAddNewMember_MouseEnter(object sender, EventArgs e)
        {
            this.tlpAddNewMember.BackColor = Color.FromArgb(220, 225, 230);
        }

        private void dgvDisplayMemberInformation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDisplayMemberInformation.Columns[e.ColumnIndex].Name == "colIsActive")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    if (status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                    {
                        e.CellStyle.ForeColor = Color.Green;
                        e.CellStyle.Font = new Font(dgvDisplayMemberInformation.Font, FontStyle.Bold);
                    }
                    else if (status.Equals("Inactive", StringComparison.OrdinalIgnoreCase))
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.Font = new Font(dgvDisplayMemberInformation.Font, FontStyle.Bold);
                    }
                }
            }
            if (dgvDisplayMemberInformation.Columns[e.ColumnIndex].Name == "colUpdate")
            {
                e.CellStyle.ForeColor = Color.Red;
                e.CellStyle.Font = new Font(dgvDisplayMemberInformation.Font, FontStyle.Bold);
            }
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

        private void txtSearchMember_Click_1(object sender, EventArgs e)
        {

            dgvDisplayMemberInformation.ClearSelection();
            txtSearchMember.Clear();
            txtSearchMember.ForeColor = Color.Black;
        
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

        private void lblAddNewMember_Click(object sender, EventArgs e)
        {
            dgvDisplayMemberInformation.ClearSelection();
        }

        private void tlpAddNewMember_Click(object sender, EventArgs e)
        {
            AdminMainForm.OpenChildForm(new FrmMemberRegistration());
        }

        private void dgvDisplayMemberInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvDisplayMemberInformation.Columns[e.ColumnIndex].Name == "colMemberProfile")
            {
              
                    AdminMainForm.OpenChildForm(new FrmMemberProfile());
            }
        }

       




       
        

    }
}
