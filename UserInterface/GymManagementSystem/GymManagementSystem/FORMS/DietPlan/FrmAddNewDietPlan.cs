using System;
using System.Drawing;
using System.Windows.Forms;
using GymManagementSystem.Common;
using GymManagementSystem.FORMS.DietPlan.UI;

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
        }
        // Form Load
        private void FrmAddNewDietPlan_Load(object sender, EventArgs e)
        {
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
            ClickCountTxtRequiredCalories = ValidationUI.ClearTextBoxWhenClicked(txtRequiredCalories, ClickCountTxtRequiredCalories);
            txtRequiredCalories.ForeColor = Color.Black;
        }
        // Plan Condition Click
        private void txtPlanCondition_Click(object sender, EventArgs e)
        {
            ClickCountTxtPlanCondition = ValidationUI.ClearTextBoxWhenClicked(txtPlanCondition, ClickCountTxtPlanCondition);
            txtPlanCondition.ForeColor = Color.Black;
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
            // ==============================
            // Clear Placeholder Text
            // ==============================

            if (ClickCountTxtRequiredCalories == 0)
                txtRequiredCalories.Clear();

            if (ClickCountTxtPlanCondition == 0)
                txtPlanCondition.Clear();


            // ==============================
            // Common UI Validation
            // ==============================

            if (!ValidationUI.ValidateRequiredTextBoxes(
                txtRequiredCalories,
                txtPlanCondition))
            {
                return;
            }


            // ==============================
            // Convert + DietPlanUI
            // ==============================

            try
            {
                int requiredCalories =
                    Convert.ToInt32(
                        txtRequiredCalories.Text.Trim());

                string planCondition =
                    txtPlanCondition.Text.Trim();


                DietPlanUI dietPlanUI =
                    new DietPlanUI();


                string result =
                    dietPlanUI.InsertDietPlanUI(
                        requiredCalories,
                        dietPlanDocument,
                        planCondition);


                MessageBox.Show(
                    result,
                    "Diet Plan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                // ==============================
                // Successful Insert
                // ==============================

                if (!string.IsNullOrWhiteSpace(result))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
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
    }
}