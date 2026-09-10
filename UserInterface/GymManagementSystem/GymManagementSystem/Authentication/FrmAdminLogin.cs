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
using GymManagementSystem.FORMS.Main;

namespace GymManagementSystem.Authentication
{
    public partial class FrmAdminLogin : Form
    {
        int ClickCountTxtAdminUsername = 0;
        int ClickCountTxtAdminPassword = 0;
        int checkedShow = 0;
        FrmUserRoleSelection frmUserRoleSelection = null;
        public FrmAdminLogin(FrmUserRoleSelection frmUserRoleSelection)
        {
            InitializeComponent();
            this.frmUserRoleSelection = frmUserRoleSelection;
           
        }

        private void FrmAdminLogin_Load(object sender, EventArgs e)
        {
            txtAdminUsername.Focus();
            this.ShowIcon = false;
            this.Text = "";
        }

        private void txtAdminPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminPassword.Text))
            {
                ClickCountTxtAdminPassword = 0;
                txtAdminPassword.Text = "Enter Password";
                txtAdminPassword.ForeColor = Color.Gray;
                txtAdminPassword.UseSystemPasswordChar = false;
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
     
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            FrmForgotPassword frmForgotPassword = new FrmForgotPassword();
            frmForgotPassword.ShowDialog();
            this.Hide();
        }
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtAdminPassword.Text != "Enter Password")
            {
                txtAdminPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
                checkedShow = 1;
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            // ==========================================
            // CLEAR DEFAULT PLACEHOLDER TEXT
            // ==========================================

            ValidationUI.ClearDefaultPlaceholderText(txtAdminUsername,ClickCountTxtAdminUsername);
            ValidationUI.ClearDefaultPlaceholderText(txtAdminPassword,ClickCountTxtAdminPassword);

            // ==========================================
            // CREATE AUTHENTICATION UI OBJECT
            // ==========================================

            AuthenticationUI adminAuthenticationUI =
                new AuthenticationUI();


            // ==========================================
            // GET LOGIN VALUES
            // ==========================================

            string userName =
                txtAdminUsername.Text.Trim();

            string password =
                txtAdminPassword.Text.Trim();


            // ADMIN LOGIN
            try
            {
                bool Result =
                    adminAuthenticationUI.AdminLoginUI(
                        userName,
                        password);

                if (Result)
                {
                    FrmMainLayout frmMainLayout =
                        new FrmMainLayout();

                    this.Close();

                    frmMainLayout.Show();

                    frmUserRoleSelection.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Invalid UserName or Password",
                        "Admin Login",
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

        private void txtAdminUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminUsername.Text))
            {
                ClickCountTxtAdminUsername = 0;
                txtAdminUsername.Text = "Enter UserName";
                txtAdminUsername.ForeColor = Color.Gray;
            }
        }

        private void txtAdminUsername_Click(object sender, EventArgs e)
        {
            ClickCountTxtAdminUsername = ValidationUI.ClearTextBoxWhenClicked(txtAdminUsername, ClickCountTxtAdminUsername);
            
        }

        private void txtAdminPassword_Click(object sender, EventArgs e)
        {

            ClickCountTxtAdminPassword = ValidationUI.ClearTextBoxWhenClicked(txtAdminPassword, ClickCountTxtAdminPassword);
            
        }

        private void txtAdminUsername_Enter(object sender, EventArgs e)
        {
            ClickCountTxtAdminUsername =
                ValidationUI.ClearTextBoxWhenClicked(
                    txtAdminUsername,
                    ClickCountTxtAdminUsername);
        }

        private void txtAdminPassword_Enter(object sender, EventArgs e)
        {
            ClickCountTxtAdminPassword =ValidationUI.ClearTextBoxWhenClicked(txtAdminPassword,ClickCountTxtAdminPassword);
        }

        private void txtAdminPassword_TextChanged(object sender, EventArgs e)
        {
            if (checkedShow == 0)
            {
                txtAdminPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
            }
        }
    }
}
