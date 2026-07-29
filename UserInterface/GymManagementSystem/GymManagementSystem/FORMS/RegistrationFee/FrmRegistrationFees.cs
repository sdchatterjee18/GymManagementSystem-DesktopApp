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


namespace GymManagementSystem.FORMS.RegistrationFee
{
    public partial class FrmRegistrationFees : Form
    {
        public FrmRegistrationFees()
        {
            InitializeComponent();
            
        }

        private void RetrieveRegistrationFees()
        {

            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;

            DataTable dataTable = new DataTable();
            try
            {
                sqlConnection = new SqlConnection(CS);
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("spGetAllRegistrationFees", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    int a = 1;
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                   
                    while (sqlDataReader.Read())
                    {
                        dgvShowAllAddRegistrationFees.Rows.Add(a,
                            Convert.ToDecimal(sqlDataReader["FeeAmount"]),
                            Convert.ToDateTime(sqlDataReader["CreatedAt"]).ToString("dd-MM-yyyy"),
                            (sqlDataReader["IsActive"]).ToString());
                        a++;
                    }


                }
                dgvShowAllAddRegistrationFees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvShowAllAddRegistrationFees.ScrollBars = ScrollBars.None;
                dgvShowAllAddRegistrationFees.ClearSelection();
            }

            catch (Exception exc)
            {

            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }

        }



        private void FrmRegistrationFees_Load(object sender, EventArgs e)
        {
            RetrieveRegistrationFees();
        
            //AdjustRowHeights();
        }


        //private void AdjustRowHeights()
        //{
        //    try
        //    {
        //        dgvShowAllAddRegistrationFees.SuspendLayout();
        //        dgvShowAllAddRegistrationFees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //        dgvShowAllAddRegistrationFees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        //        int gridHeight = dgvShowAllAddRegistrationFees.ClientSize.Height - dgvShowAllAddRegistrationFees.ColumnHeadersHeight;

        //        int visibleRowCount = dgvShowAllAddRegistrationFees.Rows.GetRowCount(DataGridViewElementStates.Visible);

        //        if (dgvShowAllAddRegistrationFees.AllowUserToAddRows)
        //        {
        //            visibleRowCount--;
        //        }

        //        if (visibleRowCount > 0)
        //        {
        //            int singlePartHeight = gridHeight / visibleRowCount;

        //            foreach (DataGridViewRow row in dgvShowAllAddRegistrationFees.Rows)
        //            {
        //                if (row.IsNewRow)
        //                    continue;

        //                if (row.Visible)
        //                {
        //                    row.Height = singlePartHeight;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    finally
        //    {
        //        dgvShowAllAddRegistrationFees.ResumeLayout();
        //        dgvShowAllAddRegistrationFees.Refresh();
        //    }
        //}

          

        private void FrmRegistrationFees_Resize(object sender, EventArgs e)
        {
           // AdjustRowHeights();
           
        }

    
        private void pnlClickAddNewFegistrationFees_Click(object sender, EventArgs e)
        {
            dgvShowAllAddRegistrationFees.ClearSelection();
            FrmAddRegistrationFee frmAddRegistrationFee = new FrmAddRegistrationFee();
            frmAddRegistrationFee.ShowDialog();

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
                //dgvShowAllAddRegistrationFees.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
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
                //dgvShowAllAddRegistrationFees.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvShowAllAddRegistrationFees.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
            }

        }

     

        

      

       

       

       

       

       
       

        

        



    }
}
