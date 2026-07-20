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

            dgvPaymentsManagement.RowTemplate.Height = 50;

            LoadSubscriptionPayments();
        }

        private void LoadSubscriptionPayments()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("spRetrieveSubscriptionPaymentDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            dgvPaymentsManagement.Rows.Clear();

                            int serialNo = 1;

                            while (dr.Read())
                            {
                                dgvPaymentsManagement.Rows.Add(
                                    serialNo,
                                    dr["MemberFullName"].ToString(),
                                    dr["MembershipPlanName"].ToString(),
                                    Convert.ToDateTime(dr["PaymentDate"]).ToString("dd-MM-yyyy"),
                                    dr["PaymentMethod"].ToString(),
                                    Convert.ToDecimal(dr["Amount"]),
                                    dr["FeesType"].ToString()
                                );

                                serialNo++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Color originalHeaderColor = Color.LightGray;

        private void dgvPaymentsManagement_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvPaymentsManagement.Rows[e.RowIndex]
                                 .Cells[e.ColumnIndex]
                                 .Style.BackColor = Color.LightBlue;
            }

            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvPaymentsManagement.EnableHeadersVisualStyles = false;

                dgvPaymentsManagement.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.DimGray;
                dgvPaymentsManagement.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.White;
            }
        }

        private void dgvPaymentsManagement_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvPaymentsManagement.Rows[e.RowIndex]
                                 .Cells[e.ColumnIndex]
                                 .Style.BackColor = Color.WhiteSmoke;
            }

            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvPaymentsManagement.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = originalHeaderColor;
                dgvPaymentsManagement.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
        }

        private void pnlPaymentTitle_Click(object sender, EventArgs e)
        {
            dgvPaymentsManagement.ClearSelection();
        }

    }


}
