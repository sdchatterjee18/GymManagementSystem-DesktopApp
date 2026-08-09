using System;
using System.Drawing;
using System.Windows.Forms;
using GymManagementSystem.Common;
using GymManagementSystem.FORMS.Workout.UI;

namespace GymManagementSystem.FORMS.Workout
{
    public partial class FrmAddNewExercise : Form
    {
        // Global Variables
        int ClickCountTxtExerciseName = 0;
        int ClickCountTxtMuscleType = 0;


        // Constructor
        public FrmAddNewExercise()
        {
            InitializeComponent();
        }
        private void txtExerciseName_Click(object sender, EventArgs e)
        {
            ClickCountTxtExerciseName =ValidationUI.ClearTextBoxWhenClicked( txtExerciseName,ClickCountTxtExerciseName);

            txtExerciseName.ForeColor =
                Color.Black;
        }


        private void txtMuscleType_Click(object sender, EventArgs e)
        {
            ClickCountTxtMuscleType =ValidationUI.ClearTextBoxWhenClicked( txtMuscleType,ClickCountTxtMuscleType);

            txtMuscleType.ForeColor =
                Color.Black;
        }


        // Submit Exercise
        private void pnlClickSubmitExercise_Click(object sender, EventArgs e)
        {

            // Clear Placeholder Text
            ValidationUI.ClearDefaultPlaceholderText(txtExerciseName, ClickCountTxtExerciseName);
            ValidationUI.ClearDefaultPlaceholderText(txtMuscleType, ClickCountTxtMuscleType);
            //if (ClickCountTxtExerciseName == 0)
            //    txtExerciseName.Clear();

            //if (ClickCountTxtMuscleType == 0)
            //    txtMuscleType.Clear();
            // ValidationB
            if (!ValidationUI.ValidateRequiredTextBoxes(
                txtExerciseName,
                txtMuscleType))
            {
                return;
            }
            WorkoutUI workoutUI = new WorkoutUI();

            string message =
                workoutUI.InsertExerciseUI(txtExerciseName.Text.Trim(),txtMuscleType.Text.Trim());

            MessageBox.Show(
                message,
                "Exercise",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnClearExercise_Click(object sender, EventArgs e)
        {
            ClearExerciseForm();
        }

        private void ClearExerciseForm()
        {
            txtExerciseName.Clear();
            txtMuscleType.Clear();

            txtExerciseName.BackColor = Color.White;
            txtMuscleType.BackColor = Color.White;

            txtExerciseName.ForeColor = Color.Black;
            txtMuscleType.ForeColor = Color.Black;

            ClickCountTxtExerciseName = 0;
            ClickCountTxtMuscleType = 0;

            this.ActiveControl = null;
        }

        private void FrmAddNewExercise_Shown_1(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void FrmAddNewExercise_Load_1(object sender, EventArgs e)
        {
            this.ShowIcon = false;
            this.Text = "";
            this.ActiveControl = null;
        }

       


     
    }
}