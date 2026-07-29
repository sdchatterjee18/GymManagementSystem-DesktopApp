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
    public partial class FrmAddNewExercise : Form
    {
        public FrmAddNewExercise()
        {
            InitializeComponent();
        }

        private void FrmAddNewExercise_Load(object sender, EventArgs e)
        {
            this.Text = "";
            this.ShowIcon = false;
        }
    }
}
