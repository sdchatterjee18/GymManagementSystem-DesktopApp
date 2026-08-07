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
    public partial class FrmChangeDietPlan : Form
    {
        public FrmChangeDietPlan()
        {
            InitializeComponent();
        }

        private void FrmChangeDietPlan_Load(object sender, EventArgs e)
        {

        }

        private void tlpChangeMemberDietPlansButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpChangeMemberDietPlansButton.BackColor = Color.DarkGreen;
        }

        private void tlpChangeMemberDietPlansButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpChangeMemberDietPlansButton.BackColor = Color.ForestGreen;
        }

        private void tlpCancleSectionInChangeMemberDietPlan_MouseEnter(object sender, EventArgs e)
        {
            this.tlpCancleSectionInChangeMemberDietPlan.BackColor = Color.OrangeRed;
        }

        private void tlpCancleSectionInChangeMemberDietPlan_MouseLeave(object sender, EventArgs e)
        {
            this.tlpCancleSectionInChangeMemberDietPlan.BackColor = Color.Red;
        }
    }
}
