using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GymManagementSystem.FORMS.Member
{
    public partial class FrmMemberProfile : Form
    {
        public FrmMemberProfile()
        {
            InitializeComponent();
        }

        private void FrmMemberProfile_Load(object sender, EventArgs e)
        {
           
        }

        private void tlpMiddlePartMemberNameAndIcon_MouseEnter(object sender, EventArgs e)
        {
            this.tlpMiddlePartMemberNameAndIcon.BackColor = Color.Navy;
        }

        private void tlpMiddlePartMemberNameAndIcon_MouseLeave(object sender, EventArgs e)
        {
            this.tlpMiddlePartMemberNameAndIcon.BackColor = Color.FromArgb(0, 0, 152);
        }

        private void tlpRenewMembershipPlan_MouseEnter(object sender, EventArgs e)
        {
            this.tlpRenewMembershipPlan.BackColor = Color.Purple;
        }

        private void tlpRenewMembershipPlan_MouseLeave(object sender, EventArgs e)
        {
            this.tlpRenewMembershipPlan.BackColor = Color.MediumOrchid;
        }

        private void tlpAssignTrainerButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpAssignTrainerButton.BackColor = Color.Navy; 
        }

        private void tlpAssignTrainerButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpAssignTrainerButton.BackColor = Color.RoyalBlue; 
        }

        private void tlpChangeTrainerButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpChangeTrainerButton.BackColor = Color.Navy; 
        }

        private void tlpChangeTrainerButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpChangeTrainerButton.BackColor = Color.RoyalBlue;
        }

        private void lblChangeTrainer_MouseLeave(object sender, EventArgs e)
        {
            this.tlpChangeTrainerButton.BackColor = Color.RoyalBlue;
        }

        private void picChangeTrainer_MouseLeave(object sender, EventArgs e)
        {
            this.tlpChangeTrainerButton.BackColor = Color.RoyalBlue;
        }

        private void tlpChangeShiftButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpChangeShiftButton.BackColor = Color.DarkOliveGreen;
        }

        private void tlpChangeShiftButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpChangeShiftButton.BackColor = Color.OliveDrab;
        }

        private void tlpChangeDietPlan_MouseEnter(object sender, EventArgs e)
        {
            this.tlpChangeDietPlan.BackColor = Color.Red;
        }

        private void tlpChangeDietPlan_MouseLeave(object sender, EventArgs e)
        {
            this.tlpChangeDietPlan.BackColor = Color.Crimson;
        }

       
        //(200, 180, 240);

    }


}
