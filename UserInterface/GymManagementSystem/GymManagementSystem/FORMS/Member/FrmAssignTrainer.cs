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
    public partial class FrmAssignTrainer : Form
    {
        public FrmAssignTrainer()
        {
            InitializeComponent();
        }

        private void FrmAssignTrainer_Load(object sender, EventArgs e)
        {
            pnlDefaultTrainerSection.Visible = true;
            pnlTrainerInformationSection.Visible = false;

            cmbSelectTrainerName.SelectedIndex = -1; 
            
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbSelectTrainerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectTrainerName.SelectedIndex == -1)
            {
                pnlDefaultTrainerSection.Visible = true;
                pnlTrainerInformationSection.Visible = false;
            }
            else
            {
                pnlDefaultTrainerSection.Visible = false;
                pnlTrainerInformationSection.Visible = true;
                pnlTrainerInformationSection.BringToFront();
            }



        }

        private void tlpRegisterButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpAssignButton.BackColor = Color.DarkGreen;
        }

        private void tlpRegisterButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpAssignButton.BackColor = Color.ForestGreen;
        }

        private void tlpCancleButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpCancleButton.BackColor = Color.OrangeRed;
        }

        private void tlpCancleButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpCancleButton.BackColor = Color.Red;
        }
    }
}
