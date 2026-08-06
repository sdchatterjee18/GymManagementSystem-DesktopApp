using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.Common;

namespace GymManagementSystem.FORMS.MembershipPlan
{
    public partial class FrmAddMembershipPlans : Form
    {
        int ClickCountTxtPlanName = 0;
        int ClickCountTxtDuration = 0;
        int ClickCountTxtAmount = 0;
        int ClickCountTxtDescription = 0;
        public FrmAddMembershipPlans()
        {
            InitializeComponent();
        }

        private void FrmAddMembershipPlans_Load(object sender, EventArgs e)
        {
            this.Text = "";
            this.ShowIcon = false;
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
            txtPlanName.Focus();
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlClickSubmit_Click(object sender, EventArgs e)
        {
            if (ClickCountTxtPlanName == 0)
            {
                txtPlanName.Clear();
            }

            if (ClickCountTxtDuration == 0)
            {
                txtDuration.Clear();
            }

            if (ClickCountTxtAmount == 0)
            {
                txtAmount.Clear();
            }

            if (ClickCountTxtDescription == 0)
            {
                txtDescription.Clear();
            }

            if (!ValidationUI.ValidateRequiredTextBoxes(
                txtPlanName,
                txtDuration,
                txtAmount,
                txtDescription))
            {
                return;
            }
        }

        private void txtPlanName_Click(object sender, EventArgs e)
        {
            ClickCountTxtPlanName = ValidationUI.ClearTextBox(txtPlanName, ClickCountTxtPlanName);
            txtPlanName.ForeColor = Color.Black;
        }

        private void txtDuration_Click(object sender, EventArgs e)
        {
            ClickCountTxtDuration = ValidationUI.ClearTextBox(txtDuration, ClickCountTxtDuration);
            txtDuration.ForeColor = Color.Black;
        }

        private void txtAmount_Click(object sender, EventArgs e)
        {
            ClickCountTxtAmount = ValidationUI.ClearTextBox(txtAmount, ClickCountTxtAmount);
            txtAmount.ForeColor = Color.Black;
        }

        private void txtDescription_Click(object sender, EventArgs e)
        {
            ClickCountTxtDescription = ValidationUI.ClearTextBox(txtDescription, ClickCountTxtDescription);
            txtDescription.ForeColor = Color.Black;
        }

        
    }
}
