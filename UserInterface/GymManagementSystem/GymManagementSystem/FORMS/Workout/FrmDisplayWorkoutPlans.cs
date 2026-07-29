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


namespace GymManagementSystem.FORMS.Workout
{
    public partial class FrmDisplayWorkoutPlans : Form
    {
        public FrmDisplayWorkoutPlans()
        {
            InitializeComponent();
        }

        private void FrmDisplayWorkoutPlans_Load(object sender, EventArgs e)
        {
            LoadExercise();
            LoadWorkoutPlans();

            dgvExerciseTable.ClearSelection();
            dgvWorkoutPlans.ClearSelection();
        }






        private void LoadExercise()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("spDisplayAllRecordsOfExercisesTable", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            dgvExerciseTable.Rows.Clear();

                            int serialNo = 1;

                            while (dr.Read())
                            {
                                dgvExerciseTable.Rows.Add(
                                    serialNo,
                                    dr["ExerciseName"].ToString(),
                                    dr["MuscleType"].ToString()
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

        private void pnlClickToAddNewExercise_Click(object sender, EventArgs e)
        {
            FrmAddNewExercise frmE = new FrmAddNewExercise();
            frmE.Show();
            
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

        private void txtExerciseNameSearch_Click(object sender, EventArgs e)
        {
            txtExerciseNameSearch.Clear();
            txtExerciseNameSearch.ForeColor = Color.Black;
        }

        private void txtWorkoutNameSearch_Click(object sender, EventArgs e)
        {
            
            txtWorkoutNameSearch.Clear();
            txtWorkoutNameSearch.ForeColor = Color.Black;
        } 

    }
}
