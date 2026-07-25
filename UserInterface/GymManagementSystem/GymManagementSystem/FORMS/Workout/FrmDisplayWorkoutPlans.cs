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
                            dgvMembershipPlan.Rows.Clear();

                            int serialNo = 1;

                            while (dr.Read())
                            {
                                dgvMembershipPlan.Rows.Add(
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



    }
}
