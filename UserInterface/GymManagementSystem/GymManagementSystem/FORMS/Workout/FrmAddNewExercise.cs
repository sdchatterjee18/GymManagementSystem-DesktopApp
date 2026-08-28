using System;
using System.Drawing;
using System.Windows.Forms;
using GymManagementSystem.Common;
using GymManagementSystem.FORMS.Workout.UI;
using GymManagementSystemBLLayer.Common;

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
            SetErrorProviderAlignment();
        }
        private void SetErrorProviderAlignment()
        {
            Control[] controls =
           {
                 txtExerciseName,
                 txtMuscleType
           };

            foreach (Control control in controls)
            {
                errorProvider1.SetIconAlignment(
                    control,
                    ErrorIconAlignment.MiddleRight);

                errorProvider1.SetIconPadding(
                    control,
                    15);
            }
        }
        // Exercise Name TextBox Click Event
        private void txtExerciseName_Click(object sender, EventArgs e)
        {
            ClickCountTxtExerciseName =ValidationUI.ClearTextBoxWhenClicked( txtExerciseName,ClickCountTxtExerciseName);

            txtExerciseName.ForeColor =
                Color.Black;
        }
        // Muscle Type TextBox Click Event
        private void txtMuscleType_Click(object sender, EventArgs e)
        {
            ClickCountTxtMuscleType =ValidationUI.ClearTextBoxWhenClicked( txtMuscleType,ClickCountTxtMuscleType);

            txtMuscleType.ForeColor =
                Color.Black;
        }
        // Submit Exercise
        private void pnlClickSubmitExercise_Click(object sender, EventArgs e)
        {

            // Clear placeholder text
            ValidationUI.ClearDefaultPlaceholderText(
                txtExerciseName,
                ClickCountTxtExerciseName);

            ValidationUI.ClearDefaultPlaceholderText(
                txtMuscleType,
                ClickCountTxtMuscleType);

            // =========================
            // REQUIRED FIELD VALIDATION
            // =========================

            ValidationUI.ValidationResult result;
            bool isValid = true;

            errorProvider1.Clear();

            // Exercise Name
            result = ValidationUI.ValidateRequiredTextBox(txtExerciseName);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    txtExerciseName,
                    "Exercise Name " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }

            // Muscle Type
            result = ValidationUI.ValidateRequiredTextBox(txtMuscleType);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    txtMuscleType,
                    "Muscle Type " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }

            // Stop if required validation failed
            if (!isValid)
            {
                MessageBox.Show(
                    "Please fill in all required fields.",
                    "Required Fields",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.ActiveControl = null;
                return;
            }

            // =========================
            // CALL UI LAYER
            // =========================

            WorkoutUI workoutUI = new WorkoutUI();

            workoutUI.ExerciseName = txtExerciseName.Text.Trim();
            workoutUI.MuscleType = txtMuscleType.Text.Trim();

            ValidationResult validationResult =workoutUI.InsertExerciseUI();

            // =========================
            // HANDLE BLL VALIDATION
            // =========================

            HandleExerciseResult(validationResult);
        }
        private void HandleExerciseResult(ValidationResult result)
        {
            errorProvider1.Clear();

            if (result.Result ==
                ValidationBll.CommonValidationMessage.Valid)
            {
                MessageBox.Show(
                    result.Message,
                    "Exercise",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();

                return;
            }

            switch (result.FieldName)
            {
                case "ExerciseName":
                    errorProvider1.SetError(
                        txtExerciseName,
                        result.Message);
                    break;

                case "MuscleType":
                    errorProvider1.SetError(
                        txtMuscleType,
                        result.Message);
                    break;
            }

            MessageBox.Show(
                result.Message,
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            this.ActiveControl = null;
        }
        // Submit Exercise
        private void btnClearExercise_Click(object sender, EventArgs e)
        {
            ClearExerciseForm();
        }
        // Clear Button Click Event
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
        // Form Shown Event
        private void FrmAddNewExercise_Shown_1(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
        // Form Load Event
        private void FrmAddNewExercise_Load_1(object sender, EventArgs e)
        {
            this.ShowIcon = false;
            this.Text = "";
            this.ActiveControl = null;
        }

        private void pnlClickSubmitExercise_MouseEnter(object sender, EventArgs e)
        {
            pnlClickSubmitExercise.BackColor = Color.White;
            lblAddNewExercise.ForeColor = Color.MidnightBlue;
            picAddButtonExercise.Image = Properties.Resources.paper_planeHOVER;
        }

        private void pnlClickSubmitExercise_MouseLeave(object sender, EventArgs e)
        {
            pnlClickSubmitExercise.BackColor = Color.MidnightBlue;
            lblAddNewExercise.ForeColor = Color.White;
            picAddButtonExercise.Image = Properties.Resources.paper_plane;
        }

        private void btnClearExercise_MouseEnter(object sender, EventArgs e)
        {
            btnClearExercise.BackColor = Color.White;
            btnClearExercise.ForeColor = Color.MidnightBlue;
        }

        private void btnClearExercise_MouseLeave(object sender, EventArgs e)
        {
            btnClearExercise.BackColor = Color.MidnightBlue;
            btnClearExercise.ForeColor = Color.White;
        }
    }
}