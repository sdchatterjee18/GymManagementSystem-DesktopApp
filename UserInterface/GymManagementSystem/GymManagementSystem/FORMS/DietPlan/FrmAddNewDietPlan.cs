using System;
using System.Drawing;
using System.Windows.Forms;
using GymManagementSystem.Common;
using GymManagementSystem.FORMS.DietPlan.UI;
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystem.FORMS.DietPlan
{
    public partial class FrmAddNewDietPlan : Form
    {
        // Global Variables
        int ClickCountTxtRequiredCalories = 0;
        int ClickCountTxtPlanCondition = 0;
        private byte[] dietPlanDocument = null;


        // Constructor
        public FrmAddNewDietPlan()
        {
            InitializeComponent();
            SetErrorProviderAlignment();
        }
        private void SetErrorProviderAlignment()
        {
            Control[] controls =
    {
        this.txtRequiredCalories,
        this.txtPlanCondition,
        this.tlpChooseFile
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
        // Form Load
        private void FrmAddNewDietPlan_Load(object sender, EventArgs e)
        {
            txtRequiredCalories.Focus();
            this.Text = "";
            this.ShowIcon = false;
            this.ActiveControl = null;
            
        }
        // Prevent Default Selection In formLoad
        private void FrmAddNewDietPlan_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        // Required Calories Click
        private void txtRequiredCalories_Click(object sender, EventArgs e)
        {
          
            if (txtRequiredCalories.ForeColor == Color.Gray)
            {
                txtRequiredCalories.Clear();
                txtRequiredCalories.ForeColor = Color.Black;
            }
            
        }
        // Plan Condition Click
        private void txtPlanCondition_Click(object sender, EventArgs e)
        {
            
            if (txtPlanCondition.ForeColor == Color.Gray)
            {
                txtPlanCondition.Clear();
                txtPlanCondition.ForeColor = Color.Black;
            }
            
        }
        // Choose File
        private void tlpChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog =
                new OpenFileDialog())
            {
                openFileDialog.Filter =
                    "PDF and Image Files|*.pdf;*.jpg;*.jpeg;*.png;*.bmp|" +
                    "PDF Files|*.pdf|" +
                    "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                openFileDialog.Title =
                    "Select Diet Plan Document";


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // ==============================
                    // Remove Previous Image
                    // ==============================

                    if (picPlanDocument.Image != null)
                    {
                        picPlanDocument.Image.Dispose();
                        picPlanDocument.Image = null;
                    }


                    // ==============================
                    // File → byte[]
                    // ==============================

                    dietPlanDocument =
                        System.IO.File.ReadAllBytes(
                            openFileDialog.FileName);


                    string extension =
                        System.IO.Path.GetExtension(
                            openFileDialog.FileName).ToLower();


                    // ==============================
                    // Image File
                    // ==============================

                    if (extension == ".jpg" ||
                        extension == ".jpeg" ||
                        extension == ".png" ||
                        extension == ".bmp")
                    {
                        using (System.IO.FileStream fileStream =
                            new System.IO.FileStream(
                                openFileDialog.FileName,
                                System.IO.FileMode.Open,
                                System.IO.FileAccess.Read))
                        {
                            using (Image image =
                                Image.FromStream(fileStream))
                            {
                                picPlanDocument.Image =
                                    new Bitmap(image);
                            }
                        }

                        picPlanDocument.SizeMode =
                            PictureBoxSizeMode.Zoom;
                    }


                    // ==============================
                    // PDF File
                    // ==============================

                    else if (extension == ".pdf")
                    {
                        string pdfIconPath =
                            Application.StartupPath +
                            @"\Images\pdf.png";

                        using (Image image =
                            Image.FromFile(pdfIconPath))
                        {
                            picPlanDocument.Image =
                                new Bitmap(image);
                        }

                        picPlanDocument.SizeMode =
                            PictureBoxSizeMode.Zoom;
                    }


                    MessageBox.Show(
                        "Diet Plan Document Selected Successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
        // Submit Form
        private void tlpSubmit_Click(object sender, EventArgs e)
        {
            // =========================================
            // Clear Placeholder Text
            // =========================================

            ValidationUI.ClearDefaultPlaceholderText(
                txtRequiredCalories,
                ClickCountTxtRequiredCalories);

            ValidationUI.ClearDefaultPlaceholderText(
                txtPlanCondition,
                ClickCountTxtPlanCondition);


            // =========================================
            // UI REQUIRED VALIDATION
            // =========================================

            ValidationUI.ValidationResult result;
            bool isValid = true;

            errorProvider1.Clear();


            // =========================================
            // Required Calories
            // =========================================

            result =
                ValidationUI.ValidateRequiredTextBox(
                    txtRequiredCalories);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    txtRequiredCalories,
                    "Required Calories " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }


            // =========================================
            // Plan Condition
            // =========================================

            result =
                ValidationUI.ValidateRequiredTextBox(
                    txtPlanCondition);

            if (result != ValidationUI.ValidationResult.Valid)
            {
                errorProvider1.SetError(
                    txtPlanCondition,
                    "Plan Condition " +
                    ValidationUI.GetValidationMessage(result));

                isValid = false;
            }


            // =========================================
            // Diet Plan Document
            // =========================================

            if (dietPlanDocument == null ||
                dietPlanDocument.Length == 0)
            {
                errorProvider1.SetError(
                    tlpChooseFile,
                    "Diet Plan Document is required.");

                isValid = false;
            }


            // =========================================
            // If Required Validation Failed
            // =========================================

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


            // =========================================
            // Convert Required Calories
            // =========================================

            int requiredCalories;

            if (!int.TryParse(
                txtRequiredCalories.Text.Trim(),
                out requiredCalories))
            {
                errorProvider1.SetError(
                    txtRequiredCalories,
                    "Required Calories must contain only numbers.");

                MessageBox.Show(
                    "Required Calories must contain only numbers.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.ActiveControl = null;
                return;
            }


            // =========================================
            // Create DietPlan UI
            // =========================================

            DietPlanUI dietPlanUI =
                new DietPlanUI();

            dietPlanUI.CaloriesPerDay =
                requiredCalories;

            dietPlanUI.ConditionStatus =
                txtPlanCondition.Text.Trim();

            dietPlanUI.DietPlanDocument =
                dietPlanDocument;


            // =========================================
            // Insert
            // =========================================

            ValidationResult finalResult =
                dietPlanUI.InsertDietPlanUI();


            // =========================================
            // Handle Result
            // =========================================

            HandleDietPlanResult(finalResult);
        }

        private void HandleDietPlanResult(ValidationResult result)
        {
            errorProvider1.Clear();

            if (result.Result ==
                ValidationBll.CommonValidationMessage.Valid)
            {
                MessageBox.Show(
                    result.Message,
                    "Diet Plan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();

                return;
            }

            switch (result.FieldName)
            {
                case "RequiredCalories":
                    errorProvider1.SetError(
                        txtRequiredCalories,
                        result.Message);
                    break;

                case "PlanCondition":
                    errorProvider1.SetError(
                        txtPlanCondition,
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
        // Clear Form
        private void tlpClear_Click(object sender, EventArgs e)
        {
            ClearDietPlanForm();
        }
        // Clear Form Method
        private void ClearDietPlanForm()
        {
            // TextBox
            txtRequiredCalories.Clear();
            txtPlanCondition.Clear();


            // Background Color
            txtRequiredCalories.BackColor =
                Color.White;

            txtPlanCondition.BackColor =
                Color.White;


            // ForeColor
            txtRequiredCalories.ForeColor =
                Color.Black;

            txtPlanCondition.ForeColor =
                Color.Black;


            // Click Count Reset
            ClickCountTxtRequiredCalories = 0;
            ClickCountTxtPlanCondition = 0;


            // Document Reset
            dietPlanDocument = null;


            // PictureBox Clear
            if (picPlanDocument.Image != null)
            {
                picPlanDocument.Image.Dispose();
                picPlanDocument.Image = null;
            }
        }

        private void tlpSubmit_MouseEnter(object sender, EventArgs e)
        {
            tlpSubmit.BackColor = Color.White;
            lblSubmit.ForeColor = Color.MidnightBlue;
            picSubmit.Image = Properties.Resources.paper_planeHOVER;
        }

        private void tlpSubmit_MouseLeave(object sender, EventArgs e)
        {
            tlpSubmit.BackColor = Color.MidnightBlue;
            lblSubmit.ForeColor = Color.White;
            picSubmit.Image = Properties.Resources.paper_plane;
        }

        private void lblClear_MouseEnter(object sender, EventArgs e)
        {
            lblClear.ForeColor = Color.MidnightBlue;
            lblClear.BackColor = Color.White;
        }

        private void lblClear_MouseLeave(object sender, EventArgs e)
        {
            lblClear.ForeColor = Color.White;
            lblClear.BackColor = Color.MidnightBlue;
        }

        private void txtRequiredCalories_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRequiredCalories.Text))
            {
                txtRequiredCalories.Text = "Enter Required Calories";
                txtRequiredCalories.ForeColor = Color.Gray;
            }
        }

        private void txtPlanCondition_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlanCondition.Text))
            {
                txtPlanCondition.Text = "Enter Plan Condition";
                txtPlanCondition.ForeColor = Color.Gray;
            }
        }
    }
}