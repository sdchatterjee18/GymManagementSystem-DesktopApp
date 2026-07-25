using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem.FORMS.DietPlan
{
    public partial class FrmAddNewDietPlan : Form
    {
        public FrmAddNewDietPlan()
        {
            InitializeComponent();
            
            
        }

    

        private void txtRequiredCalories_Click(object sender, EventArgs e)
        {
            int ClickCount = 1;
            if (ClickCount == 1)
            {
               // txtRequiredCalories.Clear();
            }
        }

        private void tlpCaloriesSection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBrowsePlan_Click(object sender, EventArgs e)
        {
            int Click= 1;
            if (Click == 1)
            {
                txtBrowsePlan.Clear();
            }

        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblCancel_MouseEnter(object sender, EventArgs e)
        {
            lblCancel.BackColor = Color.DarkRed;
            lblCancel.ForeColor = Color.White;

        }

        private void lblCancel_MouseLeave(object sender, EventArgs e)
        {
            lblCancel.BackColor = Color.Transparent;
            lblCancel.ForeColor = Color.Black;
        }

        private void lblNewDietPlanHeader_Click(object sender, EventArgs e)
        {

        }

        private void lblSubTitle_Click(object sender, EventArgs e)
        {

        }

        
    }
}
