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

        public FrmSAAddNewEmployee()
        {
            InitializeComponent();
        }

        private void FrmSAAddNewEmployee_Load(object sender, EventArgs e)
        {
            // Employee Type
            LoadEmployeeRoles();
            cmbEmployeeType.SelectedIndex = -1;
            // Load Trainer cmb
            LoadTrainerTypes();
            //pnlDefault.Visible = true;
            pnlDefault.BringToFront();
         
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
            // REQUIRED TEXTBOX VALIDATION
            // ==========================================

            //if (!ValidationUI.ValidateRequiredTextBoxes(
            //    txtFirstName,
            //    txtLastName,
            //    txtPhoneNumber,
            //    txtEmailId,
            //    txtSalary,
            //    txtBankAccountNo))
            //{
            //    return;
            //}


            // ==========================================
            // REQUIRED GENDER RADIO BUTTON VALIDATION
            // ==========================================

            if (!ValidationUI.ValidateGenderRadioButtonSelection(
                rdoMale,
                rdoFemale,
                rdoOthers))
            {
                return;
            }


            // ==========================================
            // REQUIRED ROLE COMBOBOX VALIDATION
            // ==========================================

            //if (!ValidationUI.ValidateRequiredComboBoxes(
            //    cmbEmployeeType))
            //{
            //    return;
            //}


            // ==========================================
            // CREATE EMPLOYEE UI OBJECT
            // ==========================================

            EmployeeUI employeeUI =
                new EmployeeUI();


            // ==========================================
            // EMPLOYEE PERSONAL DETAILS
            // ==========================================

            employeeUI.FirstName =
                txtFirstName.Text.Trim();

            employeeUI.MiddleName =
                txtMiddleName.Text.Trim();

            employeeUI.LastName =
                txtLastName.Text.Trim();


            // ==========================================
            // GENDER
            // ==========================================

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


            employeeUI.PhoneNo =
                txtPhoneNumber.Text.Trim();

            employeeUI.EmailId =
                txtEmailId.Text.Trim();

            employeeUI.BankAccountNo =
                txtBankAccountNo.Text.Trim();


            // ==========================================
            // EMPLOYEE ROLE
            // ==========================================

            employeeUI.RoleId =
                Convert.ToInt32(cmbEmployeeType.SelectedValue);


            // ==========================================
            // SALARY
            // ==========================================

            decimal salary;

            if (!decimal.TryParse(
                txtSalary.Text.Trim(),
                out salary))
            {
                MessageBox.Show(
                    "Please enter a valid salary amount.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSalary.BackColor =
                    Color.FromArgb(255, 240, 240);

                return;
            }

            employeeUI.Amount = salary;


            // ==========================================
            // ROLE BASED DATA
            // ==========================================

            string selectedRole =
                cmbEmployeeType.Text.Trim();


            // ==========================================
            // ADMIN DETAILS
            // ==========================================

            if (selectedRole == "Admin")
            {
                //if (!ValidationUI.ValidateRequiredTextBoxes(
                //    txtUserName,
                //    txtPassword,
                //    txtConfirmPassword))
                //{
                //    return;
                //}

                if (txtPassword.Text.Trim() !=
                    txtConfirmPassword.Text.Trim())
                {
                    MessageBox.Show(
                        "Password and Confirm Password do not match.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtConfirmPassword.BackColor =
                        Color.FromArgb(255, 240, 240);

                    return;
                }

                employeeUI.UserName =
                    txtUserName.Text.Trim();

                employeeUI.PasswordHash =
                    txtPassword.Text.Trim();
            }


            // ==========================================
            // TRAINER DETAILS
            // ==========================================

            if (selectedRole == "Trainer")
            {
                //if (!ValidationUI.ValidateRequiredTextBoxes(
                //    txtSpecialization))
                //{
                //    return;
                //}

                //if (!ValidationUI.ValidateRequiredComboBoxes(
                //    cmbTrainerType))
                //{
                //    return;
                //}

                employeeUI.TrainerType =
                    cmbTrainerType.Text.Trim();

                employeeUI.Specialization =
                    txtSpecialization.Text.Trim();
                employeeUI.Document = selectedFileBytes;
            }


             //==========================================
             //EMPLOYEE INSERT
             //==========================================

            try
            {
                string message =
                    employeeUI.InsertEmployeeUI();

                MessageBox.Show(
                    message,
                    "Employee Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

       
        
    }
}
