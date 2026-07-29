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

        private void tlpButton_Click(object sender, EventArgs e)
        {
            // It will Add new Locker
        }

        private void FrmAddLocker_Load(object sender, EventArgs e)
        {

        }

    }
}
