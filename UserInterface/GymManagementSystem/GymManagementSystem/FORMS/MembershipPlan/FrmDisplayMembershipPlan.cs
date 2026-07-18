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


namespace GymManagementSystem.FORMS.MembershipPlan
{
    public partial class FrmDisplayMembershipPlan : Form
    { 
        public FrmDisplayMembershipPlan()
        {
            InitializeComponent();
        }

       
      
        private void FrmDisplayMembershipPlan_Load(object sender, EventArgs e)
        {


         

            dgvMembershipPlan.RowTemplate.Height = 60;
            dgvMembershipPlan.ScrollBars = ScrollBars.Both;
            //dgvMembershipPlan.ScrollBars = ScrollBars.Horizontal;
            dgvMembershipPlan.Dock = DockStyle.Fill;
            //dgvMembershipPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

            LoadMembershipPlans();

            dgvMembershipPlan.ClearSelection();



            dgvMembershipPlan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvMembershipPlan.ColumnHeadersHeight = 50;
        }

        private void LoadMembershipPlans()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("spRetrieveMembershipPlans", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            dgvMembershipPlan.Rows.Clear();

                            int serialNo = 1;

                            while (dr.Read())
                            {
                                dgvMembershipPlan.Rows.Add(
                                    serialNo,
                                    dr["MembershipPlanName"].ToString(),
                                    dr["PlanType"].ToString(),
                                   Convert.ToInt32(dr["DurationInDays"]),
                                    Convert.ToDecimal(dr["Price"]),
                                    dr["Description"].ToString(),
                                    dr["IsActive"].ToString()
                                );

                                serialNo++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }



        private Color originalHeaderColor = Color.LightGray;
       
        private void dgvMembershipPlan_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvMembershipPlan.Rows[e.RowIndex]
                                 .Cells[e.ColumnIndex]
                                 .Style.BackColor = Color.LightBlue;
            }

            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvMembershipPlan.EnableHeadersVisualStyles = false;

                dgvMembershipPlan.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.DimGray;
                dgvMembershipPlan.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.White;
            }
        }

        private void dgvMembershipPlan_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvMembershipPlan.Rows[e.RowIndex]
                                 .Cells[e.ColumnIndex]
                                 .Style.BackColor = Color.WhiteSmoke;
            }

            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvMembershipPlan.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = originalHeaderColor;
                dgvMembershipPlan.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
        }

        private void pnlMembershipPlanGridview_Click(object sender, EventArgs e)
        {
            dgvMembershipPlan.ClearSelection();
        }

        private void tlpAllMembershipPlanTitle_Click(object sender, EventArgs e)
        {
            dgvMembershipPlan.ClearSelection();
        }

        private void tlpMembershipPlanSearch_Click(object sender, EventArgs e)
        {
            dgvMembershipPlan.ClearSelection();
        }

        private void tlpMembershipPlanEntireForm_Click(object sender, EventArgs e)
        {
            dgvMembershipPlan.ClearSelection();
        }

        private void txtMembershipPlanSearchBox_Click(object sender, EventArgs e)
        {
            dgvMembershipPlan.ClearSelection();
        }

        private void pnlAddNewMembarshipPlan_Click(object sender, EventArgs e)
        {
            dgvMembershipPlan.ClearSelection();
        }

        private void FrmDisplayMembershipPlan_Click(object sender, EventArgs e)
        {
            dgvMembershipPlan.ClearSelection();
        }

        private void pnlClickAddNewMembershipPlan_Click(object sender, EventArgs e)
        {
            FrmAddMembershipPlans frm = new FrmAddMembershipPlans();
            frm.Show();
        }

   
       
      
        
       

     
       
    }
}
