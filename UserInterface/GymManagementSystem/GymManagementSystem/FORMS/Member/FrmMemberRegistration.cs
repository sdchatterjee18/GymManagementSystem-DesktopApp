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
    public partial class FrmMemberRegistration : Form
    {
        public FrmMemberRegistration()
        {
            InitializeComponent();
        }

        private void FrmMemberRegistration_Load(object sender, EventArgs e)
        {
            SetPlaceholder(this);
            this.ActiveControl = null;
        }

        private void txtEnterMemberFirstName_Click(object sender, EventArgs e)
        {
            txtEnterMemberFirstName.Clear();
        }

        private void txtEnterMemberMiddleName_Click(object sender, EventArgs e)
        {
            txtEnterMemberMiddleName.Clear();
        }

        private void txtEnterMemberLastName_Click(object sender, EventArgs e)
        {
            txtEnterMemberLastName.Clear();
        }

       

        private void txtEnterMemberPhoneNumber_Click(object sender, EventArgs e)
        {
            txtEnterMemberPhoneNumber.Clear();
        }

        private void txtEnterMemberEmailId_Click(object sender, EventArgs e)
        {
            txtEnterMemberEmailId.Clear();
        }

        private void txtEnterMemberCity_Click(object sender, EventArgs e)
        {
            txtEnterMemberCity.Clear();
        }

        private void txtEnterMemberDistrict_Click(object sender, EventArgs e)
        {
            txtEnterMemberDistrict.Clear();
        }

        private void txtEnterMemberState_Click(object sender, EventArgs e)
        {
            txtEnterMemberState.Clear();
        }

        private void txtEnterMemberEmergencyContact_Click(object sender, EventArgs e)
        {
            txtEnterMemberEmergencyContact.Clear();
        }

        private void cmbSelectMemberMemberMembershipPlan_Click(object sender, EventArgs e)
        {
            cmbSelectMemberMemberMembershipPlan.Items.Clear();
            cmbSelectMemberMemberMembershipPlan.Text = null;
        }

        private void cmbSelectMemberShiftTime_Click(object sender, EventArgs e)
        {
            cmbSelectMemberShiftTime.Items.Clear();
            cmbSelectMemberShiftTime.Text = null;
        }

        private void cmbSelectMemberDietPlan_Click(object sender, EventArgs e)
        {
            cmbSelectMemberDietPlan.Items.Clear();
            cmbSelectMemberDietPlan.Text = null;
        }

        private void cmbSelectMemberPaymentMethod_Click(object sender, EventArgs e)
        {
            cmbSelectMemberPaymentMethod.Items.Clear();
            cmbSelectMemberPaymentMethod.Text = null;
        }

        private void cmbSelectMemberPaymentFeesType_Click(object sender, EventArgs e)
        {
            cmbSelectMemberPaymentFeesType.Items.Clear();
            cmbSelectMemberPaymentFeesType.Text = null;
        
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
        }
    }
}
