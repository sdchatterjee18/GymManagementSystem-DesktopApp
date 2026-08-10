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
    public partial class FrmDisplayWorkoutPlans : Form
    {
        private DataTable exerciseDataTable;
        private DataTable workoutPlanDataTable;
        public FrmDisplayWorkoutPlans()
        {
            InitializeComponent();
        }

        private void FrmDisplayWorkoutPlans_Load(object sender, EventArgs e)
        {
            //Exercises Load
            LoadExercise();
            LoadExerciseComboBox();

            //Load Workout
            LoadWorkoutPlans();
            LoadWorkoutPlansComboBox();

            dgvExerciseTable.ClearSelection();
            dgvWorkoutPlans.ClearSelection();
        }
        // Exercise Methode Show dgv
        private void LoadExercise()
        {
            try
            {
                WorkoutUI workoutUI = new WorkoutUI();

                exerciseDataTable =
                    workoutUI.RetrieveExercisesUI();

                dgvExerciseTable.AutoGenerateColumns = false;
                dgvExerciseTable.Rows.Clear();

                int serialNo = 1;

                foreach (DataRow dataRow in exerciseDataTable.Rows)
                {
                    int rowIndex = dgvExerciseTable.Rows.Add();

                    dgvExerciseTable.Rows[rowIndex]
                        .Cells["colSerialNo1"].Value = serialNo++;

                    dgvExerciseTable.Rows[rowIndex]
                        .Cells["colExerciseName"].Value =
                        dataRow["ExerciseName"].ToString();

                    dgvExerciseTable.Rows[rowIndex]
                        .Cells["colMuscleType"].Value =
                        dataRow["MuscleType"].ToString();

                    dgvExerciseTable.Rows[rowIndex]
                        .Cells["colExercisesId"].Value =
                        Convert.ToInt32(dataRow["ExerciseId"]);
                }

                dgvExerciseTable.ClearSelection();
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
        // Exercise Name (Show cmb)
        private void LoadExerciseComboBox()
        {
            try
            {
                WorkoutUI workoutUI = new WorkoutUI();
                DataTable dataTable =workoutUI.GetExercisesForComboBox();
                cmbExerciseName.DataSource = dataTable;
                cmbExerciseName.DisplayMember = "ExerciseName";
                cmbExerciseName.ValueMember = "ExerciseId";
                cmbExerciseName.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        //Exercise select cmb box
        private void cmbExerciseName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbExerciseName.SelectedIndex == -1)
                return;
            try
            {
                int exerciseId = Convert.ToInt32(cmbExerciseName.SelectedValue);

                LoadSpecificExercise(exerciseId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Retrieve specific exercise
        private void LoadSpecificExercise(int exerciseId)
        {
            try
            {
                int serialNo = 0;
                foreach (DataRow dataRow in exerciseDataTable.Rows)
                {
                    if (Convert.ToInt32(dataRow["ExerciseId"]) == exerciseId)
                    {
                        int index = exerciseDataTable.Rows.IndexOf(dataRow);

                        serialNo = index + 1;

                        break;
                    }
                }

                WorkoutUI workoutUI = new WorkoutUI();

                DataTable dataTable =
                    workoutUI.RetrieveSpecificExerciseUI(exerciseId);

                dgvExerciseTable.AutoGenerateColumns = false;
                dgvExerciseTable.Rows.Clear();

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    int rowIndex =
                        dgvExerciseTable.Rows.Add();

                    dgvExerciseTable.Rows[rowIndex]
                        .Cells["colSerialNo1"].Value =
                        serialNo;

                    dgvExerciseTable.Rows[rowIndex]
                        .Cells["colExerciseName"].Value =
                        dataRow["ExerciseName"].ToString();

                    dgvExerciseTable.Rows[rowIndex]
                        .Cells["colMuscleType"].Value =
                        dataRow["MuscleType"].ToString();

                    dgvExerciseTable.Rows[rowIndex]
                        .Cells["colExercisesId"].Value =
                        Convert.ToInt32(dataRow["ExerciseId"]);
                }

                dgvExerciseTable.ClearSelection();
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
        // Display all exercise
        private void btnExerciseDisplayAll_Click(object sender, EventArgs e)
        {
            cmbExerciseName.SelectedIndex = -1;
            LoadExercise();
            dgvExerciseTable.ClearSelection();
        }
        // Load Add form (Exercise)
        private void pnlClickToAddNewExercise_Click(object sender, EventArgs e)
        {
            using (FrmAddNewExercise frmAddNewExercise = new FrmAddNewExercise())
            {
                DialogResult result = frmAddNewExercise.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadExercise();
                    LoadExerciseComboBox();
                    dgvExerciseTable.ClearSelection();
                    dgvWorkoutPlans.ClearSelection();
                }
                frmAddNewExercise.Show();
                frmAddNewExercise.StartPosition = FormStartPosition.CenterParent;
            }
        }

        // Workout Plan Show dgv
        private void LoadWorkoutPlans()
        {
            try
            {
                WorkoutUI workoutUI = new WorkoutUI();
                workoutPlanDataTable = workoutUI.RetrieveWorkoutPlansUI();
                dgvWorkoutPlans.AutoGenerateColumns = false;
                dgvWorkoutPlans.Rows.Clear();
                int serialNo = 1;
                foreach (DataRow dataRow in workoutPlanDataTable.Rows)
                {
                    int rowIndex = dgvWorkoutPlans.Rows.Add();

                    dgvWorkoutPlans.Rows[rowIndex]
                        .Cells["colSerialNo2"].Value = serialNo++;

                    dgvWorkoutPlans.Rows[rowIndex]
                        .Cells["colWorkoutPlanId"].Value =
                        Convert.ToInt32(dataRow["WorkoutPlanId"]);

                    dgvWorkoutPlans.Rows[rowIndex]
                        .Cells["colWorkoutName"].Value =
                        dataRow["WorkoutName"].ToString();

                    dgvWorkoutPlans.Rows[rowIndex]
                        .Cells["colDescription"].Value =
                        dataRow["Description"].ToString();
                }

                dgvWorkoutPlans.ClearSelection();
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
        //Workout Plam Name (cmb Box)
        private void LoadWorkoutPlansComboBox()
        {
            try
            {
                WorkoutUI workoutUI = new WorkoutUI();
                DataTable dataTable = workoutUI.GetWorkoutPlansForComboBox();
                cmbWorkoutplansName.DataSource = dataTable;
                cmbWorkoutplansName.DisplayMember = "WorkoutName";
                cmbWorkoutplansName.ValueMember = "WorkoutPlanId";
                cmbWorkoutplansName.SelectedIndex = -1;
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
        // Retrieve specific Workout Plan
        private void LoadSpecificWorkoutPlan(int workoutPlanId)
        {
            try
            {
                int serialNo = 0;
                foreach (DataRow dataRow in workoutPlanDataTable.Rows)
                {
                    if (Convert.ToInt32(dataRow["WorkoutPlanId"]) == workoutPlanId)
                    {
                        int index =
                            workoutPlanDataTable.Rows.IndexOf(dataRow);

                        serialNo = index + 1;

                        break;
                    }
                }

                WorkoutUI workoutUI = new WorkoutUI();
                DataTable dataTable =
                    workoutUI.RetrieveSpecificWorkoutPlanUI(workoutPlanId);

                dgvWorkoutPlans.AutoGenerateColumns = false;
                dgvWorkoutPlans.Rows.Clear();
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    int rowIndex = dgvWorkoutPlans.Rows.Add();

                    dgvWorkoutPlans.Rows[rowIndex]
                        .Cells["colSerialNo2"].Value =
                        serialNo;

                    dgvWorkoutPlans.Rows[rowIndex]
                        .Cells["colWorkoutPlanId"].Value =
                        Convert.ToInt32(dataRow["WorkoutPlanId"]);

                    dgvWorkoutPlans.Rows[rowIndex]
                        .Cells["colWorkoutName"].Value =
                        dataRow["WorkoutName"].ToString();

                    dgvWorkoutPlans.Rows[rowIndex]
                        .Cells["colDescription"].Value =
                        dataRow["Description"].ToString();
                }

                dgvWorkoutPlans.ClearSelection();
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
        //Select cmb Box
        private void cmbWorkoutplansName_SelectionChangeCommitted(object sender,EventArgs e)
        {
            if (cmbWorkoutplansName.SelectedIndex == -1)
                return;

            try
            {
                int workoutPlanId =
                    Convert.ToInt32(cmbWorkoutplansName.SelectedValue);

                LoadSpecificWorkoutPlan(workoutPlanId);
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
        // Display all Workout Plan
        private void btnWorkoutPlanDisplayAll_Click(object sender, EventArgs e)
        {
            cmbWorkoutplansName.SelectedIndex = -1;
            LoadWorkoutPlans();
            dgvWorkoutPlans.ClearSelection();
        }
        // Load Add form (Workout Plan)
        private void pnlClickToAddNewWorkoutPlan_Click(object sender, EventArgs e)
        {
            using (FrmAddNewWorkoutPlan frmAddNewWorkoutPlan =
                new FrmAddNewWorkoutPlan())
            {
                DialogResult result =
                    frmAddNewWorkoutPlan.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadWorkoutPlans();
                    LoadWorkoutPlansComboBox();

                    dgvWorkoutPlans.ClearSelection();
                    dgvExerciseTable.ClearSelection();
                }

                frmAddNewWorkoutPlan.Show();
                frmAddNewWorkoutPlan.StartPosition =
                    FormStartPosition.CenterParent;
            }
        }

        // Exercise DataGridView Mouse Enter Event
        private void dgvExerciseTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvExerciseTable.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvExerciseTable.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvExerciseTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }
        // Exercise DataGridView Mouse Leave Event
        private void dgvExerciseTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
              if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvExerciseTable.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvExerciseTable.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvExerciseTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
    
            }
        }
        // Workout Plan DataGridView Mouse Enter Event
        private void dgvWorkoutPlans_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvWorkoutPlans.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvWorkoutPlans.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvWorkoutPlans.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;

            }
        }
        // Workout Plan DataGridView Mouse Leave Event
        private void dgvWorkoutPlans_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvWorkoutPlans.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvWorkoutPlans.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvWorkoutPlans.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }
        // Exercise DataGridView Cell Formatting Event
        private void dgvExerciseTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvExerciseTable.Columns[e.ColumnIndex].Name == "colSerialNo1")
            {

                e.CellStyle.ForeColor = Color.Navy;
            }    
        }
        // Workout Plan DataGridView Cell Formatting Event
        private void dgvWorkoutPlans_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvWorkoutPlans.Columns[e.ColumnIndex].Name == "colSerialNo2")
            {

                e.CellStyle.ForeColor = Color.Navy;
            }   
        }
        // Header Click Event
        private void tlpExerciseHeader_Click(object sender, EventArgs e)
        {
            dgvExerciseTable.ClearSelection();
            dgvWorkoutPlans.ClearSelection();
        }
        private void tlpAddNewExercise_MouseEnter(object sender, EventArgs e)
        {
            tlpAddNewExercise.BackColor = Color.FromArgb(220, 225, 230);
        }
        private void tlpAddNewExercise_MouseLeave(object sender, EventArgs e)
        {
            tlpAddNewExercise.BackColor = Color.FromArgb(236, 240, 243);
        }
        private void tlpAddNewWorkoutPlan_MouseEnter(object sender, EventArgs e)
        {
            tlpAddNewWorkoutPlan.BackColor = Color.FromArgb(220, 225, 230);
        }
        private void tlpAddNewWorkoutPlan_MouseLeave(object sender, EventArgs e)
        {
            tlpAddNewWorkoutPlan.BackColor = Color.FromArgb(236, 240, 243);
        }
    }
}
