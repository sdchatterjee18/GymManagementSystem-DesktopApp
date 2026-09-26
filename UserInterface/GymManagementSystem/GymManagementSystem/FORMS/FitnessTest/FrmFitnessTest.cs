using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.FORMS.Gender;
using GymManagementSystem.Common;
using GymManagementSystem.FORMS.FitnessTest.UI;
using GymManagementSystem.Common;

namespace GymManagementSystem.FORMS
{
    public partial class FrmFitnessTest : Form
    {
        int ClickCountTxtHeight = 0;
        int ClickCountTxtWeight = 0;
        int ClickCountTxtAge = 0;
        
        public FrmFitnessTest()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmFitnessTest_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            LoadGender();
            LoadActivity();
            LoadGoal();
        }

        private void cmbActivityInput_Enter(object sender, EventArgs e)
        {
            if (!MouseButtons.Equals(MouseButtons.Left))
            {
                cmbActivityInput.DroppedDown = true;
            }
        }

        private void cmbGoalInput_Enter(object sender, EventArgs e)
        {
           if (!MouseButtons.Equals(MouseButtons.Left))
           {
               cmbGoalInput.DroppedDown = true;
           }
        }

        private void FrmFitnessTest_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void LoadGender()
        {
            DataTable dataTable =
                GenderUI.GetGenderDetailsForComboBox();
            cmbGenderInput.Items.Clear();
            cmbGenderInput.DataSource = dataTable;
            cmbGenderInput.DisplayMember = "GenderName";
            cmbGenderInput.SelectedIndex = -1;
        }

        private void LoadActivity()
        {
            DataTable dataTable =
                FitnessUI.GetActivityDetailsUI();
            cmbActivityInput.Items.Clear();
            cmbActivityInput.DataSource = dataTable;
            cmbActivityInput.DisplayMember = "Activity";
            cmbActivityInput.SelectedIndex = -1;
        }

        private void LoadGoal()
        {
            DataTable dataTable =
                FitnessUI.GetGoalDetailsUI();
            cmbGoalInput.Items.Clear();
            cmbGoalInput.DataSource = dataTable;
            cmbGoalInput.DisplayMember = "Goal";
            cmbGoalInput.SelectedIndex = -1;
        }

        private void txtHightInput_Click(object sender, EventArgs e)
        {
            if (ClickCountTxtHeight != 1)
            {
                ClickCountTxtHeight = ValidationUI.ClearTextBoxWhenClicked(txtHightInput, ClickCountTxtHeight);
            }
        }

        private void txtWeightInput_Click(object sender, EventArgs e)
        {
            if (ClickCountTxtWeight != 1)
            {
                ClickCountTxtWeight = ValidationUI.ClearTextBoxWhenClicked(txtWeightInput, ClickCountTxtWeight);
            }
        }

        private void txtAgeInput_Click(object sender, EventArgs e)
        {
            if (ClickCountTxtAge != 1)
            {
                ClickCountTxtAge = ValidationUI.ClearTextBoxWhenClicked(txtAgeInput, ClickCountTxtAge);
            }
        }

        private void btnCalculateFitnessTest_Click(object sender, EventArgs e)
        {
            // =========================================================
            // Clear Default Placeholder Text
            // =========================================================

            if (ClickCountTxtHeight == 0)
                txtHightInput.Clear();

            if (ClickCountTxtWeight == 0)
                txtWeightInput.Clear();

            if (ClickCountTxtAge == 0)
                txtAgeInput.Clear();


            // =========================================================
            // Required Field Validation
            // =========================================================



            ValidationUI.ClearDefaultPlaceholderText(txtHightInput, ClickCountTxtHeight);
            ValidationUI.ClearDefaultPlaceholderText(txtWeightInput, ClickCountTxtWeight);
            ValidationUI.ClearDefaultPlaceholderText(txtAgeInput, ClickCountTxtAge);
            ValidationUI.ValidationResult result;
            bool IsValid = true;
            errorProvider1.Clear();
            result = ValidationUI.ValidateRequiredTextBox(txtHightInput);
            if (result != Common.ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(picHight, "Hight " + ValidationUI.GetValidationMessage(result));
                IsValid = false;
            }
            result = ValidationUI.ValidateRequiredTextBox(txtWeightInput);
            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(picWeight, "Weight " + ValidationUI.GetValidationMessage(result));
                IsValid = false;
            }
            result = ValidationUI.ValidateRequiredComboBox(cmbGenderInput);
            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(picGender, "Gender " + ValidationUI.GetValidationMessage(result));
                IsValid = false;
            }
            result = ValidationUI.ValidateRequiredTextBox(txtAgeInput);
            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(picAgeInput, "Age " + ValidationUI.GetValidationMessage(result));
                IsValid = false;
            }

            result = ValidationUI.ValidateRequiredComboBox(cmbActivityInput);
            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(picActivity, "Activity " + ValidationUI.GetValidationMessage(result));
                IsValid = false;
            }

            result = ValidationUI.ValidateRequiredComboBox(cmbGoalInput);
            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(picGoal, "Goal " + ValidationUI.GetValidationMessage(result));
                IsValid = false;
            }

            if (!IsValid)
            {
                MessageBox.Show("Please fill in all required fields.",
                                "Required Fields",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                if (string.IsNullOrWhiteSpace(txtHightInput.Text))
                {
                    txtHightInput.Text = "---Enter height---";
                    txtHightInput.ForeColor = Color.Gray;
                }

                if (string.IsNullOrWhiteSpace(txtWeightInput.Text))
                {
                    txtWeightInput.Text = "---Enter weight---";
                    txtWeightInput.ForeColor = Color.Gray;
                }

                if (string.IsNullOrWhiteSpace(txtAgeInput.Text))
                {
                    txtAgeInput.Text = "---Enter age---";
                    txtAgeInput.ForeColor = Color.Gray;
                }
                this.ActiveControl = null;
                return;
            }

            // =========================================================
            // ComboBox Validation
            // =========================================================

            if (cmbGenderInput.SelectedIndex == -1 ||
                cmbActivityInput.SelectedIndex == -1 ||
                cmbGoalInput.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please fill up all things.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            // =========================================================
            // Trim Input
            // =========================================================

            string heightText =
                txtHightInput.Text.Trim();

            string weightText =
                txtWeightInput.Text.Trim();

            string ageText =
                txtAgeInput.Text.Trim();

            string gender =
                cmbGenderInput.Text.Trim();

            string activity =
                cmbActivityInput.Text.Trim();

            string goal =
                cmbGoalInput.Text.Trim();


            // =========================================================
            // Numeric Conversion
            // =========================================================

            decimal height;
            decimal weight;
            int age;


            // =========================================================
            // Height
            // =========================================================

            if (!decimal.TryParse(heightText, out height))
            {
                MessageBox.Show(
                    "Height must be a valid number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtHightInput.Focus();

                return;
            }


            // =========================================================
            // Weight
            // =========================================================

            if (!decimal.TryParse(weightText, out weight))
            {
                MessageBox.Show(
                    "Weight must be a valid number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtWeightInput.Focus();

                return;
            }


            // =========================================================
            // Age
            // =========================================================

            if (!int.TryParse(ageText, out age))
            {
                MessageBox.Show(
                    "Age must be a valid whole number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAgeInput.Focus();

                return;
            }


            // =========================================================
            // FitnessUI Object
            // =========================================================

            FitnessUI fitnessUI =
                new FitnessUI();

            fitnessUI.GenderName = gender;
            fitnessUI.Hight = height;
            fitnessUI.Wight = weight;
            fitnessUI.Age = age;
            fitnessUI.Activity = activity;
            fitnessUI.Goal = goal;


            // =========================================================
            // BLL Validation through UI Layer
            // =========================================================

            string validationMessage =
                fitnessUI.ValidateFitnessTestUI();

            if (validationMessage != "Valid")
            {
                MessageBox.Show(
                    validationMessage,
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            // =========================================================
            // Calculation through UI Layer
            // =========================================================

            decimal bmi =
                fitnessUI.CalculateBMIUI();

            decimal bmr =
                fitnessUI.CalculateBMRUI();

            decimal ibw =
                fitnessUI.CalculateIBWUI();

            decimal tdee =
                fitnessUI.CalculateTDEEUI();

            decimal goalCalories =
                fitnessUI.CalculateGoalCaloriesUI();


            // =========================================================
            // Display Results
            // =========================================================

            lblResultBMI.Text =
                bmi.ToString("0.00");

            lblResultBMR.Text =
                bmr.ToString("0.00") + " kcal/day";

            lblResultIBW.Text =
                ibw.ToString("0.00") + " kg";

            lblResultTDEE.Text =
                tdee.ToString("0.00") + " kcal/day";


      
        }

        private void txtHightInput_Leave(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtHightInput.Text))
            {
                ClickCountTxtHeight = 0;
                txtHightInput.Text = "---Enter Hight---";
                txtHightInput.ForeColor = Color.Gray;
            }
        }

        private void txtWeightInput_Leave(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtWeightInput.Text))
            {
                ClickCountTxtWeight = 0;
                txtWeightInput.Text = "---Enter Weight---";
                txtWeightInput.ForeColor = Color.Gray;
            }
        }

        private void txtAgeInput_Leave(object sender, EventArgs e)
        { 
            if (string.IsNullOrWhiteSpace(txtAgeInput.Text))
            {
                ClickCountTxtAge = 0;
                txtAgeInput.Text = "---Enter Age---";
                txtAgeInput.ForeColor = Color.Gray;
            }
        }

        private void cmbGenderInput_Enter(object sender, EventArgs e)
        {
            if (!MouseButtons.Equals(MouseButtons.Left))
            {
                cmbGenderInput.DroppedDown = true;
            }
        }

        private void txtHightInput_Enter(object sender, EventArgs e)
        {
            if (ClickCountTxtHeight != 1)
            {
                ClickCountTxtHeight = ValidationUI.ClearTextBoxWhenClicked(txtHightInput, ClickCountTxtHeight);
            }
        }

        private void txtWeightInput_Enter(object sender, EventArgs e)
        {
            if (ClickCountTxtWeight != 1)
            {
                ClickCountTxtWeight = ValidationUI.ClearTextBoxWhenClicked(txtWeightInput, ClickCountTxtWeight);
            }
        }

        private void txtAgeInput_Enter(object sender, EventArgs e)
        {
            if(ClickCountTxtAge!=1)
            {
                ClickCountTxtAge = ValidationUI.ClearTextBoxWhenClicked(txtAgeInput, ClickCountTxtAge);
            }
        }
    }
}
