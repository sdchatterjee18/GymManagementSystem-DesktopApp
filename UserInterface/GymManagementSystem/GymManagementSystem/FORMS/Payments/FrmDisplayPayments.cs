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


           // LoadSubscriptionPayments();
            dgvPaymentsManagement.ClearSelection();
        }

        //private void LoadSubscriptionPayments()
        //{
        //    string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(CS))
        //        {
        //            con.Open();

        //            using (SqlCommand cmd = new SqlCommand("spRetrieveSubscriptionPaymentDetails", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                using (SqlDataReader dr = cmd.ExecuteReader())
        //                {
        //                    dgvPaymentsManagement.Rows.Clear();

        //                    int serialNo = 1;

        //                    while (dr.Read())
        //                    {
        //                        dgvPaymentsManagement.Rows.Add(
        //                            serialNo,
        //                            dr["MemberFullName"].ToString(),
        //                            dr["MembershipPlanName"].ToString(),
        //                            Convert.ToDateTime(dr["PaymentDate"]).ToString("dd-MM-yyyy"),
        //                            dr["PaymentMethod"].ToString(),
        //                            Convert.ToDecimal(dr["Amount"]),
        //                            dr["FeesType"].ToString()
        //                        );

        //                        serialNo++;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void dgvPaymentsManagement_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvPaymentsManagement.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvPaymentsManagement.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
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
                dgvPaymentsManagement.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
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
