using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace GymManagementSystem.FORMS.RegistrationFee
{
    public partial class FrmAddRegistrationFee : Form
    {
        public FrmAddRegistrationFee()
        {
            InitializeComponent();
           
        }

   

        private void tlpTopFrmAddRegistrationFee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExitFrmAddRegistrationFee_MouseClick(object sender, MouseEventArgs e)
        {
            btnExitFrmAddRegistrationFee.BackColor = Color.Red;
            btnExitFrmAddRegistrationFee.ForeColor = Color.White;
        }

        private void btnExitFrmAddRegistrationFee_MouseLeave(object sender, EventArgs e)
        {
            btnExitFrmAddRegistrationFee.BackColor = SystemColors.Control;
            btnExitFrmAddRegistrationFee.ForeColor = Color.DimGray;
        }

        private void btnExitFrmAddRegistrationFee_MouseHover(object sender, EventArgs e)
        {
            btnExitFrmAddRegistrationFee.BackColor = Color.Red;
            btnExitFrmAddRegistrationFee.ForeColor = Color.White;
        }

      


       


   



     
    }
}
