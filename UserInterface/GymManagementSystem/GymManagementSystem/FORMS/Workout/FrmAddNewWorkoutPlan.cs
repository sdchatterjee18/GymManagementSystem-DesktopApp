using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem.FORMS.Workout
{
    public partial class FrmAddNewWorkoutPlan : Form
    {
        public FrmAddNewWorkoutPlan()
        {
            InitializeComponent();
        }

        private void FrmAddNewWorkoutPlan_Load(object sender, EventArgs e)
        {
            this.Text = "";
            this.ShowIcon = false;
        }

        private void txtWorkoutPlanName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmAddNewWorkoutPlan_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void txtWorkoutPlanName_Click(object sender, EventArgs e)
        {
            txtWorkoutPlanName.Clear();
            txtWorkoutPlanName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            txtWorkoutPlanName.ForeColor = Color.Black;
        }

        private void txtDescription_Click(object sender, EventArgs e)
        {
            txtDescription.Clear();
            txtDescription.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            txtDescription.ForeColor = Color.Black;
        }
    }
}
