using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.FORMS.Shift.UI;
using GymManagementSystem.FORMS.MembershipPlan.UI;
using GymManagementSystem.Common;

namespace GymManagementSystem.FORMS.Member
{
    public partial class FrmMemberRegistration : Form
    {
        public FrmMemberRegistration()
        {
            InitializeComponent();
        }
        private void LoadShiftComboBox()
        {
            List<ShiftUI> shifts = LookupUI.GetShifts();
            cmbSelectMemberShiftTime.DataSource =shifts;
            cmbSelectMemberShiftTime.DisplayMember = "ShiftName";
            cmbSelectMemberShiftTime.ValueMember = "ShiftId";
            cmbSelectMemberShiftTime.SelectedIndex = -1;
        }

        private void LoadMembershipPlanComboBox()
        {
            List<MembershipPlanUI> membershipPlansUI = LookupUI.GetMembershipPlans();
            cmbSelectMemberMemberMembershipPlan.DataSource = membershipPlansUI;
            cmbSelectMemberMemberMembershipPlan.DisplayMember = "MembershipPlanName";
            cmbSelectMemberMemberMembershipPlan.ValueMember = "MembershipPlanId";
            cmbSelectMemberMemberMembershipPlan.SelectedIndex = -1;
        }

        private void FrmMemberRegistration_Load(object sender, EventArgs e)
        {
            SetPlaceholder(this);
            this.ActiveControl = null;
            LoadShiftComboBox();
            LoadMembershipPlanComboBox();
        }

        private void txtEnterMemberFirstName_Click(object sender, EventArgs e)
        {
            txtEnterMemberFirstName.Clear();
            txtEnterMemberFirstName.ForeColor = Color.Black;
        }

        private void txtEnterMemberMiddleName_Click(object sender, EventArgs e)
        {
            txtEnterMemberMiddleName.Clear();
            txtEnterMemberMiddleName.ForeColor = Color.Black;
        }

        private void txtEnterMemberLastName_Click(object sender, EventArgs e)
        {
            txtEnterMemberLastName.Clear();
            txtEnterMemberLastName.ForeColor = Color.Black;
        }

       

        private void txtEnterMemberPhoneNumber_Click(object sender, EventArgs e)
        {
            txtEnterMemberPhoneNumber.Clear();
            txtEnterMemberPhoneNumber.ForeColor = Color.Black;
        }

        private void txtEnterMemberEmailId_Click(object sender, EventArgs e)
        {
            txtEnterMemberEmailId.Clear();
            txtEnterMemberEmailId.ForeColor = Color.Black;
        }

        private void txtEnterMemberCity_Click(object sender, EventArgs e)
        {
            txtEnterMemberCity.Clear();
            txtEnterMemberCity.ForeColor = Color.Black;
        }

        private void txtEnterMemberDistrict_Click(object sender, EventArgs e)
        {
            txtEnterMemberDistrict.Clear();
            txtEnterMemberDistrict.ForeColor = Color.Black;
        }

        private void txtEnterMemberState_Click(object sender, EventArgs e)
        {
            txtEnterMemberState.Clear();
            txtEnterMemberState.ForeColor = Color.Black;
        }

        private void txtEnterMemberEmergencyContact_Click(object sender, EventArgs e)
        {
            txtEnterMemberEmergencyContact.Clear();
            txtEnterMemberEmergencyContact.ForeColor = Color.Black;
        }

        private void cmbSelectMemberMemberMembershipPlan_Click(object sender, EventArgs e)
        {
            cmbSelectMemberMemberMembershipPlan.Items.Clear();
            cmbSelectMemberMemberMembershipPlan.Text = null;
            //cmbSelectMemberMemberMembershipPlan.ForeColor = Color.Black;
        }

        private void cmbSelectMemberShiftTime_Click(object sender, EventArgs e)
        {
            //cmbSelectMemberShiftTime.Items.Clear();
            //cmbSelectMemberShiftTime.Text = null;
            //cmbSelectMemberShiftTime.ForeColor = Color.Black;
        }

        private void cmbSelectMemberDietPlan_Click(object sender, EventArgs e)
        {
            cmbSelectMemberDietPlan.Items.Clear();
            cmbSelectMemberDietPlan.Text = null;
            cmbSelectMemberDietPlan.ForeColor = Color.Black;
        }

        private void cmbSelectMemberPaymentMethod_Click(object sender, EventArgs e)
        {
            cmbSelectMemberPaymentMethod.Items.Clear();
            cmbSelectMemberPaymentMethod.Text = null;
            cmbSelectMemberPaymentMethod.ForeColor = Color.Black;
        }

        private void cmbSelectMemberPaymentFeesType_Click(object sender, EventArgs e)
        {
            cmbSelectMemberPaymentFeesType.Items.Clear();
            cmbSelectMemberPaymentFeesType.Text = null;
            cmbSelectMemberPaymentFeesType.ForeColor = Color.Black;
        
        }

        private void SetPlaceholder(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = (TextBox)c;

                    txt.Tag = txt.Text;        
                    txt.ForeColor = Color.Gray;

                    txt.Enter += Placeholder_Enter;
                    txt.Leave += Placeholder_Leave;
                }

                if (c.HasChildren)
                    SetPlaceholder(c);
            }
        }

        private void Placeholder_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text == txt.Tag.ToString())
            {
                txt.Clear();
                txt.ForeColor = Color.Black;
            }
        }

        private void Placeholder_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = txt.Tag.ToString();
                txt.ForeColor = Color.Gray;
            }
        }
        private void Placeholder_Click(object sender, MouseEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text == txt.Tag.ToString())
            {
                txt.Clear();
                txt.ForeColor = Color.Black;
            }
        }

        private void FrmMemberRegistration_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void cmbSelectMemberGender_Click_1(object sender, EventArgs e)
        {
            cmbSelectMemberGender.Items.Clear();
            cmbSelectMemberGender.Text = null;
            cmbSelectMemberGender.ForeColor = Color.Black;
        }

        private void tlpRegisterButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpRegisterButton.BackColor = Color.OliveDrab;
        }

        private void tlpRegisterButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpRegisterButton.BackColor = Color.ForestGreen;
        }

        private void tlpResetButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpResetButton.BackColor = Color.SkyBlue;
        }

        private void tlpResetButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpResetButton.BackColor = Color.Navy;
        }

        private void tlpCancleButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpCancleButton.BackColor = Color.OrangeRed;
        }

        private void tlpCancleButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpCancleButton.BackColor = Color.Red;
        }

        private void tlpMemberBrowsePhoto_MouseEnter(object sender, EventArgs e)
        {
            this.tlpMemberBrowsePhoto.BackColor = Color.DarkViolet;
        }

        private void tlpMemberBrowsePhoto_MouseLeave(object sender, EventArgs e)
        {
            this.tlpMemberBrowsePhoto.BackColor = Color.Purple;
        }

        private void pnlResetButton_MouseEnter(object sender, EventArgs e)
        {
            this.pnlResetButton.BackColor = Color.SkyBlue;
        }

        private void pnlResetButton_MouseLeave(object sender, EventArgs e)
        {
            this.pnlResetButton.BackColor = Color.Navy;
        }

        private void pnlRegisterButton_Click(object sender, EventArgs e)
        {

        }

        private void cmbSelectMemberShiftTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (cmbSelectMemberShiftTime.SelectedIndex <= 0)
                cmbSelectMemberShiftTime.ForeColor = Color.Gray;
            else
                cmbSelectMemberShiftTime.ForeColor = Color.Black;
        }

       
        //private void tlpResetButton_MouseEnter(object sender, EventArgs e)
        //{
        //    this.tlpResetButton.BackColor = Color.SkyBlue;
        //}

        //private void tlpResetButton_MouseLeave(object sender, EventArgs e)
        //{
        //    this.tlpResetButton.BackColor = Color.Navy;
        //}
    }
}
