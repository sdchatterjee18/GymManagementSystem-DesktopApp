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

namespace GymManagementSystem.FORMS.Locker
{
    public partial class FrmAddLocker : Form
    {
        public string LockerNumber { get; private set; } 

        public FrmAddLocker()
        {
            InitializeComponent();
        }


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

            // ==============================
            // Clear Placeholder Text
            // ==============================

            //if (checklockerno == 0)
            //    this.txtLockerNumber.clear();

            // ==============================
            // Common UI Validation
            // ==============================

            if (!ValidationUI.ValidateRequiredTextBoxes(
                this.txtLockerNumber))
            {
                return;
            }


            // ==============================
            // Convert + DietPlanUI
            // ==============================

            try
            {
                string LockerNumber =
                        txtLockerNumber.Text.Trim();

                LockerUI lockerUI =
                    new LockerUI();

                string result =
                    lockerUI.InserNewLockerUI(
                            LockerNumber
                        );


                MessageBox.Show(
                    result,
                    "Locker",
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

    }
}
