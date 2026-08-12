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

        private void txtRegistrationSuperAdminPassword_Enter(object sender, EventArgs e)
        {

        }

      
       

       


    }
}