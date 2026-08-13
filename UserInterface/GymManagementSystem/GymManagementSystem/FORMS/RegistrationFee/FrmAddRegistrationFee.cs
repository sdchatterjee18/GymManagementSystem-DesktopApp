using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.Common;
using GymManagementSystem.FORMS.RegistrationFee.UI;


namespace GymManagementSystem.FORMS.RegistrationFee
{
    public partial class FrmAddRegistrationFee : Form
    {
        public FrmAddRegistrationFee()
        {
            InitializeComponent();
           
        }
        //int clickCountTxtRegistrationFee = 0;
        private void FrmAddRegistrationFee_Load(object sender, EventArgs e)
        {
            this.Text = "";
            this.ShowIcon = false;
        }

        private void lblFeesAmountStar_Click(object sender, EventArgs e)
        {
            

        }

        private void pnlAddRegistrationFee_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlSubmitButton_Click(object sender, EventArgs e)
        {
            // ==============================
            // Required Field Validation
            // ==============================

            if (!ValidationUI.ValidateRequiredTextBoxes(
                txtFeesAmountInAddRegistrationFee))
            {
                return;
            }


            try
            {
                // ==============================
                // Registration Fee UI
                // ==============================

                RegistrationFeeUI registrationFeeUI =
                    new RegistrationFeeUI();


                // ==============================
                // BLL Validation
                // ==============================

                string validationMessage =
                    registrationFeeUI.ValidateRegistrationFeeUI(
                        txtFeesAmountInAddRegistrationFee.Text.Trim());


                if (!string.IsNullOrEmpty(validationMessage))
                {
                    MessageBox.Show(
                        validationMessage,
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtFeesAmountInAddRegistrationFee.Focus();
                    return;
                }


                // ==============================
                // Convert to Decimal
                // ==============================

                decimal feeAmount;

                if (!decimal.TryParse(
                    txtFeesAmountInAddRegistrationFee.Text.Trim(),
                    out feeAmount))
                {
                    MessageBox.Show(
                        "Please enter a valid fee amount.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtFeesAmountInAddRegistrationFee.Focus();
                    return;
                }


                // ==============================
                // Set Fee Amount
                // ==============================

                registrationFeeUI.FeeAmount = feeAmount;


                // ==============================
                // Insert
                // ==============================

                string message =
                    registrationFeeUI.InsertRegistrationFeeUI();


                // ==============================
                // Show Result
                // ==============================

                MessageBox.Show(
                    message,
                    "Registration Fee",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
