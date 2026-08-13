using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem.FormsSuperAdmin.Financials
{
    public partial class FrmSAPayment : Form
    {
        public FrmSAPayment()
        {
            InitializeComponent();
        }

        private void FrmSAPayment_Load(object sender, EventArgs e)
        {
            dgvPaymentHistory.ClearSelection();
        }

        private void dgvPaymentHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tlpPaymentHistory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSAPayment_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void dgvPaymentHistory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvPaymentHistory.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvPaymentHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvPaymentHistory_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvPaymentHistory.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvPaymentHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;



            }
        }

        private void dgvPaymentHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPaymentHistory.Columns[e.ColumnIndex].Name == "colSerialNo")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Navy;

                }
            }

            if (dgvPaymentHistory.Columns[e.ColumnIndex].Name == "colPaymentDate")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Green;

                }
            }

            if (dgvPaymentHistory.Columns[e.ColumnIndex].Name == "colAmount")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Navy;

                }
            }
        }

        
    }
}
