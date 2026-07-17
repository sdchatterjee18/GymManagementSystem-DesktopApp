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

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            this.btnSubmit.BackColor = Color.FromArgb(250, 250, 250);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            LockerNumber = txtLockerNumber.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
