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
    public partial class FrmDisplayWorkoutSchedule : Form
    {
        public FrmDisplayWorkoutSchedule()
        {
            InitializeComponent();
        }

        private void FrmDisplayWorkoutSchedule_Load(object sender, EventArgs e)
        {
            LoadWorkoutShedule();
            dgvWorkoutShedule.ClearSelection();
        }



        private void LoadWorkoutShedule()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("spDisplayAllWorkoutScheduleRecords", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            dgvWorkoutShedule.Rows.Clear();

                            int serialNo = 1;

                            while (dr.Read())
                            {
                                dgvWorkoutShedule.Rows.Add(
                                    serialNo,
                                    dr["WorkoutName"].ToString(),
                                    dr["ExerciseName"].ToString(),
                                    dr["WorkoutDay"].ToString()
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

        private void pnlClickToAddNewWorkoutShedule_Click(object sender, EventArgs e)
        {
            FrmAddNewWorkoutSchedule frmWS = new FrmAddNewWorkoutSchedule();
            frmWS.Show();
        }

        private void dgvWorkoutShedule_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvWorkoutShedule.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvWorkoutShedule.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvWorkoutShedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvWorkoutShedule_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvWorkoutShedule.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);
                dgvWorkoutShedule.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvWorkoutShedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;


            }
        }

        private void dgvWorkoutShedule_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvWorkoutShedule.Columns[e.ColumnIndex].Name == "colSerialNo1")
            {

                e.CellStyle.ForeColor = Color.Navy;
            }
        }

        private void tlpWorkoutSheduleHeader_Click(object sender, EventArgs e)
        {
            dgvWorkoutShedule.ClearSelection();
        }


    }
}
