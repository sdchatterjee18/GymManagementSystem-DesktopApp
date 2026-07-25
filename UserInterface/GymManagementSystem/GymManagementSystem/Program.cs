using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GymManagementSystem.FORMS.RegistrationFee;
using GymManagementSystem.FORMS.Main;
using GymManagementSystem.FORMS.Member;
namespace GymManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMainLayout());           
        }
    }
}