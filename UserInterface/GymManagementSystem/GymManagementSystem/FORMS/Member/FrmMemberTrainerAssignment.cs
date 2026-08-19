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
using GymManagementSystem.FORMS.Member.UI;

namespace GymManagementSystem.FORMS.Member
{
    public partial class FrmMemberTrainerAssignment : Form
    {
        public FrmMemberTrainerAssignment()
        {
            InitializeComponent();
        }

        private void FrmMemberTrainerAssignment_Load(object sender, EventArgs e)
        {
            dgvMemberTrainerAssignmentDetails.Columns["colSLNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            txtSearchBar.Select(0, 0);
            txtSearchBar.DeselectAll();

            RetrieveMemberTrainerDetails();
        }

        private void txtSearchBar_Click(object sender, EventArgs e)
        {
            int SearchBarClick = 1;
            if (SearchBarClick == 1)
            {
                txtSearchBar.Clear();
                txtSearchBar.ForeColor = Color.Black;
            }
        }
        

        private void dgvMemberTrainerAssignmentDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvMemberTrainerAssignmentDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }


        }

        private void dgvMemberTrainerAssignmentDetails_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvMemberTrainerAssignmentDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;

                string colName = dgvMemberTrainerAssignmentDetails.Columns[e.ColumnIndex].Name;

                if (colName == "colSl_No")
                {
                    dgvMemberTrainerAssignmentDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.FromArgb(160, 170, 240);
                }
            }

        }

        private void tlpSearchBar_Click(object sender, EventArgs e)
        {
            dgvMemberTrainerAssignmentDetails.ClearSelection();
        }

        private void tlpSearch_Click(object sender, EventArgs e)
        {
            dgvMemberTrainerAssignmentDetails.ClearSelection();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            dgvMemberTrainerAssignmentDetails.ClearSelection();
        }

        private void tlpMemberTrainerAssignment_Click(object sender, EventArgs e)
        {
            dgvMemberTrainerAssignmentDetails.ClearSelection();
        }

        private void tlpHeader_Click(object sender, EventArgs e)
        {
            dgvMemberTrainerAssignmentDetails.ClearSelection();
        }

        private void tlpTitleAndSubTitle_Click(object sender, EventArgs e)
        {
            dgvMemberTrainerAssignmentDetails.ClearSelection();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {
            dgvMemberTrainerAssignmentDetails.ClearSelection();
        }

        private void lblSubTitle_Click(object sender, EventArgs e)
        {
            dgvMemberTrainerAssignmentDetails.ClearSelection();
        }

        private void picMemberTrainerAssignment_Click(object sender, EventArgs e)
        {
            dgvMemberTrainerAssignmentDetails.ClearSelection();
        }
        private void RetrieveMemberTrainerDetails()
        {

            try
            {
                MemberAllDetailsUI memberAllDetailsUI = new MemberAllDetailsUI();

                DataTable dataTable = memberAllDetailsUI.RetrieveAssignTrainerToMemberDetailsUI();




                int SerialNo = 1;

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    int RowIndex = dgvMemberTrainerAssignmentDetails.Rows.Add();
                    dgvMemberTrainerAssignmentDetails.Rows[RowIndex].Cells["colSLNo"].Value = SerialNo++;
                    dgvMemberTrainerAssignmentDetails.Rows[RowIndex].Cells["colSLNo"].Style.ForeColor = Color.RoyalBlue;
                    dgvMemberTrainerAssignmentDetails.Rows[RowIndex].Cells["colMemberName"].Value = dataRow["MemberName"].ToString();
                    dgvMemberTrainerAssignmentDetails.Rows[RowIndex].Cells["colPhoneNo"].Value = dataRow["PhoneNo"].ToString();
                    dgvMemberTrainerAssignmentDetails.Rows[RowIndex].Cells["colTrainerName"].Value = dataRow["TrainerName"].ToString();

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Search by Phone Number
        private void SearchMemberByPhoneNumberInTextBox()
        {
            string SearchData = (txtSearchBar.Text.Trim()).ToString();

            try
            {
                MemberAllDetailsUI memberAllDetailsUI =
                    new MemberAllDetailsUI();

                DataTable dataTable =
                    memberAllDetailsUI.GetMemberTrainerAssignmentsByPhoneNo(SearchData);

                // Clear old data
                dgvMemberTrainerAssignmentDetails.Rows.Clear();

            

                int SerialNo = 1;

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    int RowIndex =
                        dgvMemberTrainerAssignmentDetails.Rows.Add();

                    dgvMemberTrainerAssignmentDetails.Rows[RowIndex]
                        .Cells["colSLNo"].Value = SerialNo++;

                    dgvMemberTrainerAssignmentDetails.Rows[RowIndex]
                        .Cells["colSLNo"].Style.ForeColor =
                        Color.RoyalBlue;

                    dgvMemberTrainerAssignmentDetails.Rows[RowIndex]
                        .Cells["colMemberName"].Value =
                        dataRow["MemberName"].ToString();

                    dgvMemberTrainerAssignmentDetails.Rows[RowIndex]
                        .Cells["colPhoneNo"].Value =
                        dataRow["PhoneNo"].ToString();

                    dgvMemberTrainerAssignmentDetails.Rows[RowIndex]
                        .Cells["colTrainerName"].Value =
                        dataRow["TrainerName"].ToString();
                }
            }
            catch (Exception ex)
            {
                
            }


        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            SearchMemberByPhoneNumberInTextBox();
        }    
    }
}
