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
namespace GymManagementSystem.FORMS.Attendance
{
    public partial class FrmViewAttendance : Form
    {
        public FrmViewAttendance()
        {
            InitializeComponent();
            getMemberAttendenceDetails();
            this.dgvMemberAttendance.ClearSelection();
        }

        private void getMemberAttendenceDetails()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            try
            {
                string queryStr = "spGetTodaysAllAttendence";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(queryStr, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlConnection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            dgvMemberAttendance.Rows.Clear();

                            int i = 1;
                            while (reader.Read())
                            {
                                dgvMemberAttendance.Rows.Add(
                                    i++,
                                    reader["MemberId"].ToString(),
                                    reader["MemberName"].ToString(),
                                    reader["PhoneNo"].ToString(),
                                    reader["ShiftName"].ToString(),
                                    reader["Attendance"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void dgvMemberAttendance_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                this.dgvMemberAttendance.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                this.dgvMemberAttendance.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.DimGray;
                this.dgvMemberAttendance.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.White;
            }
        }

        private void dgvMemberAttendance_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                this.dgvMemberAttendance.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.WhiteSmoke;
            }
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                this.dgvMemberAttendance.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.LightGray;
                this.dgvMemberAttendance.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Black;
            }
        }

        private void dvgMemeberAttendance_Click(object sender, EventArgs e)
        {
            Point clientPoint = this.dgvMemberAttendance.PointToClient(Cursor.Position);
            var hitTest = this.dgvMemberAttendance.HitTest(clientPoint.X, clientPoint.Y);

            if (hitTest.Type == DataGridViewHitTestType.None)
            {
                this.dgvMemberAttendance.ClearSelection();
            }
        }

        private void txtMobileNo_Enter(object sender, EventArgs e)
        {
            if (txtMobileNo.Text == "  Mobile No." && txtMobileNo.ForeColor == Color.Gray)
            {
                txtMobileNo.Text = "";
                txtMobileNo.ForeColor = Color.Black;
            }
        }

        private void txtMobileNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMobileNo.Text))
            {
                txtMobileNo.Text = "  Mobile No.";
                txtMobileNo.ForeColor = Color.Gray;
            }
        }
    }
}