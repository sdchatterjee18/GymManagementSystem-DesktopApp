using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using GymManagementSystem.FORMS.Workout.UI;


namespace GymManagementSystem.FORMS.Workout
{
    public partial class FrmDisplayWorkoutPlans : Form
    {
        private DataTable exerciseDataTable;
        public FrmDisplayWorkoutPlans()
        {
            InitializeComponent();
        }

        private void FrmDisplayWorkoutPlans_Load(object sender, EventArgs e)
        {
            //Exercises Load
            LoadExercise();
            LoadExerciseComboBox();
            //LoadWorkoutPlans();

            dgvExerciseTable.ClearSelection();
            dgvWorkoutPlans.ClearSelection();
        }
        // Exercise Methode Show dgv
        private void LoadExercise()
        {
            try
            {
                WorkoutUI workoutUI = new WorkoutUI();

                exerciseDataTable =
                    workoutUI.RetrieveExercisesUI();

                dgvExerciseTable.AutoGenerateColumns = false;
                dgvExerciseTable.Rows.Clear();

                int serialNo = 1;

                foreach (DataRow dataRow in exerciseDataTable.Rows)
                {
                    int rowIndex = dgvExerciseTable.Rows.Add();

                    dgvExerciseTable.Rows[rowIndex]
                        .Cells["colSerialNo1"].Value = serialNo++;

                    dgvExerciseTable.Rows[rowIndex]
                        .Cells["colExerciseName"].Value =
                        dataRow["ExerciseName"].ToString();

                    dgvExerciseTable.Rows[rowIndex]
                        .Cells["colMuscleType"].Value =
                        dataRow["MuscleType"].ToString();

                    dgvExerciseTable.Rows[rowIndex]
                        .Cells["colExercisesId"].Value =
                        Convert.ToInt32(dataRow["ExerciseId"]);
                }

                dgvExerciseTable.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        // Exercise Methode Show cmb
        private void LoadExerciseComboBox()
        {
            try
            {
                WorkoutUI workoutUI = new WorkoutUI();
                DataTable dataTable =workoutUI.GetExercisesForComboBox();
                cmbExerciseName.DataSource = dataTable;
                cmbExerciseName.DisplayMember = "ExerciseName";
                cmbExerciseName.ValueMember = "ExerciseId";
                cmbExerciseName.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        //Exercise select cmb box
        private void cmbExerciseName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbExerciseName.SelectedIndex == -1)
                return;
            try
            {
                int exerciseId = Convert.ToInt32(cmbExerciseName.SelectedValue);

                LoadSpecificExercise(exerciseId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Load specific exercise
        private void LoadSpecificExercise(int exerciseId)
        {
            try
            {
                int serialNo = 0;

                // Original exercise list থেকে serial বের করা
                foreach (DataRow dataRow in exerciseDataTable.Rows)
                {
                    if (Convert.ToInt32(dataRow["ExerciseId"]) == exerciseId)
                    {
                        int index = exerciseDataTable.Rows.IndexOf(dataRow);

                        serialNo = index + 1;

                        break;
                    }
                }

                WorkoutUI workoutUI = new WorkoutUI();

                DataTable dataTable =
                    workoutUI.RetrieveSpecificExerciseUI(exerciseId);

                dgvExerciseTable.AutoGenerateColumns = false;
                dgvExerciseTable.Rows.Clear();

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    int rowIndex =
                        dgvExerciseTable.Rows.Add();

                    dgvExerciseTable.Rows[rowIndex]
                        .Cells["colSerialNo1"].Value =
                        serialNo;

                    dgvExerciseTable.Rows[rowIndex]
                        .Cells["colExerciseName"].Value =
                        dataRow["ExerciseName"].ToString();

                    dgvExerciseTable.Rows[rowIndex]
                        .Cells["colMuscleType"].Value =
                        dataRow["MuscleType"].ToString();

                    dgvExerciseTable.Rows[rowIndex]
                        .Cells["colExercisesId"].Value =
                        Convert.ToInt32(dataRow["ExerciseId"]);
                }

                dgvExerciseTable.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        // Display all exercise
        private void btnExerciseDisplayAll_Click(object sender, EventArgs e)
        {
            cmbExerciseName.SelectedIndex = -1;
            LoadExercise();
            dgvExerciseTable.ClearSelection();
        }
        // Load Add form (Exercise)
        private void pnlClickToAddNewExercise_Click(object sender, EventArgs e)
        {
            using (FrmAddNewExercise frmAddNewExercise = new FrmAddNewExercise())
            {
                DialogResult result = frmAddNewExercise.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadExercise();
                    LoadExerciseComboBox();
                    dgvExerciseTable.ClearSelection();
                    dgvWorkoutPlans.ClearSelection();
                }
            }
        }

        private void LoadWorkoutPlans()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("spDisplayAllRecordsOfWorkoutPlanTable", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            dgvWorkoutPlans.Rows.Clear();

                            int serialNo = 1;

                            while (dr.Read())
                            {
                                dgvWorkoutPlans.Rows.Add(
                                    serialNo,
                                    dr["WorkoutName"].ToString(),
                                    dr["Description"].ToString()
                                );

                                serialNo++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvExerciseTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvExerciseTable.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvExerciseTable.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvExerciseTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvExerciseTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
              if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvExerciseTable.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvExerciseTable.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvExerciseTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;

                
            }
        }

        private void dgvWorkoutPlans_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvWorkoutPlans.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvWorkoutPlans.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvWorkoutPlans.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;


            }
        }

        private void dgvWorkoutPlans_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvWorkoutPlans.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvWorkoutPlans.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvWorkoutPlans.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvExerciseTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvExerciseTable.Columns[e.ColumnIndex].Name == "colSerialNo1")
            {

                e.CellStyle.ForeColor = Color.Navy;
            }    
        }

        private void dgvWorkoutPlans_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvWorkoutPlans.Columns[e.ColumnIndex].Name == "colSerialNo2")
            {

                e.CellStyle.ForeColor = Color.Navy;
            }   
        }

        private void tlpExerciseHeader_Click(object sender, EventArgs e)
        {
            dgvExerciseTable.ClearSelection();
            dgvWorkoutPlans.ClearSelection();
        }

     

        private void pnlClickToAddNewWorkoutPlan_Click(object sender, EventArgs e)
        {
            FrmAddNewWorkoutPlan frmW = new FrmAddNewWorkoutPlan();
            frmW.Show();
        }

        private void tlpAddNewExercise_MouseEnter(object sender, EventArgs e)
        {
            tlpAddNewExercise.BackColor = Color.FromArgb(220, 225, 230);
        }

        private void tlpAddNewExercise_MouseLeave(object sender, EventArgs e)
        {
            tlpAddNewExercise.BackColor = Color.FromArgb(236, 240, 243);
        }

        private void tlpAddNewWorkoutPlan_MouseEnter(object sender, EventArgs e)
        {
            tlpAddNewWorkoutPlan.BackColor = Color.FromArgb(220, 225, 230);
        }

        private void tlpAddNewWorkoutPlan_MouseLeave(object sender, EventArgs e)
        {
            tlpAddNewWorkoutPlan.BackColor = Color.FromArgb(236, 240, 243);
        }

      

       
       
        

    }
}
