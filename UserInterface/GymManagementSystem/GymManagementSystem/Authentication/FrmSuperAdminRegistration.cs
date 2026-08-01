using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem.Authentication
{
    public partial class FrmSuperAdminRegistration : Form
    {
        public FrmSuperAdminRegistration()
        {
            InitializeComponent();
        }

        private void FrmSuperAdminRegistration_Load(object sender, EventArgs e)
        {

        }

        private void txtRegistrationSuperAdminUsername_Enter(object sender, EventArgs e)
        {
            if (txtRegistrationSuperAdminUsername.Text.Trim() == "Enter Username")
            {
                txtRegistrationSuperAdminUsername.Text = "";
                txtRegistrationSuperAdminUsername.ForeColor = Color.Gray;
            }
        }

        private void txtRegistrationSuperAdminUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegistrationSuperAdminUsername.Text))
            {
                txtRegistrationSuperAdminUsername.Text = "Enter Username";
                txtRegistrationSuperAdminUsername.ForeColor = Color.Gray;
            }
        }

        private void txtRegistrationSuperAdminMobileNo_Enter(object sender, EventArgs e)
        {
            if (txtRegistrationSuperAdminMobileNo.Text.Trim() == "Enter Mobile no")
            {
                txtRegistrationSuperAdminMobileNo.Text = "";
                txtRegistrationSuperAdminMobileNo.ForeColor = Color.Gray;
            }
        }

        private void txtRegistrationSuperAdminMobileNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegistrationSuperAdminMobileNo.Text))
            {
                txtRegistrationSuperAdminMobileNo.Text = "Enter Mobile no";
                txtRegistrationSuperAdminMobileNo.ForeColor = Color.Gray;
            }
        }

        private void txtRegistrationSuperAdminEmailId_Enter(object sender, EventArgs e)
        {
            if (txtRegistrationSuperAdminEmailId.Text.Trim() == "Enter Email Id")
            {
                txtRegistrationSuperAdminEmailId.Text = "";
                txtRegistrationSuperAdminEmailId.ForeColor = Color.Gray;
            }
        }

        private void txtRegistrationSuperAdminEmailId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegistrationSuperAdminEmailId.Text))
            {
                txtRegistrationSuperAdminEmailId.Text = "Enter Email Id";
                txtRegistrationSuperAdminEmailId.ForeColor = Color.Gray;
            }
        }

        private void txtRegistrationSuperAdminPassword_Enter(object sender, EventArgs e)
        {
            if (txtRegistrationSuperAdminPassword.Text.Trim() == "Enter Password")
            {
                txtRegistrationSuperAdminPassword.Text = "";
                txtRegistrationSuperAdminPassword.ForeColor = Color.Gray;
            }
        }

        private void txtRegistrationSuperAdminPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegistrationSuperAdminPassword.Text))
            {
                txtRegistrationSuperAdminPassword.Text = "Enter Password";
                txtRegistrationSuperAdminPassword.ForeColor = Color.Gray;
            }
        }

        private void txtRegistrationSuperAdminConfermPassword_Enter(object sender, EventArgs e)
        {
            if (txtRegistrationSuperAdminConfermPassword.Text.Trim() == "Confirm Password")
            {
                txtRegistrationSuperAdminConfermPassword.Text = "";
                txtRegistrationSuperAdminConfermPassword.ForeColor = Color.Gray;
            }
        }

        private void txtRegistrationSuperAdminConfermPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegistrationSuperAdminConfermPassword.Text))
            {
                txtRegistrationSuperAdminConfermPassword.Text = "Confirm Password";
                txtRegistrationSuperAdminConfermPassword.ForeColor = Color.Gray;
            }
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
                txtRegistrationSuperAdminPassword.PasswordChar = '\0';
                chkShowConfermPassword.BackColor = Color.PapayaWhip;
            }
            else
            {
                txtRegistrationSuperAdminPassword.PasswordChar = '*';
            }
        }

        private void txtRegistrationSuperAdminConfermPassword_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
