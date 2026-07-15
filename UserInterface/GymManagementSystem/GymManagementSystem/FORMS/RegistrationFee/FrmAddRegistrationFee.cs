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

       
        //private void SetRightRoundedPanel(Panel panel, int radius)
        //{
        //    GraphicsPath graphicsPath = new GraphicsPath();
        //    graphicsPath.StartFigure();
        //    graphicsPath.AddLine(0, 0, panel.Width - radius, 0);
        //    graphicsPath.AddArc(panel.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
        //    graphicsPath.AddArc(panel.Width - radius * 2, panel.Height - radius * 2, radius * 2, radius * 2, 0, 90);
        //    graphicsPath.AddLine(0, panel.Height, 0, 0);
        //    graphicsPath.CloseFigure();
        //    panel.Region = new Region(graphicsPath);
        //}
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

        private void FrmAddRegistrationFee_Load(object sender, EventArgs e)
        {

            SetRoundedTableLayoutPanel(tlpAddNewRegistrationFees, 20);
        }

     
    }
}
