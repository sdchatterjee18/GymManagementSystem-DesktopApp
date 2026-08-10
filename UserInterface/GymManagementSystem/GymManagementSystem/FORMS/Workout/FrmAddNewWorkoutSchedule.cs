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
    public partial class FrmAddNewWorkoutSchedule : Form
    {
        public FrmAddNewWorkoutSchedule()
        {
            InitializeComponent();
        }

        private void FrmAddNewWorkoutSchedule_Load(object sender, EventArgs e)
        {
            this.Text = "";
            this.ShowIcon = false;
            LoadWorkoutNameComboBox();
            LoadExerciseNameComboBox();
            LoadWorkoutDaysComboBox();
        }

        // Workout Name
        private void LoadWorkoutNameComboBox()
        {
            try
            {
                WorkoutUI workoutUI = new WorkoutUI();

                DataTable dataTable = workoutUI.GetWorkoutPlansForComboBox();
                cmbWorkoutName.DataSource = dataTable;
                cmbWorkoutName.DisplayMember = "WorkoutName";
                cmbWorkoutName.ValueMember = "WorkoutPlanId";
                cmbWorkoutName.SelectedIndex = -1;
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
        // Exercise Name
        private void LoadExerciseNameComboBox()
        {
            try
            {
                WorkoutUI workoutUI = new WorkoutUI();

                DataTable dataTable =
                    workoutUI.GetExercisesForComboBox();

                cmbExerciseName.DataSource = dataTable;
                cmbExerciseName.DisplayMember = "ExerciseName";
                cmbExerciseName.ValueMember = "ExerciseId";

                cmbExerciseName.SelectedIndex = -1;
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
        // Workout Days
        private void LoadWorkoutDaysComboBox()
        {
            try
            {
                WorkoutUI workoutUI = new WorkoutUI();

                List<string> workoutDays =
                    workoutUI.GetWorkoutDaysUI();

                cmbWorkoutDays.Items.Clear();

                foreach (string day in workoutDays)
                {
                    cmbWorkoutDays.Items.Add(day);
                }

                cmbWorkoutDays.SelectedIndex = -1;
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
        // Submit Workout Schedule
        private void pnlClickSubmitWorkoutSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbWorkoutName.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select Workout Name.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbWorkoutName.Focus();
                    return;
                }

                if (cmbExerciseName.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select Exercise Name.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbExerciseName.Focus();
                    return;
                }

                if (cmbWorkoutDays.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select Workout Day.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbWorkoutDays.Focus();
                    return;
                }

                int workoutPlanId =
                    Convert.ToInt32(cmbWorkoutName.SelectedValue);

                int exerciseId =
                    Convert.ToInt32(cmbExerciseName.SelectedValue);

                string workoutDay =
                    cmbWorkoutDays.SelectedItem.ToString();

                WorkoutUI workoutUI = new WorkoutUI();

                string message =
                    workoutUI.InsertWorkoutScheduleUI(
                        workoutPlanId,
                        exerciseId,
                        workoutDay);

                if (message == "Record inserted successfuly")
                {
                    MessageBox.Show(
                        message,
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        message,
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
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
        // Clear Button Click Event
        private void btnClearWorkoutSchedule_Click(object sender, EventArgs e)
        {
            cmbWorkoutName.SelectedIndex = -1;
            cmbExerciseName.SelectedIndex = -1;
            cmbWorkoutDays.SelectedIndex = -1;
            this.ActiveControl = null;
        }
    }
}
