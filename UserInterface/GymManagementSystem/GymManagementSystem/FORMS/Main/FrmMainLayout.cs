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
using GymManagementSystem.FORMS.Payments;
using GymManagementSystem.FORMS.Trainer;
using GymManagementSystem.FORMS.Workout;
using GymManagementSystem.FORMS.Member;
using GymManagementSystem.FORMS.Expenses;
using GymManagementSystem.FORMS.Settings;
using GymManagementSystem.FORMS.Attendance;
using GymManagementSystem.Authentication;

namespace GymManagementSystem.FORMS.Main
{
    public partial class FrmMainLayout : Form
    {
        bool isSettingsExpanded = false;
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
        private Panel selectedPanel = null;
        private void SelectPanel(Panel panel)
        {
            // Reset the previously selected panel
            if (selectedPanel != null)
            {
                selectedPanel.BackColor = Color.Transparent; // Default color

            }

            // Highlight the new panel
            selectedPanel = panel;
            selectedPanel.BackColor = Color.FromArgb(68, 97, 174); // Selected color
        }

        public void OpenChildForm(Form childForm)
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
       
        
        private void FrmMainLayout_Load(object sender, EventArgs e)
        {
          
            //Color borderColor = Color.FromArgb(15, 15, 15);
            Panel topBorder = new Panel();
            topBorder.Dock = DockStyle.Bottom;
            topBorder.Height = 1;
            //topBorder.BackColor = borderColor;
            pnlTopbar.Controls.Add(topBorder);
            Panel mainLeftBorder = new Panel();
            mainLeftBorder.Dock = DockStyle.Left;
            mainLeftBorder.Width = 1;
            //mainLeftBorder.BackColor = borderColor;
            pnlMainPanel.Controls.Add(mainLeftBorder);
            pnlSidebar.Width = ExpandedWidth;
            OpenChildForm(new FrmDashboard());
        }

        private void pnlMembers_MouseEnter(object sender, EventArgs e)
        {
            if (pnlMembers != selectedPanel && selectedPanel != pnlViewAllMembers && selectedPanel != pnlMemberTrainerAssignment)
            {
                pnlMembers.BackColor = Color.FromArgb(190, 216, 230);
                pnlMembers.ForeColor = Color.Black;
                picMembers.Image = Properties.Resources.usersHOVER;
                picMembersArrowe.Image = Properties.Resources.downArrowB;
            }
        }

        private void pnlMembers_MouseLeave(object sender, EventArgs e)
        {
            if (pnlMembers != selectedPanel && selectedPanel != pnlViewAllMembers && selectedPanel != pnlMemberTrainerAssignment)
            {
                pnlMembers.BackColor = Color.Transparent;
                pnlMembers.ForeColor = Color.White;
                picMembers.Image = Properties.Resources.users;
                picMembersArrowe.Image = Properties.Resources.downArrowW;
            }
            
        }

        private void pnlMembers_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlMembers);
            pnlMembers.ForeColor = Color.White;
            picMembers.Image = Properties.Resources.users;
            ExpandIfCollapsed();
            if (!isMembersExpanded)
            {
                pnlDropDownMembers.Visible = true;
                picMembersArrowe.Image = Properties.Resources.topArrowW;
                isMembersExpanded = true;
            }
            else
            {
                pnlDropDownMembers.Visible = false;
                picMembersArrowe.Image = Properties.Resources.downArrowW;
                isMembersExpanded = false;
            }

        }

        private void pnlMemberAttendance_MouseEnter(object sender, EventArgs e)
        {
            if(selectedPanel!=pnlMemberAttendance && selectedPanel!=pnlMarkMemberAttendance && selectedPanel!=pnlViewMemberAttendance)
            {
                pnlMemberAttendance.BackColor = Color.FromArgb(190, 216, 230);
                pnlMemberAttendance.ForeColor = Color.Black;
                picMemberAttendance.Image = Properties.Resources.attendanceHOVER__1_;
                picMemberAttendanceArrowe.Image = Properties.Resources.downArrowB;
            } 
        }

        private void pnlMemberAttendance_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlMemberAttendance && selectedPanel != pnlMarkMemberAttendance && selectedPanel != pnlViewMemberAttendance)
            {
                pnlMemberAttendance.BackColor = Color.Transparent;
                pnlMemberAttendance.ForeColor = Color.White;
                picMemberAttendance.Image = Properties.Resources.attendance;
                picMemberAttendanceArrowe.Image = Properties.Resources.downArrowW;
            }  
        }

        private void pnlMemberAttendance_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlMemberAttendance);
            pnlMemberAttendance.ForeColor = Color.White;
            picMemberAttendance.Image = Properties.Resources.attendance;
            ExpandIfCollapsed();
            
            if (!isMemberAttendanceExpanded)
            {
                pnlDropDownMemberAttendance.Visible = true;
                picMemberAttendanceArrowe.Image = Properties.Resources.topArrowW;

                isMemberAttendanceExpanded = true;
            }
            else
            {
                pnlDropDownMemberAttendance.Visible = false;
                picMemberAttendanceArrowe.Image = Properties.Resources.downArrowW;

                isMemberAttendanceExpanded = false;
            }
        }

        private void pnlExerciseAndWorkout_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlExerciseAndWorkout && selectedPanel!=pnlWorkoutPlans && selectedPanel!= pnlWorkoutShedule)
            {
                pnlExerciseAndWorkout.BackColor = Color.FromArgb(190, 216, 230);
                pnlExerciseAndWorkout.ForeColor = Color.Black;
                picExerciseAndWorkout.Image = Properties.Resources.workoutHOVER__1_;
                picExerciseAndWorkoutArrowe.Image = Properties.Resources.downArrowB;
            }
            
        }

        private void pnlExerciseAndWorkout_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlExerciseAndWorkout && selectedPanel != pnlWorkoutPlans && selectedPanel != pnlWorkoutShedule)
            {
                pnlExerciseAndWorkout.BackColor = Color.Transparent;
                pnlExerciseAndWorkout.ForeColor = Color.White;
                picExerciseAndWorkout.Image = Properties.Resources.workout;
                picExerciseAndWorkoutArrowe.Image = Properties.Resources.downArrowW;
            }
            
        }

        private void pnlExerciseAndWorkout_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlExerciseAndWorkout);
            pnlExerciseAndWorkout.ForeColor = Color.White;
            picExerciseAndWorkout.Image = Properties.Resources.workout;
            ExpandIfCollapsed();
            if (!isExerciseAndWorkoutExpanded)
            {
                pnlDropDownExerciseAndWorkout.Visible = true;
                picExerciseAndWorkoutArrowe.Image = Properties.Resources.topArrowW;
                isExerciseAndWorkoutExpanded = true;
            }
            else
            {
                pnlDropDownExerciseAndWorkout.Visible = false;
                picExerciseAndWorkoutArrowe.Image = Properties.Resources.downArrowW;
                isExerciseAndWorkoutExpanded = false;
            }
        }

        private void pnlDashboard_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlDashboard)
            {
             pnlDashboard.BackColor = Color.FromArgb(190, 216, 230);
             pnlDashboard.ForeColor = Color.Black;
             picDashboard.Image = Properties.Resources.dashboardHOVER;
            }
        }

        private void pnlDashboard_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlDashboard)
            {
                pnlDashboard.BackColor = Color.Transparent;
                pnlDashboard.ForeColor = Color.White;
                picDashboard.Image = Properties.Resources.dashboard;
            }
        }

        private void pnlDashboard_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlDashboard);
            pnlDashboard.ForeColor = Color.White;
            picDashboard.Image=Properties.Resources.dashboard;
            ExpandIfCollapsed();
            OpenChildForm(new FrmDashboard());
        }

        private void pnlViewAllMembers_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlViewAllMembers)
            {
                pnlViewAllMembers.BackColor = Color.FromArgb(190, 216, 230);
                pnlViewAllMembers.ForeColor = Color.Black;
                picViewAllMembers.Image = Properties.Resources.record_button;
            } 
        }

        private void pnlViewAllMembers_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlViewAllMembers)
            {
                pnlViewAllMembers.BackColor = Color.Transparent;
                pnlViewAllMembers.ForeColor = Color.White;
                picViewAllMembers.Image = Properties.Resources.recor_buttonW;
            } 
            
        }

        private void pnlViewAllMembers_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
            OpenChildForm(new FrmDisplayAllMembers(this));
            SelectPanel(pnlViewAllMembers);
            pnlViewAllMembers.ForeColor = Color.White;
            picViewAllMembers.Image = Properties.Resources.recor_buttonW;
        }

        private void pnlMemberTrainerAssignment_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlMemberTrainerAssignment)
            {
                pnlMemberTrainerAssignment.BackColor = Color.FromArgb(190, 216, 230);
                pnlMemberTrainerAssignment.ForeColor = Color.Black;
                picMemberTrainerAssignment.Image = Properties.Resources.record_button;
            }
            
        }

        private void pnlMemberTrainerAssignment_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlMemberTrainerAssignment)
            {
                pnlMemberTrainerAssignment.BackColor = Color.Transparent;
                pnlMemberTrainerAssignment.ForeColor = Color.White;
                picMemberTrainerAssignment.Image = Properties.Resources.recor_buttonW;
            }
            
        }

        private void pnlMemberTrainerAssignment_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
            OpenChildForm(new FrmMemberTrainerAssignment());
            SelectPanel(pnlMemberTrainerAssignment);
            pnlMemberTrainerAssignment.ForeColor = Color.White;
            picMemberTrainerAssignment.Image = Properties.Resources.recor_buttonW;
            
        }

        private void pnlTrainer_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlTrainer)
            {
                pnlTrainer.BackColor = Color.FromArgb(190, 216, 230);
                pnlTrainer.ForeColor = Color.Black;
                picTrainer.Image = Properties.Resources.trainerHOVER;
            }           
        }

        private void pnlTrainer_MouseLeave(object sender, EventArgs e)
        {
            if(selectedPanel!=pnlTrainer)
            {
                pnlTrainer.BackColor = Color.Transparent;
                pnlTrainer.ForeColor = Color.White;
                picTrainer.Image = Properties.Resources.trainer;
            }
        }

        private void pnlTrainer_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlTrainer);
            pnlTrainer.ForeColor = Color.White;
            picTrainer.Image = Properties.Resources.trainer;
            ExpandIfCollapsed();
            OpenChildForm(new FrmTrainer());
        }

        private void pnlFitnessTest_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlFitnessTest)
            {
                pnlFitnessTest.BackColor = Color.FromArgb(190, 216, 230);
                pnlFitnessTest.ForeColor = Color.Black;
                picFitnessTest.Image = Properties.Resources.fitnessTestHover;
            }      
        }

        private void pnlFitnessTest_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlFitnessTest)
            {
                pnlFitnessTest.BackColor = Color.Transparent;
                pnlFitnessTest.ForeColor = Color.White;
                picFitnessTest.Image = Properties.Resources.fitnessTest;
            }  
        }

        private void pnlFitnessTest_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlFitnessTest);
            pnlFitnessTest.ForeColor = Color.White;
            picFitnessTest.Image = Properties.Resources.fitnessTest;
            ExpandIfCollapsed();
            OpenChildForm(new FrmFitnessTest());
        }
        private void pnlMarkMemberAttendance_MouseEnter(object sender, EventArgs e)
        {
            if(selectedPanel!=pnlMarkMemberAttendance)
            {
                pnlMarkMemberAttendance.BackColor = Color.FromArgb(190, 216, 230);
                pnlMarkMemberAttendance.ForeColor = Color.Black;
                picMarkMemberAtttendance.Image = Properties.Resources.record_button;
            }
        }

        private void pnlMarkMemberAttendance_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlMarkMemberAttendance)
            {
                pnlMarkMemberAttendance.BackColor = Color.Transparent;
                pnlMarkMemberAttendance.ForeColor = Color.White;
                picMarkMemberAtttendance.Image = Properties.Resources.recor_buttonW;
            }
        }

        private void pnlMarkMemberAttendance_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
            OpenChildForm(new FrmMarkAttendance());
            SelectPanel(pnlMarkMemberAttendance);
            pnlMarkMemberAttendance.ForeColor = Color.White;
            picMarkMemberAtttendance.Image = Properties.Resources.recor_buttonW;
        }

        private void pnlViewMemberAttendance_MouseEnter(object sender, EventArgs e)
        {
            if(selectedPanel!=pnlViewMemberAttendance)
            {
                pnlViewMemberAttendance.BackColor = Color.FromArgb(190, 216, 230);
                pnlViewMemberAttendance.ForeColor = Color.Black;
                picViewMemberAttendance.Image = Properties.Resources.record_button;
            }
            
        }

        private void pnlViewMemberAttendance_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlViewMemberAttendance)
            {
                pnlViewMemberAttendance.BackColor = Color.Transparent;
                pnlViewMemberAttendance.ForeColor = Color.White;
                picViewMemberAttendance.Image = Properties.Resources.recor_buttonW;
            }
            
        }

        private void pnlViewMemberAttendance_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
            OpenChildForm(new FrmViewAttendance());
            SelectPanel(pnlViewMemberAttendance);
            pnlViewMemberAttendance.ForeColor = Color.White;
            picViewMemberAttendance.Image = Properties.Resources.recor_buttonW;
        }

        private void pnlMembershipPlan_MouseEnter(object sender, EventArgs e)
        {
            if(selectedPanel!=pnlMembershipPlan)
            {
                pnlMembershipPlan.BackColor = Color.FromArgb(190, 216, 230);
                pnlMembershipPlan.ForeColor = Color.Black;
                picMembershipPlan.Image = Properties.Resources.plansHOVER;
            }
        }

        private void pnlMembershipPlan_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlMembershipPlan)
            {
                pnlMembershipPlan.BackColor = Color.Transparent;
                pnlMembershipPlan.ForeColor = Color.White;
                picMembershipPlan.Image = Properties.Resources.Plans;
            }           
        }

        private void pnlMembershipPlan_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlMembershipPlan);
            pnlMembershipPlan.ForeColor = Color.White;
            picMembershipPlan.Image = Properties.Resources.Plans;
            ExpandIfCollapsed();
            OpenChildForm(new FrmDisplayMembershipPlan());
        }

        private void pnlShift_MouseEnter(object sender, EventArgs e)
        {
            if(selectedPanel!=pnlShift)
            {
                pnlShift.BackColor = Color.FromArgb(190, 216, 230);
                pnlShift.ForeColor = Color.Black;
                picShift.Image = Properties.Resources.shiftHover;
            }
            
        }

        private void pnlShift_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlShift)
            {
                pnlShift.BackColor = Color.Transparent;
                pnlShift.ForeColor = Color.White;
                picShift.Image = Properties.Resources.shift;
            }
  
        }

        private void pnlShift_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlShift);
            pnlShift.ForeColor = Color.White;
            picShift.Image = Properties.Resources.shift;
            ExpandIfCollapsed();
            OpenChildForm(new FrmDisplayShift());
        }

        private void pnlLocker_MouseEnter(object sender, EventArgs e)
        {
            if(selectedPanel!=pnlLocker)
            {
                pnlLocker.BackColor = Color.FromArgb(190, 216, 230);
                pnlLocker.ForeColor = Color.Black;
                picLocker.Image = Properties.Resources.lockerHOVER__1_;
            }
            
        }

        private void pnlLocker_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlLocker)
            {
                pnlLocker.BackColor = Color.Transparent;
                pnlLocker.ForeColor = Color.White;
                picLocker.Image = Properties.Resources.locker;
            }
            
        }

        private void pnlLocker_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlLocker);
            pnlLocker.ForeColor = Color.White;
            picLocker.Image = Properties.Resources.locker;
            ExpandIfCollapsed();
            OpenChildForm(new FrmDisplayLocker());
        }



        private void pnlWorkoutPlans_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlWorkoutPlans)
            {
                pnlWorkoutPlans.BackColor = Color.FromArgb(190, 216, 230);
                pnlWorkoutPlans.ForeColor = Color.Black;
                picWorkoutPlans.Image = Properties.Resources.record_button;
            }
            
        }

        private void pnlWorkoutPlans_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlWorkoutPlans)
            {
                pnlWorkoutPlans.BackColor = Color.Transparent;
                pnlWorkoutPlans.ForeColor = Color.White;
                picWorkoutPlans.Image = Properties.Resources.recor_buttonW;
            }
        }

        private void pnlWorkoutPlans_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
            OpenChildForm(new FrmDisplayWorkoutPlans());
            SelectPanel(pnlWorkoutPlans);
            pnlWorkoutPlans.ForeColor = Color.White;
            picWorkoutPlans.Image = Properties.Resources.recor_buttonW;
        }

        private void pnlWorkoutShedule_MouseEnter(object sender, EventArgs e)
        {
            if(selectedPanel != pnlWorkoutShedule)
            {
                pnlWorkoutShedule.BackColor = Color.FromArgb(190, 216, 230);
                pnlWorkoutShedule.ForeColor = Color.Black;
                picWorkoutShedule.Image = Properties.Resources.record_button;
            }
            
        }

        private void pnlWorkoutShedule_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlWorkoutShedule)
            {
                pnlWorkoutShedule.BackColor = Color.Transparent;
                pnlWorkoutShedule.ForeColor = Color.White;
                picWorkoutShedule.Image = Properties.Resources.recor_buttonW;
            }
            
           
        }

        private void pnlWorkoutShedule_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
            OpenChildForm(new FrmDisplayWorkoutSchedule());
            SelectPanel(pnlWorkoutShedule);
            pnlWorkoutShedule.ForeColor = Color.White;
            picWorkoutShedule.Image = Properties.Resources.recor_buttonW;
        }

        private void pnlRegistrationFees_MouseEnter(object sender, EventArgs e)
        {
            if(selectedPanel!=pnlRegistrationFees)
            {
                pnlRegistrationFees.BackColor = Color.FromArgb(190, 216, 230);
                pnlRegistrationFees.ForeColor = Color.Black;
                picRegistrationFees.Image = Properties.Resources.regFeesHOVER__1_;
            }
            
        }

        private void pnlRegistrationFees_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlRegistrationFees)
            {
                pnlRegistrationFees.BackColor = Color.Transparent;
                pnlRegistrationFees.ForeColor = Color.White;
                picRegistrationFees.Image = Properties.Resources.regfee;
            }
            
        }

        private void pnlRegistrationFees_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlRegistrationFees);
            pnlRegistrationFees.ForeColor = Color.White;
            picRegistrationFees.Image = Properties.Resources.regfee;
            ExpandIfCollapsed();
            OpenChildForm(new FrmRegistrationFees());
        }

        private void pnlDietPlan_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlDietPlan)
            {
                pnlDietPlan.BackColor = Color.FromArgb(190, 216, 230);
                pnlDietPlan.ForeColor = Color.Black;
                picDietPlan.Image = Properties.Resources.planHOVER__1_;
            }
            
        }

        private void pnlDietPlan_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlDietPlan)
            {
                pnlDietPlan.BackColor = Color.Transparent;
                pnlDietPlan.ForeColor = Color.White;
                picDietPlan.Image = Properties.Resources.plan;
            }
            
        }

        private void pnlDietPlan_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlDietPlan);
            pnlDietPlan.ForeColor = Color.White;
            picDietPlan.Image = Properties.Resources.plan;
            ExpandIfCollapsed();
            OpenChildForm(new FrmShowDietPlans());
        }

        private void pnlPayment_MouseEnter(object sender, EventArgs e)
        {
            if(selectedPanel!=pnlPayment)
            {
                pnlPayment.BackColor = Color.FromArgb(190, 216, 230);
                pnlPayment.ForeColor = Color.Black;
                picPayment.Image = Properties.Resources.PaymentHOVER__1_;
            }
            
        }

        private void pnlPayment_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlPayment)
            {
                pnlPayment.BackColor = Color.Transparent;
                pnlPayment.ForeColor = Color.White;
                picPayment.Image = Properties.Resources.payment;
            }
            
        }

        private void pnlPayment_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlPayment);
            pnlPayment.ForeColor = Color.White;
            picPayment.Image = Properties.Resources.payment;
            ExpandIfCollapsed();
            OpenChildForm(new FrmDisplayPayments());
        }

        private void pnlExpense_MouseEnter(object sender, EventArgs e)
        {
            if(selectedPanel!=pnlExpense)
            {
                pnlExpense.BackColor = Color.FromArgb(190, 216, 230);
                pnlExpense.ForeColor = Color.Black;
                picExpense.Image = Properties.Resources.expenseHOVER__1_;
            }
           
        }

        private void pnlExpense_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlExpense)
            {
                pnlExpense.BackColor = Color.Transparent;
                pnlExpense.ForeColor = Color.White;
                picExpense.Image = Properties.Resources.expense;
            }
            
        }

        private void pnlExpense_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlExpense);
            pnlExpense.ForeColor = Color.White;
            picExpense.Image= Properties.Resources.expense;
            ExpandIfCollapsed();
            OpenChildForm(new FrmAddExpenses());
        }

        private void pnlSettings_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlSettings && selectedPanel!=pnlAdminPasswordChange)
            {
                pnlSettings.BackColor = Color.FromArgb(190, 216, 230);
                pnlSettings.ForeColor = Color.Black;
                picSettingsArrowe.Image = Properties.Resources.downArrowB;
                picSettings.Image = Properties.Resources.settingHOVER;
            }

        }

        private void pnlSettings_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlSettings &&selectedPanel!=pnlAdminPasswordChange)
            {
                pnlSettings.BackColor = Color.Transparent;
                pnlSettings.ForeColor = Color.White;
                picSettings.Image = Properties.Resources.setting;
                picSettingsArrowe.Image = Properties.Resources.downArrowW;
            }

        }
        private void pnlSettings_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlSettings);
            pnlSettings.ForeColor = Color.White;
            picSettings.Image = Properties.Resources.setting;
            ExpandIfCollapsed();
            if (!isSettingsExpanded)
            {
                pnlDropDownSettings.Visible = true;
                picSettingsArrowe.Image = Properties.Resources.topArrowW;
                isSettingsExpanded = true;
            }
            else
            {
                pnlDropDownSettings.Visible = false;
                picSettingsArrowe.Image = Properties.Resources.downArrowW;
                isSettingsExpanded = false;
            }
        }
        private void pnlLogout_MouseEnter(object sender, EventArgs e)
        {
            pnlLogout.BackColor = Color.FromArgb(190, 216, 230);
            pnlLogout.ForeColor = Color.Black;
            picLogout.Image = Properties.Resources.logoutHOVER__2_;
        }

        private void pnlLogout_MouseLeave(object sender, EventArgs e)
        {
            pnlLogout.BackColor = Color.Transparent;
            pnlLogout.ForeColor = Color.White;
            picLogout.Image = Properties.Resources.logout;
        }

        private void pnlLogout_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
            FrmUserRoleSelection frmUserRoleSelection = new FrmUserRoleSelection();
            this.Hide();
            frmUserRoleSelection.ShowDialog();
            this.Close();
        }

        private void pnlMenu_MouseEnter(object sender, EventArgs e)
        {
            pnlMenu.BackColor = Color.FromArgb(190, 216, 230);
            picMenu.Image = Properties.Resources.menuHOVER;
            pnlMenu.ForeColor = Color.Black;
        }

        private void pnlMenu_MouseLeave(object sender, EventArgs e)
        {
            pnlMenu.BackColor = Color.Transparent;
            picMenu.Image = Properties.Resources.menu;
            pnlMenu.ForeColor = Color.White;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlExit_MouseEnter(object sender, EventArgs e)
        {
            pnlExit.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void pnlExit_MouseLeave(object sender, EventArgs e)
        {
            pnlExit.BackColor = Color.FromArgb(230, 238, 248);
        }

        private void pnlExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlRestore_MouseEnter(object sender, EventArgs e)
        {
            pnlRestore.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void pnlRestore_MouseLeave(object sender, EventArgs e)
        {
            pnlRestore.BackColor = Color.FromArgb(230, 238, 248);
        }

        private void pnlRestore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pnlMinimize_MouseEnter(object sender, EventArgs e)
        {
            pnlMinimize.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void pnlMinimize_MouseLeave(object sender, EventArgs e)
        {
            pnlMinimize.BackColor = Color.FromArgb(230, 238, 248);
        }

        private void pnlMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlAdminChangePassword_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlAdminPasswordChange)
            {
                pnlAdminPasswordChange.BackColor = Color.FromArgb(190, 216, 230);
                pnlAdminPasswordChange.ForeColor = Color.Black;
                picAdminPasswordChange.Image = Properties.Resources.record_button;
            }
        }

        private void pnlAdminPasswordChange_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlAdminPasswordChange)
            {
                pnlAdminPasswordChange.BackColor = Color.Transparent;
                pnlAdminPasswordChange.ForeColor = Color.White;
                picAdminPasswordChange.Image = Properties.Resources.recor_buttonW;
            }
        }

        private void pnlAdminPasswordChange_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();
            FrmChangePasswordAdmin frmChangePasswordAdmin = new FrmChangePasswordAdmin();
            frmChangePasswordAdmin.ShowDialog();
            SelectPanel(pnlAdminPasswordChange);
            pnlAdminPasswordChange.ForeColor = Color.White;
            picAdminPasswordChange.Image = Properties.Resources.recor_buttonW;
        }

        

       
       
    
       }
}
