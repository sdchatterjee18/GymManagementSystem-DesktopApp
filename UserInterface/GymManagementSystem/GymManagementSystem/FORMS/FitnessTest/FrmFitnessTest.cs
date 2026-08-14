using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.FORMS.Gender;
using GymManagementSystem.FORMS.FitnessTest.UI;


namespace GymManagementSystem.FORMS
{
    public partial class FrmFitnessTest : Form
    {
        public FrmFitnessTest()
        {
            InitializeComponent();
        }

        private void FrmFitnessTest_Load(object sender, EventArgs e)
        {
            LoadGender();
            LoadGoalList();
            LoadActivityLevels();

            this.ActiveControl = null;
        }
        private void LoadGender()
        {
            DataTable dataTable = GenderUI.GetGenderDetailsForComboBox();

            if (dataTable == null)
            {
                MessageBox.Show(
                    "Gender data could not be loaded.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            cmbGenderInput.DataSource = dataTable;
            cmbGenderInput.DisplayMember = "GenderName";
            cmbGenderInput.ValueMember = "GenderId";

            cmbGenderInput.SelectedIndex = -1;
        }
        private void LoadActivityLevels()
        {
            List<string> activityLevels =
                FitnessTestUI.GetActivityLevels();

            cmbActivityInput.Items.Clear();

            foreach (string activity in activityLevels)
            {
                cmbActivityInput.Items.Add(activity);
            }

            cmbActivityInput.SelectedIndex = -1;
        }
        private void LoadGoalList()
        {
            List<string> goalList = FitnessTestUI.GetGoalList();

            cmbGoalInput.Items.Clear();

            foreach (string goal in goalList)
            {
                cmbGoalInput.Items.Add(goal);
            }

            cmbGoalInput.SelectedIndex = -1;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtHightInput_Enter(object sender, EventArgs e)
        {
            if (txtHightInput.Text.Trim() == "Enter Hight")
            {
                txtHightInput.Text = "";
                txtHightInput.ForeColor = Color.Gray;
            }
        }

        private void txtHightInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHightInput.Text))
            {
                txtHightInput.Text = "Enter Hight";
                txtHightInput.ForeColor = Color.Gray;
            }
        }

        private void txtWeightInput_Enter(object sender, EventArgs e)
        {
            if (txtWeightInput.Text.Trim() == "Enter Weight")
            {
                txtWeightInput.Text = "";
                txtWeightInput.ForeColor = Color.Gray;
            }
        }

        private void txtWeightInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWeightInput.Text))
            {
                txtWeightInput.Text = "Enter Weight";
                txtWeightInput.ForeColor = Color.Gray;
            }
        }

        private void cmbGenderInput_Enter(object sender, EventArgs e)
        {
            if (cmbGenderInput.Text.Trim() == "---select---")
            {
                cmbGenderInput.Text = "";
                cmbGenderInput.ForeColor = Color.Gray;
            }
        }

        private void cmbGenderInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbGenderInput.Text))
            {
                cmbGenderInput.Text = "---select---";
                cmbGenderInput.ForeColor = Color.Gray;
            }
        }

        private void txtAgeInput_Enter(object sender, EventArgs e)
        {
            if (txtAgeInput.Text.Trim() == "Enter Age")
            {
                txtAgeInput.Text = "";
                txtAgeInput.ForeColor = Color.Gray;
            }
        }

        private void txtAgeInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAgeInput.Text))
            {
                txtAgeInput.Text = "Enter Age";
                txtAgeInput.ForeColor = Color.Gray;
            }
        }

        private void cmbActivityInput_Enter(object sender, EventArgs e)
        {
            if (cmbActivityInput.Text.Trim() == "---select---")
            {
                cmbActivityInput.Text = "";
                cmbActivityInput.ForeColor = Color.Gray;
            }
        }

        private void cmbActivityInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbActivityInput.Text))
            {
                cmbActivityInput.Text = "---select---";
                cmbActivityInput.ForeColor = Color.Gray;
            }
        }

        private void cmbGoalInput_Enter(object sender, EventArgs e)
        {
            if (cmbGoalInput.Text.Trim() == "---select---")
            {
                cmbGoalInput.Text = "";
                cmbGoalInput.ForeColor = Color.Gray;
            }
        }

        private void cmbGoalInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbGoalInput.Text))
            {
                cmbGoalInput.Text = "---select---";
                cmbGoalInput.ForeColor = Color.Gray;
            }
        }

        private void FrmFitnessTest_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        

    }
}
