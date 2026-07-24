using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem.FORMS.MembershipPlan
{
    public partial class FrmAddMembershipPlans : Form
    {
        public FrmAddMembershipPlans()
        {
            InitializeComponent();
        }

        private void FrmAddMembershipPlans_Load(object sender, EventArgs e)
        {

        }

        private void btnPageRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPlanName.Clear();
            txtAmount.Clear();
            txtDescription.Clear();

            cmbPlanType.Text = "";
            cmbDuration.Text = "";

            txtPlanName.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
