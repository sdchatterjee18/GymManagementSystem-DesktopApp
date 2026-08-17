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
using System.Drawing.Drawing2D;

namespace GymManagementSystem.FORMS .Shift
{
    public partial class FrmDisplayShift : Form
    {
        private int currentRow;
        private int currentColumn;
        private DateTimePicker dtpTime = new DateTimePicker();


        public FrmDisplayShift()
        {
            InitializeComponent();
          
        }

        private void FrmDisplayShift_Load(object sender, EventArgs e)
        {
            RetrieveAllShifts();
        }



        private void RetrieveAllShifts()
        {
            string CS = ConfigurationManager
                .ConnectionStrings["DBCS"]
                .ConnectionString;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(CS))
                {
                    using (SqlCommand sqlCommand =
                        new SqlCommand("spRetrieveShiftTimeTable", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter sqlDataAdapter =
                            new SqlDataAdapter(sqlCommand);

                        DataTable dataTable = new DataTable();

                        sqlDataAdapter.Fill(dataTable);

                        dgvShiftManagement.AutoGenerateColumns = false;
                        dgvShiftManagement.Rows.Clear();

                        int serialNo = 1;

                        foreach (DataRow dataRow in dataTable.Rows)
                        {
                            int rowIndex = dgvShiftManagement.Rows.Add();

                            // SL No
                            dgvShiftManagement.Rows[rowIndex]
                                .Cells["colSerialNo"].Value = serialNo++;

                            // Shift Name
                            dgvShiftManagement.Rows[rowIndex]
                                .Cells["colShiftName"].Value =
                                dataRow["ShiftName"].ToString();

                            // Start Time
                            dgvShiftManagement.Rows[rowIndex]
                                .Cells["colStartTime"].Value =
                                dataRow["StartTime"].ToString();

                            // End Time
                            dgvShiftManagement.Rows[rowIndex]
                                .Cells["colEndTime"].Value =
                                dataRow["EndTime"].ToString();
                        }

                        dgvShiftManagement.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvShiftManagement_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvShiftManagement.Columns[e.ColumnIndex].Name == "colSerialNo")
            {

                e.CellStyle.ForeColor = Color.Navy;
            }

            if (dgvShiftManagement.Columns[e.ColumnIndex].Name == "colStartTime")
            {

                e.CellStyle.ForeColor = Color.Green;
            }
            if (dgvShiftManagement.Columns[e.ColumnIndex].Name == "colEndTime")
            {

                e.CellStyle.ForeColor = Color.Brown;
            }

        }

        private void dgvShiftManagement_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvShiftManagement.Columns["colUpdate"].Index)
            {
                e.PaintBackground(e.CellBounds, true);

                ButtonRenderer.DrawButton(e.Graphics, e.CellBounds,
                    System.Windows.Forms.VisualStyles.PushButtonState.Normal);

                TextRenderer.DrawText(
                    e.Graphics,
                    "Update",
                    dgvShiftManagement.Font,
                    e.CellBounds,
                    Color.SlateBlue, // Your desired text color
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;
            }
        }
        private void dgvShiftManagement_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvShiftManagement.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvShiftManagement.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvShiftManagement.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvShiftManagement_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvShiftManagement.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvShiftManagement.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvShiftManagement.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;


            }
        }
       
       
    }
}
