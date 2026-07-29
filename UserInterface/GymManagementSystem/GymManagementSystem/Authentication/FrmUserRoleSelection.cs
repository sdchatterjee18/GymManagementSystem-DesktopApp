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
    public partial class FrmUserRoleSelection : Form
    {
        public FrmUserRoleSelection()
        {
            InitializeComponent();
        }

        private void FrmUserRoleSelection_Load(object sender, EventArgs e)
        {

        }

        private void btnSuperAdminLogin_Click(object sender, EventArgs e)
        {
            FrmSuperAdminLogin frm = new FrmSuperAdminLogin();
            frm.Show();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            FrmAdminLogin frm = new FrmAdminLogin();
            frm.Show();
        }

        private void pnlclickAddNewSuperadmin_MouseEnter(object sender, EventArgs e)
        {
            pnlclickAddNewSuperadmin.BackColor = Color.Cornsilk;
        }

        private void pnlclickAddNewSuperadmin_MouseLeave(object sender, EventArgs e)
        {
            pnlclickAddNewSuperadmin.BackColor = Color.FloralWhite;
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
    }
}
