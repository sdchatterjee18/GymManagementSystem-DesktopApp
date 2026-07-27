using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem.FORMS.Settings
{
    public partial class FrmChangePasswordAdmin : Form
    {
        public FrmChangePasswordAdmin()
        {
            InitializeComponent();
        }

        private void FrmChangePasswordAdmin_Load(object sender, EventArgs e)
        {

        }

        private void txtOldPassword_Click(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = true;
            //picNewPasswordHide.Image = Properties.Resources.hide;

            txtConfirmPassword.UseSystemPasswordChar = true;
            //picConfirmPasswordHide.Image = Properties.Resources.hide;
        }

        private void txtNewPassword_Click(object sender, EventArgs e)
        {
            txtOldPassword.UseSystemPasswordChar = true;
            //picOldPasswordHide.Image = Properties.Resources.hide;

            txtConfirmPassword.UseSystemPasswordChar = true;
            //picConfirmPasswordHide.Image = Properties.Resources.hide;
        }

        private void txtConfirmPassword_Click(object sender, EventArgs e)
        {
            txtOldPassword.UseSystemPasswordChar = true;
            //picOldPasswordHide.Image = Properties.Resources.hide;

            txtNewPassword.UseSystemPasswordChar = true;
            //picNewPasswordHide.Image = Properties.Resources.hide;
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
                //picNewPasswordHide.Image = Properties.Resources.hide;

            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = false;
                //picNewPasswordHide.Image = Properties.Resources.view;
            }
        }

        private void picConfirmPasswordHide_Click(object sender, EventArgs e)
        {
            if (!txtConfirmPassword.UseSystemPasswordChar)
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                //picConfirmPasswordHide.Image = Properties.Resources.hide;
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
                //picConfirmPasswordHide.Image = Properties.Resources.view;
            }
        }

        private void btnClearPassword_Click(object sender, EventArgs e)
        {
            txtNewPassword.Clear();
            txtOldPassword.Clear();
            txtConfirmPassword.Clear();
        }
    }
}
