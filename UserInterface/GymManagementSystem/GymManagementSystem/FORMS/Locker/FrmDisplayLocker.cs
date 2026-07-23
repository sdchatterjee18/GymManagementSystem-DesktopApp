using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using GymManagementSystem.FORMS;
using System.Configuration;

namespace GymManagementSystem.FORMS.Locker
{
    public partial class FrmDisplayLocker : Form
    {
        public FrmDisplayLocker()
        {
            InitializeComponent();
        }

        private void FrmDisplayLocker_Load(object sender, EventArgs e)
        {
            this.getLockersDetails();
            this.dgvDisplayLocker.ClearSelection();
        }

        private void pnlButton_Click(object sender, EventArgs e)
        {
            FrmAddLocker frmAddLocker = new FrmAddLocker();
            frmAddLocker.ShowDialog();
        }

        private void pnlButton_MouseEnter(object sender, EventArgs e)
        {
            this.pnlButton.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void pnlButton_MouseLeave(object sender, EventArgs e)
        {
            this.pnlButton.BackColor = Color.FromArgb(184, 195, 179);
        }

        private void getLockersDetails()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;

            string queryStr = "select l.LockerNo as LNo,m.FirstName + CASE WHEN m.MiddleName IS NOT NULL THEN ' ' + m.MiddleName ELSE '' END +' ' + m.LastName AS MemberName,l.LockerStatus as LStatus from tblLocker l join tblLockerAllocation la on l.LockerId = la.LockerId join tblMember m on m.MemberId = la.MemberId order by l.LockerId,m.MiddleName";

            try
            {
                sqlConnection = new SqlConnection(connectionString);

                using (SqlCommand sqlCommand = new SqlCommand(queryStr, sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dtLockers = new DataTable();
                        adapter.Fill(dtLockers);

                        this.dgvDisplayLocker.DataSource = dtLockers;
                        int i = 1;
                        foreach (DataGridViewRow row in dgvDisplayLocker.Rows)
                        {
                            row.Cells["colSlNo"].Value = i++;
                            row.Cells["colSlNo"].Style.ForeColor = Color.FromArgb(30, 60, 220);
                            row.Cells["colSlNo"].Style.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }            
        }

        private void dgvDisplayLocker_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvDisplayLocker.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvDisplayLocker.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvDisplayLocker.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvDisplayLocker_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvDisplayLocker.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvDisplayLocker.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvDisplayLocker.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
                dgvDisplayLocker.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Empty;
            }
        }
    
        private void dgvDisplayLocker_Click(object sender, EventArgs e)
        {
            Point clientPoint = dgvDisplayLocker.PointToClient(Cursor.Position);
            var hitTest = dgvDisplayLocker.HitTest(clientPoint.X, clientPoint.Y);

            if (hitTest.Type == DataGridViewHitTestType.None)
            {
                dgvDisplayLocker.ClearSelection();
            }
        }

        private void FrmDisplayLocker_Resize(object sender, EventArgs e)
        {
            int newHeight = this.ClientSize.Height / 12;
            if (newHeight < 30) newHeight = 30;         
            if (newHeight > 100) newHeight = 100;       

            dgvDisplayLocker.RowTemplate.Height = newHeight;

            float newFontSize = this.ClientSize.Width / 40f; 
            if (newFontSize < 12f) newFontSize = 12f;        
            if (newFontSize > 28f) newFontSize = 28f;        
            lblLockerManagement.Font = new Font(lblLockerManagement.Font.FontFamily, newFontSize, FontStyle.Bold);

            dgvDisplayLocker.Invalidate();
        }

    }
}