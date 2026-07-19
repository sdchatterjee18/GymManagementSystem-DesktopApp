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

namespace GymManagementSystem.FORMS.Shift
{
    public partial class FrmDisplayShift : Form
    {
        private int currentRow;
        private int currentColumn;
        private DateTimePicker dtpTime = new DateTimePicker();


        public FrmDisplayShift()
        {
            InitializeComponent();
            dtpTime.Visible = false;
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "hh:mm tt";
            dtpTime.ShowUpDown = true;

            this.Controls.Add(dtpTime);

            dtpTime.CloseUp += dtpTime_CloseUp;
            dtpTime.Leave += dtpTime_Leave;
        }

        private void LoadShiftDetails()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            try
            {
                using (sqlConnection = new SqlConnection(CS))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spRetrieveShiftTimeTable", sqlConnection);
                    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);

                    dgvShift.DataSource = dt;
                    for (int i = 0; i < dgvShift.Rows.Count; i++)
                    {
                        dgvShift.Rows[i].Cells["ColSerialNo"].Value = i + 1;
                    }
                    dgvShift.ScrollBars = ScrollBars.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private void FrmDisplayShift_Load(object sender, EventArgs e)
        {
            dgvShift.AutoGenerateColumns = false;
            dgvShift.RowHeadersVisible = false;
            LoadShiftDetails();
            foreach (DataGridViewColumn column in dgvShift.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            StretchRows();
            dgvShift.ScrollBars = ScrollBars.None;
        }

        private void dgvShift_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvShift.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvShift.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.DimGray;
                dgvShift.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.White;
            }
        }

        private void dgvShift_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvShift.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.WhiteSmoke;
            }
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvShift.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.LightGray;
                dgvShift.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
        }

        private void dgvShift_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvShift.Columns[e.ColumnIndex].Name != "ColStartTime" &&
                dgvShift.Columns[e.ColumnIndex].Name != "ColEndTime")
                return;

            currentRow = e.RowIndex;
            currentColumn = e.ColumnIndex;

            Rectangle rect = dgvShift.GetCellDisplayRectangle(
                e.ColumnIndex,
                e.RowIndex,
                true);
            Point location = dgvShift.PointToScreen(rect.Location);
            location = this.PointToClient(location);
            dtpTime.SetBounds(
            location.X - 1,
            location.Y - 1,
            rect.Width + 2,
            rect.Height + 2);

            DateTime time;
            if (DateTime.TryParse(dgvShift.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out time))
            {
                dtpTime.Value = time;
            }
            else
            {
                dtpTime.Value = DateTime.Now;
            }

            dtpTime.Visible = true;
            dtpTime.BringToFront();
            dtpTime.Focus();
        }

        private void dtpTime_CloseUp(object sender, EventArgs e)
        {
            dgvShift.Rows[currentRow]
            .Cells[currentColumn]
            .Value = dtpTime.Value.ToString("hh:mm tt");

            dtpTime.Visible = false;
        }

        private void dtpTime_Leave(object sender, EventArgs e)
        {
            dgvShift.Rows[currentRow]
            .Cells[currentColumn]
            .Value = dtpTime.Value.ToString("hh:mm tt");

            dtpTime.Visible = false;
        }

        private void StretchRows()
        {
            if (dgvShift.Rows.Count == 0)
                return;

            // Height available for rows (excluding column header)
            int availableHeight = dgvShift.ClientSize.Height - dgvShift.ColumnHeadersHeight;

            // Calculate row height
            int rowHeight = availableHeight / dgvShift.Rows.Count;

            // Set row height
            foreach (DataGridViewRow row in dgvShift.Rows)
            {
                row.Height = rowHeight;
            }
        }

        private void FrmDisplayShift_Resize(object sender, EventArgs e)
        {
            StretchRows();
        }

        private void tlpMainLayout_Click(object sender, EventArgs e)
        {
            dgvShift.ClearSelection();
        }

        private void tlpTitleLayout_Click(object sender, EventArgs e)
        {
            dgvShift.ClearSelection();
        }

        private void pnlTitleShift_Click(object sender, EventArgs e)
        {
            dgvShift.ClearSelection();
        }

        private void FrmDisplayShift_Click(object sender, EventArgs e)
        {
            dgvShift.ClearSelection();
        }

        private void lblTitleShift_Click(object sender, EventArgs e)
        {
            dgvShift.ClearSelection();
        }

        private void tlpGridLayout_Click(object sender, EventArgs e)
        {
            dgvShift.ClearSelection();
        }

    }
}
