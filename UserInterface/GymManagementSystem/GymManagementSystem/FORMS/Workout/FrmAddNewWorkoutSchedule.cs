using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.FORMS.Workout.UI;
using GymManagementSystem.Common;

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
            LoadWorkoutDaysComboBox();
            LoadExerciseComboBox();
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

        private void LoadExerciseComboBox()
        {
            try
            {
                WorkoutUI workoutUI = new WorkoutUI();
                
                DataTable dataTable = workoutUI.GetExercisesForComboBox();
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
            
            ValidationUI.ValidationResult result;
            bool IsValid = true;
            errorProvider1.Clear();

            result = ValidationUI.ValidateRequiredComboBox(cmbWorkoutName);
            if( result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(cmbWorkoutName,"Is required" + ValidationUI.GetValidationMessage(result));
                IsValid = false;
            }

            result = ValidationUI.ValidateRequiredComboBox(cmbExerciseName);

            if(result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(cmbExerciseName,"is required" + ValidationUI.GetValidationMessage(result));
                IsValid = false;
            }

             result = ValidationUI.ValidateRequiredComboBox(cmbWorkoutDays);

            if(result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(cmbWorkoutDays,"is required" + ValidationUI.GetValidationMessage(result));
                IsValid = false;
            }

            if (!IsValid)
            {
                MessageBox.Show("Please fill in all required fields.",
                                "Required Fields",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                this.ActiveControl = null;
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
        // Clear Button Click Event
        private void btnClearWorkoutSchedule_Click(object sender, EventArgs e)
        {
            cmbWorkoutName.SelectedIndex = -1;
            cmbExerciseName.SelectedIndex = -1;
            cmbWorkoutDays.SelectedIndex = -1;
            this.ActiveControl = null;
        }

        private void pnlClickSubmitWorkoutSchedule_MouseEnter(object sender, EventArgs e)
        {
            pnlClickSubmitWorkoutSchedule.BackColor = Color.White;
            picAddButtonWorkoutSchedule.Image = Properties.Resources.paper_planeHOVER;
            lblAddNewWorkoutSchedule.ForeColor = Color.MidnightBlue;
        }

        private void pnlClickSubmitWorkoutSchedule_MouseLeave(object sender, EventArgs e)
        {
            pnlClickSubmitWorkoutSchedule.BackColor = Color.MidnightBlue;
            picAddButtonWorkoutSchedule.Image = Properties.Resources.paper_plane;
            lblAddNewWorkoutSchedule.ForeColor = Color.White;
        }

        private void btnClearWorkoutSchedule_MouseEnter(object sender, EventArgs e)
        {
            btnClearWorkoutSchedule.BackColor = Color.White;
            btnClearWorkoutSchedule.ForeColor = Color.MidnightBlue;
        }

        private void btnClearWorkoutSchedule_MouseLeave(object sender, EventArgs e)
        {
            btnClearWorkoutSchedule.BackColor = Color.MidnightBlue;
            btnClearWorkoutSchedule.ForeColor = Color.White;
        }

        private void cmbWorkoutName_Enter(object sender, EventArgs e)
        {
            cmbWorkoutName.DroppedDown = true;
        }

        private void cmbExerciseName_Enter(object sender, EventArgs e)
        {
            cmbExerciseName.DroppedDown = true;
        }

        private void cmbWorkoutDays_Enter(object sender, EventArgs e)
        {
            cmbWorkoutDays.DroppedDown = true;
        }
    }
}
