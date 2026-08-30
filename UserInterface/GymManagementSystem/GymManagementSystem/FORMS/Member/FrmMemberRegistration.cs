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
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystem.FORMS.Member
{
    public partial class FrmMemberRegistration : Form
    {
        private string selectedImagePath = string.Empty;
        private byte[] selectedProfilePhoto = null;
        public FrmMemberRegistration()
        {
            InitializeComponent();
            SetErrorProviderAlignment();
        }
        private void SetErrorProviderAlignment()
        {
            Control[] controls =
    {
        this.txtEnterMemberFirstName,
        this.txtEnterMemberLastName,
        this.txtEnterMemberPhoneNumber,
        this.txtEnterMemberEmailId,
        this.txtEnterMemberState,
        this.txtEnterMemberCity,
        this.txtEnterMemberDistrict,

        this.cmbSelectMemberMemberMembershipPlan,
        this.cmbSelectMemberShiftTime,
        this.cmbSelectMemberDietPlan,
        this.cmbSelectMemberPaymentMethod,
        this.cmbSelectMemberGender
    };
            foreach (Control control in controls)
            {
                errorProvider1.SetIconAlignment(
                    control,
                    ErrorIconAlignment.MiddleRight);

                errorProvider1.SetIconPadding(
                    control,
                    15);
            }
        }
        //CLICK COUNT VARIABLES OF TEXTBOXES
        int ClickCountTxtFirstName = 0;
        int ClickCountTxtMiddleName = 0;
        int ClickCountTxtLastName = 0;
        int ClickCountTxtPhoneNumber = 0;
        int ClickCountTxtEmailId = 0;
        int ClickCountTxtEmergencyContact = 0;
        int ClickCountTxtState = 0;
        int ClickCountTxtCity = 0;
        int ClickCountTxtDistrict = 0;

        //METHODS FOR LOAD DATA IN COMBOBOXES
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

        private void FrmMemberRegistration_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            LoadShiftComboBox();
            LoadMembershipPlanComboBox();
            LoadDietPlanComboBox();
            LoadGenderComboBox();
            LoadPaymentMethodComboBox();
        }

        private void txtEnterMemberFirstName_Click(object sender, EventArgs e)
        {  
            txtEnterMemberFirstName.ForeColor = Color.Black;
            ClickCountTxtFirstName = ValidationUI.ClearTextBoxWhenClicked(txtEnterMemberFirstName, ClickCountTxtFirstName);
        }

        private void txtEnterMemberMiddleName_Click(object sender, EventArgs e)
        {
            ClickCountTxtMiddleName = ValidationUI.ClearTextBoxWhenClicked(txtEnterMemberMiddleName, ClickCountTxtMiddleName);
            txtEnterMemberMiddleName.ForeColor = Color.Black;
        }

        private void txtEnterMemberLastName_Click(object sender, EventArgs e)
        {
            ClickCountTxtLastName = ValidationUI.ClearTextBoxWhenClicked(txtEnterMemberLastName, ClickCountTxtLastName);
            txtEnterMemberLastName.ForeColor = Color.Black;
        }

        private void txtEnterMemberPhoneNumber_Click(object sender, EventArgs e)
        {
            ClickCountTxtPhoneNumber = ValidationUI.ClearTextBoxWhenClicked(txtEnterMemberPhoneNumber, ClickCountTxtPhoneNumber);
            txtEnterMemberPhoneNumber.ForeColor = Color.Black;
        }

        private void txtEnterMemberEmailId_Click(object sender, EventArgs e)
        {
            ClickCountTxtEmailId = ValidationUI.ClearTextBoxWhenClicked(txtEnterMemberEmailId, ClickCountTxtEmailId);
            txtEnterMemberEmailId.ForeColor = Color.Black;
        }

        private void txtEnterMemberCity_Click(object sender, EventArgs e)
        {
            ClickCountTxtCity = ValidationUI.ClearTextBoxWhenClicked(txtEnterMemberCity, ClickCountTxtCity);
            txtEnterMemberCity.ForeColor = Color.Black;
        }

        private void txtEnterMemberDistrict_Click(object sender, EventArgs e)
        {
            ClickCountTxtDistrict = ValidationUI.ClearTextBoxWhenClicked(txtEnterMemberDistrict, ClickCountTxtDistrict);
            txtEnterMemberDistrict.ForeColor = Color.Black;
        }

        private void txtEnterMemberState_Click(object sender, EventArgs e)
        {
            ClickCountTxtState = ValidationUI.ClearTextBoxWhenClicked(txtEnterMemberState, ClickCountTxtState);
            txtEnterMemberState.ForeColor = Color.Black;
        }

        private void txtEnterMemberEmergencyContact_Click(object sender, EventArgs e)
        {
            ClickCountTxtEmergencyContact = ValidationUI.ClearTextBoxWhenClicked(txtEnterMemberEmergencyContact, ClickCountTxtEmergencyContact);
            txtEnterMemberEmergencyContact.ForeColor = Color.Black;
        }

        private void FrmMemberRegistration_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
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

            //CLEAR TEXTBOX IF IT CONTAINS DEFAULT PLACEHOLDER BEFORE REGISTRATION BUTTON CLICK
            ValidationUI.ClearDefaultPlaceholderText(txtEnterMemberFirstName, ClickCountTxtFirstName);
            ValidationUI.ClearDefaultPlaceholderText(txtEnterMemberMiddleName, ClickCountTxtMiddleName);
            ValidationUI.ClearDefaultPlaceholderText(txtEnterMemberLastName, ClickCountTxtLastName);
            ValidationUI.ClearDefaultPlaceholderText(txtEnterMemberPhoneNumber, ClickCountTxtPhoneNumber);
            ValidationUI.ClearDefaultPlaceholderText(txtEnterMemberEmailId, ClickCountTxtEmailId);
            ValidationUI.ClearDefaultPlaceholderText(txtEnterMemberEmergencyContact, ClickCountTxtEmergencyContact);
            ValidationUI.ClearDefaultPlaceholderText(txtEnterMemberState, ClickCountTxtState);
            ValidationUI.ClearDefaultPlaceholderText(txtEnterMemberCity, ClickCountTxtCity);
            ValidationUI.ClearDefaultPlaceholderText(txtEnterMemberDistrict, ClickCountTxtDistrict);

            //VALIDATION
            ValidationUI.ValidationResult result;
            bool isValid = true;
            errorProvider1.Clear();
            //VALIDATION OF ALL TEXTBOXES CHECKING NULL AND WHITE SPACES
            // First Name
            result = ValidationUI.ValidateRequiredTextBox(txtEnterMemberFirstName);
            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(txtEnterMemberFirstName,"First Name " +ValidationUI.GetValidationMessage(result));
                isValid = false;
            }

            // Last Name
            result = ValidationUI.ValidateRequiredTextBox(txtEnterMemberLastName);
            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(txtEnterMemberLastName,"Last Name " +ValidationUI.GetValidationMessage(result));
                isValid = false;
            }

            // Phone Number
            result = ValidationUI.ValidateRequiredTextBox(txtEnterMemberPhoneNumber);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(txtEnterMemberPhoneNumber,"Phone Number " +ValidationUI.GetValidationMessage(result));
                isValid = false;
            }

            // Email ID
            result = ValidationUI.ValidateRequiredTextBox(txtEnterMemberEmailId);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(txtEnterMemberEmailId,"Email ID " + ValidationUI.GetValidationMessage(result));
                isValid = false;
            }

            // State
            result = ValidationUI.ValidateRequiredTextBox(txtEnterMemberState);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(txtEnterMemberState,"State " +ValidationUI.GetValidationMessage(result));

                isValid = false;
            }

            // City
            result = ValidationUI.ValidateRequiredTextBox(txtEnterMemberCity);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(txtEnterMemberCity,"City " +ValidationUI.GetValidationMessage(result));
                isValid = false;
            }

            // District
            result = ValidationUI.ValidateRequiredTextBox(txtEnterMemberDistrict);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(txtEnterMemberDistrict,"District " +ValidationUI.GetValidationMessage(result));
                isValid = false;
            }

            //VALIDATION OF ALL COMBO BOXES CHECKING IF NOT SELECTED
            // Membership Plan
            result = ValidationUI.ValidateRequiredComboBox(
                cmbSelectMemberMemberMembershipPlan);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    cmbSelectMemberMemberMembershipPlan,
                    "Membership Plan " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }

            // Shift Time
            result = ValidationUI.ValidateRequiredComboBox(
                cmbSelectMemberShiftTime);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    cmbSelectMemberShiftTime,
                    "Shift Time " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }

            // Diet Plan
            result = ValidationUI.ValidateRequiredComboBox(
                cmbSelectMemberDietPlan);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    cmbSelectMemberDietPlan,
                    "Diet Plan " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }

            // Payment Method
            result = ValidationUI.ValidateRequiredComboBox(
                cmbSelectMemberPaymentMethod);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    cmbSelectMemberPaymentMethod,
                    "Payment Method " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }

            // Gender
            result = ValidationUI.ValidateRequiredComboBox(
                cmbSelectMemberGender);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    cmbSelectMemberGender,
                    "Gender " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }

            result = ValidationUI.ValidateRadioButtonSelection(rbtnNeedLocker, rbtnDontNeedLocker);
            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    rbtnDontNeedLocker,
                    "Locker selection " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }
            // Stop only after checking ALL textboxes
            if (!isValid)
            {
                MessageBox.Show("Please fill in all required fields.",
                                "Required Fields",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                this.ActiveControl = null;
                return;
            }

            //OBJECT CREATION
            MemberAllDetailsUI memberAllDetailsUI = new MemberAllDetailsUI();
               //ASSIGNING PROPERTIES FROM USER INPUT
            //PERSONAL DETAILS
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
            //MEMBERSHIP PLAN
            memberAllDetailsUI.MembershipPlanId = Convert.ToInt32(cmbSelectMemberMemberMembershipPlan.SelectedValue);
            //PAYMENT
            memberAllDetailsUI.PaymentMethod =cmbSelectMemberPaymentMethod.Text;
            // SHIFT
            memberAllDetailsUI.ShiftId = Convert.ToInt32(cmbSelectMemberShiftTime.SelectedValue);
            // DIET
            memberAllDetailsUI.DietPlanId =Convert.ToInt32(cmbSelectMemberDietPlan.SelectedValue);
            //LOCKER
            if (rbtnNeedLocker.Checked)
                memberAllDetailsUI.NeedLocker = 1;
            else
                memberAllDetailsUI.NeedLocker = 0;
            // PROFILE PHOTO
            if (selectedProfilePhoto != null &&
                selectedProfilePhoto.Length > 0)
            {
                memberAllDetailsUI.ProfilePhoto =
                    selectedProfilePhoto;
            }
            //MEMBER REGISTRATION METHOD CALL FROM UI
            ValidationResult Finalresult =memberAllDetailsUI.RegisterNewMemberUI();
            HandleRegistrationResult(Finalresult);
            
        }
        private void HandleRegistrationResult(ValidationResult result)
        {
            errorProvider1.Clear();

            if (result.Result == ValidationBll.CommonValidationMessage.Valid)
            {
                MessageBox.Show(
                    result.Message,
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            switch (result.FieldName)
            {
                case "FirstName":
                    errorProvider1.SetError(
                        txtEnterMemberFirstName,
                        result.Message);
                    break;

                case "LastName":
                    errorProvider1.SetError(
                        txtEnterMemberLastName,
                        result.Message);
                    break;

                case "PhoneNo":
                    errorProvider1.SetError(
                        txtEnterMemberPhoneNumber,
                        result.Message);
                    break;

                case "EmailId":
                    errorProvider1.SetError(
                        txtEnterMemberEmailId,
                        result.Message);
                    break;

                case "City":
                    errorProvider1.SetError(
                        txtEnterMemberCity,
                        result.Message);
                    break;

                case "District":
                    errorProvider1.SetError(
                        txtEnterMemberDistrict,
                        result.Message);
                    break;

                case "State":
                    errorProvider1.SetError(
                        txtEnterMemberState,
                        result.Message);
                    break;

                case "EmergencyContact":
                    errorProvider1.SetError(
                        txtEnterMemberEmergencyContact,
                        result.Message);
                    break;
            }
            MessageBox.Show(
        result.Message,
        "Validation Error",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning);

            this.ActiveControl = null;
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
            //CHANGE PRICE IN PAYMENT SECTION BASED ON SELECTED MEMBERSHIP PLAN
            if (cmbSelectMemberMemberMembershipPlan.SelectedIndex != -1)
            {
                int MembershipPlanId = Convert.ToInt32(((DataRowView)cmbSelectMemberMemberMembershipPlan.SelectedItem)["MembershipPlanId"]);
                string MembershipPlanPrice = MembershipPlanUI.GetPriceByMembershipPlanId(MembershipPlanId).ToString();

                lblRetrieveMemberPaymentAmount.Text = string.Format("₹ {0:N2}", MembershipPlanPrice);
            }
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

        // OPEN FILE DIALOG TO SELECT PROFILE PHOTO
        private void pnlMemberBrowsePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select Member Photo";

            openFileDialog.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            selectedImagePath = openFileDialog.FileName;

            // Open selected image
            using (Image originalImage =
                   Image.FromFile(selectedImagePath))
            {
                // Create independent copy
                using (Bitmap imageCopy =
                       new Bitmap(originalImage))
                {
                    // Open crop form
                    using (FrmCropImage frmCropImage =
                           new FrmCropImage(imageCopy))
                    {
                        if (frmCropImage.ShowDialog() == DialogResult.OK)
                        {
                            if (frmCropImage.CroppedImage == null)
                                return;

                            // Remove previous image
                            if (picMemberUploadedPhoto.Image != null)
                            {
                                Image oldImage =
                                    picMemberUploadedPhoto.Image;

                                picMemberUploadedPhoto.Image = null;

                                oldImage.Dispose();
                            }

                            // Show cropped image
                            picMemberUploadedPhoto.Image =
                                new Bitmap(
                                    frmCropImage.CroppedImage
                                );

                            picMemberUploadedPhoto.SizeMode =
                                PictureBoxSizeMode.Zoom;

                            // Convert cropped image to byte[]
                            using (MemoryStream ms =
                                   new MemoryStream())
                            {
                                frmCropImage.CroppedImage.Save(
                                    ms,
                                    System.Drawing.Imaging.ImageFormat.Png
                                );

                                selectedProfilePhoto =
                                    ms.ToArray();
                            }
                        }
                    }
                }
            }
        }
    }
}
