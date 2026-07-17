using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Configuration;
using System.Data.SqlClient;


namespace GymManagementSystem.FORMS.RegistrationFee
{
    public partial class FrmRegistrationFees : Form
    {
        public FrmRegistrationFees()
        {
            InitializeComponent();
        }



        private void SetRoundedTableLayoutPanel(TableLayoutPanel tlp, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(tlp.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(tlp.Width - radius, tlp.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, tlp.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            tlp.Region = new Region(path);
        }



        private void FrmRegistrationFees_Load(object sender, EventArgs e)
        {
            SetRoundedTableLayoutPanel(tlpAddNewRegistrationFees, 20);

            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            //DataSet dataSet = null;
            DataTable dataTable = new DataTable();
            try
            {
                sqlConnection = new SqlConnection(CS);
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("select *from tblRegistrationFees", sqlConnection))
                {
                    int a=1;
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        dgvShowAllAddRegistrationFees.Rows.Add(a,Convert.ToInt32(sqlDataReader["RegistrationFeesId"]),
                            Convert.ToDecimal(sqlDataReader["FeeAmount"]),
                            Convert.ToByte(sqlDataReader["IsActive"]),
                            Convert.ToDateTime(sqlDataReader["CreatedAt"]));
                        a++;
                    }


                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }








           
        }


        public void GetRegistrationFees()
        {
            
        }





       


       

       

       






      



        

       





    }
}
