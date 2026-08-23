using System;
using System.Drawing;
using System.Windows.Forms;
using GymManagementSystem.Common;
using GymManagementSystem.FORMS.Workout.UI;
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystem.FORMS.Workout
{
    public partial class FrmAddNewWorkoutPlan : Form
    {
        // Global Variables
        int ClickCountTxtWorkoutPlanName = 0;
        int ClickCountTxtDescription = 0;

        // Constructor
        public FrmAddNewWorkoutPlan()
        {
            InitializeComponent();
            SetErrorProviderAlignment();
        }
        private void SetErrorProviderAlignment()
        {
            errorProvider1.SetIconAlignment(
                txtWorkoutPlanName,
                ErrorIconAlignment.MiddleRight);

            errorProvider1.SetIconPadding(
                txtWorkoutPlanName,
                15);
        }
        // Workout Plan Name Click
      private void txtWorkoutPlanName_Click( object sender, EventArgs e)
        {
            ClickCountTxtWorkoutPlanName =
                ValidationUI.ClearTextBoxWhenClicked(
                    txtWorkoutPlanName,
                    ClickCountTxtWorkoutPlanName);

            txtWorkoutPlanName.ForeColor =
                Color.Black;
        }
        // Description Click
        private void txtDescription_Click(object sender,EventArgs e)
        {
            ClickCountTxtDescription =
                ValidationUI.ClearTextBoxWhenClicked(
                    txtDescription,
                    ClickCountTxtDescription);

            txtDescription.ForeColor =
                Color.Black;
        }
        // Submit Workout Plan
        private void pnlClickSubmitWorkoutPlan_Click(object sender, EventArgs e)
        {
            // Clear Placeholder Text
            ValidationUI.ClearDefaultPlaceholderText(
                txtWorkoutPlanName,
                ClickCountTxtWorkoutPlanName);

            ValidationUI.ClearDefaultPlaceholderText(
                txtDescription,
                ClickCountTxtDescription);


            // =========================
            // REQUIRED VALIDATION
            // =========================

            ValidationUI.ValidationResult result;
            bool isValid = true;

            errorProvider1.Clear();

            // Workout Plan Name
            result = ValidationUI.ValidateRequiredTextBox(
                txtWorkoutPlanName);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    txtWorkoutPlanName,
                    "Workout Plan Name " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }

            result = ValidationUI.ValidateRequiredTextBox(
                txtDescription);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    txtDescription,
                    "Description " +
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
            // CREATE UI OBJECT
            // =========================

            WorkoutUI workoutUI = new WorkoutUI();

            workoutUI.WorkoutName =
                txtWorkoutPlanName.Text.Trim();

            workoutUI.Description =
                txtDescription.Text.Trim();


            // =========================
            // CALL UI
            // =========================

            ValidationResult validationResult =
                workoutUI.InsertWorkoutPlanUI();


            // =========================
            // HANDLE RESULT
            // =========================

            HandleWorkoutPlanResult(validationResult);
        }
        private void HandleWorkoutPlanResult(ValidationResult result)
        {
            errorProvider1.Clear();

            if (result.Result ==
                ValidationBll.CommonValidationMessage.Valid)
            {
                MessageBox.Show(
                    result.Message,
                    "Workout Plan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();

                return;
            }

            switch (result.FieldName)
            {
                case "WorkoutPlanName":
                    errorProvider1.SetError(
                        txtWorkoutPlanName,
                        result.Message);
                    break;

                case "Description":
                    errorProvider1.SetError(
                        txtDescription,
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
        // Clear Button
        private void btnClearWorkoutPlan_Click(object sender,EventArgs e)
        {
            ClearWorkoutPlanForm();
        }
        // Clear Form
        private void ClearWorkoutPlanForm()
        {
            txtWorkoutPlanName.Clear();
            txtDescription.Clear();


            txtWorkoutPlanName.BackColor =
                Color.White;

            txtDescription.BackColor =
                Color.White;


            txtWorkoutPlanName.ForeColor =
                Color.Black;

            txtDescription.ForeColor =
                Color.Black;


            ClickCountTxtWorkoutPlanName = 0;
            ClickCountTxtDescription = 0;


            this.ActiveControl = null;
        }
        // Form Shown
        private void FrmAddNewWorkoutPlan_Shown(object sender,EventArgs e)
        {
            this.ActiveControl = null;
        }
        // Form Load
        private void FrmAddNewWorkoutPlan_Load( object sender,EventArgs e)
        {
            this.ShowIcon = false;
            this.Text = "";
            this.ActiveControl = null;
        }

        private void btnClearWorkoutPlan_MouseEnter(object sender, EventArgs e)
        {
            btnClearWorkoutPlan.BackColor = Color.White;
            btnClearWorkoutPlan.ForeColor = Color.MidnightBlue;
        }

        private void btnClearWorkoutPlan_MouseLeave(object sender, EventArgs e)
        {
            btnClearWorkoutPlan.BackColor = Color.MidnightBlue;
            btnClearWorkoutPlan.ForeColor = Color.White;
        }

        private void pnlClickSubmitWorkoutPlan_MouseEnter(object sender, EventArgs e)
        {

            pnlClickSubmitWorkoutPlan.BackColor = Color.White;
            lblAddNewWorkoutPlan.ForeColor = Color.MidnightBlue;
            picAddButtonWorkoutPlan.Image = Properties.Resources.paper_planeHOVER; 
        }

        private void pnlClickSubmitWorkoutPlan_MouseLeave(object sender, EventArgs e)
        {
            pnlClickSubmitWorkoutPlan.BackColor = Color.MidnightBlue;
            lblAddNewWorkoutPlan.ForeColor = Color.White;
            picAddButtonWorkoutPlan.Image = Properties.Resources.paper_plane; 
        }

    }
}