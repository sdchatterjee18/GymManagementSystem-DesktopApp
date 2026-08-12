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
using GymManagementSystem.FORMS.Locker.UI;

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
            this.dgvDisplayLocker.DefaultCellStyle.BackColor = Color.White;
        }
        private void pnlButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpAddNewLocker.BackColor = Color.FromArgb(220, 225, 230);
        }

        private void pnlButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpAddNewLocker.BackColor = Color.FromArgb(236, 240, 243);
        }

        private void dgvDisplayLocker_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvDisplayLocker.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
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
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvDisplayLocker.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;

                string colName = dgvDisplayLocker.Columns[e.ColumnIndex].Name;

                if (colName == "colSlNo")
                {
                    dgvDisplayLocker.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.FromArgb(30, 60, 220);
                }
                else if (colName == "colLStatus")
                {
                    object cellValue = dgvDisplayLocker.Rows[e.RowIndex].Cells["colLStatus"].Value;
                    string status = (cellValue != null) ? cellValue.ToString().Trim() : null;

                    if (status != null && (status.Equals("Available", StringComparison.OrdinalIgnoreCase) || status.Equals("Active", StringComparison.OrdinalIgnoreCase)))
                        dgvDisplayLocker.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.FromArgb(20, 140, 60);
                    else if (status != null && (status.Equals("Occupied", StringComparison.OrdinalIgnoreCase) || status.Equals("Inactive", StringComparison.OrdinalIgnoreCase)))
                        dgvDisplayLocker.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.FromArgb(200, 40, 40);
                }
                else
                {
                    dgvDisplayLocker.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Empty;
                }
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

        //Retrieve Locker Details
        private void getLockersDetails()
        {
            try
            {
                LockerUI lockerUI = new LockerUI();

                DataTable dataTable = lockerUI.RetrieveLockersUI();

                dgvDisplayLocker.AutoGenerateColumns = false;
                dgvDisplayLocker.Rows.Clear();

                int serialNo = 1;

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    int rowIndex = dgvDisplayLocker.Rows.Add();

                    dgvDisplayLocker.Rows[rowIndex].Cells["colSLNo"].Value = serialNo++;

                    dgvDisplayLocker.Rows[rowIndex].Cells["colLNo"].Value =
                        dataRow["LockerNo"]; 

                    dgvDisplayLocker.Rows[rowIndex].Cells["colAllocatedTo"].Value =
                        dataRow["MemberName"].ToString();

                    dgvDisplayLocker.Rows[rowIndex].Cells["colLStatus"].Value =
                        dataRow["LockerStatus"].ToString();
                    
                    string status = dataRow["LockerStatus"].ToString().Trim();

                    // Cell conditioning
                    if (status.Equals("Available", StringComparison.OrdinalIgnoreCase))
                    {
                        dgvDisplayLocker.Rows[rowIndex].Cells["colLStatus"].Style.ForeColor = Color.FromArgb(20, 140, 60);
                    }
                    else if (status.Equals("Occupied", StringComparison.OrdinalIgnoreCase))
                    {
                        dgvDisplayLocker.Rows[rowIndex].Cells["colLStatus"].Style.ForeColor = Color.FromArgb(200, 40, 40);
                    }
                    else
                    {
                        dgvDisplayLocker.Rows[rowIndex].Cells["colLStatus"].Style.ForeColor = Color.Black;
                    }
                }

                dgvDisplayLocker.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnlButton_Click_1(object sender, EventArgs e)
        {
            FrmAddLocker frmAddLocker = new FrmAddLocker();
            if (frmAddLocker.ShowDialog() == DialogResult.OK)
            {
                this.getLockersDetails();
            }
        }
    }
}