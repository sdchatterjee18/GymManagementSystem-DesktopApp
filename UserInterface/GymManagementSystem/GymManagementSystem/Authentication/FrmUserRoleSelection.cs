using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.FORMS.Main;
using GymManagementSystem.FormsSuperAdmin.MainLayout;

namespace GymManagementSystem.Authentication
{
    public partial class FrmUserRoleSelection : Form
    {
        public FrmUserRoleSelection()
        {
            InitializeComponent();
        }

        private void FrmUserRoleSelection_Load(object sender, EventArgs e)
        {
            this.Text = "";
            this.ShowIcon = false;
        }

        private void btnSuperAdminLogin_Click(object sender, EventArgs e)
        {
            FrmSAMainForm frmSAMainForm = new FrmSAMainForm();
            this.Hide();
            frmSAMainForm.ShowDialog();
            this.Close();
            //FrmSuperAdminLogin frm = new FrmSuperAdminLogin();
            //frm.Show();
            
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            //FrmAdminLogin frm = new FrmAdminLogin();
            //frm.Show();
            FrmMainLayout frmMainLayout = new FrmMainLayout();
            this.Hide();
            frmMainLayout.ShowDialog();
            this.Close();
        }

        private void pnlclickAddNewSuperadmin_MouseEnter(object sender, EventArgs e)
        {
            pnlclickAddNewSuperAdmin.BackColor = Color.Cornsilk;
           
        }

        private void pnlclickAddNewSuperadmin_MouseLeave(object sender, EventArgs e)
        {
            pnlclickAddNewSuperAdmin.BackColor = Color.FloralWhite;
        }

        private void pnlAdminLogin_MouseEnter(object sender, EventArgs e)
        {
            pnlAdminLogin.BackColor = Color.Cornsilk;
        }

        private void pnlAdminLogin_MouseLeave(object sender, EventArgs e)
        {
            pnlAdminLogin.BackColor = Color.FloralWhite;
        }

        private void pnlSuperAdminLogin_MouseEnter(object sender, EventArgs e)
        {
            pnlSuperAdminLogin.BackColor = Color.Cornsilk;
        }

        private void pnlSuperAdminLogin_MouseLeave(object sender, EventArgs e)
        {
            pnlSuperAdminLogin.BackColor = Color.FloralWhite;
        }

        private void pnlclickAddNewSuperAdmin_Click(object sender, EventArgs e)
        {
            FrmSuperAdminRegistration from = new FrmSuperAdminRegistration();
            from.Show();
        }

        
    }
}
