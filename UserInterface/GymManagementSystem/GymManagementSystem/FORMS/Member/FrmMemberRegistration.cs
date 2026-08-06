using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using GymManagementSystem.FORMS.Shift.UI;
using GymManagementSystem.FORMS.MembershipPlan.UI;
using GymManagementSystem.FORMS.DietPlan.UI;
using GymManagementSystem.FORMS.Member.UI;
using GymManagementSystem.Common;

namespace GymManagementSystem.FORMS.Member
{
    public partial class FrmMemberRegistration : Form
    {
        private string selectedImagePath = string.Empty;
        public FrmMemberRegistration()
        {
            InitializeComponent();
        }
        int ClickCountTxtFirstName = 0;
        int ClickCountTxtMiddleName = 0;
        int ClickCountTxtLastName = 0;
        int ClickCountTxtPhoneNumber = 0;
        int ClickCountTxtEmailId = 0;
        int ClickCountTxtEmergencyContact = 0;
        int ClickCountTxtState = 0;
        int ClickCountTxtCity = 0;
        int ClickCountTxtDistrict = 0;
        private void LoadShiftComboBox()
        {
            ShiftUI shiftUI = new ShiftUI();
            cmbSelectMemberShiftTime.DataSource = shiftUI.GetShiftDetailsForComboBox();
            cmbSelectMemberShiftTime.DisplayMember = "ShiftName";
            cmbSelectMemberShiftTime.ValueMember = "ShiftId";
            cmbSelectMemberShiftTime.SelectedIndex = -1;
        }
        private void LoadMembershipPlanComboBox()
        {
            MembershipPlanUI membershipPlanUI = new MembershipPlanUI();
            DataTable dataTable = membershipPlanUI.GetMembershipPlanDetailsForComboBox();
            cmbSelectMemberMemberMembershipPlan.DataSource = dataTable;
            cmbSelectMemberMemberMembershipPlan.DisplayMember = "MembershipPlanName";
            cmbSelectMemberMemberMembershipPlan.ValueMember = "MembershipPlanId";
            cmbSelectMemberMemberMembershipPlan.SelectedIndex = -1;
        }
        private void LoadDietPlanComboBox()
        {
            DietPlanUI DietPlanUI = new DietPlan.UI.DietPlanUI();
            cmbSelectMemberDietPlan.DataSource = DietPlanUI.GetDietPlansForComboBox();
            cmbSelectMemberDietPlan.DisplayMember = "CaloriesPerDay";
            cmbSelectMemberDietPlan.ValueMember = "DietPlanId";
            cmbSelectMemberDietPlan.SelectedIndex = -1;
        }
        private void LoadGenderComboBox()
        {
            cmbSelectMemberGender.DataSource = Gender.GenderUI.GetGenderDetailsForComboBox();
            cmbSelectMemberGender.DisplayMember = "GenderName";
            cmbSelectMemberGender.ValueMember = "GenderId";
            cmbSelectMemberGender.SelectedIndex = -1;
        }
        private void LoadPaymentMethodComboBox()
        {
            cmbSelectMemberPaymentMethod.DataSource = LookupUI.GetPaymentMethods();
            cmbSelectMemberPaymentMethod.SelectedIndex = -1;
        }
        private void LoadFeesTypeComboBox()
        {
            cmbSelectMemberPaymentFeesType.DataSource = LookupUI.GetFeesType();
            cmbSelectMemberPaymentFeesType.SelectedIndex = -1;
        }
        private void FrmMemberRegistration_Load(object sender, EventArgs e)
        {
            //SetPlaceholder(this);
            this.ActiveControl = null;
            LoadShiftComboBox();
            LoadMembershipPlanComboBox();
            LoadDietPlanComboBox();
            LoadGenderComboBox();
            LoadPaymentMethodComboBox();
            LoadFeesTypeComboBox();
        }

        private void txtEnterMemberFirstName_Click(object sender, EventArgs e)
        {
            
            txtEnterMemberFirstName.ForeColor = Color.Black;
            ClickCountTxtFirstName = ValidationUI.ClearTextBox(txtEnterMemberFirstName,ClickCountTxtFirstName);
        }

        private void txtEnterMemberMiddleName_Click(object sender, EventArgs e)
        {
            ClickCountTxtMiddleName = ValidationUI.ClearTextBox(txtEnterMemberMiddleName, ClickCountTxtMiddleName);
            txtEnterMemberMiddleName.ForeColor = Color.Black;
        }

        private void txtEnterMemberLastName_Click(object sender, EventArgs e)
        {
            ClickCountTxtLastName = ValidationUI.ClearTextBox(txtEnterMemberLastName, ClickCountTxtLastName);
            txtEnterMemberLastName.ForeColor = Color.Black;
        }

       

        private void txtEnterMemberPhoneNumber_Click(object sender, EventArgs e)
        {
            ClickCountTxtPhoneNumber = ValidationUI.ClearTextBox(txtEnterMemberPhoneNumber, ClickCountTxtPhoneNumber);
            txtEnterMemberPhoneNumber.ForeColor = Color.Black;
        }

        private void txtEnterMemberEmailId_Click(object sender, EventArgs e)
        {
            ClickCountTxtEmailId = ValidationUI.ClearTextBox(txtEnterMemberEmailId, ClickCountTxtEmailId);
            txtEnterMemberEmailId.ForeColor = Color.Black;
        }

        private void txtEnterMemberCity_Click(object sender, EventArgs e)
        {
            ClickCountTxtCity = ValidationUI.ClearTextBox(txtEnterMemberCity, ClickCountTxtCity);
            txtEnterMemberCity.ForeColor = Color.Black;
        }

        private void txtEnterMemberDistrict_Click(object sender, EventArgs e)
        {
            ClickCountTxtDistrict = ValidationUI.ClearTextBox(txtEnterMemberDistrict, ClickCountTxtDistrict);
            txtEnterMemberDistrict.ForeColor = Color.Black;
        }

        private void txtEnterMemberState_Click(object sender, EventArgs e)
        {
            ClickCountTxtState = ValidationUI.ClearTextBox(txtEnterMemberState, ClickCountTxtState);
            txtEnterMemberState.ForeColor = Color.Black;
        }

        private void txtEnterMemberEmergencyContact_Click(object sender, EventArgs e)
        {
            ClickCountTxtEmergencyContact = ValidationUI.ClearTextBox(txtEnterMemberEmergencyContact, ClickCountTxtEmergencyContact);
            txtEnterMemberEmergencyContact.ForeColor = Color.Black;
        }

        private void cmbSelectMemberMemberMembershipPlan_Click(object sender, EventArgs e)
        {
            //cmbSelectMemberMemberMembershipPlan.Items.Clear();
            //cmbSelectMemberMemberMembershipPlan.Text = null;
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
            //cmbSelectMemberDietPlan.Items.Clear();
            //cmbSelectMemberDietPlan.Text = null;
            cmbSelectMemberDietPlan.ForeColor = Color.Black;
        }

        private void cmbSelectMemberPaymentMethod_Click(object sender, EventArgs e)
        {
            //cmbSelectMemberPaymentMethod.Items.Clear();
            cmbSelectMemberPaymentMethod.Text = null;
            cmbSelectMemberPaymentMethod.ForeColor = Color.Black;
        }

        private void cmbSelectMemberPaymentFeesType_Click(object sender, EventArgs e)
        {
            //cmbSelectMemberPaymentFeesType.Items.Clear();
            cmbSelectMemberPaymentFeesType.Text = null;
            cmbSelectMemberPaymentFeesType.ForeColor = Color.Black;
        
        }

        private void FrmMemberRegistration_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void cmbSelectMemberGender_Click_1(object sender, EventArgs e)
        {
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
            if(ClickCountTxtFirstName==0)
            {
                txtEnterMemberFirstName.Clear();
            }
            if (ClickCountTxtMiddleName == 0)
            {
                txtEnterMemberMiddleName.Clear();
            }
            if (ClickCountTxtLastName == 0)
            {
                txtEnterMemberLastName.Clear();
            }
            if (ClickCountTxtPhoneNumber == 0)
            {
                txtEnterMemberPhoneNumber.Clear();
            }
            if (ClickCountTxtEmailId == 0)
            {
                txtEnterMemberEmailId.Clear();
            }
            if (ClickCountTxtEmergencyContact == 0)
            {
                txtEnterMemberEmergencyContact.Clear();
            }
            if (ClickCountTxtState == 0)
            {
                txtEnterMemberState.Clear();
            }
            if (ClickCountTxtCity == 0)
            {
                txtEnterMemberCity.Clear();
            }
            if (ClickCountTxtDistrict == 0)
            {
                txtEnterMemberDistrict.Clear();
            }
            //Radio Button Validation
            if (!ValidationUI.ValidateRadioButtonSelection(
                    rbtnNeedLocker,
                    rbtnDontNeedLocker))
            {
                return;
            }
            //TextBox Validation
            if (!ValidationUI.ValidateRequiredTextBoxes(
                this.txtEnterMemberFirstName,
                this.txtEnterMemberLastName,
                this.txtEnterMemberPhoneNumber,
                this.txtEnterMemberEmailId,
                this.txtEnterMemberEmergencyContact,
                this.txtEnterMemberState,
                this.txtEnterMemberCity,
                this.txtEnterMemberDistrict
                ))
            {
                return;
            }
            //ComboBox Validation
            if (!ValidationUI.ValidateRequiredComboBoxes(
                cmbSelectMemberMemberMembershipPlan,
                cmbSelectMemberShiftTime,
                cmbSelectMemberDietPlan,
                cmbSelectMemberPaymentMethod,
                cmbSelectMemberPaymentFeesType,
                cmbSelectMemberGender
                ))
            {
                return;
            }
            //Object Created
            MemberAllDetailsUI memberAllDetailsUI = new MemberAllDetailsUI();

            memberAllDetailsUI.FirstName = txtEnterMemberFirstName.Text.Trim();
            memberAllDetailsUI.MiddleName = txtEnterMemberMiddleName.Text.Trim();
            memberAllDetailsUI.LastName = txtEnterMemberLastName.Text.Trim();
            memberAllDetailsUI.GenderId = Convert.ToInt32(cmbSelectMemberGender.SelectedValue);
            memberAllDetailsUI.PhoneNo = txtEnterMemberPhoneNumber.Text.Trim();
            memberAllDetailsUI.EmailId = txtEnterMemberEmailId.Text.Trim();
            memberAllDetailsUI.City = txtEnterMemberCity.Text.Trim();
            memberAllDetailsUI.District = txtEnterMemberDistrict.Text.Trim();
            memberAllDetailsUI.State = txtEnterMemberState.Text.Trim();
            memberAllDetailsUI.EmergencyContact = txtEnterMemberEmergencyContact.Text.Trim();
            memberAllDetailsUI.MembershipPlanId = Convert.ToInt32(cmbSelectMemberMemberMembershipPlan.SelectedValue);


            memberAllDetailsUI.PaymentMethod =cmbSelectMemberPaymentMethod.Text;
            memberAllDetailsUI.FeesType =cmbSelectMemberPaymentFeesType.Text;

            //=========================
            // SHIFT
            //=========================

            memberAllDetailsUI.ShiftId = Convert.ToInt32(cmbSelectMemberShiftTime.SelectedValue);

            //=========================
            // DIET
            //=========================

            memberAllDetailsUI.DietPlanId =Convert.ToInt32(cmbSelectMemberDietPlan.SelectedValue);

            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                memberAllDetailsUI.ProfilePhoto =
                    File.ReadAllBytes(selectedImagePath);
            }
            if (rbtnNeedLocker.Checked)
            {
                memberAllDetailsUI.NeedLocker = 1;
            }
            else
            {
                memberAllDetailsUI.NeedLocker = 0;
            }
            string message = memberAllDetailsUI.RegisterNewMemberUI();

            MessageBox.Show(message,
                            "Registration",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void cmbSelectMemberShiftTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            cmbSelectMemberShiftTime.ForeColor = Color.Black;
        }

        private void cmbSelectMemberMemberMembershipPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
                cmbSelectMemberMemberMembershipPlan.ForeColor = Color.Black;
        }

        private void cmbSelectMemberDietPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            cmbSelectMemberDietPlan.ForeColor = Color.Black;
        }

        private void cmbSelectMemberGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            cmbSelectMemberGender.ForeColor = Color.Black;
        }

        private void cmbSelectMemberPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            cmbSelectMemberPaymentMethod.ForeColor = Color.Black;
        }

        private void pnlMemberBrowsePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select Member Photo";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
               picMemberUploadedPhoto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void cmbSelectMemberPaymentFeesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
