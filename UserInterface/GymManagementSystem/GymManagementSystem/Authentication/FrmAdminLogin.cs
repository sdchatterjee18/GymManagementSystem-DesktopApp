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
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        private void FrmAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtAdminUsernameI_Enter(object sender, EventArgs e)
        {
            if (txtAdminUsernameI.Text.Trim() == "Enter Username")
            {
                txtAdminUsernameI.Text = "";
                txtAdminUsernameI.ForeColor = Color.Gray;
            }
        }

        private void txtAdminUsernameI_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminUsernameI.Text))
            {
                txtAdminUsernameI.Text = "Enter Username";
                txtAdminUsernameI.ForeColor = Color.Gray;
            }
        }

        private void txtAdminPassword_Enter(object sender, EventArgs e)
        {
            if (txtAdminPassword.Text.Trim() == "Enter Password")
            {
                txtAdminPassword.Text = "";
                txtAdminPassword.ForeColor = Color.Gray;
            }
        }

        private void txtAdminPassword_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAdminPassword.Text))
            {
                txtAdminPassword.Text = "Enter Password";
                txtAdminPassword.ForeColor = Color.Gray;
            }
        }

        private void FrmAdminLogin_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void pnlPasswordAdmin_MouseEnter(object sender, EventArgs e)
        {
            pnlPasswordAdmin.BackColor = Color.PapayaWhip;
        }

        private void pnlPasswordAdmin_MouseLeave(object sender, EventArgs e)
        {
            pnlPasswordAdmin.BackColor = Color.FloralWhite;
        }

        private void pnlUsernameAdmin_MouseEnter(object sender, EventArgs e)
        {
            pnlUsernameAdmin.BackColor = Color.PapayaWhip;
        }

        private void pnlUsernameAdmin_MouseLeave(object sender, EventArgs e)
        {
            pnlUsernameAdmin.BackColor = Color.FloralWhite;
        }
    }
}
