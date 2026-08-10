using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.FORMS.Workout.UI;

namespace GymManagementSystem.FORMS.Workout
{
    public partial class FrmDisplayWorkoutSchedule : Form
    {
        private DataTable workoutScheduleDataTable;
        public FrmDisplayWorkoutSchedule()
        {
            InitializeComponent();
        }
        // Form Load Event
        private void FrmDisplayWorkoutSchedule_Load(object sender, EventArgs e)
        {
            LoadWorkoutShedule();
            dgvWorkoutShedule.ClearSelection();
            LoadWorkoutDayComboBox();
        }
        // Display All Workout Schedule
        private void LoadWorkoutShedule()
        {
            try
            {
                WorkoutUI workoutUI = new WorkoutUI();

                workoutScheduleDataTable =
                    workoutUI.RetrieveWorkoutScheduleRecordsUI();

                dgvWorkoutShedule.AutoGenerateColumns = false;
                dgvWorkoutShedule.Rows.Clear();

                int serialNo = 1;

                foreach (DataRow dataRow in workoutScheduleDataTable.Rows)
                {
                    int rowIndex =
                        dgvWorkoutShedule.Rows.Add();

                    dgvWorkoutShedule.Rows[rowIndex]
                        .Cells["colSerialNo"].Value =
                        serialNo++;

                    dgvWorkoutShedule.Rows[rowIndex]
                        .Cells["colWorkoutName"].Value =
                        dataRow["WorkoutName"].ToString();

                    dgvWorkoutShedule.Rows[rowIndex]
                        .Cells["colExerciseName"].Value =
                        dataRow["ExerciseName"].ToString();

                    dgvWorkoutShedule.Rows[rowIndex]
                        .Cells["colWorkoutDay"].Value =
                        dataRow["WorkoutDay"].ToString();

                    dgvWorkoutShedule.Rows[rowIndex]
                        .Cells["colWorkoutScheduleId"].Value =
                        Convert.ToInt32(
                            dataRow["WorkoutScheduleId"]);
                }

                dgvWorkoutShedule.ClearSelection();
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
        // Load Workout Days into ComboBox
        private void LoadWorkoutDayComboBox()
        {
            try
            {
                WorkoutUI workoutUI = new WorkoutUI();

                List<string> workoutDays =
                    workoutUI.GetWorkoutDaysUI();

                cmbWorkoutDaySearch.Items.Clear();

                foreach (string day in workoutDays)
                {
                    cmbWorkoutDaySearch.Items.Add(day);
                }

                cmbWorkoutDaySearch.SelectedIndex = -1;
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
        // Display Workout Schedule by Selected Day
        private void LoadWorkoutScheduleByDay(string workoutDay)
        {
            try
            {
                WorkoutUI workoutUI = new WorkoutUI();

                DataTable dataTable =
                    workoutUI.RetrieveWorkoutScheduleByDayUI(workoutDay);

                dgvWorkoutShedule.AutoGenerateColumns = false;
                dgvWorkoutShedule.Rows.Clear();

                int serialNo = 1;

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    int rowIndex =
                        dgvWorkoutShedule.Rows.Add();

                    // Serial Number
                    dgvWorkoutShedule.Rows[rowIndex]
                        .Cells["colSerialNo"].Value =
                        serialNo++;

                    // Workout Name
                    dgvWorkoutShedule.Rows[rowIndex]
                        .Cells["colWorkoutName"].Value =
                        dataRow["WorkoutName"].ToString();

                    // Exercise Name
                    dgvWorkoutShedule.Rows[rowIndex]
                        .Cells["colExerciseName"].Value =
                        dataRow["ExerciseName"].ToString();

                    // Workout Day
                    dgvWorkoutShedule.Rows[rowIndex]
                        .Cells["colWorkoutDay"].Value =
                        dataRow["WorkoutDay"].ToString();

                    // Workout Schedule Id
                    dgvWorkoutShedule.Rows[rowIndex]
                        .Cells["colWorkoutScheduleId"].Value =
                        Convert.ToInt32(
                            dataRow["WorkoutScheduleId"]);
                }

                dgvWorkoutShedule.ClearSelection();
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
        // ComboBox Selection Change Event
        private void cmbWorkoutDaySearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbWorkoutDaySearch.SelectedIndex == -1)
                return;

            try
            {
                string workoutDay =
                    cmbWorkoutDaySearch.SelectedItem.ToString();

                LoadWorkoutScheduleByDay(workoutDay);
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
        // Display All Button Click Event
        private void btnWorkoutSheduleDisplayAll_Click(object sender, EventArgs e)
        {
            try
            {
                // ComboBox reset
                cmbWorkoutDaySearch.SelectedIndex = -1;
                // Display all workout schedule
                LoadWorkoutShedule();
                // Selection clear
                dgvWorkoutShedule.ClearSelection();
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
        // Add New Workout Schedule Panel Click Event
        private void pnlClickToAddNewWorkoutShedule_Click(object sender, EventArgs e)
        {
            using (FrmAddNewWorkoutSchedule frmAddNewWorkoutSchedule =
                new FrmAddNewWorkoutSchedule())
            {
                frmAddNewWorkoutSchedule.StartPosition =
                    FormStartPosition.CenterParent;

                DialogResult result =
                    frmAddNewWorkoutSchedule.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    LoadWorkoutShedule();

                    cmbWorkoutDaySearch.SelectedIndex = -1;

                    dgvWorkoutShedule.ClearSelection();
                }
            }
        }
        // Delete Button Click Event
        private void dgvWorkoutShedule_CellContentClick(object sender,DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvWorkoutShedule.Columns[e.ColumnIndex].Name == "colDelete")
            {
                int workoutScheduleId =
                    Convert.ToInt32(
                        dgvWorkoutShedule.Rows[e.RowIndex]
                        .Cells["colWorkoutScheduleId"].Value);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this workout schedule?",
                    "Delete Workout Schedule",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    WorkoutUI workoutUI = new WorkoutUI();

                    string message =
                        workoutUI.RemoveWorkoutScheduleByIdUI(
                            workoutScheduleId);

                    MessageBox.Show(
                        message,
                        "Workout Schedule",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    if (message ==
                        "Workout Schedule record deleted successfully")
                    {
                        LoadWorkoutShedule();

                        cmbWorkoutDaySearch.SelectedIndex = -1;

                        dgvWorkoutShedule.ClearSelection();
                    }
                }
            }
        }
        // DataGridView Cell Mouse Enter Event
        private void dgvWorkoutShedule_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvWorkoutShedule.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvWorkoutShedule.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvWorkoutShedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }
        // DataGridView Cell Mouse Leave Event
        private void dgvWorkoutShedule_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvWorkoutShedule.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvWorkoutShedule.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvWorkoutShedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;


            }
        }
        // DataGridView Cell Formatting Event
        private void dgvWorkoutShedule_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvWorkoutShedule.Columns[e.ColumnIndex].Name == "colSerialNo")
            {

                e.CellStyle.ForeColor = Color.Navy;
            }


            if (dgvWorkoutShedule.Columns[e.ColumnIndex].Name == "colDelete")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Blue;

                }
            }

        }
        // Header Click Event
        private void tlpWorkoutSheduleHeader_Click(object sender, EventArgs e)
        {
            dgvWorkoutShedule.ClearSelection();
        }
        private void tlpAddNewWorkoutSchedule_MouseEnter(object sender, EventArgs e)
        {
            tlpAddNewWorkoutSchedule.BackColor = Color.FromArgb(220, 225, 230);
        }
        private void tlpAddNewWorkoutSchedule_MouseLeave(object sender, EventArgs e)
        {
            tlpAddNewWorkoutSchedule.BackColor = Color.FromArgb(236, 240, 243);
        }
        // Delete Button Cell Painting Event
        private void dgvWorkoutShedule_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvWorkoutShedule.Columns["colDelete"].Index)
            {
                e.PaintBackground(e.CellBounds, true);

                ButtonRenderer.DrawButton(e.Graphics, e.CellBounds,
                    System.Windows.Forms.VisualStyles.PushButtonState.Normal);

                TextRenderer.DrawText(
                    e.Graphics,
                    "Delete",
                    dgvWorkoutShedule.Font,
                    e.CellBounds,
                    Color.Brown, // Your desired text color
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;
            }
        }

    }
}
