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
using GymManagementSystem.FORMS.Trainer.UI;

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

            RetrieveAllTrainer();
            
        }

        //Retrieve All Trainers
        private void RetrieveAllTrainer()
        {
            DataTable AllTrainers = null;
            try
            {
                TrainerUI TrainerUI = new TrainerUI();
                AllTrainers = TrainerUI.RetrieveAllTrainerUI();
                int Sl_No = 1;
                foreach (DataRow row in AllTrainers.Rows)
                {
                    dgvTrainerDetails.Rows.Add(
                        Sl_No++,
                        row["TrainerName"].ToString(),
                        row["Specialization"].ToString(),
                        row["TrainerType"].ToString(),
                        row["Document"].ToString(),
                        row["PhoneNo"].ToString(),
                        row["Gender"].ToString()
                        );
                }

            }
            catch (Exception ex)
            {
                AllTrainers = null;
            }
        }

        //Retrieve Trainer By PhoneNO
        private void RetrieveTrainerByPhoneNO()
        {
            DataTable RetieveTrainerByPhoneNo = null;
            try
            {
                TrainerUI TrainerUI = new TrainerUI();
                RetieveTrainerByPhoneNo = TrainerUI.RetrieveTrainerByPhoneNoUI(txtSearchBar.Text);
                int slNo = 1;
                foreach (DataRow row in RetieveTrainerByPhoneNo.Rows)
                {
                    dgvTrainerDetails.Rows.Add(
                        slNo++,
                        row["TrainerName"].ToString(),
                        row["Specialization"].ToString(),
                        row["TrainerType"].ToString(),
                        row["Document"].ToString(),
                        row["PhoneNo"].ToString(),
                        row["GenderName"].ToString()
                        );
                }

            }
            catch (Exception ex)
            {
                RetieveTrainerByPhoneNo = null;
            }
        }

        //Retrieve General Trainers
        private void RetrieveGerenalTrainer()
        {
            DataTable GerenalTrainers = null;
            try
            {
                TrainerUI TrainerUI = new TrainerUI();
                GerenalTrainers = TrainerUI.RetrieveGeneralTrainerUI();
                int Sl_no=1;
                foreach (DataRow row in GerenalTrainers.Rows)
                {
                    dgvTrainerDetails.Rows.Add(
                        Sl_no++,
                        row["TrainerName"].ToString(),
                        row["Specialization"].ToString(),
                        row["TrainerType"].ToString(),
                        row["Document"].ToString(),
                        row["PhoneNo"].ToString(),
                        row["GenderName"].ToString()
                        );
                }

            }
            catch (Exception ex)
            {
                GerenalTrainers = null;
            }
        }

        //Retrieve Personal Trainers
        private void RetrievePersonalTrainer()
        {
            DataTable PersonalTrainers = null;
            try
            {
                TrainerUI TrainerUI = new TrainerUI();
                PersonalTrainers = TrainerUI.RetrievePersonalTrainerUI();
                int Sl_no = 1;
                foreach (DataRow row in PersonalTrainers.Rows)
                {
                    dgvTrainerDetails.Rows.Add(
                        Sl_no++,
                        row["TrainerName"].ToString(),
                        row["Specialization"].ToString(),
                        row["TrainerType"].ToString(),
                        row["Document"].ToString(),
                        row["PhoneNo"].ToString(),
                        row["GenderName"].ToString()
                        );
                }

            }
            catch (Exception ex)
            {
                PersonalTrainers = null;
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
            dgvTrainerDetails.Rows.Clear();
            dgvTrainerDetails.ReadOnly = true;
            RetrieveTrainerByPhoneNO();
        }
        int SearchClick = 1;
        private void txtSearchBar_Click(object sender, EventArgs e)
        {
           
            if (SearchClick == 1)
            {
                txtSearchBar.Clear();
                txtSearchBar.ForeColor = Color.Black;
                SearchClick++;
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
                Font fixedFont = new Font("Segoe UI", 9F,FontStyle.Regular);
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
            tlpPersonalTrainer.BackColor = Color.FromArgb(14, 28, 65);
            lblPersonalTrainer.ForeColor = Color.White;
            tlpGeneralTrainer.BackColor = Color.MidnightBlue;
            lblGeneralTrainer.ForeColor = Color.White;

            dgvTrainerDetails.Rows.Clear();
            dgvTrainerDetails.ReadOnly = false;
            RetrievePersonalTrainer();

        }

        private void tlpPersonalTrainer_MouseEnter(object sender, EventArgs e)
        {
           if(selectedTLP!=tlpPersonalTrainer)
           {
               tlpPersonalTrainer.BackColor = Color.DarkBlue;
           }
        }

        private void tlpPersonalTrainer_MouseLeave(object sender, EventArgs e)
        {
            if (selectedTLP != tlpPersonalTrainer)
            {
                tlpPersonalTrainer.BackColor = Color.MidnightBlue;
            }
        }

        private void tlpGeneralTrainer_Click(object sender, EventArgs e)
        {
            selectedTLP = tlpGeneralTrainer;
            tlpGeneralTrainer.BackColor = Color.FromArgb(14, 28, 65);
            lblGeneralTrainer.ForeColor = Color.White;
            tlpPersonalTrainer.BackColor = Color.MidnightBlue;
            lblPersonalTrainer.ForeColor = Color.White;

            dgvTrainerDetails.Rows.Clear();
            dgvTrainerDetails.ReadOnly = false;
            RetrieveGerenalTrainer();
        }

        private void tlpGeneralTrainer_MouseEnter(object sender, EventArgs e)
        {
            if (selectedTLP != tlpGeneralTrainer)
            {
                tlpGeneralTrainer.BackColor = Color.DarkBlue;
            }
        }


        private void tlpGeneralTrainer_MouseLeave(object sender, EventArgs e)
        {
            if (selectedTLP != tlpGeneralTrainer)
            {
                tlpGeneralTrainer.BackColor = Color.MidnightBlue;
            }

            
        }

        private void tlpGeneralTrainerPicture_Paint(object sender, PaintEventArgs e)
        {

        }
        private const string PLACEHOLDER_TEXT = "Enter Mobile No.";

        private void tlpGeneralTrainer_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void tlpPersonalTrainer_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            dgvTrainerDetails.Rows.Clear();
            dgvTrainerDetails.ReadOnly = false;
            RetrieveTrainerByPhoneNO();
        }

        
    }
}
    
