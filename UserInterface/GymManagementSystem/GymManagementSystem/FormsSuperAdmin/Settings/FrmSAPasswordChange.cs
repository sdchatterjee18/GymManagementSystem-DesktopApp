using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.Common;
using GymManagementSystem.FormsSuperAdmin.Settings.UI;

namespace GymManagementSystem.FormsSuperAdmin.Settings
{
    public partial class FrmSAPasswordChange : Form
    {
        public FrmSAPasswordChange()
        {
            InitializeComponent();
        }
        int clickCountUserName = 0;
        int clickCountOldPassword = 0;
        int clickCountNewPassword = 0;
        int clickCountConfirmPassword = 0;
        private string UserName = null;
        private string CurrentPassword = null;
        private string NewPassword = null;
        private string ConfirmNewPassword = null;
        private void FrmSAPasswordChange_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        

        private void FrmSAPasswordChange_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void txtOldPassword_Click(object sender, EventArgs e)
        {
            clickCountOldPassword=ValidationUI.ClearTextBoxWhenClicked(txtOldPassword, clickCountOldPassword);
            txtOldPassword.ForeColor = Color.Black;
        }

        private void txtNewPassword_Click(object sender, EventArgs e)
        {
            clickCountNewPassword = ValidationUI.ClearTextBoxWhenClicked(txtNewPassword, clickCountNewPassword);
            txtNewPassword.ForeColor = Color.Black;
        }

        private void txtConfermPassword_Click(object sender, EventArgs e)
        {
            clickCountConfirmPassword = ValidationUI.ClearTextBoxWhenClicked(txtConfirmPassword,clickCountConfirmPassword);
            txtConfirmPassword.ForeColor = Color.Black;
        }
        private void txtUserName_Click(object sender, EventArgs e)
        {
            clickCountUserName = ValidationUI.ClearTextBoxWhenClicked(txtUserName, clickCountUserName);
            txtUserName.ForeColor = Color.Black;
        }
        private void tlpSubmit_Click(object sender, EventArgs e)
        {
            SuperAdminChangePasswordUI superAdminChangePasswordUI =
                new SuperAdminChangePasswordUI();

            UserName = txtUserName.Text;
            CurrentPassword = txtOldPassword.Text;
            NewPassword = txtNewPassword.Text;

             ConfirmNewPassword =
                txtConfirmPassword.Text;

            string message;

            bool result =
                superAdminChangePasswordUI.ChangeSuperAdminPasswordUI(
                    UserName,
                    CurrentPassword,
                    NewPassword,
                    ConfirmNewPassword,
                    out message);

            MessageBox.Show(message);

            // CLOSE ONLY IF PASSWORD CHANGE WAS SUCCESSFUL
            if (result)
            {
                this.Close();
            }
        }

        private void tlpSubmit_MouseEnter(object sender, EventArgs e)
        {
            tlpSubmit.BackColor = Color.White;
            lblSubmit.ForeColor = Color.MidnightBlue;
        }

        private void tlpSubmit_MouseLeave(object sender, EventArgs e)
        {
            tlpSubmit.BackColor = Color.MidnightBlue;
            lblSubmit.ForeColor = Color.White;
        } 
    }
}
