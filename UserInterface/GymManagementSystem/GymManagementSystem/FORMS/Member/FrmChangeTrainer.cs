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
    public partial class FrmChangeTrainer : Form
    {
        public FrmChangeTrainer()
        {
            InitializeComponent();
        }

        private void FrmChangeTrainer_Load(object sender, EventArgs e)
        {

        }

        private void tlpRegisterButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpRegisterButton.BackColor = Color.DarkGreen;
        }

        private void tlpRegisterButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpRegisterButton.BackColor = Color.ForestGreen;
        }

        private void tlpCancleSection_MouseEnter(object sender, EventArgs e)
        {
            this.tlpCancleSection.BackColor = Color.OrangeRed;
        }

        private void tlpCancleSection_MouseLeave(object sender, EventArgs e)
        {
            this.tlpCancleSection.BackColor = Color.Red;
        }

        
    }
}
