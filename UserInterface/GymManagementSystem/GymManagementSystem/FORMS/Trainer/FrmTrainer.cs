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
using System.IO;

namespace GymManagementSystem.FORMS.Trainer
{
    public partial class FrmTrainer : Form
    {
        public FrmTrainer()
        {
            InitializeComponent();
        }

        private void lblGeneralTrainer_Click(object sender, EventArgs e)
        {

        }

        private void FrmTrainer_Load(object sender, EventArgs e)
        {
            dgvTrainerDetails.AutoGenerateColumns = false;
            RetrieveTrainerDetails();

        }

        private void RetrieveTrainerDetails()
        {
            string CS=ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                using (SqlCommand sqlCommand = new SqlCommand("spGetAllTrainerEmployeeDetails", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dgvTrainerDetails.DataSource = dataTable;
                    dgvTrainerDetails.Columns["EmployeeId"].DataPropertyName = "EmployeeId";
                    dgvTrainerDetails.Columns["TrainerId"].DataPropertyName = "TrainerId";
                    dgvTrainerDetails.Columns["TrainerName"].DataPropertyName = "TrainerName";
                    dgvTrainerDetails.Columns["Specialization"].DataPropertyName = "Specialization";
                    dgvTrainerDetails.Columns["TrainerType"].DataPropertyName = "TrainerType";
                    dgvTrainerDetails.Columns["Document"].DataPropertyName = "Document";
                    dgvTrainerDetails.Columns["PhoneNo"].DataPropertyName = "PhoneNo";
                    dgvTrainerDetails.Columns["Gender"].DataPropertyName = "Gender";
                    for ( int i = 0 ; i < dgvTrainerDetails.Rows.Count ; i++)
                    {
                        dgvTrainerDetails.Rows[i].Cells["Profile"].Value = "Profile";
                    }
                    
                }
            }
            catch (Exception ex)
            {
                dgvTrainerDetails.DataSource = null;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void dgvTrainerDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
        }

        private void pnlGeneralTrainer_MouseEnter(object sender, EventArgs e)
        {
            pnlGeneralTrainer.BackColor = Color.DimGray;
            pnlGeneralTrainer.ForeColor = Color.Black;
        }

        private void pnlGeneralTrainer_MouseHover(object sender, EventArgs e)
        {
            pnlGeneralTrainer.BackColor = Color.DimGray;
            pnlGeneralTrainer.ForeColor = Color.Black;

        }

        private void pnlGeneralTrainer_MouseLeave(object sender, EventArgs e)
        {
            pnlGeneralTrainer.BackColor = Color.Transparent;
            pnlGeneralTrainer.ForeColor = Color.Black;
        }

        private void pnlPersonalTrainer_MouseEnter(object sender, EventArgs e)
        {
            pnlPersonalTrainer.BackColor = Color.DimGray;
            pnlPersonalTrainer.ForeColor = Color.Black;

        }

        private void pnlPersonalTrainer_MouseHover(object sender, EventArgs e)
        {
            pnlPersonalTrainer.BackColor = Color.DimGray;
            pnlPersonalTrainer.ForeColor = Color.Black;
        }

        private void pnlPersonalTrainer_MouseLeave(object sender, EventArgs e)
        {
            pnlPersonalTrainer.BackColor = Color.Transparent;
            pnlPersonalTrainer.ForeColor = Color.Black;
        }

        private void dgvTrainerDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvTrainerDetails.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.DimGray;
                dgvTrainerDetails.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.White;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvTrainerDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }


        }

        private void dgvTrainerDetails_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvTrainerDetails.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.LightGray;
                dgvTrainerDetails.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvTrainerDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
                dgvTrainerDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Empty;
            }


        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchBar_Click(object sender, EventArgs e)
        {
            int SearchClick = 1;
            if (SearchClick == 1)
            {
                txtSearchBar.Clear();
            }
        }

        private void tlpTrainer_Click(object sender, EventArgs e)
        {
            dgvTrainerDetails.ClearSelection();
        }

        private void tlpTrainerDetails_Click(object sender, EventArgs e)
        {
            dgvTrainerDetails.ClearSelection();
        }

        private void tlpSelectTrainer_Click(object sender, EventArgs e)
        {
            dgvTrainerDetails.ClearSelection();
        }

        private void tlpSearchSection_Click(object sender, EventArgs e)
        {
            dgvTrainerDetails.ClearSelection();
        }

        private void tlpShowTrainers_Click(object sender, EventArgs e)
        {
            dgvTrainerDetails.ClearSelection();
        }
    }
}
    
