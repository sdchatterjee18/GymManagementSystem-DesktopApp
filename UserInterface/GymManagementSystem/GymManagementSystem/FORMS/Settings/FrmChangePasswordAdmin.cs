using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.Common;
using GymManagementSystem.FORMS.Settings.UI;

namespace GymManagementSystem.FORMS.Settings
{
    public partial class FrmChangePasswordAdmin : Form
    {
        int ClickCountTxtOldPassword = 0;
        int ClickCountTxtNewPassword = 0;
        int ClickCountTxtConfirmPassword = 0;
        int ClickCountTxtUserName = 0;
        public FrmChangePasswordAdmin()
        {
            InitializeComponent();

            // Username → visible
            txtUserName.UseSystemPasswordChar = false;

            // Old Password → visible by default
            txtOldPassword.UseSystemPasswordChar = false;

            // New Password → hidden by default
            txtNewPassword.UseSystemPasswordChar = true;

            // Confirm Password → hidden by default
            txtConfirmPassword.UseSystemPasswordChar = true;

            // Eye icons → hidden/closed initially
            picNewPasswordHide.Image = Properties.Resources.hidden;
            picConfirmPasswordHide.Image = Properties.Resources.hidden;
        }

        private void FrmChangePasswordAdmin_Load(object sender, EventArgs e)
        {
            this.Text = "";
            this.ShowIcon = false;
        }

        private void txtOldPassword_Click(object sender, EventArgs e)
        {
            ClickCountTxtOldPassword =
                ValidationUI.ClearTextBoxWhenClicked(
                    txtOldPassword,
                    ClickCountTxtOldPassword);

            txtOldPassword.ForeColor = Color.Black;
        }
        private void txtNewPassword_Click(object sender, EventArgs e)
        {
            ClickCountTxtNewPassword =
        ValidationUI.ClearTextBoxWhenClicked(
            txtNewPassword,
            ClickCountTxtNewPassword);

            txtNewPassword.ForeColor = Color.Black;
        }

        private void txtConfirmPassword_Click(object sender, EventArgs e)
        {
            ClickCountTxtConfirmPassword =
          ValidationUI.ClearTextBoxWhenClicked(
              txtConfirmPassword,
              ClickCountTxtConfirmPassword);

            txtConfirmPassword.ForeColor = Color.Black;
        }

        private void picOldPasswordHide_Click(object sender, EventArgs e)
        {
            if (!txtOldPassword.UseSystemPasswordChar)
            {

                txtOldPassword.UseSystemPasswordChar = true;
                //picOldPasswordHide.Image = Properties.Resources.hide;
            }
            else
            {

                txtOldPassword.UseSystemPasswordChar = false;
                //picOldPasswordHide.Image = Properties.Resources.view;
            }
        }

        private void picNewPasswordHide_Click(object sender, EventArgs e)
        {
            if (!txtNewPassword.UseSystemPasswordChar)
            {
                txtNewPassword.UseSystemPasswordChar = true;
                picNewPasswordHide.Image = Properties.Resources.hidden;
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = false;
                picNewPasswordHide.Image = Properties.Resources.eye;
            }
        }

        private void picConfirmPasswordHide_Click(object sender, EventArgs e)
        {
            if (!txtConfirmPassword.UseSystemPasswordChar)
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                picConfirmPasswordHide.Image = Properties.Resources.hidden;
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
                picConfirmPasswordHide.Image = Properties.Resources.eye;
            }
        }

        private void btnClearPassword_Click(object sender, EventArgs e)
        {
            txtNewPassword.Clear();
            txtOldPassword.Clear();
            txtConfirmPassword.Clear();
            txtUserName.Clear();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            AdminChangePasswordUI adminChangePasswordUI =
                new AdminChangePasswordUI();

            string userName = txtUserName.Text;
            string currentPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            string message;

            bool result =
                adminChangePasswordUI.ChangeAdminPasswordUI(
                    userName,
                    currentPassword,
                    newPassword,
                    confirmPassword,
                    out message);

            MessageBox.Show(message);

            if (result)
            {
                this.Close();
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            ClickCountTxtUserName = ValidationUI.ClearTextBoxWhenClicked(txtUserName,ClickCountTxtUserName);
            txtUserName.ForeColor = Color.Black;
        }

    
    }
}
