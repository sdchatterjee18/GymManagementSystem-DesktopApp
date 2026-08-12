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
using System.Windows.Forms;
using GymManagementSystem.FORMS.RegistrationFee.UI;


namespace GymManagementSystem.FORMS.RegistrationFee
{
    public partial class FrmRegistrationFees : Form
    {
        private DataTable RegistrationDataTable;
        public FrmRegistrationFees()
        {
            InitializeComponent();
            
        }

 

        private void FrmRegistrationFees_Load(object sender, EventArgs e)
        {
           RetrieveRegistrationFees();
        
        }


        private void RetrieveRegistrationFees()
        {
            try
            {
                RegistrationFeeUI registrationFeeUI = new RegistrationFeeUI();

                RegistrationDataTable =
                    registrationFeeUI.RetrieveRegistrationFeesUI();

                dgvShowAllAddRegistrationFees.AutoGenerateColumns = false;
                dgvShowAllAddRegistrationFees.Rows.Clear();

                int serialNo = 1;

                foreach (DataRow dataRow in RegistrationDataTable.Rows)
                {
                    int rowIndex = dgvShowAllAddRegistrationFees.Rows.Add();

                    dgvShowAllAddRegistrationFees.Rows[rowIndex]
                        .Cells["colSLNO"].Value = serialNo++;

                    dgvShowAllAddRegistrationFees.Rows[rowIndex]
                        .Cells["colFeeAmount"].Value =
                         Convert.ToDecimal(dataRow["FeeAmount"]);

                    dgvShowAllAddRegistrationFees.Rows[rowIndex]
                        .Cells["colCreatedAt"].Value =
                        Convert.ToDateTime(dataRow["CreatedAt"]).ToString("dd-MM-yyyy");

                    dgvShowAllAddRegistrationFees.Rows[rowIndex]
                        .Cells["colStatus"].Value = (dataRow["IsActive"]).ToString();


                }

                dgvShowAllAddRegistrationFees.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }




        private void FrmRegistrationFees_Resize(object sender, EventArgs e)
        {
           
        }


        private void pnlClickAddNewFegistrationFees_Click(object sender, EventArgs e)
        {
            dgvShowAllAddRegistrationFees.ClearSelection();

            FrmAddRegistrationFee frmAddRegistrationFee =
                new FrmAddRegistrationFee();

            frmAddRegistrationFee.ShowDialog();

            RetrieveRegistrationFees();
        }
        private void dgvShowAllAddRegistrationFees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvShowAllAddRegistrationFees.Columns[e.ColumnIndex].Name == "colStatus")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    if (status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                    {
                        e.CellStyle.ForeColor = Color.Green;
                        e.CellStyle.Font = new Font(dgvShowAllAddRegistrationFees.Font, FontStyle.Bold);
                    }
                    else if (status.Equals("Inactive", StringComparison.OrdinalIgnoreCase))
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.Font = new Font(dgvShowAllAddRegistrationFees.Font, FontStyle.Bold);
                    }
                }
            }
        }

        private void tlpAddNewRegistrationFees_MouseEnter(object sender, EventArgs e)
        {
            this.tlpAddNewRegistrationFees.BackColor = Color.FromArgb(220, 225, 230);
        }

        private void tlpAddNewRegistrationFees_MouseLeave(object sender, EventArgs e)
        {
            this.tlpAddNewRegistrationFees.BackColor = Color.FromArgb(236, 240, 243);
        }

        private void picRegistrationFeesIcon_Click(object sender, EventArgs e)
        {
            dgvShowAllAddRegistrationFees.ClearSelection();
        }

        private void tlpMainAddRegistrationFee_Click(object sender, EventArgs e)
        {
            dgvShowAllAddRegistrationFees.ClearSelection();
        }

        private void tlpTopTitleAndSubTitleAndIcon_Click(object sender, EventArgs e)
        {
            dgvShowAllAddRegistrationFees.ClearSelection();
        }

        private void lblRegistrationFeesTitle_Click(object sender, EventArgs e)
        {
            dgvShowAllAddRegistrationFees.ClearSelection();
        }

        private void lblManageRegistrationFeesSubTitle_Click(object sender, EventArgs e)
        {
            dgvShowAllAddRegistrationFees.ClearSelection();
        }

        private void tlpTopRegistrationFeesAndAddNewRegistrationFees_Click(object sender, EventArgs e)
        {
            dgvShowAllAddRegistrationFees.ClearSelection();
        }

      



        private void dgvShowAllAddRegistrationFees_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvShowAllAddRegistrationFees.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
            
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvShowAllAddRegistrationFees.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvShowAllAddRegistrationFees_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvShowAllAddRegistrationFees.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
              
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvShowAllAddRegistrationFees.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
            }

        }

    }
}
