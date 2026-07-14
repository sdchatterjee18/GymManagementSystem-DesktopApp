using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GymManagementSystem.FORMS.Main
{
    public partial class FrmMainLayout : Form
    {
        bool isMembersExpanded = false;
        private bool isMemberAttendanceExpanded = false;
        private bool isExerciseAndWorkoutExpanded = false;
        public FrmMainLayout()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void SetRightRoundedPanel(Panel panel, int radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddLine(0, 0, panel.Width - radius, 0);
            graphicsPath.AddArc(panel.Width - radius * 2,0,radius * 2,radius * 2,270,90);
            graphicsPath.AddArc(panel.Width - radius * 2,panel.Height - radius * 2,radius * 2,radius * 2,0,90);
            graphicsPath.AddLine(0, panel.Height, 0, 0);
            graphicsPath.CloseFigure();
            panel.Region = new Region(graphicsPath);
        }

        private void FrmMainLayout_Load(object sender, EventArgs e)
        {
            timer.Start();
            Color borderColor = Color.FromArgb(15, 15, 15);
            Panel topBorder = new Panel();
            topBorder.Dock = DockStyle.Bottom;
            topBorder.Height = 1;
            topBorder.BackColor = borderColor;
            pnlTopbar.Controls.Add(topBorder);
            Panel mainLeftBorder = new Panel();
            mainLeftBorder.Dock = DockStyle.Left;
            mainLeftBorder.Width = 1;
            mainLeftBorder.BackColor = borderColor;
            pnlMainPanel.Controls.Add(mainLeftBorder);
            SetRightRoundedPanel(pnlDashboard, 15);
            SetRightRoundedPanel(pnlMembers, 15);
            SetRightRoundedPanel(pnlFitnessTest, 15);
            SetRightRoundedPanel(pnlMemberTrainerAssignment, 15);
            SetRightRoundedPanel(pnlViewAllMembers, 15);
            SetRightRoundedPanel(pnlMemberAttendance, 15);
            SetRightRoundedPanel(pnlViewMemberAttendance, 15);
            SetRightRoundedPanel(pnlMarkMemberAttendance, 15);
            SetRightRoundedPanel(pnlExerciseAndWorkout, 15);
            SetRightRoundedPanel(pnlWorkoutPlans, 15);
            SetRightRoundedPanel(pnlWorkoutShedule, 15);
            SetRightRoundedPanel(pnlRegistrationFees, 15);
            SetRightRoundedPanel(pnlTrainer, 15);
            SetRightRoundedPanel(pnlMembershipPlan, 15);
            SetRightRoundedPanel(pnlLocker, 15);
            SetRightRoundedPanel(pnlShift, 15);
            SetRightRoundedPanel(pnlDietPlan, 15);
            SetRightRoundedPanel(pnlPayment, 15);
            SetRightRoundedPanel(pnlExpense, 15);
            SetRightRoundedPanel(pnlSettins, 15);
            SetRightRoundedPanel(pnlLogout, 15);

        }

        private void pnlMembers_MouseEnter(object sender, EventArgs e)
        {
            pnlMembers.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlMembers_MouseLeave(object sender, EventArgs e)
        {
            pnlMembers.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlMembers_Click(object sender, EventArgs e)
        {
            if (!isMembersExpanded)
            {
                pnlDropDownMembers.Visible = true;
                picMembersArrowe.Image = Properties.Resources.arrowhead_up;
                isMembersExpanded = true;
            }
            else
            {
                pnlDropDownMembers.Visible = false;
                picMembersArrowe.Image = Properties.Resources.down_arrow;
                isMembersExpanded = false;
            }
        }

        private void pnlMemberAttendance_MouseEnter(object sender, EventArgs e)
        {
            pnlMemberAttendance.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlMemberAttendance_MouseLeave(object sender, EventArgs e)
        {
            pnlMemberAttendance.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlMemberAttendance_Click(object sender, EventArgs e)
        {
            if (!isMemberAttendanceExpanded)
            {
                pnlDropDownMemberAttendance.Visible = true;
                picMemberAttendanceArrowe.Image = Properties.Resources.arrowhead_up;

                isMemberAttendanceExpanded = true;
            }
            else
            {
                pnlDropDownMemberAttendance.Visible = false;
                picMemberAttendanceArrowe.Image = Properties.Resources.down_arrow;

                isMemberAttendanceExpanded = false;
            }
        }

        private void pnlExerciseAndWorkout_MouseEnter(object sender, EventArgs e)
        {
            pnlExerciseAndWorkout.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlExerciseAndWorkout_MouseLeave(object sender, EventArgs e)
        {
            pnlExerciseAndWorkout.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlExerciseAndWorkout_Click(object sender, EventArgs e)
        {
            if (!isExerciseAndWorkoutExpanded)
            {
                pnlDropDownExerciseAndWorkout.Visible = true;
                picExerciseAndWorkoutArrowe.Image = Properties.Resources.arrowhead_up;
                isExerciseAndWorkoutExpanded = true;
            }
            else
            {
                pnlDropDownExerciseAndWorkout.Visible = false;
                picExerciseAndWorkoutArrowe.Image = Properties.Resources.down_arrow;
                isExerciseAndWorkoutExpanded = false;
            }
        }

        private void pnlDashboard_MouseEnter(object sender, EventArgs e)
        {
            pnlDashboard.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlDashboard_MouseLeave(object sender, EventArgs e)
        {
            pnlDashboard.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlDashboard_Click(object sender, EventArgs e)
        {

        }

        private void pnlViewAllMembers_MouseEnter(object sender, EventArgs e)
        {
            pnlViewAllMembers.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlViewAllMembers_MouseLeave(object sender, EventArgs e)
        {
            pnlViewAllMembers.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlViewAllMembers_Click(object sender, EventArgs e)
        {

        }

        private void pnlMemberTrainerAssignment_MouseEnter(object sender, EventArgs e)
        {
            pnlMemberTrainerAssignment.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlMemberTrainerAssignment_MouseLeave(object sender, EventArgs e)
        {
            pnlMemberTrainerAssignment.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlMemberTrainerAssignment_Click(object sender, EventArgs e)
        {

        }

        private void pnlTrainer_MouseEnter(object sender, EventArgs e)
        {
            pnlTrainer.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlTrainer_MouseLeave(object sender, EventArgs e)
        {
            pnlTrainer.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlTrainer_Click(object sender, EventArgs e)
        {

        }

        private void pnlFitnessTest_MouseEnter(object sender, EventArgs e)
        {
            pnlFitnessTest.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlFitnessTest_MouseLeave(object sender, EventArgs e)
        {
            pnlFitnessTest.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlFitnessTest_Click(object sender, EventArgs e)
        {

        }

       

        private void pnlMarkMemberAttendance_MouseEnter(object sender, EventArgs e)
        {
            pnlMarkMemberAttendance.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlMarkMemberAttendance_MouseLeave(object sender, EventArgs e)
        {
            pnlMarkMemberAttendance.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlMarkMemberAttendance_Click(object sender, EventArgs e)
        {

        }

        private void pnlViewMemberAttendance_MouseEnter(object sender, EventArgs e)
        {
            pnlViewMemberAttendance.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlViewMemberAttendance_MouseLeave(object sender, EventArgs e)
        {
            pnlViewMemberAttendance.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlViewMemberAttendance_Click(object sender, EventArgs e)
        {

        }

        private void pnlMembershipPlan_MouseEnter(object sender, EventArgs e)
        {
            pnlMembershipPlan.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlMembershipPlan_MouseLeave(object sender, EventArgs e)
        {
            pnlMembershipPlan.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlMembershipPlan_Click(object sender, EventArgs e)
        {

        }

        private void pnlShift_MouseEnter(object sender, EventArgs e)
        {
            pnlShift.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlShift_MouseLeave(object sender, EventArgs e)
        {
            pnlShift.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlShift_Click(object sender, EventArgs e)
        {

        }

        private void pnlLocker_MouseEnter(object sender, EventArgs e)
        {
            pnlLocker.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlLocker_MouseLeave(object sender, EventArgs e)
        {
            pnlLocker.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlLocker_Click(object sender, EventArgs e)
        {

        }

        private void pnlWorkoutPlans_MouseEnter(object sender, EventArgs e)
        {
            pnlWorkoutPlans.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlWorkoutPlans_MouseLeave(object sender, EventArgs e)
        {
            pnlWorkoutPlans.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlWorkoutPlans_Click(object sender, EventArgs e)
        {

        }

        private void pnlWorkoutShedule_MouseEnter(object sender, EventArgs e)
        {
            pnlWorkoutShedule.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlWorkoutShedule_MouseLeave(object sender, EventArgs e)
        {
            pnlWorkoutShedule.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlWorkoutShedule_Click(object sender, EventArgs e)
        {

        }

        private void pnlRegistrationFees_MouseEnter(object sender, EventArgs e)
        {
            pnlRegistrationFees.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlRegistrationFees_MouseLeave(object sender, EventArgs e)
        {
            pnlRegistrationFees.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlRegistrationFees_Click(object sender, EventArgs e)
        {

        }

        private void pnlDietPlan_MouseEnter(object sender, EventArgs e)
        {
            pnlDietPlan.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlDietPlan_MouseLeave(object sender, EventArgs e)
        {
            pnlDietPlan.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlDietPlan_Click(object sender, EventArgs e)
        {

        }

        private void pnlPayment_MouseEnter(object sender, EventArgs e)
        {
            pnlPayment.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlPayment_MouseLeave(object sender, EventArgs e)
        {
            pnlPayment.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlPayment_Click(object sender, EventArgs e)
        {

        }

        private void pnlExpense_MouseEnter(object sender, EventArgs e)
        {
            pnlExpense.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlExpense_MouseLeave(object sender, EventArgs e)
        {
            pnlExpense.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlExpense_Click(object sender, EventArgs e)
        {

        }

        private void pnlSettins_MouseEnter(object sender, EventArgs e)
        {
            pnlSettins.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlSettins_MouseLeave(object sender, EventArgs e)
        {
            pnlSettins.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlSettins_Click(object sender, EventArgs e)
        {

        }

        private void pnlLogout_MouseEnter(object sender, EventArgs e)
        {
            pnlLogout.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlLogout_MouseLeave(object sender, EventArgs e)
        {
            pnlLogout.BackColor = Color.FromArgb(247, 247, 247);
        }

        private void pnlLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
