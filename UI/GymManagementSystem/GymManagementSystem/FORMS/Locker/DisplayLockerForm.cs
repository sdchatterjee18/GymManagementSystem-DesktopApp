using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem.FORMS.Locker
{
    public partial class DisplayLockerForm : Form
    {
        public DisplayLockerForm()
        {
            InitializeComponent();
        }

        private void pnlButton_MouseEnter(object sender, EventArgs e)
        {
            this.pnlButton.BackColor = Color.FromArgb(20,20,20);
        }

        private void pnlButton_MouseLeave(object sender, EventArgs e)
        {
            this.pnlButton.BackColor = Color.FromArgb(27, 34, 44);
        }

        private void pnlButton_MouseClick(object sender, MouseEventArgs e)
        {
             // Open..
        }
    }
}
