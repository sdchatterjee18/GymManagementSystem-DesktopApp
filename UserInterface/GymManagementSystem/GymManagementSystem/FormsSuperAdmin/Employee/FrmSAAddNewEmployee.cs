using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.Common;
using GymManagementSystem.FormsSuperAdmin.Employee.UI;
using System.IO;
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystem.FormsSuperAdmin.Employee
{
    public partial class FrmSAAddNewEmployee : Form
    {
        // CLICK COUNT VARIABLES
        int ClickCountTxtFirstName = 0;
        int ClickCountTxtMiddleName = 0;
        int ClickCountTxtLastName = 0;
        int ClickCountDateOfBirth = 0;
        int ClickCountTxtPhoneNumber = 0;
        int ClickCountTxtEmailId = 0;
        int ClickCountTxtSalary = 0;
        int ClickCountTxtBankAccountNo = 0;
        int ClickCountTxtSpecialization = 0;
        int ClickCountTxtDocument = 0;
        int ClickCountTxtUserName = 0;
        int ClickCountTxtPassword = 0;
        int ClickCountTxtConfirmPassword = 0;
        private byte[] selectedFileBytes;
        private bool isDateOfBirthSelected = false;

        public FrmSAAddNewEmployee()
        {
            InitializeComponent();
            SetErrorProviderAlignment();
        }
        private void SetErrorProviderAlignment()
        {
            Control[] controls =
            {
                txtFirstName,
                txtFirstName,
                txtLastName,
                txtPhoneNumber,
                txtEmailId,
                txtSalary,
                txtBankAccountNo,

                cmbEmployeeType,

                txtUserName,
                txtPassword,
                txtConfirmPassword,

                cmbTrainerType,
                txtSpecialization
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
        private void FrmSAAddNewEmployee_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();
            // Employee Type
            LoadEmployeeRoles();
            cmbEmployeeType.SelectedIndex = -1;
            // Load Trainer cmb
            LoadTrainerTypes();
            //pnlDefault.Visible = true;
            pnlDefault.BringToFront();

            // ==========================================
            // DATE OF BIRTH DEFAULT
            // ==========================================
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.CustomFormat = " ";
            isDateOfBirthSelected = false;
            this.ActiveControl = null;   
        }
        // Load Employee cmb
        private void LoadEmployeeRoles()
        {
            EmployeeUI employeeUI = new EmployeeUI();

            DataTable dataTable =
                employeeUI.LoadEmployeeRoles();

            cmbEmployeeType.DataSource = dataTable;
            cmbEmployeeType.DisplayMember = "Role";
            cmbEmployeeType.ValueMember = "RoleId";
            cmbEmployeeType.SelectedIndex = -1;
        }
        // Load Trainer cmb
        private void LoadTrainerTypes()
        {
            EmployeeUI employeeUI = new EmployeeUI();

            List<string> trainerTypes =
                employeeUI.LoadTrainerTypes();

            cmbTrainerType.DataSource = trainerTypes;

            cmbTrainerType.SelectedIndex = -1;
        }

        private void cmbEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
    
            pnlAdminDetails.Visible = false;
            pnlTrainerDetails.Visible = false;
            pnlStaffDetails.Visible = false;

            if (cmbEmployeeType.SelectedIndex == -1)
            {
                pnlDefault.Visible = true;
                pnlDefault.BringToFront();

                return;
            }
            pnlDefault.Visible = false;

            if (cmbEmployeeType.Text == "Admin")
            {
                pnlAdminDetails.Visible = true;
                pnlAdminDetails.BringToFront();
            }
            else if (cmbEmployeeType.Text == "Trainer")
            {
                pnlTrainerDetails.Visible = true;
                pnlTrainerDetails.BringToFront();
            }
            else if (cmbEmployeeType.Text == "Staff")
            {
                pnlStaffDetails.Visible = true;
                pnlStaffDetails.BringToFront();
            }
        }

        private void FrmSAAddNewEmployee_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void pnlSubmitForm_MouseEnter(object sender, EventArgs e)
        {
            pnlSubmitForm.BackColor = Color.FromArgb(76, 175, 80);
        }

        private void pnlSubmitForm_MouseLeave(object sender, EventArgs e)
        {
            pnlSubmitForm.BackColor = Color.Green;
        }

        private void pnlSubmitForm_Click(object sender, EventArgs e)
        {
            // ==========================================
            // CLEAR DEFAULT PLACEHOLDER TEXT
            // ==========================================

            ValidationUI.ClearDefaultPlaceholderText(
                txtFirstName,
                ClickCountTxtFirstName);

            ValidationUI.ClearDefaultPlaceholderText(
                txtMiddleName,
                ClickCountTxtMiddleName);

            ValidationUI.ClearDefaultPlaceholderText(
                txtLastName,
                ClickCountTxtLastName);

            ValidationUI.ClearDefaultPlaceholderText(
                txtPhoneNumber,
                ClickCountTxtPhoneNumber);

            ValidationUI.ClearDefaultPlaceholderText(
                txtEmailId,
                ClickCountTxtEmailId);

            ValidationUI.ClearDefaultPlaceholderText(
                txtSalary,
                ClickCountTxtSalary);

            ValidationUI.ClearDefaultPlaceholderText(
                txtBankAccountNo,
                ClickCountTxtBankAccountNo);

            ValidationUI.ClearDefaultPlaceholderText(
                txtSpecialization,
                ClickCountTxtSpecialization);

            ValidationUI.ClearDefaultPlaceholderText(
                txtUserName,
                ClickCountTxtUserName);

            ValidationUI.ClearDefaultPlaceholderText(
                txtPassword,
                ClickCountTxtPassword);

            ValidationUI.ClearDefaultPlaceholderText(
                txtConfirmPassword,
                ClickCountTxtConfirmPassword);

            // ==========================================
            // VALIDATION
            // ==========================================

            ValidationUI.ValidationResult result;
            bool isValid = true;
            errorProvider1.Clear();

            //TEXT_BOXES
            result = ValidationUI.ValidateRequiredTextBox(txtFirstName);
            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(txtFirstName,"First Name " + ValidationUI.GetValidationMessage(result));
                isValid = false;
            }
            result = ValidationUI.ValidateRequiredTextBox(txtLastName);

           if (result != ValidationUI.ValidationResult.Valid)
           {
             errorProvider1.SetError(txtLastName,"Last Name " + ValidationUI.GetValidationMessage(result));
             isValid = false;
           }

           result = ValidationUI.ValidateRequiredTextBox(txtPhoneNumber);
           if (result != ValidationUI.ValidationResult.Valid)
           {
            errorProvider1.SetError(txtPhoneNumber,"Phone Number " + ValidationUI.GetValidationMessage(result));
            isValid = false;
           }

           result = ValidationUI.ValidateRequiredTextBox(txtEmailId);
           if (result != ValidationUI.ValidationResult.Valid)
           {
            errorProvider1.SetError(txtEmailId,"Email ID " + ValidationUI.GetValidationMessage(result));
            isValid = false;
           }

          result = ValidationUI.ValidateRequiredTextBox(txtSalary);
          if (result != ValidationUI.ValidationResult.Valid)
          {
                errorProvider1.SetError(
                    txtSalary,
                    "Salary " + ValidationUI.GetValidationMessage(result));
                isValid = false;
          }

        result = ValidationUI.ValidateRequiredTextBox(txtBankAccountNo);

        if (result != ValidationUI.ValidationResult.Valid)
        {
            errorProvider1.SetError(
                txtBankAccountNo,
                "Bank Account Number " +
                ValidationUI.GetValidationMessage(result));

            isValid = false;
        }
        
        //COMBO_BOXES
        result = ValidationUI.ValidateRequiredComboBox(cmbEmployeeType);
        if (result != ValidationUI.ValidationResult.Valid)
        {
            errorProvider1.SetError(
                cmbEmployeeType,
                "Employee Type " +
                ValidationUI.GetValidationMessage(result));

            isValid = false;
        }

        //RADIO_BUTTON
        result = ValidationUI.ValidateRadioButtonSelection(rdoMale,rdoFemale,rdoOthers);
        if (result != ValidationUI.ValidationResult.Valid)
        {
            errorProvider1.SetError(
                rdoOthers,
                "Gender selection " +
                ValidationUI.GetValidationMessage(result));

            isValid = false;
        }
        
        //DATE TIME PICKER
        if (!isDateOfBirthSelected)
        {
            errorProvider1.SetError(
                dtpDOB,
                "Date of Birth is required.");

            isValid = false;
        }
            // ROLE BASED DATA
            string selectedRole =cmbEmployeeType.Text.Trim();

            // ==========================================
            // ADMIN DETAILS
            // ==========================================
            if (selectedRole == "Admin")
            {
                result = ValidationUI.ValidateRequiredTextBox(txtUserName);

                if (result != ValidationUI.ValidationResult.Valid)
                {
                    errorProvider1.SetError(
                        txtUserName,
                        "Username " +
                        ValidationUI.GetValidationMessage(result));
                    isValid = false;
                }


                result = ValidationUI.ValidateRequiredTextBox(txtPassword);

                if (result != ValidationUI.ValidationResult.Valid)
                {
                    errorProvider1.SetError(
                        txtPassword,
                        "Password " +
                        ValidationUI.GetValidationMessage(result));
                    isValid = false;
                }


                result = ValidationUI.ValidateRequiredTextBox(txtConfirmPassword);

                if (result != ValidationUI.ValidationResult.Valid)
                {
                    errorProvider1.SetError(
                        txtConfirmPassword,
                        "Confirm Password " +
                        ValidationUI.GetValidationMessage(result));
                    isValid = false;
                }

                if (txtPassword.Text.Trim() !=txtConfirmPassword.Text.Trim())
                {
                    errorProvider1.SetError(txtConfirmPassword,"Password and Confirm Password do not match.");
                    MessageBox.Show(
                    "Password and Confirm Password do not match",
                    "Invalid Salary",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                    txtConfirmPassword.Focus();
                    return; 
                }
            }
            // ==========================================
            // TRAINER DETAILS
            // ==========================================
            if (selectedRole == "Trainer")
            {
                result = ValidationUI.ValidateRequiredComboBox(cmbTrainerType);

                if (result != ValidationUI.ValidationResult.Valid)
                {
                    errorProvider1.SetError(
                        cmbTrainerType,
                        "Trainer Type " +
                        ValidationUI.GetValidationMessage(result));

                    isValid = false;
                }


                result = ValidationUI.ValidateRequiredTextBox(txtSpecialization);

                if (result != ValidationUI.ValidationResult.Valid)
                {
                    errorProvider1.SetError(
                        txtSpecialization,
                        "Specialization " +
                        ValidationUI.GetValidationMessage(result));

                    isValid = false;
                }
            }
            if (!isValid)
            {
                MessageBox.Show(
                    "Please fill in all required fields.",
                    "Required Fields",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.ActiveControl = null;

                return;
            }

            //salary validation
            decimal salary;
            if (!decimal.TryParse(txtSalary.Text.Trim(), out salary))
            {
                errorProvider1.SetError(
                    txtSalary,
                    "Please enter a valid salary amount.");

                MessageBox.Show(
                "Please enter a valid salary amount.",
                "Invalid Salary",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                txtSalary.Focus();
                return;
            }

            // ==========================================
            // CREATE EMPLOYEE UI OBJECT
            // ==========================================
            EmployeeUI employeeUI = new EmployeeUI();

            // EMPLOYEE PERSONAL DETAILS
            employeeUI.FirstName = txtFirstName.Text.Trim();
            employeeUI.MiddleName = txtMiddleName.Text.Trim();
            employeeUI.LastName = txtLastName.Text.Trim();
            employeeUI.DateOfBirth = dtpDOB.Value;
            if (rdoMale.Checked)
            {
                employeeUI.GenderId = 1;
            }
            else if (rdoFemale.Checked)
            {
                employeeUI.GenderId = 2;
            }
            else if (rdoOthers.Checked)
            {
                employeeUI.GenderId = 3;
            }

            employeeUI.PhoneNo = txtPhoneNumber.Text.Trim();
            employeeUI.EmailId = txtEmailId.Text.Trim();
            employeeUI.BankAccountNo = txtBankAccountNo.Text.Trim();


            // ==========================================
            // EMPLOYEE ROLE
            // ==========================================
            employeeUI.RoleId =
                Convert.ToInt32(cmbEmployeeType.SelectedValue);

            // SALARY
            employeeUI.Amount = salary;

            // ADMIN DETAILS
            if (selectedRole == "Admin")
            {
                employeeUI.UserName =
                    txtUserName.Text.Trim();

                employeeUI.Password =
                    txtPassword.Text.Trim();
            }

            // TRAINER DETAILS
            if (selectedRole == "Trainer")
            {
                employeeUI.TrainerType =
                    cmbTrainerType.Text.Trim();

                employeeUI.Specialization =
                    txtSpecialization.Text.Trim();

                employeeUI.Document =
                    selectedFileBytes;
            }

            // CALL UI METHOD
            ValidationResult finalResult =employeeUI.InsertEmployeeUI();
            HandleRegistrationResult(finalResult);
        }
        private void HandleRegistrationResult(ValidationResult result)
        {
            errorProvider1.Clear();

            // ==========================================
            // SUCCESS
            // ==========================================

            if (result.Result ==
                ValidationBll.CommonValidationMessage.Valid)
            {
                MessageBox.Show(
                    result.Message,
                    "Employee Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.ActiveControl = null;

                return;
            }


            // ==========================================
            // DISPLAY ERROR PROVIDER
            // ==========================================

            switch (result.FieldName)
            {
                case "FirstName":

                    errorProvider1.SetError(
                        txtFirstName,
                        result.Message);

                    break;


                case "MiddleName":

                    errorProvider1.SetError(
                        txtMiddleName,
                        result.Message);

                    break;


                case "LastName":

                    errorProvider1.SetError(
                        txtLastName,
                        result.Message);

                    break;


                case "PhoneNo":

                    errorProvider1.SetError(
                        txtPhoneNumber,
                        result.Message);

                    break;


                case "EmailId":

                    errorProvider1.SetError(
                        txtEmailId,
                        result.Message);

                    break;


                case "Salary":

                    errorProvider1.SetError(
                        txtSalary,
                        result.Message);

                    break;


                case "BankAccountNo":

                    errorProvider1.SetError(
                        txtBankAccountNo,
                        result.Message);

                    break;


                case "UserName":

                    errorProvider1.SetError(
                        txtUserName,
                        result.Message);

                    break;


                case "Password":

                    errorProvider1.SetError(
                        txtPassword,
                        result.Message);

                    break;


                case "ConfirmPassword":

                    errorProvider1.SetError(
                        txtConfirmPassword,
                        result.Message);

                    break;


                case "TrainerType":

                    errorProvider1.SetError(
                        cmbTrainerType,
                        result.Message);

                    break;


                case "Specialization":

                    errorProvider1.SetError(
                        txtSpecialization,
                        result.Message);

                    break;
            }


            // ==========================================
            // SHOW VALIDATION MESSAGE
            // ==========================================

            MessageBox.Show(
                result.Message,
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            this.ActiveControl = null;
        }
        private void pnlReset_MouseEnter(object sender, EventArgs e)
        {
            pnlReset.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void pnlReset_MouseLeave(object sender, EventArgs e)
        {
            pnlReset.BackColor = Color.Blue;
        }

        private void pnlReset_Click(object sender, EventArgs e)
        {
            // =========================
            // Clear TextBoxes
            // =========================

            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            txtEmailId.Clear();
            txtSalary.Clear();
            txtBankAccountNo.Clear();
            txtSpecialization.Clear();
            txtDocument.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();

            // =========================
            // Clear Gender
            // =========================

            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            rdoOthers.Checked = false;

            // =========================
            // Reset Employee Type
            // =========================

            cmbEmployeeType.SelectedIndex = -1;

            // =========================
            // Reset Trainer Type
            // =========================

            cmbTrainerType.SelectedIndex = -1;

            // =========================
            // Reset Panels
            // =========================

            pnlAdminDetails.Visible = false;
            pnlTrainerDetails.Visible = false;
            pnlStaffDetails.Visible = false;

            pnlDefault.Visible = true;
            pnlDefault.BringToFront();

            // =========================
            // Reset Click Count
            // =========================

            ClickCountTxtFirstName = 0;
            ClickCountTxtMiddleName = 0;
            ClickCountTxtLastName = 0;
            ClickCountDateOfBirth = 0;
            ClickCountTxtPhoneNumber = 0;
            ClickCountTxtEmailId = 0;
            ClickCountTxtSalary = 0;
            ClickCountTxtBankAccountNo = 0;
            ClickCountTxtSpecialization = 0;
            ClickCountTxtDocument = 0;
            ClickCountTxtUserName = 0;
            ClickCountTxtPassword = 0;
            ClickCountTxtConfirmPassword = 0;

            // =========================
            // Remove Focus
            // =========================

            this.ActiveControl = null;
        }

        private void pnlCancel_MouseEnter(object sender, EventArgs e)
        {
            pnlCancel.BackColor = Color.FromArgb(203, 67, 53);
        }

        private void pnlCancel_MouseLeave(object sender, EventArgs e)
        {
            pnlCancel.BackColor = Color.Red;
        }

        private void pnlCancel_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel?",
                "Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {
            ClickCountTxtFirstName = ValidationUI.ClearTextBoxWhenClicked(txtFirstName,ClickCountTxtFirstName);
            txtFirstName.ForeColor = Color.Black;
        }

        private void txtMiddleName_Click(object sender, EventArgs e)
        {
            ClickCountTxtMiddleName = ValidationUI.ClearTextBoxWhenClicked(txtMiddleName,ClickCountTxtMiddleName);
            txtMiddleName.ForeColor = Color.Black;
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            ClickCountTxtLastName = ValidationUI.ClearTextBoxWhenClicked(txtLastName,ClickCountTxtLastName);
            txtLastName.ForeColor = Color.Black;
        }

        //private void txtDateOfBirth_Click(object sender, EventArgs e)
        //{
        //    ClickCountTxtDateOfBirth = ValidationUI.ClearTextBoxWhenClicked(dateTimePicker1,ClickCountTxtDateOfBirth);
        //    txtDateOfBirth.ForeColor = Color.Black;
        //}


        private void txtPhoneNumber_Click(object sender, EventArgs e)
        {
            ClickCountTxtPhoneNumber = ValidationUI.ClearTextBoxWhenClicked(txtPhoneNumber,ClickCountTxtPhoneNumber);
            txtPhoneNumber.ForeColor = Color.Black;
        }
        private void txtEmailId_Click(object sender, EventArgs e)
        {
            ClickCountTxtEmailId = ValidationUI.ClearTextBoxWhenClicked(txtEmailId,ClickCountTxtEmailId);
            txtEmailId.ForeColor = Color.Black;
        }

        private void txtSalary_Click(object sender, EventArgs e)
        {
            ClickCountTxtSalary = ValidationUI.ClearTextBoxWhenClicked(txtSalary,ClickCountTxtSalary);
            txtSalary.ForeColor = Color.Black;
        }

        private void txtBankAccountNo_Click(object sender, EventArgs e)
        {
            ClickCountTxtBankAccountNo = ValidationUI.ClearTextBoxWhenClicked(txtBankAccountNo,ClickCountTxtBankAccountNo);
            txtBankAccountNo.ForeColor = Color.Black;
        }

        private void txtSpecialization_Click(object sender, EventArgs e)
        {
            ClickCountTxtSpecialization = ValidationUI.ClearTextBoxWhenClicked(txtSpecialization,ClickCountTxtSpecialization);
            txtSpecialization.ForeColor = Color.Black;
        }

        private void txtDocument_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;

                    // Convert selected file into byte[]
                    byte[] fileBytes = File.ReadAllBytes(filePath);

                    // Store it in a form-level variable
                    selectedFileBytes = fileBytes;
                }
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            ClickCountTxtUserName = ValidationUI.ClearTextBoxWhenClicked(txtUserName,ClickCountTxtUserName);
            txtUserName.ForeColor = Color.Black;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            ClickCountTxtPassword = ValidationUI.ClearTextBoxWhenClicked(txtPassword,ClickCountTxtPassword);
            txtPassword.ForeColor = Color.Black;
        }

        private void txtConfirmPassword_Click(object sender, EventArgs e)
        {
            ClickCountTxtConfirmPassword = ValidationUI.ClearTextBoxWhenClicked(txtConfirmPassword,ClickCountTxtConfirmPassword);
            txtConfirmPassword.ForeColor = Color.Black;
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            dtpDOB.CustomFormat = "dd/MM/yyyy";
            isDateOfBirthSelected = true;
            errorProvider1.SetError(dtpDOB, "");
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            txtMiddleName.Focus();
        }

        private void txtMiddleName_Leave(object sender, EventArgs e)
        {
            txtLastName.Focus();
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            txtPhoneNumber.Focus();
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            txtEmailId.Focus();
        }

        private void txtEmailId_Leave(object sender, EventArgs e)
        {
            cmbEmployeeType.Focus();
            cmbEmployeeType.DroppedDown = true;
        }

        private void cmbEmployeeType_Leave(object sender, EventArgs e)
        {
            txtSalary.Focus();
        }

        private void txtSpecialization_Leave(object sender, EventArgs e)
        {
            txtBankAccountNo.Focus();
        }

       
        
    }
}
