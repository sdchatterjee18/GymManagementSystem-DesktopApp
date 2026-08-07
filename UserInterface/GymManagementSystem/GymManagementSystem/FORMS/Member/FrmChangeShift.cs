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
    public partial class FrmChangeShift : Form
    {
        public FrmChangeShift()
        {
            InitializeComponent();
        }

        private void tlpChangeShiftButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpChangeShiftButton.BackColor = Color.DarkGreen;
        }

        private void tlpChangeShiftButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpChangeShiftButton.BackColor = Color.ForestGreen;
        }

        private void tlpCancleSectionInChangeMemberShift_MouseEnter(object sender, EventArgs e)
        {
            this.tlpCancleSectionInChangeMemberShift.BackColor = Color.OrangeRed;
            
        }

        private void tlpCancleSectionInChangeMemberShift_MouseLeave(object sender, EventArgs e)
        {
            this.tlpCancleSectionInChangeMemberShift.BackColor = Color.Red;
        }

        private void FrmChangeShift_Load(object sender, EventArgs e)
        {

        }

       

       
    }
}
