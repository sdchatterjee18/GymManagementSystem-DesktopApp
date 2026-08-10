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
using GymManagementSystem.FORMS.Payments.UI;

namespace GymManagementSystem.FORMS.Payments
{
    public partial class FrmDisplayPayments : Form
    {
        public FrmDisplayPayments()
        {
            InitializeComponent();
        }

        private void FrmDisplayPayments_Load(object sender, EventArgs e)
        {
            LoadSubscriptionPaymentDetails();
            dgvPaymentsManagement.ClearSelection();
        }

        //Retrieve Data From PaymentUI 

        private void LoadSubscriptionPaymentDetails()
        {
            PaymentUI paymentUI = new PaymentUI();
            List<PaymentUI> PaymentDetails = paymentUI.RetrieveAllMemberSubscriptionPaymentDetailsUI();
            int SerialNo = 1;
            foreach (PaymentUI PaymentDetail in PaymentDetails)
            {
                dgvPaymentsManagement.Rows.Add
                    (
                    SerialNo++,
                    PaymentDetail.MemberShipPlanName,
                    PaymentDetail.PaymentDate,
                    PaymentDetail.PaymentMethod,
                    PaymentDetail.Amount,
                    PaymentDetail.FeesType
                    );
            }

        }

        private void dgvPaymentsManagement_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvPaymentsManagement.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvPaymentsManagement.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvPaymentsManagement_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvPaymentsManagement.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);    
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvPaymentsManagement.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
                
            }
        }

        private void dgvPaymentsManagement_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvPaymentsManagement.Columns[e.ColumnIndex].Name == "colFeesType")
            {

                e.CellStyle.ForeColor = Color.Green;
            }

            if (dgvPaymentsManagement.Columns[e.ColumnIndex].Name == "colSerialNo")
            {

                e.CellStyle.ForeColor = Color.Navy;
            }

        }

        private void txtEnterPlanName_Click(object sender, EventArgs e)
        {
            txtEnterPlanName.Clear();
            txtEnterPlanName.ForeColor = Color.Black;
            txtEnterPlanName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
        }



    }


}
