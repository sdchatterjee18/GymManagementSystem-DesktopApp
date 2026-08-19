using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.Authentication.UI;
using GymManagementSystem.Common;

namespace GymManagementSystem.Authentication
{
    public partial class FrmSuperAdminRegistration : Form
    {
        int ClickCountTxtRegistrationSuperAdminUsername = 0;
        int ClickCountTxtRegistrationSuperAdminMobileNo = 0;
        int ClickCountTxtRegistrationSuperAdminEmailId = 0;
        int ClickCountTxtRegistrationSuperAdminPassword = 0;
        int ClickCountTxtRegistrationSuperAdminConfermPassword = 0;
        public FrmSuperAdminRegistration()
        {
            InitializeComponent();
        }

        private void FrmSuperAdminRegistration_Load(object sender, EventArgs e)
        {

        }

       
        

        private void FrmSuperAdminRegistration_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void pnlConfermPasswordSuperAdminRegistration_Enter(object sender, EventArgs e)
        {
            pnlConfermPasswordSuperAdminRegistration.BackColor = Color.PapayaWhip;
        }

        private void pnlConfermPasswordSuperAdminRegistration_Leave(object sender, EventArgs e)
        {
            pnlConfermPasswordSuperAdminRegistration.BackColor = Color.FloralWhite;
        }

        private void pnlEmailIdSuperAdminRegistration_Enter(object sender, EventArgs e)
        {
            pnlEmailIdSuperAdminRegistration.BackColor = Color.PapayaWhip;
        }

        private void pnlEmailIdSuperAdminRegistration_Leave(object sender, EventArgs e)
        {
            pnlEmailIdSuperAdminRegistration.BackColor = Color.FloralWhite;
        }

        private void pnlMobileNoSuperAdminRegistration_Enter(object sender, EventArgs e)
        {
            pnlMobileNoSuperAdminRegistration.BackColor = Color.PapayaWhip;
        }

        private void pnlMobileNoSuperAdminRegistration_Leave(object sender, EventArgs e)
        {
            pnlMobileNoSuperAdminRegistration.BackColor = Color.FloralWhite;
        }

        private void pnlPasswordSuperAdminRegistration_Enter(object sender, EventArgs e)
        {
            pnlPasswordSuperAdminRegistration.BackColor = Color.PapayaWhip;
        }

        private void pnlPasswordSuperAdminRegistration_Leave(object sender, EventArgs e)
        {
            pnlPasswordSuperAdminRegistration.BackColor = Color.FloralWhite;
        }

        private void pnlUsernameSuperAdminRegistration_Enter(object sender, EventArgs e)
        {
            pnlUsernameSuperAdminRegistration.BackColor = Color.PapayaWhip;
        }

        private void pnlUsernameSuperAdminRegistration_Leave(object sender, EventArgs e)
        {
            pnlUsernameSuperAdminRegistration.BackColor = Color.FloralWhite;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (chkShowPassword.Checked)
            {
                txtRegistrationSuperAdminPassword.PasswordChar = '\0';
                chkShowPassword.BackColor = Color.PapayaWhip;
            }
            else
            {
                txtRegistrationSuperAdminPassword.PasswordChar = '*';
            }
        }

        private void chkShowConfermPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowConfermPassword.Checked)
            {
                txtRegistrationSuperAdminConfermPassword.PasswordChar = '\0';
                chkShowConfermPassword.BackColor = Color.PapayaWhip;
            }
            else
            {
                txtRegistrationSuperAdminConfermPassword.PasswordChar = '*';
            }
        }

        private void btnSuperAdminRegistration_Click(object sender, EventArgs e)
        {
            // ==========================================
            // CLEAR DEFAULT PLACEHOLDER TEXT
            // ==========================================

            ValidationUI.ClearDefaultPlaceholderText(
                txtRegistrationSuperAdminUsername,
                ClickCountTxtRegistrationSuperAdminUsername);

            ValidationUI.ClearDefaultPlaceholderText(
                txtRegistrationSuperAdminMobileNo,
                ClickCountTxtRegistrationSuperAdminMobileNo);

            ValidationUI.ClearDefaultPlaceholderText(
                txtRegistrationSuperAdminEmailId,
                ClickCountTxtRegistrationSuperAdminEmailId);

            ValidationUI.ClearDefaultPlaceholderText(
                txtRegistrationSuperAdminPassword,
                ClickCountTxtRegistrationSuperAdminPassword);

            ValidationUI.ClearDefaultPlaceholderText(
                txtRegistrationSuperAdminConfermPassword,
                ClickCountTxtRegistrationSuperAdminConfermPassword);


            // ==========================================
            // REQUIRED TEXTBOX VALIDATION
            // ==========================================

            if (!ValidationUI.ValidateRequiredTextBoxes(
                txtRegistrationSuperAdminUsername,
                txtRegistrationSuperAdminMobileNo,
                txtRegistrationSuperAdminEmailId,
                txtRegistrationSuperAdminPassword,
                txtRegistrationSuperAdminConfermPassword))
            {
                return;
            }


            // ==========================================
            // CONFIRM PASSWORD VALIDATION
            // ==========================================

            if (txtRegistrationSuperAdminPassword.Text.Trim() !=
                txtRegistrationSuperAdminConfermPassword.Text.Trim())
            {
                MessageBox.Show(
                    "Password and Confirm Password do not match.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtRegistrationSuperAdminConfermPassword.BackColor =
                    Color.FromArgb(255, 240, 240);

                return;
            }


            // ==========================================
            // CREATE AUTHENTICATION UI OBJECT
            // ==========================================

            AuthenticationUI authenticationUI =
                new AuthenticationUI();


            // ==========================================
            // GET REGISTRATION VALUES
            // ==========================================

            string userName =
                txtRegistrationSuperAdminUsername.Text.Trim();

            string phoneNumber =
                txtRegistrationSuperAdminMobileNo.Text.Trim();

            string emailId =
                txtRegistrationSuperAdminEmailId.Text.Trim();

            string password =
                txtRegistrationSuperAdminPassword.Text.Trim();


            // ==========================================
            // REGISTER SUPER ADMIN
            // ==========================================

            try
            {
                string message =
                    authenticationUI.RegisterNewSuperAdminUI(
                        userName,
                        password,
                        emailId,
                        phoneNumber);

                MessageBox.Show(
                    message,
                    "Super Admin Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
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

        private void txtRegistrationSuperAdminUsername_Click(object sender, EventArgs e)
        {
            ClickCountTxtRegistrationSuperAdminUsername =
             ValidationUI.ClearTextBoxWhenClicked(
             txtRegistrationSuperAdminUsername,
             ClickCountTxtRegistrationSuperAdminUsername);

            txtRegistrationSuperAdminUsername.ForeColor = Color.Black;
        }

        private void txtRegistrationSuperAdminMobileNo_Click(object sender, EventArgs e)
        {
            ClickCountTxtRegistrationSuperAdminMobileNo =
             ValidationUI.ClearTextBoxWhenClicked(
            txtRegistrationSuperAdminMobileNo,
            ClickCountTxtRegistrationSuperAdminMobileNo);

            txtRegistrationSuperAdminMobileNo.ForeColor = Color.Black;
        }

        private void txtRegistrationSuperAdminEmailId_Click(object sender, EventArgs e)
        {
            ClickCountTxtRegistrationSuperAdminEmailId =
            ValidationUI.ClearTextBoxWhenClicked(
            txtRegistrationSuperAdminEmailId,
            ClickCountTxtRegistrationSuperAdminEmailId);

            txtRegistrationSuperAdminEmailId.ForeColor = Color.Black;
        }

        private void txtRegistrationSuperAdminPassword_Click(object sender, EventArgs e)
        {
            ClickCountTxtRegistrationSuperAdminPassword =
           ValidationUI.ClearTextBoxWhenClicked(
          txtRegistrationSuperAdminPassword,
          ClickCountTxtRegistrationSuperAdminPassword);

            txtRegistrationSuperAdminPassword.ForeColor = Color.Black;
        }

        private void txtRegistrationSuperAdminConfermPassword_Click(object sender, EventArgs e)
        {
            ClickCountTxtRegistrationSuperAdminConfermPassword =
            ValidationUI.ClearTextBoxWhenClicked(
           txtRegistrationSuperAdminConfermPassword,
           ClickCountTxtRegistrationSuperAdminConfermPassword);

            txtRegistrationSuperAdminConfermPassword.ForeColor = Color.Black;
        }
    }
}