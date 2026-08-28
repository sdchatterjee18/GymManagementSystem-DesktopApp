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
using GymManagementSystem.Common;

namespace GymManagementSystem.FORMS.Payments
{
    public partial class FrmDisplayPayments : Form
    {
        public FrmDisplayPayments()
        {
            InitializeComponent();
            LookupUI.EnableDoubleBuffering(dgvPaymentsManagement);
        }
        int clickCountTxtSearch = 0;
        private void FrmDisplayPayments_Load(object sender, EventArgs e)
        {
            LoadSubscriptionPaymentDetails();
            dgvPaymentsManagement.ClearSelection();
            this.ActiveControl = null;
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
                    PaymentDetail.MemberName,
                    PaymentDetail.PhoneNo,
                    PaymentDetail.MemberShipPlanName,
                    PaymentDetail.PaymentDate.Date,
                    PaymentDetail.PaymentMethod,
                    "₹ "+
                    PaymentDetail.Amount,
                    PaymentDetail.FeesType
                    );
            }

        }

        private void LoadSpecificMemberSubscriptionPaymentDetails()
        {
            
            PaymentUI paymentUI = new PaymentUI();
            List<PaymentUI> SubscriptionPaymentDetails = paymentUI.RetrieveSpecificMemberSubscriptionPaymentDetailsUI(txtPhoneNo.Text);
            int SerialNo = 1;
            foreach (PaymentUI PaymentDetail in SubscriptionPaymentDetails)
            {
                dgvPaymentsManagement.Rows.Add
                    (
                    SerialNo++,
                    PaymentDetail.MemberName,
                    PaymentDetail.PhoneNo,
                    PaymentDetail.MemberShipPlanName,
                    PaymentDetail.PaymentDate,
                    PaymentDetail.PaymentMethod,
                    "₹ "+
                    PaymentDetail.Amount,
                    PaymentDetail.FeesType
                    );
            }
        }

        private void dgvPaymentsManagement_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvPaymentsManagement.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvPaymentsManagement_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvPaymentsManagement.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
                
            }
        }
        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            dgvPaymentsManagement.Rows.Clear();
            LoadSpecificMemberSubscriptionPaymentDetails();
        }

        private void txtPhoneNo_Click(object sender, EventArgs e)
        {
            clickCountTxtSearch = ValidationUI.ClearTextBoxWhenClicked(txtPhoneNo,clickCountTxtSearch);
        }

        private void dgvPaymentsManagement_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string columnName = dgvPaymentsManagement.Columns[e.ColumnIndex].Name;

            if (columnName == "colSerialNo")
            {
                e.CellStyle.ForeColor = Color.Navy;
            }
            else if (columnName == "colAmount")
            {
                e.CellStyle.ForeColor = Color.Red;
            }
            else if (columnName == "colPaymentMethod")
            {
                e.CellStyle.ForeColor = Color.Blue;
            }
            else if (columnName == "colFeesType")
            {
                e.CellStyle.ForeColor = Color.Green;
            }
        }



    }


}
