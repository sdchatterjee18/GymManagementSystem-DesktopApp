using System;
using System.Drawing;
using System.Windows.Forms;
using GymManagementSystem.Common;
using GymManagementSystem.FORMS.Workout.UI;

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


            // Required Validation
            if (!ValidationUI.ValidateRequiredTextBoxes(
                txtWorkoutPlanName,
                txtDescription))
            {
                return;
            }


            // Workout UI
            WorkoutUI workoutUI =
                new WorkoutUI();


            // Insert Workout Plan
            string message =
                workoutUI.InsertWorkoutPlanUI(
                    txtWorkoutPlanName.Text.Trim(),
                    txtDescription.Text.Trim());


            // Show Result
            MessageBox.Show(
                message,
                "Workout Plan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            // Only close when insertion is successful
            if (message == "Record inserted successfuly")
            {
                this.DialogResult =
                    DialogResult.OK;

                this.Close();
            }
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
    }
}