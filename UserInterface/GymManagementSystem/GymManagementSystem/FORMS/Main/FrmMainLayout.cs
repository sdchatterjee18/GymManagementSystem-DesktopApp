using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using GymManagementSystem.FORMS.Shift;
using GymManagementSystem.FORMS.RegistrationFee;
using GymManagementSystem.FORMS.Locker;
using GymManagementSystem.FORMS.DietPlan;
using GymManagementSystem.FORMS.MembershipPlan;
using GymManagementSystem.FORMS.Dashboard;

namespace GymManagementSystem.FORMS.Main
{
    public partial class FrmMainLayout : Form
    {
        bool isMembersExpanded = false;
        private bool isMemberAttendanceExpanded = false;
        private bool isExerciseAndWorkoutExpanded = false;
        private bool sidebarExpand = true;
        private const int ExpandedWidth = 250;
        private const int CollapsedWidth = 70;
        public FrmMainLayout()
        {
            InitializeComponent();

            pnlSidebar.Width = ExpandedWidth;

            timerSidebar.Interval = 10;
        }

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            // Close the currently opened form
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlMainPanel.Controls.Clear();
            pnlMainPanel.Controls.Add(childForm);
            pnlMainPanel.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");

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
            pnlSidebar.Width = ExpandedWidth;
            OpenChildForm(new FrmDashboard());
        }

        private void pnlMembers_MouseEnter(object sender, EventArgs e)
        {
            pnlMembers.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlMembers_MouseLeave(object sender, EventArgs e)
        {
            pnlMembers.BackColor = Color.Transparent;
        }

        private void pnlMembers_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
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
            pnlMemberAttendance.BackColor = Color.Transparent;
        }

        private void pnlMemberAttendance_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
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
            pnlExerciseAndWorkout.BackColor = Color.Transparent;
        }

        private void pnlExerciseAndWorkout_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
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
            pnlDashboard.BackColor = Color.Transparent;
        }

        private void pnlDashboard_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
        }

        private void pnlViewAllMembers_MouseEnter(object sender, EventArgs e)
        {
            pnlViewAllMembers.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlViewAllMembers_MouseLeave(object sender, EventArgs e)
        {
            pnlViewAllMembers.BackColor = Color.Transparent;
        }

        private void pnlViewAllMembers_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
        }

        private void pnlMemberTrainerAssignment_MouseEnter(object sender, EventArgs e)
        {
            pnlMemberTrainerAssignment.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlMemberTrainerAssignment_MouseLeave(object sender, EventArgs e)
        {
            pnlMemberTrainerAssignment.BackColor = Color.Transparent;
        }

        private void pnlMemberTrainerAssignment_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
        }

        private void pnlTrainer_MouseEnter(object sender, EventArgs e)
        {
            pnlTrainer.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlTrainer_MouseLeave(object sender, EventArgs e)
        {
            pnlTrainer.BackColor = Color.Transparent;
        }

        private void pnlTrainer_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
        }

        private void pnlFitnessTest_MouseEnter(object sender, EventArgs e)
        {
            pnlFitnessTest.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlFitnessTest_MouseLeave(object sender, EventArgs e)
        {
            pnlFitnessTest.BackColor = Color.Transparent;
        }

        private void pnlFitnessTest_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
        }

       

        private void pnlMarkMemberAttendance_MouseEnter(object sender, EventArgs e)
        {
            pnlMarkMemberAttendance.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlMarkMemberAttendance_MouseLeave(object sender, EventArgs e)
        {
            pnlMarkMemberAttendance.BackColor = Color.Transparent;
        }

        private void pnlMarkMemberAttendance_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
        }

        private void pnlViewMemberAttendance_MouseEnter(object sender, EventArgs e)
        {
            pnlViewMemberAttendance.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlViewMemberAttendance_MouseLeave(object sender, EventArgs e)
        {
            pnlViewMemberAttendance.BackColor = Color.Transparent;
        }

        private void pnlViewMemberAttendance_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
        }

        private void pnlMembershipPlan_MouseEnter(object sender, EventArgs e)
        {
            pnlMembershipPlan.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlMembershipPlan_MouseLeave(object sender, EventArgs e)
        {
            pnlMembershipPlan.BackColor = Color.Transparent;
        }

        private void pnlMembershipPlan_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
            OpenChildForm(new FrmDisplayMembershipPlan());
        }

        private void pnlShift_MouseEnter(object sender, EventArgs e)
        {
            pnlShift.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlShift_MouseLeave(object sender, EventArgs e)
        {
            pnlShift.BackColor = Color.Transparent;
        }

        private void pnlShift_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
            OpenChildForm(new FrmDisplayShift());

        }

        private void pnlLocker_MouseEnter(object sender, EventArgs e)
        {
            pnlLocker.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlLocker_MouseLeave(object sender, EventArgs e)
        {
            pnlLocker.BackColor = Color.Transparent;
        }

        private void pnlLocker_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
            OpenChildForm(new FrmDisplayLocker());
        }

        private void pnlExerCise_MouseEnter(object sender, EventArgs e)
        {
            pnlExerCise.BackColor = Color.FromArgb(190, 216, 230);
        }


        private void pnlExerCise_MouseLeave(object sender, EventArgs e)
        {
            pnlExerCise.BackColor = Color.Transparent;
        }
        private void pnlExerCise_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
        }


        private void pnlWorkoutPlans_MouseEnter(object sender, EventArgs e)
        {
            pnlWorkoutPlans.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlWorkoutPlans_MouseLeave(object sender, EventArgs e)
        {
            pnlWorkoutPlans.BackColor = Color.Transparent;
        }

        private void pnlWorkoutPlans_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
        }

        private void pnlWorkoutShedule_MouseEnter(object sender, EventArgs e)
        {
            pnlWorkoutShedule.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlWorkoutShedule_MouseLeave(object sender, EventArgs e)
        {
            pnlWorkoutShedule.BackColor = Color.Transparent;
        }

        private void pnlWorkoutShedule_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
        }

        private void pnlRegistrationFees_MouseEnter(object sender, EventArgs e)
        {
            pnlRegistrationFees.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlRegistrationFees_MouseLeave(object sender, EventArgs e)
        {
            pnlRegistrationFees.BackColor = Color.Transparent;
        }

        private void pnlRegistrationFees_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
            OpenChildForm(new FrmRegistrationFees());
        }

        private void pnlDietPlan_MouseEnter(object sender, EventArgs e)
        {
            pnlDietPlan.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlDietPlan_MouseLeave(object sender, EventArgs e)
        {
            pnlDietPlan.BackColor = Color.Transparent;
        }

        private void pnlDietPlan_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
            OpenChildForm(new FrmShowDietPlans());
        }

        private void pnlPayment_MouseEnter(object sender, EventArgs e)
        {
            pnlPayment.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlPayment_MouseLeave(object sender, EventArgs e)
        {
            pnlPayment.BackColor = Color.Transparent;
        }

        private void pnlPayment_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
        }

        private void pnlExpense_MouseEnter(object sender, EventArgs e)
        {
            pnlExpense.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlExpense_MouseLeave(object sender, EventArgs e)
        {
            pnlExpense.BackColor = Color.Transparent;
        }

        private void pnlExpense_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
        }

        private void pnlSettins_MouseEnter(object sender, EventArgs e)
        {
            pnlSettins.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlSettins_MouseLeave(object sender, EventArgs e)
        {
            pnlSettins.BackColor = Color.Transparent;
        }

        private void pnlSettins_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
        }

        private void pnlLogout_MouseEnter(object sender, EventArgs e)
        {
            pnlLogout.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlLogout_MouseLeave(object sender, EventArgs e)
        {
            pnlLogout.BackColor = Color.Transparent;
        }

        private void pnlLogout_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
        }

        private void pnlMenu_MouseEnter(object sender, EventArgs e)
        {
            pnlMenu.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlMenu_MouseLeave(object sender, EventArgs e)
        {
            pnlMenu.BackColor = Color.Transparent;
        }

        private void pnlMenu_Click(object sender, EventArgs e)
        {
            if (pnlDropDownMembers.Visible || pnlDropDownMemberAttendance.Visible ||pnlDropDownExerciseAndWorkout.Visible)
            {
                return;   
            }
            CollapseIfExpanded();
            ExpandIfCollapsed();
        }
      
        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnlSidebar.Width -= 12;

                if (pnlSidebar.Width <= CollapsedWidth)
                {
                    pnlSidebar.Width = CollapsedWidth;

                    timerSidebar.Stop();

                    sidebarExpand = false;

                    CollapseSidebar();
                }
            }
            else
            {
                pnlSidebar.Width += 12;

                if (pnlSidebar.Width >= ExpandedWidth)
                {
                    pnlSidebar.Width = ExpandedWidth;

                    timerSidebar.Stop();

                    sidebarExpand = true;

                    ExpandSidebar();
                }
            }
        }
        private void CollapseSidebar()
        {
            foreach (Control c in fnlSidebar.Controls)
            {
                c.Width = fnlSidebar.ClientSize.Width;

                foreach (Control child in c.Controls)
                {
                    if (child is Label)
                        child.Visible = false;

                    if (child is PictureBox && !child.Name.ToLower().Contains("arrow"))
                        child.Left = (CollapsedWidth - child.Width) / 2;
                }
            }

            pnlLogout.Width = CollapsedWidth;
            lblLogout.Visible = false;
            picLogout.Left = (CollapsedWidth - picLogout.Width) / 2;
        }
        private void ExpandSidebar()
        {
            foreach (Control c in fnlSidebar.Controls)
            {
                c.Width = fnlSidebar.ClientSize.Width;

                foreach (Control child in c.Controls)
                {
                    if (child is Label)
                        child.Visible = true;

                    if (child is PictureBox && !child.Name.ToLower().Contains("arrow"))
                        child.Left = 15;
                }
            }

            pnlLogout.Width = ExpandedWidth;
            lblLogout.Visible = true;
            picLogout.Left = 15;
        }
        private void CollapseIfExpanded()
        {
            if (sidebarExpand && !timerSidebar.Enabled)
            {
                timerSidebar.Start();
            }
        }

        private void ExpandIfCollapsed()
        {
            if (!sidebarExpand && !timerSidebar.Enabled)
            {
                timerSidebar.Start();
            }
        }

       
       
       
       }
}
