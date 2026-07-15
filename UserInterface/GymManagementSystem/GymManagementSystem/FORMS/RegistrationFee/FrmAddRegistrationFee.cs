using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GymManagementSystem.FORMS.RegistrationFee
{
    public partial class FrmAddRegistrationFee : Form
    {
        public FrmAddRegistrationFee()
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

      

private void SetRoundedDataGridView(DataGridView dgv, int radius)
{
    GraphicsPath path = new GraphicsPath();

    int d = radius * 2;

    path.AddArc(0, 0, d, d, 180, 90);
    path.AddArc(dgv.Width - d - 1, 0, d, d, 270, 90);
    path.AddArc(dgv.Width - d - 1, dgv.Height - d - 1, d, d, 0, 90);
    path.AddArc(0, dgv.Height - d - 1, d, d, 90, 90);
    path.CloseFigure();

    dgv.Region = new Region(path);
}


      



        private void FrmAddRegistrationFee_Load(object sender, EventArgs e)
        {

            SetRoundedTableLayoutPanel(tlpAddNewRegistrationFees, 20);

          
       
        }

      






   



     
    }
}
