using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GymManagementSystem.FORMS.Workout;
using GymManagementSystem.FORMS.Payments;
using GymManagementSystem.FORMS.RegistrationFee;
using GymManagementSystem.FORMS.Main;
using GymManagementSystem.FORMS.Member;
using GymManagementSystem.FormsSuperAdmin.Employee;
using GymManagementSystem.FormsSuperAdmin.MainLayout;
using GymManagementSystem.FormsSuperAdmin.Dashboard;
using GymManagementSystem.FORMS.DietPlan;
using GymManagementSystem.FORMS.Expenses;
using GymManagementSystem.FORMS.Member;
using GymManagementSystem.FORMS.Settings;

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
            //Application.Run(new FrmSADisplayAllEmployee());
            Application.Run(new FrmDisplayAllMembers());

        }
    }
}