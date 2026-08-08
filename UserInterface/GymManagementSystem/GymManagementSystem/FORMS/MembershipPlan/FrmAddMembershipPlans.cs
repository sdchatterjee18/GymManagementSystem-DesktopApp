using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.Common;
using GymManagementSystem.FORMS.MembershipPlan.UI;

namespace GymManagementSystem.FORMS.MembershipPlan
{
    public partial class FrmAddMembershipPlans : Form
    {
        // Global Variables
        int ClickCountTxtPlanName = 0;
        int ClickCountTxtDuration = 0;
        int ClickCountTxtAmount = 0;
        int ClickCountTxtDescription = 0;
        
        // Constructor
        public FrmAddMembershipPlans()
        {
            InitializeComponent();
        }

        // // Form Load
        private void FrmAddMembershipPlans_Load(object sender, EventArgs e)
        {
            this.Text = "";
            this.ShowIcon = false;
            LoadPlanTypes();
        }
        private void btnPageRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPlanName.Clear();
            txtAmount.Clear();
            txtDescription.Clear();

            cmbPlanType.Text = "";
            txtPlanName.Focus();
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Submit
        private void pnlClickSubmit_Click(object sender, EventArgs e)
        {
            if (ClickCountTxtPlanName == 0)
                txtPlanName.Clear();

            if (ClickCountTxtDuration == 0)
                txtDuration.Clear();

            if (ClickCountTxtAmount == 0)
                txtAmount.Clear();

            if (ClickCountTxtDescription == 0)
                txtDescription.Clear();

            if (!ValidationUI.ValidateRequiredTextBoxes(
                txtPlanName,
                txtDuration,
                txtAmount,
                txtDescription))
            {
                return;
            }

            if (cmbPlanType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select Membership Plan Type.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbPlanType.Focus();
                return;
            }

            //=============================
            // Validation First
            //=============================

            MembershipPlanUI membershipPlanUI = new MembershipPlanUI();

            string validationMessage =
                membershipPlanUI.ValidateMembershipPlanUI(
                    txtPlanName.Text.Trim(),
                    txtDuration.Text.Trim(),
                    txtAmount.Text.Trim(),
                    txtDescription.Text.Trim());

            if (validationMessage != string.Empty)
            {
                MessageBox.Show(
                    validationMessage,
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            //=============================
            // Validation Pass
            // Now Convert
            //=============================

            membershipPlanUI.MembershipPlanName = txtPlanName.Text.Trim();
            membershipPlanUI.PlanTypeId = Convert.ToInt32(cmbPlanType.SelectedValue);
            membershipPlanUI.DurationInDays = Convert.ToInt32(txtDuration.Text.Trim());
            membershipPlanUI.Price = Convert.ToDecimal(txtAmount.Text.Trim());
            membershipPlanUI.Description = txtDescription.Text.Trim();

            //=============================
            // Insert
            //=============================

            string message = membershipPlanUI.InsertMembershipPlanUI();

            MessageBox.Show(
                message,
                "Membership Plan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (message == "Membership Plan Added Successfully.")
            {
                btnClear.PerformClick();
            }
        }

        // TextBox Click Events
        private void txtPlanName_Click(object sender, EventArgs e)
        {
            ClickCountTxtPlanName = ValidationUI.ClearTextBox(txtPlanName, ClickCountTxtPlanName);
            txtPlanName.ForeColor = Color.Black;
        }
        private void txtDuration_Click(object sender, EventArgs e)
        {
            ClickCountTxtDuration = ValidationUI.ClearTextBox(txtDuration, ClickCountTxtDuration);
            txtDuration.ForeColor = Color.Black;
        }
        private void txtAmount_Click(object sender, EventArgs e)
        {
            ClickCountTxtAmount = ValidationUI.ClearTextBox(txtAmount, ClickCountTxtAmount);
            txtAmount.ForeColor = Color.Black;
        }
        private void txtDescription_Click(object sender, EventArgs e)
        {
            ClickCountTxtDescription = ValidationUI.ClearTextBox(txtDescription, ClickCountTxtDescription);
            txtDescription.ForeColor = Color.Black;
        }

        // Load Membership Plan Types
        private void LoadPlanTypes()
        {
            MembershipPlanUI membershipPlanUI = new MembershipPlanUI();

            cmbPlanType.DataSource = membershipPlanUI.GetMembershipPlanTypeDetailsForComboBox();
            cmbPlanType.DisplayMember = "PlanType";
            cmbPlanType.ValueMember = "PlanTypeId";
            cmbPlanType.SelectedIndex = -1;
        }  
    }
}
