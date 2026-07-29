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
using System.Drawing.Drawing2D;

namespace GymManagementSystem.FORMS.Trainer
{
    public partial class FrmTrainer : Form
    {
        public FrmTrainer()
        {
            InitializeComponent();
        }
        private TableLayoutPanel selectedTLP = null;
        private void lblGeneralTrainer_Click(object sender, EventArgs e)
        {

        }

        private void FrmTrainer_Load(object sender, EventArgs e)
        {
           
            //For Textbox Text Deselection
            txtSearchBar.Select(0, 0);
            txtSearchBar.DeselectAll();
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
                    dgvTrainerDetails.Columns["colEmployeeId"].DataPropertyName = "EmployeeId";
                    dgvTrainerDetails.Columns["colTrainerId"].DataPropertyName = "TrainerId";
                    dgvTrainerDetails.Columns["colTrainerName"].DataPropertyName = "TrainerName";
                    dgvTrainerDetails.Columns["colSpecialization"].DataPropertyName = "Specialization";
                    dgvTrainerDetails.Columns["colTrainerType"].DataPropertyName = "TrainerType";
                    dgvTrainerDetails.Columns["colDocument"].DataPropertyName = "Document";
                    dgvTrainerDetails.Columns["colPhoneNo"].DataPropertyName = "PhoneNo";
                    dgvTrainerDetails.Columns["colGender"].DataPropertyName = "Gender";
                    for ( int i = 0 ; i < dgvTrainerDetails.Rows.Count ; i++)
                    {
                        dgvTrainerDetails.Rows[i].Cells["colProfile"].Value = "Profile";
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
        private void dgvTrainerDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
        
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvTrainerDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }


        }

        private void dgvTrainerDetails_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
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
                txtSearchBar.ForeColor = Color.Black;
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
        

        private void dgvTrainerDetails_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvTrainerDetails.Columns["colProfile"].Index)
            {
                e.PaintBackground(e.CellBounds, true);

                ButtonRenderer.DrawButton(e.Graphics, e.CellBounds,
                    System.Windows.Forms.VisualStyles.PushButtonState.Normal);

                
                Font fixedFont = new Font("Segoe UI", 10F, FontStyle.Bold);

                TextRenderer.DrawText(
                    e.Graphics,
                    "Profile",
                    fixedFont,
                    e.CellBounds,
                    Color.RoyalBlue,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;

            }
        }

        private void tlpSubmit_Click(object sender, EventArgs e)
        {

        }

        private void tlpTrainerTitleAndSubTitle_Click(object sender, EventArgs e)
        {
            dgvTrainerDetails.ClearSelection();
        }

        private void tlpPersonalTrainer_Click(object sender, EventArgs e)
        {
            selectedTLP = tlpPersonalTrainer;
            //tlpPersonalTrainer.BackColor = Color.FromArgb(165, 175, 240);
            tlpPersonalTrainer.BackColor = Color.RoyalBlue;
            lblPersonalTrainer.ForeColor = Color.White;
            tlpGeneralTrainer.BackColor = Color.FromArgb(210,215,245);
            lblGeneralTrainer.ForeColor = Color.Blue;

        }

        private void tlpPersonalTrainer_MouseEnter(object sender, EventArgs e)
        {
           if(selectedTLP!=tlpPersonalTrainer)
           {
               tlpPersonalTrainer.BackColor = Color.FromArgb(180,188,245);
           }
        }

        private void tlpPersonalTrainer_MouseLeave(object sender, EventArgs e)
        {
            if (selectedTLP != tlpPersonalTrainer)
            {
                tlpPersonalTrainer.BackColor = Color.FromArgb(210,215,255);
            }
        }

        private void tlpGeneralTrainer_Click(object sender, EventArgs e)
        {
            selectedTLP = tlpGeneralTrainer;
            //tlpGeneralTrainer.BackColor = Color.FromArgb(165, 175, 240);
            tlpGeneralTrainer.BackColor = Color.RoyalBlue;
            lblGeneralTrainer.ForeColor = Color.White;
            tlpPersonalTrainer.BackColor = Color.FromArgb(210, 215, 245);
            lblPersonalTrainer.ForeColor = Color.Blue;
        }

        private void tlpGeneralTrainer_MouseEnter(object sender, EventArgs e)
        {
            if (selectedTLP != tlpGeneralTrainer)
            {
                tlpGeneralTrainer.BackColor = Color.FromArgb(180, 188, 245);
            }
        }


        private void tlpGeneralTrainer_MouseLeave(object sender, EventArgs e)
        {
            if (selectedTLP != tlpGeneralTrainer)
            {
                tlpGeneralTrainer.BackColor = Color.FromArgb(210, 215, 255);
            }

            
        }

        private void tlpGeneralTrainerPicture_Paint(object sender, PaintEventArgs e)
        {

        }
        private const string PLACEHOLDER_TEXT = "Enter Mobile No.";

        private void tlpGeneralTrainer_MouseHover(object sender, EventArgs e)
        {

        }

        private void tlpPersonalTrainer_MouseHover(object sender, EventArgs e)
        {

        }

        private void tlpGeneralTrainer_Paint(object sender, PaintEventArgs e)
        {
        //    ControlPaint.DrawBorder(
        //e.Graphics,
        //tlpGeneralTrainer.ClientRectangle,
        //Color.Blue,       // Border color
        //ButtonBorderStyle.Solid);
        }

        private void tlpPersonalTrainer_Paint(object sender, PaintEventArgs e)
        {
        //    ControlPaint.DrawBorder(
        //e.Graphics,
        //tlpGeneralTrainer.ClientRectangle,
        //Color.Blue,       // Border color
        //ButtonBorderStyle.Solid);
        }

        
    }
}
    
