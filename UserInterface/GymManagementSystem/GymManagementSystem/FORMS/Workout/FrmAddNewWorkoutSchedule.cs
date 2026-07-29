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
    public partial class FrmAddNewWorkoutSchedule : Form
    {
        public FrmAddNewWorkoutSchedule()
        {
            InitializeComponent();
        }

        private void FrmAddNewWorkoutSchedule_Load(object sender, EventArgs e)
        {
            this.Text = "";
            this.ShowIcon = false;
        }
    }
}
