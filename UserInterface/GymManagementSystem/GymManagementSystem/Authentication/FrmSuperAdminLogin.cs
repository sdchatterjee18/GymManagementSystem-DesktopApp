using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using GymManagementSystem.Common;
using GymManagementSystem.Authentication.UI;
using GymManagementSystem.FormsSuperAdmin.MainLayout;
using GymManagementSystem.Authentication;

namespace GymManagementSystem.Authentication
{
    public partial class FrmSuperAdminLogin : Form
    {
        int ClickCountTxtSuperAdminUsername = 0;
        int ClickCountTxtSuperAdminPassword = 0;
        int checkedShow = 0;
        FrmUserRoleSelection frmUserRoleSelection = null;
        public FrmSuperAdminLogin(FrmUserRoleSelection frmUserRoleSelection)
        {
            this.frmUserRoleSelection = frmUserRoleSelection;
            InitializeComponent();
        }
        private void FrmSuperAdminLogin_Load(object sender, EventArgs e)
        {
            this.ShowIcon = false;
            this.Text = "";
            lblForgotPassword.Focus();
            txtSuperAdminPassword.UseSystemPasswordChar = false;
        }

        private void txtSuperAdminUsername_Enter(object sender, EventArgs e)
        {
            ClickCountTxtSuperAdminUsername = ValidationUI.ClearTextBoxWhenClicked(txtSuperAdminUsername, ClickCountTxtSuperAdminUsername);
        }

        private void txtSuperAdminUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSuperAdminUsername.Text))
            {
                ClickCountTxtSuperAdminUsername = 0;
                txtSuperAdminUsername.Text = "Enter UserName";
                txtSuperAdminUsername.ForeColor = Color.Gray;
            }
        }

        private void txtSuperAdminPassword_Enter(object sender, EventArgs e)
        {
            ClickCountTxtSuperAdminPassword =
               ValidationUI.ClearTextBoxWhenClicked(
                   txtSuperAdminPassword,
                   ClickCountTxtSuperAdminPassword);
        }

        private void txtSuperAdminPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSuperAdminPassword.Text))
            {
                ClickCountTxtSuperAdminPassword = 0;
                txtSuperAdminPassword.Text = "Enter Password";
                txtSuperAdminPassword.ForeColor = Color.Gray;
                txtSuperAdminPassword.UseSystemPasswordChar = false;
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
        private void tlpSuperAdminLoginEntireForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSuperAdminLogin_Click(object sender, EventArgs e)
        {
            // CLEAR DEFAULT PLACEHOLDER TEXT
            ValidationUI.ClearDefaultPlaceholderText(
                txtSuperAdminUsername,
                ClickCountTxtSuperAdminUsername);
            ValidationUI.ClearDefaultPlaceholderText(
                txtSuperAdminPassword,
                ClickCountTxtSuperAdminPassword);
            // CREATE AUTHENTICATION UI OBJECT
            AuthenticationUI authenticationUI =
                new AuthenticationUI();

            // GET LOGIN VALUES
            string userName =
                txtSuperAdminUsername.Text.Trim();

            string password =
                txtSuperAdminPassword.Text.Trim();

            // SUPER ADMIN LOGIN
            try
            {
                bool Result = authenticationUI.SuperAdminLoginUI(userName, password);

                if (Result)
                {
                    FrmSAMainForm frmSAMainForm = new FrmSAMainForm();
                    this.Close();
                    frmSAMainForm.Show();
                    frmUserRoleSelection.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Invalid UserName or Password",
                        "Super Admin Login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
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
        private void txtSuperAdminUsername_Click(object sender, EventArgs e)
        {
            ClickCountTxtSuperAdminUsername =ValidationUI.ClearTextBoxWhenClicked(txtSuperAdminUsername,ClickCountTxtSuperAdminUsername);
        }

        private void txtSuperAdminPassword_Click(object sender, EventArgs e)
        {
            ClickCountTxtSuperAdminPassword =ValidationUI.ClearTextBoxWhenClicked(txtSuperAdminPassword,ClickCountTxtSuperAdminPassword);
            txtSuperAdminPassword.ForeColor = Color.Black;  
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSuperAdminPassword.Text != "Enter Password")
            {
                txtSuperAdminPassword.UseSystemPasswordChar =!cbShowPassword.Checked;
                checkedShow = 1;
            }
        } 
        private void txtSuperAdminPassword_TextChanged(object sender, EventArgs e)
        {
            if (checkedShow==0)
            {
                txtSuperAdminPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            FrmForgotPassword frmForgotPassword = new FrmForgotPassword();
            frmForgotPassword.ShowDialog();
            this.Close();
        }
    }
}