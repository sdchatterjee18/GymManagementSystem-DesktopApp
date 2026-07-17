using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using GymManagementSystem.FORMS;

namespace GymManagementSystem.FORMS.Locker
{
    public partial class FrmDisplayLocker : Form
    {
        public FrmDisplayLocker()
        {
            InitializeComponent();
        }

        private void FrmDisplayLocker_Load(object sender, EventArgs e)
        {
            
        }

        private void pnlButton_Click(object sender, EventArgs e)
        {
            LoadLockers();
            FrmAddLocker frmAddLocker = new FrmAddLocker();
            frmAddLocker.ShowDialog();
        }

        private void pnlButton_MouseEnter(object sender, EventArgs e)
        {
            this.pnlButton.BackColor = Color.FromArgb(200,200,200);
        }

        private void pnlButton_MouseLeave(object sender, EventArgs e)
        {
            this.pnlButton.BackColor = Color.FromArgb(184, 195, 179);
        }

        private void LoadLockers()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = new SqlConnection(connectionString);

                using (SqlCommand sqlCommand = new SqlCommand("spGetLockers", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dtLockers = new DataTable();
                        adapter.Fill(dtLockers);

                        this.dgvDisplayLocker.DataSource = dtLockers;
                        int i = 1;
                        foreach (DataGridViewRow row in dgvDisplayLocker.Rows)
                        {
                            row.Cells["SLNo"].Value = i++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

    } 
}
