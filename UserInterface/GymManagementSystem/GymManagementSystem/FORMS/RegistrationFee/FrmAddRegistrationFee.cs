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

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.Image = Properties.Resources.CloseHover;
            
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.Image = Properties.Resources.Close;
        }

   

       

        //private void btnExitFrmAddRegistrationFee_MouseClick(object sender, MouseEventArgs e)
        //{
        //    btnExitFrmAddRegistrationFee.BackColor = Color.Red;
        //    btnExitFrmAddRegistrationFee.ForeColor = Color.White;
        //}

        //private void btnExitFrmAddRegistrationFee_MouseLeave(object sender, EventArgs e)
        //{
        //    btnExitFrmAddRegistrationFee.BackColor = Color.White;
        //    btnExitFrmAddRegistrationFee.ForeColor = Color.Black;
        //}

        //private void btnExitFrmAddRegistrationFee_MouseHover(object sender, EventArgs e)
        //{
        //    btnExitFrmAddRegistrationFee.BackColor = Color.Red;
        //    btnExitFrmAddRegistrationFee.ForeColor = Color.White;
        //}

        //private void btnExitFrmAddRegistrationFee_Click(object sender, EventArgs e)
        //{
        //    this.Dispose();
        //}

     

        


       

       

       

      


       

       

      


       


   



     
    }
}
