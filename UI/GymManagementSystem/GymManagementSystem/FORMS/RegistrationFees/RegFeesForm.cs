using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem.FORMS.RegistrationFees
{
    public partial class RegFeesForm : Form
    {
        public RegFeesForm()
        {
            InitializeComponent();
        }


        private void pnlAddNewRegistrationFees_Click(object sender, EventArgs e)
        {
            pnlAddNewRegistrationFees.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void pnlAddNewRegistrationFees_MouseLeave(object sender, EventArgs e)
        {
            pnlAddNewRegistrationFees.BackColor = Color.FromArgb(90, 100, 110);
        }

        private void pnlAddNewRegistrationFees_MouseEnter(object sender, EventArgs e)
        {
            pnlAddNewRegistrationFees.BackColor = Color.FromArgb(60, 60, 60);
        }
    }
}
