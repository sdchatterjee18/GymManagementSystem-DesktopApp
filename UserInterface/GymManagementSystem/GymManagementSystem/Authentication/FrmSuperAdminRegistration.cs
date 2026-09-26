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
            this.ShowIcon = false;
            this.Text = "";
            txtRegistrationSuperAdminConfermPassword.UseSystemPasswordChar = false;
            txtRegistrationSuperAdminPassword.UseSystemPasswordChar = false;
            this.ActiveControl = null;
        }  
        private void FrmSuperAdminRegistration_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void pnlConfermPasswordSuperAdminRegistration_Enter(object sender, EventArgs e)
        {
            //pnlConfermPasswordSuperAdminRegistration.BackColor = Color.PapayaWhip;
        }

        private void pnlConfermPasswordSuperAdminRegistration_Leave(object sender, EventArgs e)
        {
            //pnlConfermPasswordSuperAdminRegistration.BackColor = Color.FloralWhite;
        }

        private void pnlEmailIdSuperAdminRegistration_Enter(object sender, EventArgs e)
        {
            //pnlEmailIdSuperAdminRegistration.BackColor = Color.PapayaWhip;
        }

        private void pnlEmailIdSuperAdminRegistration_Leave(object sender, EventArgs e)
        {
            //pnlEmailIdSuperAdminRegistration.BackColor = Color.FloralWhite;
        }

        private void pnlMobileNoSuperAdminRegistration_Enter(object sender, EventArgs e)
        {
            //pnlMobileNoSuperAdminRegistration.BackColor = Color.PapayaWhip;
        }

        private void pnlMobileNoSuperAdminRegistration_Leave(object sender, EventArgs e)
        {
            //pnlMobileNoSuperAdminRegistration.BackColor = Color.FloralWhite;
        }

        private void pnlPasswordSuperAdminRegistration_Enter(object sender, EventArgs e)
        {
            //pnlPasswordSuperAdminRegistration.BackColor = Color.PapayaWhip;
        }

        private void pnlPasswordSuperAdminRegistration_Leave(object sender, EventArgs e)
        {
            //pnlPasswordSuperAdminRegistration.BackColor = Color.FloralWhite;
        }

        private void pnlUsernameSuperAdminRegistration_Enter(object sender, EventArgs e)
        {
            //pnlUsernameSuperAdminRegistration.BackColor = Color.PapayaWhip;
        }

        private void pnlUsernameSuperAdminRegistration_Leave(object sender, EventArgs e)
        {
            //pnlUsernameSuperAdminRegistration.BackColor = Color.FloralWhite;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (chkShowPassword.Checked)
            {
                txtRegistrationSuperAdminPassword.PasswordChar = '\0';
            }
            else
            {
                txtRegistrationSuperAdminPassword.PasswordChar = '●';
            }
        }

        private void chkShowConfermPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowConfermPassword.Checked)
            {
                txtRegistrationSuperAdminConfermPassword.PasswordChar = '\0';
            }
            else
            {
                txtRegistrationSuperAdminConfermPassword.PasswordChar = '●';
            }
        }
        private void txtRegistrationSuperAdminUsername_Click(object sender, EventArgs e)
        {
            if (ClickCountTxtRegistrationSuperAdminUsername!=1)
            {
                ClickCountTxtRegistrationSuperAdminUsername = ValidationUI.ClearTextBoxWhenClicked(txtRegistrationSuperAdminUsername,
             ClickCountTxtRegistrationSuperAdminUsername);
            }
        }

        private void txtRegistrationSuperAdminMobileNo_Click(object sender, EventArgs e)
        {
            if (ClickCountTxtRegistrationSuperAdminMobileNo != 1)
            {
                ClickCountTxtRegistrationSuperAdminMobileNo =
             ValidationUI.ClearTextBoxWhenClicked(txtRegistrationSuperAdminMobileNo, ClickCountTxtRegistrationSuperAdminMobileNo);
            }            
        }

        private void txtRegistrationSuperAdminEmailId_Click(object sender, EventArgs e)
        {
            if (ClickCountTxtRegistrationSuperAdminEmailId != 1)
            {
                ClickCountTxtRegistrationSuperAdminEmailId =
            ValidationUI.ClearTextBoxWhenClicked(txtRegistrationSuperAdminEmailId, ClickCountTxtRegistrationSuperAdminEmailId);
            }
        }

        private void txtRegistrationSuperAdminPassword_Click(object sender, EventArgs e)
        {
            if (ClickCountTxtRegistrationSuperAdminPassword!=1)
            {
                ClickCountTxtRegistrationSuperAdminPassword = ValidationUI.ClearTextBoxWhenClicked(txtRegistrationSuperAdminPassword, ClickCountTxtRegistrationSuperAdminPassword);
            }
        }

        private void txtRegistrationSuperAdminConfermPassword_Click(object sender, EventArgs e)
        {
            if (ClickCountTxtRegistrationSuperAdminConfermPassword!=1)
            {
                ClickCountTxtRegistrationSuperAdminConfermPassword = ValidationUI.ClearTextBoxWhenClicked(txtRegistrationSuperAdminConfermPassword,
           ClickCountTxtRegistrationSuperAdminConfermPassword);
            }
        }

        private void txtRegistrationSuperAdminUsername_Enter(object sender, EventArgs e)
        {
            if (ClickCountTxtRegistrationSuperAdminUsername != 1)
            {
                ClickCountTxtRegistrationSuperAdminUsername = ValidationUI.ClearTextBoxWhenClicked(txtRegistrationSuperAdminUsername,
             ClickCountTxtRegistrationSuperAdminUsername);
            }
        }

        private void txtRegistrationSuperAdminMobileNo_Enter(object sender, EventArgs e)
        {
            if (ClickCountTxtRegistrationSuperAdminMobileNo != 1)
            {
                ClickCountTxtRegistrationSuperAdminMobileNo =
             ValidationUI.ClearTextBoxWhenClicked(txtRegistrationSuperAdminMobileNo, ClickCountTxtRegistrationSuperAdminMobileNo);
            }  
        }

        private void txtRegistrationSuperAdminEmailId_Enter(object sender, EventArgs e)
        {
            if (ClickCountTxtRegistrationSuperAdminEmailId != 1)
            {
                ClickCountTxtRegistrationSuperAdminEmailId =
            ValidationUI.ClearTextBoxWhenClicked(txtRegistrationSuperAdminEmailId, ClickCountTxtRegistrationSuperAdminEmailId);
            }
        }

        private void txtRegistrationSuperAdminPassword_Enter(object sender, EventArgs e)
        {
            if (ClickCountTxtRegistrationSuperAdminPassword != 1)
            {
                ClickCountTxtRegistrationSuperAdminPassword = ValidationUI.ClearTextBoxWhenClicked(txtRegistrationSuperAdminPassword, ClickCountTxtRegistrationSuperAdminPassword);
            }
        }

        private void txtRegistrationSuperAdminConfermPassword_Enter(object sender, EventArgs e)
        {
            if (ClickCountTxtRegistrationSuperAdminConfermPassword != 1)
            {
                ClickCountTxtRegistrationSuperAdminConfermPassword = ValidationUI.ClearTextBoxWhenClicked(txtRegistrationSuperAdminConfermPassword,
           ClickCountTxtRegistrationSuperAdminConfermPassword);
            }
        }

        private void txtRegistrationSuperAdminUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegistrationSuperAdminUsername.Text))
            {
                txtRegistrationSuperAdminUsername.Text = "---Enter Username---";
                txtRegistrationSuperAdminUsername.ForeColor = Color.Gray;
                ClickCountTxtRegistrationSuperAdminUsername = 0;
            }
            txtRegistrationSuperAdminMobileNo.Focus();
        }

        private void txtRegistrationSuperAdminMobileNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegistrationSuperAdminMobileNo.Text))
            {
                txtRegistrationSuperAdminMobileNo.Text = "---Enter MobileNo---";
                txtRegistrationSuperAdminMobileNo.ForeColor = Color.Gray;
                ClickCountTxtRegistrationSuperAdminMobileNo = 0;
            }
            txtRegistrationSuperAdminEmailId.Focus();
        }

        private void txtRegistrationSuperAdminEmailId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegistrationSuperAdminEmailId.Text))
            {
                txtRegistrationSuperAdminEmailId.Text = "---Enter EmailId---";
                txtRegistrationSuperAdminEmailId.ForeColor = Color.Gray;
                ClickCountTxtRegistrationSuperAdminEmailId = 0;
            }
            txtRegistrationSuperAdminPassword.Focus();
        }

        private void txtRegistrationSuperAdminConfermPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegistrationSuperAdminConfermPassword.Text))
            {
                txtRegistrationSuperAdminConfermPassword.Text = "---Confirm Password---";
                txtRegistrationSuperAdminConfermPassword.ForeColor = Color.Gray;
                ClickCountTxtRegistrationSuperAdminConfermPassword = 0;
            }
            txtRegistrationSuperAdminUsername.Focus();
        }

        private void txtRegistrationSuperAdminPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegistrationSuperAdminPassword.Text))
            {
                txtRegistrationSuperAdminPassword.Text = "---Confirm Password---";
                txtRegistrationSuperAdminPassword.ForeColor = Color.Gray;
                ClickCountTxtRegistrationSuperAdminPassword = 0;
            }
            txtRegistrationSuperAdminConfermPassword.Focus();
        }

        private void btnSuperAdminRegistration_Click(object sender, EventArgs e)
        {
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

            //if (!ValidationUI.ValidateRequiredTextBoxes(
            //    txtRegistrationSuperAdminUsername,
            //    txtRegistrationSuperAdminMobileNo,B
            //    txtRegistrationSuperAdminEmailId,
            //    txtRegistrationSuperAdminPassword,
            //    txtRegistrationSuperAdminConfermPassword))
            //{
            //    return;
            //}


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
    }
}