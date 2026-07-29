using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GymManagementSystem.Authentication
{
    public partial class FrmSuperAdminLogin : Form
    {

        public FrmSuperAdminLogin()
        {
            InitializeComponent();
        }
            

        private void FrmSuperAdminLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void txtSuperAdminUsername_Enter(object sender, EventArgs e)
        {
            if (txtSuperAdminUsername.Text.Trim() == "Enter Username")
            {
                txtSuperAdminUsername.Text = "";
                txtSuperAdminUsername.ForeColor = Color.Gray;
            }
        }

        private void txtSuperAdminUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSuperAdminUsername.Text))
            {
                txtSuperAdminUsername.Text = "Enter Username";
                txtSuperAdminUsername.ForeColor = Color.Gray;
            }
        }

        private void txtSuperAdminPassword_Enter(object sender, EventArgs e)
        {

            if (txtSuperAdminPassword.Text.Trim() == "Enter Password")
            {
                txtSuperAdminPassword.Text = "";
                txtSuperAdminPassword.ForeColor = Color.Gray;
            }
        }

        private void txtSuperAdminPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSuperAdminPassword.Text))
            {
                txtSuperAdminPassword.Text = "Enter Password";
                txtSuperAdminPassword.ForeColor = Color.Gray;
            }
        }

        private void FrmSuperAdminLogin_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void pnlUsernameSuperAdmin_MouseEnter(object sender, EventArgs e)
        {
            pnlUsernameSuperAdmin.BackColor = Color.PapayaWhip;
        }

        private void pnlUsernameSuperAdmin_MouseLeave(object sender, EventArgs e)
        {
            pnlUsernameSuperAdmin.BackColor = Color.FloralWhite;
        }

        private void pnlPasswordSuperAdmin_MouseEnter(object sender, EventArgs e)
        {
            pnlPasswordSuperAdmin.BackColor = Color.PapayaWhip;
        }

        private void pnlPasswordSuperAdmin_MouseLeave(object sender, EventArgs e)
        {
            pnlPasswordSuperAdmin.BackColor = Color.FloralWhite;
        }
    }
}
