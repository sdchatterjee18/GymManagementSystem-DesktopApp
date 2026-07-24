using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

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

        //private void pnlClose_MouseEnter(object sender, EventArgs e)
        //{
        //    pnlClose.BackgroundImage = Properties.Resources;
        //}

        //private void pnlClose_MouseLeave(object sender, EventArgs e)
        //{
        //    pnlClose.BackgroundImage = Properties.Resources;
        //}

        private void tlpButton_MouseEnter(object sender, EventArgs e)
        {

        }

        private void tlpButton_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
