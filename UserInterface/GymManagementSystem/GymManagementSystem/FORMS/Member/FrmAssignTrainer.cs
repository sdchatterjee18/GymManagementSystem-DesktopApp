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
            pnlDefaultTrainerSectionShow.Visible = true;
            pnlTrainerInformationSectionRetrieve.Visible = false;

            cmbSelectTrainer.SelectedIndex = -1;
        }

        private void cmbSelectTrainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectTrainer.SelectedIndex != -1)
            {
                pnlDefaultTrainerSectionShow.Visible = false;
                pnlTrainerInformationSectionRetrieve.Visible = true;

                pnlTrainerInformationSectionRetrieve.BringToFront();
            }
            else
            {
                pnlDefaultTrainerSectionShow.Visible = true;
                pnlTrainerInformationSectionRetrieve.Visible = false;

                pnlDefaultTrainerSectionShow.BringToFront();
            }
        }

        private void tlpAssignButtonCreateInAssignPersonalTrainer_MouseEnter(object sender, EventArgs e)
        {
            this.tlpAssignButtonCreateInAssignPersonalTrainer.BackColor = Color.DarkGreen;
        }

        private void tlpAssignButtonCreateInAssignPersonalTrainer_MouseLeave(object sender, EventArgs e)
        {
            this.tlpAssignButtonCreateInAssignPersonalTrainer.BackColor = Color.ForestGreen;
        }

        private void tlpCancleImageAndLevel_MouseEnter(object sender, EventArgs e)
        {
            this.tlpCancleImageAndLevel.BackColor = Color.OrangeRed;
        }

        private void tlpCancleImageAndLevel_MouseLeave(object sender, EventArgs e)
        {
            this.tlpCancleImageAndLevel.BackColor = Color.Red;
        }

       
    }
}