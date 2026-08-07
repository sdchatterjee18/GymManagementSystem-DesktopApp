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
using GymManagementSystem.FORMS.Shift;
using GymManagementSystem.FormsSuperAdmin.Financials;
using GymManagementSystem.FormsSuperAdmin.Salary;
using GymManagementSystem.Authentication;
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
            //Application.Run(new FrmDisplayShift());
            //Application.Run(new FrmSADisplayAllEmployee());
            //Application.Run(new FrmDisplayAllMembers());
            //Application.Run(new FrmSAMainForm());
            //Application.Run(new FrmMainLayout());
            Application.Run(new FrmAssignTrainer());
            //Application.Run(new FrmSAAddNewEmployee());
            //Application.Run(new FrmSAProfitLoss());
            //Application.Run(new FrmMainLayout());
            //Application.Run(new FrmMemberRegistration());

        }
    }
}