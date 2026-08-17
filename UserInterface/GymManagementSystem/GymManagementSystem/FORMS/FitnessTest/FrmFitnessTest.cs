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
            if (cmbActivityInput.Text.Trim() == "---select---")
            {
                cmbActivityInput.Text = "";
                cmbActivityInput.ForeColor = Color.Gray;
            }
        }

        private void cmbActivityInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbActivityInput.Text))
            {
                cmbActivityInput.Text = "---select---";
                cmbActivityInput.ForeColor = Color.Gray;
            }
        }

        private void cmbGoalInput_Enter(object sender, EventArgs e)
        {
            if (cmbGoalInput.Text.Trim() == "---select---")
            {
                cmbGoalInput.Text = "";
                cmbGoalInput.ForeColor = Color.Gray;
            }
        }

        private void cmbGoalInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbGoalInput.Text))
            {
                cmbGoalInput.Text = "---select---";
                cmbGoalInput.ForeColor = Color.Gray;
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

            cmbGenderInput.DataSource = dataTable;
            cmbGenderInput.DisplayMember = "GenderName";
            cmbGenderInput.SelectedIndex = -1;
        }
        private void LoadActivity()
        {
            DataTable dataTable =
                FitnessUI.GetActivityDetailsUI();

            cmbActivityInput.DataSource = dataTable;
            cmbActivityInput.DisplayMember = "Activity";
            cmbActivityInput.SelectedIndex = -1;
        }

        private void LoadGoal()
        {
            DataTable dataTable =
                FitnessUI.GetGoalDetailsUI();

            cmbGoalInput.DataSource = dataTable;
            cmbGoalInput.DisplayMember = "Goal";
            cmbGoalInput.SelectedIndex = -1;
        }

        private void txtHightInput_Click(object sender, EventArgs e)
        {
            ClickCountTxtHeight =
        ValidationUI.ClearTextBoxWhenClicked(
            txtHightInput,
            ClickCountTxtHeight);

            txtHightInput.ForeColor = Color.Black;
        }

        private void txtWeightInput_Click(object sender, EventArgs e)
        {
            ClickCountTxtWeight = ValidationUI.ClearTextBoxWhenClicked(
               txtWeightInput,
               ClickCountTxtWeight);

            txtWeightInput.ForeColor = Color.Black;
        }

        private void txtAgeInput_Click(object sender, EventArgs e)
        {
            ClickCountTxtAge = ValidationUI.ClearTextBoxWhenClicked(
               txtAgeInput,
               ClickCountTxtAge);

            txtAgeInput.ForeColor = Color.Black;
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

            if (!ValidationUI.ValidateRequiredTextBoxes(
                txtHightInput,
                txtWeightInput,
                txtAgeInput))
            {
                MessageBox.Show(
                    "Please fill up all things.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

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
    }
}
