using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace GymManagementSystem.FORMS.DietPlan
{
    public partial class FrmShowDietPlans : Form
    {
        private Color originalColor;
        private Color hoverColor = Color.SkyBlue;
        private Color MouseLeave;
        private Color clickColor = Color.FromArgb(184, 195, 179);

        public FrmShowDietPlans()
        {
            InitializeComponent();

          
            originalColor = pnlAddNewDietPlan.BackColor;
            
        }

        private void FrmShowDietPlans_Load(object sender, EventArgs e)
        {
            dgvDietPlan.RowHeadersVisible = false;
            dgvDietPlan.AllowUserToAddRows = false;
            string CS=ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnetion = null;
            try
            {
                sqlConnetion = new SqlConnection(CS);
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spDisplayAllDietPlans", sqlConnetion))
                {
                    sqlDataAdapter.SelectCommand.CommandType =
                        CommandType.StoredProcedure;
                    sqlConnetion.Open();
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dgvDietPlan.AutoGenerateColumns = false;
                    
                    dgvDietPlan.Columns["CaloriesPerDay"].DataPropertyName = "CaloriesPerDay";
                    dgvDietPlan.Columns["Document"].DataPropertyName = "DietPlanDocument";
                    dgvDietPlan.Columns["Condition"].DataPropertyName = "ConditionStatus";
                    dgvDietPlan.DataSource = dataTable;

                    for (int i = 0; i < dgvDietPlan.Rows.Count; i++)
                    {
                        dgvDietPlan.Rows[i].Cells["SL_No"].Value = i + 1;
                    }
                    
                    
                }
            }
            catch (Exception ex)
            {
                dgvDietPlan.DataSource = null;
            }
            finally
            {
                sqlConnetion.Close();
            }
           

        }
        
        private void RetrieveDietData()
        {
            

        }

        private void lblAddNewDietPlan_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAddNewDietPlan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAddNewDietPlan_MouseEnter(object sender, EventArgs e)
        {
            pnlAddNewDietPlan.BackColor = hoverColor;

        }

        private void pnlAddNewDietPlan_MouseHover(object sender, EventArgs e)
        {

        }


        private void pnlAddNewDietPlan_MouseLeave(object sender, EventArgs e)
        {
                pnlAddNewDietPlan.BackColor = MouseLeave;
        }

        private void lblAddNewDietPlan_MouseEnter(object sender, EventArgs e)
        {


        }

        private void lblAddNewDietPlan_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblAddNewDietPlan_MouseLeave(object sender, EventArgs e)
        {


        }

        private void lblAddNewDietPlan_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pnlAddNewDietPlan_Click(object sender, EventArgs e)
        {

            pnlAddNewDietPlan.BackColor = clickColor;
            FrmAddNewDietPlan FrmAddNewDietPlan = new FrmAddNewDietPlan();
            FrmAddNewDietPlan.ShowDialog();
        }


        private void pnlAddNewDietPlan_Enter(object sender, EventArgs e)
        {

            pnlAddNewDietPlan.BackColor = hoverColor;
        }



        private void pnlAddNewDietPlan_Leave(object sender, EventArgs e)
        {


            pnlAddNewDietPlan.BackColor = originalColor;
        }

       
        

        }
        
}
