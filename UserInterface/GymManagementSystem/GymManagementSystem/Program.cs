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
using GymManagementSystem.FORMS.Attendance;
using GymManagementSystem.FormsSuperAdmin.Employee;
using GymManagementSystem.FORMS.Expenses;
using GymManagementSystem.FORMS.Settings;
using GymManagementSystem.FormsSuperAdmin.Salary;


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
            //Application.Run(new FrmSAMainForm());
            //Application.Run(new FrmMainLayout());
            Application.Run(new FrmAssignTrainer());
        }
    }
}