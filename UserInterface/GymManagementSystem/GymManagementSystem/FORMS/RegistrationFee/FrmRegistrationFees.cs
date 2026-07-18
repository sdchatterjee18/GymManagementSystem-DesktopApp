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
                            (sqlDataReader["IsActive"]).ToString(),
                            Convert.ToDateTime(sqlDataReader["CreatedAt"]).ToString("dd-MM-yyyy"));
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
            AdjustRowHeights();
        }


        private void AdjustRowHeights()
        {
            try
            {
                dgvShowAllAddRegistrationFees.SuspendLayout();
                dgvShowAllAddRegistrationFees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvShowAllAddRegistrationFees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                int gridHeight = dgvShowAllAddRegistrationFees.ClientSize.Height - dgvShowAllAddRegistrationFees.ColumnHeadersHeight;

                int visibleRowCount = dgvShowAllAddRegistrationFees.Rows.GetRowCount(DataGridViewElementStates.Visible);

                if (dgvShowAllAddRegistrationFees.AllowUserToAddRows)
                {
                    visibleRowCount--;
                }

                if (visibleRowCount > 0)
                {
                    int singlePartHeight = gridHeight / visibleRowCount;

                    foreach (DataGridViewRow row in dgvShowAllAddRegistrationFees.Rows)
                    {
                        if (row.IsNewRow)
                            continue;

                        if (row.Visible)
                        {
                            row.Height = singlePartHeight;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                dgvShowAllAddRegistrationFees.ResumeLayout();
                dgvShowAllAddRegistrationFees.Refresh();
            }
        }

      
        

        private void dgvShowAllAddRegistrationFees_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvShowAllAddRegistrationFees[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.LightBlue;
            }
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvShowAllAddRegistrationFees.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.DimGray;
                dgvShowAllAddRegistrationFees.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.White;
            }

        }


        private void dgvShowAllAddRegistrationFees_CellMouseLeave_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvShowAllAddRegistrationFees[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
            }
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvShowAllAddRegistrationFees.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.LightGray;
                dgvShowAllAddRegistrationFees.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }

        }


        

        private void tlpAddNewRegistrationFees_MouseLeave(object sender, EventArgs e)
        {
            this.tlpAddNewRegistrationFees.BackColor = Color.FromArgb(184, 195, 179);
        }

        private void tlpAddNewRegistrationFees_MouseEnter(object sender, EventArgs e)
        {
            this.tlpAddNewRegistrationFees.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void picAddRegistrationFee_MouseEnter(object sender, EventArgs e)
        {
            this.tlpAddNewRegistrationFees.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void picAddRegistrationFee_MouseLeave(object sender, EventArgs e)
        {
            this.tlpAddNewRegistrationFees.BackColor = Color.FromArgb(184, 195, 179);
        }

        private void lblAddRegistrationFees_MouseEnter(object sender, EventArgs e)
        {
            this.tlpAddNewRegistrationFees.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void lblAddRegistrationFees_MouseLeave(object sender, EventArgs e)
        {
            this.tlpAddNewRegistrationFees.BackColor = Color.FromArgb(184, 195, 179);
        }


        private void FrmRegistrationFees_Resize(object sender, EventArgs e)
        {
            AdjustRowHeights();
           
        }

        private void tlpTopFrmAddRegistrationFee_Click(object sender, EventArgs e)
        {
            dgvShowAllAddRegistrationFees.ClearSelection();

        }

        private void tlpMiddleFrmAddRegistrationFee_Click(object sender, EventArgs e)
        {
            dgvShowAllAddRegistrationFees.ClearSelection();
        }

        private void tlpAddNewRegistrationFees_Click(object sender, EventArgs e)
        {
            dgvShowAllAddRegistrationFees.ClearSelection();
        }

        private void lblRegistrationFeesFrmAddRegistrationFee_Click(object sender, EventArgs e)
        {
            dgvShowAllAddRegistrationFees.ClearSelection();
        }

        private void picAddRegistrationFee_Click(object sender, EventArgs e)
        {
            dgvShowAllAddRegistrationFees.ClearSelection();
        }

        private void lblAddRegistrationFees_Click(object sender, EventArgs e)
        {
            dgvShowAllAddRegistrationFees.ClearSelection();

        }
        private void pnlClickAddNewFegistrationFees_Click(object sender, EventArgs e)
        {
            FrmAddRegistrationFee frmAddRegistrationFee = new FrmAddRegistrationFee();
            frmAddRegistrationFee.ShowDialog();
        }




       

      

      

       

        

     

        

       

       

       




       

        


        

       


       
       






    }
}
