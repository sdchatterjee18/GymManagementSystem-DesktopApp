using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem.FORMS.Member
{
    public partial class FrmMembershipRenewal : Form
    {
        public FrmMembershipRenewal()
        {
            InitializeComponent();
        }

        private void FrmMembershipRenewal_Load(object sender, EventArgs e)
        {

        }

        private void tlpChangeMembershipButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpChangeMembershipButton.BackColor = Color.DarkGreen;
        }

        private void tlpChangeMembershipButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpChangeMembershipButton.BackColor = Color.ForestGreen;
        }

        private void tlpCancleSectionInChangeMembership_MouseEnter(object sender, EventArgs e)
        {
            this.tlpCancleSectionInChangeMembership.BackColor = Color.OrangeRed;
        }

        private void tlpCancleSectionInChangeMembership_MouseLeave(object sender, EventArgs e)
        {
            this.tlpCancleSectionInChangeMembership.BackColor = Color.Red;
        }
    }
}
