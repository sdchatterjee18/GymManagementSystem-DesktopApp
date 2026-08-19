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

using GymManagementSystem.FORMS.Shift.UI;

namespace GymManagementSystem.FORMS .Shift
{
    public partial class FrmDisplayShift : Form
    {
       
        private DateTimePicker dtpTime = new DateTimePicker();
        private int editingRow = -1;
        private int editingColumn = -1;

        public FrmDisplayShift()
        {
            InitializeComponent();

            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "hh:mm tt";
            dtpTime.ShowUpDown = true;

            dtpTime.Visible = false;

            dtpTime.ValueChanged += dtpTime_ValueChanged;
            dtpTime.KeyDown += dtpTime_KeyDown;
            dgvShiftManagement.Controls.Add(dtpTime);
          
        }

        private void FrmDisplayShift_Load(object sender, EventArgs e)
        {
          
            RetrieveShiftDetails();
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
                ButtonRenderer.DrawButton(e.Graphics, e.CellBounds,System.Windows.Forms.VisualStyles.PushButtonState.Normal);
                TextRenderer.DrawText(e.Graphics,"Update",dgvShiftManagement.Font,e.CellBounds,Color.SlateBlue,TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
            }
        }
        private void dgvShiftManagement_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvShiftManagement.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvShiftManagement_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvShiftManagement.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
            }
        }


        private void RetrieveShiftDetails()
        {
            try
            {
                ShiftUI shiftUI = new ShiftUI();
                DataTable dataTable = shiftUI.RetrieveShiftDetailsUI();
                int SerialNo = 1;
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    int RowIndex = dgvShiftManagement.Rows.Add();
                    dgvShiftManagement.Rows[RowIndex].Cells["colSerialNo"].Value = SerialNo++;
                    dgvShiftManagement.Rows[RowIndex].Cells["colShiftId"].Value = Convert.ToInt32(dataRow["ShiftId"]);
                    dgvShiftManagement.Rows[RowIndex].Cells["colShiftName"].Value = dataRow["ShiftName"].ToString();
                    dgvShiftManagement.Rows[RowIndex].Cells["colStartTime"].Value = dataRow["StartTime"].ToString();
                    dgvShiftManagement.Rows[RowIndex].Cells["colEndTime"].Value = dataRow["EndTime"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void dgvShiftManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int startColumn = dgvShiftManagement.Columns["colStartTime"].Index;
            int endColumn = dgvShiftManagement.Columns["colEndTime"].Index;
            if (e.ColumnIndex != startColumn && e.ColumnIndex != endColumn)
            {
                dtpTime.Visible = false;
                return;
            }
            editingRow = e.RowIndex;
            editingColumn = e.ColumnIndex;
            Rectangle cellRectangle = dgvShiftManagement.GetCellDisplayRectangle( e.ColumnIndex, e.RowIndex,true);
            dtpTime.Location = cellRectangle.Location;
            dtpTime.Size = cellRectangle.Size;
            string value = Convert.ToString(dgvShiftManagement.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            DateTime existingTime;
            if (DateTime.TryParse(value, out existingTime))
            {
                dtpTime.Value = existingTime;
            }
            else
            {
                dtpTime.Value = DateTime.Now;
            }
            dtpTime.Visible = true;
            dtpTime.BringToFront();
            dtpTime.Focus();
            if (e.RowIndex < 0)
                return;


        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
           if (editingRow >= 0 && editingColumn >= 0)
                {
                    dgvShiftManagement.Rows[editingRow].Cells[editingColumn].Value = dtpTime.Value.ToString("hh:mm tt");
                    dgvShiftManagement.InvalidateCell(editingColumn,editingRow);
                }
         }
        private void dtpTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvShiftManagement.Rows[editingRow].Cells[editingColumn].Value = dtpTime.Value.ToString("hh:mm tt");
                dtpTime.Visible = false;
                dgvShiftManagement.InvalidateCell(editingColumn,editingRow);
                e.Handled = true;
            }
        }

        private void dgvShiftManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvShiftManagement.Columns[e.ColumnIndex].Name != "colUpdate")
                return;

            int shiftId = Convert.ToInt32(dgvShiftManagement.Rows[e.RowIndex].Cells["colShiftId"].Value);

            string startTimeText = Convert.ToString(dgvShiftManagement.Rows[e.RowIndex].Cells["colStartTime"].Value);

            string endTimeText = Convert.ToString( dgvShiftManagement.Rows[e.RowIndex].Cells["colEndTime"].Value);

            DateTime startDateTime;
            DateTime endDateTime;

            if (!DateTime.TryParse(startTimeText, out startDateTime))
            {
                //MessageBox.Show("Invalid Start Time.");
                return;
            }

            if (!DateTime.TryParse(endTimeText, out endDateTime))
            {
               // MessageBox.Show("Invalid End Time.");
                return;
            }

            TimeSpan startTime = startDateTime.TimeOfDay;
            TimeSpan endTime = endDateTime.TimeOfDay;

            ShiftUI shiftUI = new ShiftUI();

            string result = shiftUI.UpdateShiftDetailsUI(shiftId,startTime,endTime);
            MessageBox.Show(result);
            dgvShiftManagement.Rows.Clear();
            RetrieveShiftDetails();
        }
  
    }
}
