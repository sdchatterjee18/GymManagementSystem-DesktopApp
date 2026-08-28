using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using GymManagementSystem.Common;
using GymManagementSystem.FORMS.Locker.UI;
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystem.FORMS.Locker
{
    public partial class FrmAddLocker : Form
    {
        public string LockerNumber { get; private set; } 

        public FrmAddLocker()
        {
            InitializeComponent();
        }
        int clickCountTxtLocker = 0;

        private void pnlClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddLocker_Load(object sender, EventArgs e)
        {

        }

        // Submit Form
        private void tlpButton_Click(object sender, EventArgs e)
        {
            ValidationUI.ClearDefaultPlaceholderText(txtLockerNumber,clickCountTxtLocker);

            ValidationUI.ValidationResult result;
            bool isValid = true;
            errorProvider1.Clear();

            // Plan Name
            result = ValidationUI.ValidateRequiredTextBox(txtLockerNumber);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    txtLockerNumber,
                    "Locker " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
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
            LockerUI lockerUI = new LockerUI();
            lockerUI.LockerNo = txtLockerNumber.Text.Trim();
            ValidationResult lockerResult = lockerUI.InserNewLockerUI();
            HandleLockerResult(lockerResult);
        }
        private void HandleLockerResult(ValidationResult result)
        {
            errorProvider1.Clear();

            if (result.Result == ValidationBll.CommonValidationMessage.Valid)
            {
                MessageBox.Show(
                    result.Message,
                    "Locker",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            switch (result.FieldName)
            {
                case "LockerNumber":
                    errorProvider1.SetError(
                        txtLockerNumber,
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


        private void tlpButton_MouseEnter(object sender, EventArgs e)
        {
            tlpButton.BackColor = Color.White;
            lblSubmit.ForeColor = Color.MidnightBlue;
            picSubmit.Image = Properties.Resources.paper_planeHOVER;
        }

        private void tlpButton_MouseLeave(object sender, EventArgs e)
        {
            tlpButton.BackColor = Color.MidnightBlue;
            lblSubmit.ForeColor = Color.White;
            picSubmit.Image = Properties.Resources.paper_plane;
        }

        private void txtLockerNumber_Click(object sender, EventArgs e)
        {
           clickCountTxtLocker= ValidationUI.ClearTextBoxWhenClicked(txtLockerNumber,clickCountTxtLocker);
        }

    }
}
