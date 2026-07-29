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

namespace GymManagementSystem.FORMS.Shift
{
    public partial class FrmDisplayShift : Form
    {
        private int currentRow;
        private int currentColumn;
        private DateTimePicker dtpTime = new DateTimePicker();


        public FrmDisplayShift()
        {
            InitializeComponent();
        }

        private void FrmDisplayShift_Load(object sender, EventArgs e)
        {

        }
       
    }
}
