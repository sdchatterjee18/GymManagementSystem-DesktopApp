using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem.FormsSuperAdmin.Settings
{
    public partial class FrmSAPasswordChange : Form
    {
        public FrmSAPasswordChange()
        {
            InitializeComponent();
        }

        private void FrmSAPasswordChange_Load(object sender, EventArgs e)
        {

        }

        private void txtOldPassword_Enter(object sender, EventArgs e)
        {
            if (txtOldPassword.Text.Trim() == "Enter Old Password")
            {
                txtOldPassword.Text = "";
                txtOldPassword.ForeColor = Color.Black;
            }
        }

        private void txtOldPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOldPassword.Text))
            {
                txtOldPassword.Text = "Enter Old Password";
                txtOldPassword.ForeColor = Color.Gray;
            }
        }

        private void txtNewPassword_Enter(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Trim() == "Enter New Password")
            {
                txtNewPassword.Text = "";
                txtNewPassword.ForeColor = Color.Black;
            }
        }

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                txtNewPassword.Text = "Enter New Password";
                txtNewPassword.ForeColor = Color.Gray;
            }
        }

        private void txtConfermPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfermPassword.Text.Trim() == "Conferm New Password")
            {
                txtConfermPassword.Text = "";
                txtConfermPassword.ForeColor = Color.Black;
            }
        }

        private void txtConfermPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfermPassword.Text))
            {
                txtConfermPassword.Text = "Conferm New Password";
                txtConfermPassword.ForeColor = Color.Gray;
            }
        }

        private void FrmSAPasswordChange_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
