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
using GymManagementSystemBLLayer.Common;

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
            SetErrorProviderAlignment();
        }
        private void SetErrorProviderAlignment()
        {
            Control[] controls =
            {
               this.txtPlanName,
               this.txtDuration,
               this.txtAmount,
               this.txtDescription
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
        private void FrmAddMembershipPlans_Load(object sender, EventArgs e)
        {
            txtPlanName.Focus();
            this.Text = "";
            this.ShowIcon = false;
            LoadPlanTypes();
            this.ActiveControl = null;
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
            //CLEAR TEXTBOX IF IT CONTAINS DEFAULT PLACEHOLDER BEFORE REGISTRATION BUTTON CLICK
            ValidationUI.ClearDefaultPlaceholderText(txtPlanName, ClickCountTxtPlanName);
            ValidationUI.ClearDefaultPlaceholderText(txtDuration, ClickCountTxtDuration);
            ValidationUI.ClearDefaultPlaceholderText(txtAmount, ClickCountTxtAmount);
            ValidationUI.ClearDefaultPlaceholderText(txtDescription, ClickCountTxtDescription);
            // VALIDATION
            ValidationUI.ValidationResult result;
            bool isValid = true;
            errorProvider1.Clear();

            // Plan Name
            result = ValidationUI.ValidateRequiredTextBox(txtPlanName);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    txtPlanName,
                    "Plan Name " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }

            // Duration
            result = ValidationUI.ValidateRequiredTextBox(txtDuration);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    txtDuration,
                    "Duration " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }

            // Amount
            result = ValidationUI.ValidateRequiredTextBox(txtAmount);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    txtAmount,
                    "Amount " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }

            // Description
            result = ValidationUI.ValidateRequiredTextBox(txtDescription);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    txtDescription,
                    "Description " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }
            // Gender
            result = ValidationUI.ValidateRequiredComboBox(
                cmbPlanType);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    cmbPlanType,
                    "Play Type " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }
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
            int duration;
            decimal price;
            if (!int.TryParse(txtDuration.Text.Trim(), out duration))
            {
                errorProvider1.SetError(
                    txtDuration,
                    "Duration must contain only numbers.");

                MessageBox.Show(
                    "Duration must contain only numbers.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            if (!decimal.TryParse(txtAmount.Text.Trim(), out price))
            {
                errorProvider1.SetError(
                    txtAmount,
                    "Price must contain a valid numeric value.");

                MessageBox.Show(
                    "Price must contain a valid numeric value.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            MembershipPlanUI membershipPlanUI = new MembershipPlanUI();
            membershipPlanUI.MembershipPlanName = txtPlanName.Text.Trim();
            membershipPlanUI.PlanTypeId = Convert.ToInt32(cmbPlanType.SelectedValue);
            membershipPlanUI.DurationInDays = duration;
            membershipPlanUI.Price = price;
            membershipPlanUI.Description = txtDescription.Text.Trim();

            ValidationResult finalResult =membershipPlanUI.InsertMembershipPlanUI();

            HandleMembershipPlanResult(finalResult);
        }
        private void HandleMembershipPlanResult(ValidationResult result)
        {
            errorProvider1.Clear();

            if (result.Result == ValidationBll.CommonValidationMessage.Valid)
            {
                MessageBox.Show(
                    result.Message,
                    "Membership Plan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            switch (result.FieldName)
            {
                case "PlanName":
                    errorProvider1.SetError(
                        txtPlanName,
                        result.Message);
                    break;

                case "Duration":
                    errorProvider1.SetError(
                        txtDuration,
                        result.Message);
                    break;

                case "Amount":
                    errorProvider1.SetError(
                        txtAmount,
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


        // TextBox Click Events
        private void txtPlanName_Click(object sender, EventArgs e)
        {
            
            if (txtPlanName.ForeColor == Color.Gray)
            {
                txtPlanName.Clear();
                txtPlanName.ForeColor = Color.Black;
            }
            
        }
        private void txtDuration_Click(object sender, EventArgs e)
        {
           
            if (txtDuration.ForeColor == Color.Gray)
            {
                txtDuration.Clear();
                txtDuration.ForeColor = Color.Black;
            }
            
        }
        private void txtAmount_Click(object sender, EventArgs e)
        {
           
            if (txtAmount.ForeColor == Color.Gray)
            {
                txtAmount.Clear();
                txtAmount.ForeColor = Color.Black;
            }
            
        }
        private void txtDescription_Click(object sender, EventArgs e)
        {
            
            if (txtDescription.ForeColor == Color.Gray)
            {
                txtDescription.Clear();
                txtDescription.ForeColor = Color.Black;
            }
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

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.MidnightBlue;
            btnClear.BackColor = Color.White;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.White;
            btnClear.BackColor = Color.MidnightBlue;
        }

        private void pnlClickSubmit_MouseEnter(object sender, EventArgs e)
        {
            pnlClickSubmit.BackColor = Color.White;
            lblSubmit.ForeColor = Color.MidnightBlue;
            picAddButton.Image = Properties.Resources.paper_planeHOVER;
        }

        private void pnlClickSubmit_MouseLeave(object sender, EventArgs e)
        {
            pnlClickSubmit.BackColor = Color.MidnightBlue;
            lblSubmit.ForeColor = Color.White;
            picAddButton.Image = Properties.Resources.paper_plane;
        }

        private void FrmAddMembershipPlans_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void tlpNewMembarshipPlanDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbPlanType_Enter(object sender, EventArgs e)
        {
            cmbPlanType.DroppedDown = true;
        }

        private void txtPlanName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlanName.Text))
            {
                txtPlanName.Text = "Enter Plan Name";
                txtPlanName.ForeColor = Color.Gray;
            }
        }

        private void txtDuration_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDuration.Text))
            {
                txtDuration.Text = "Enter Duration";
                txtDuration.ForeColor = Color.Gray;
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                txtAmount.Text = "Enter Amount";
                txtAmount.ForeColor = Color.Gray;
            }
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                txtDescription.Text = "Enter Description";
                txtDescription.ForeColor = Color.Gray;
            }

        }  
    }
}
