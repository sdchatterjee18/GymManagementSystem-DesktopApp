using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.FormsSuperAdmin.Dashboard;
using GymManagementSystem.FormsSuperAdmin.Employee;
using GymManagementSystem.FormsSuperAdmin.Salary;
using GymManagementSystem.FormsSuperAdmin.Financials;
using GymManagementSystem.Authentication;
using GymManagementSystem.FormsSuperAdmin.Settings;
using GymManagementSystem.Authentication.UI;

namespace GymManagementSystem.FormsSuperAdmin.MainLayout
{
    public partial class FrmSAMainForm : Form
    {
        private bool isFinancialManagementExpanded = false;
        private bool isSettingsExpanded = false;
        private const int ExpandedWidth = 280;
        private const int CollapsedWidth = 70;
        private bool sidebarExpand = true;
        private Form activeForm = null;
        FrmUserRoleSelection frmUserRoleSelection = null;
        public FrmSAMainForm()
        {
            //this.frmUserRoleSelection = frmUserRoleSelection;
            InitializeComponent();
        }
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



        private void FrmSAMainForm_Load_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Load Working");


            pnlSidebar.Width = ExpandedWidth;
            sidebarExpand = true;
            ExpandSidebar();
            OpenChildForm(new FrmSADashboard());
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

        private void pnlMenu_Click(object sender, EventArgs e)
        {
            if (pnlDropDownSettings.Visible)
            {
                return;
            }

            if (!timerSidebar.Enabled)
            {
                timerSidebar.Start();
            }
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

        private void pnlMenu_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlMenu)
            {
                pnlMenu.BackColor = Color.FromArgb(190, 216, 230); // Hover Color
            }
        }

        private void pnlMenu_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlMenu)
            {
                pnlMenu.BackColor = Color.Transparent;
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
            CloseAllDropdowns();

            SelectPanel(pnlDashboard);
            pnlDashboard.ForeColor = Color.White;
            picDashboard.Image = Properties.Resources.dashboard;

            ExpandIfCollapsed();
            OpenChildForm(new FrmSADashboard());
        }

        private void pnlEmployeeManagement_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlEmployeeManagement)
            {
                pnlEmployeeManagement.BackColor = Color.FromArgb(190, 216, 230);
                pnlEmployeeManagement.ForeColor = Color.Black;
                picEmployeeManagement.Image = Properties.Resources.EmployeeHOVER;
            }
        }

        private void pnlEmployeeManagement_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlEmployeeManagement)
            {
                pnlEmployeeManagement.BackColor = Color.Transparent;
                pnlEmployeeManagement.ForeColor = Color.White;
                picEmployeeManagement.Image = Properties.Resources.Employee;
            }
        }

        private void pnlEmployeeManagement_Click(object sender, EventArgs e)
        {
            CloseAllDropdowns();

            SelectPanel(pnlEmployeeManagement);

            pnlEmployeeManagement.ForeColor = Color.White;
            picEmployeeManagement.Image = Properties.Resources.Employee;

            ExpandIfCollapsed();
            OpenChildForm(new FrmSADisplayAllEmployee(this));
        }
        private void pnlEmployeeSalaryManagement_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlEmployeeSalaryManagement)
            {
                pnlEmployeeSalaryManagement.BackColor = Color.FromArgb(190, 216, 230);
                pnlEmployeeSalaryManagement.ForeColor = Color.Black;
                picEmployeeSalaryManagement.Image = Properties.Resources.SalaryHOVER;
            }
        }

        private void pnlEmployeeSalaryManagement_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlEmployeeSalaryManagement)
            {
                pnlEmployeeSalaryManagement.BackColor = Color.Transparent;
                pnlEmployeeSalaryManagement.ForeColor = Color.White;
                picEmployeeSalaryManagement.Image = Properties.Resources.Salary;
            }
        }

        private void pnlEmployeeSalaryManagement_Click(object sender, EventArgs e)
        {
            CloseAllDropdowns();

            SelectPanel(pnlEmployeeSalaryManagement);

            pnlEmployeeSalaryManagement.ForeColor = Color.White;
            picEmployeeSalaryManagement.Image = Properties.Resources.Salary;

            ExpandIfCollapsed();
            OpenChildForm(new FrmSASalaryPayment());
        }

        private void pnlFinancialManagement_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlFinancialManagement &&
                selectedPanel != pnlProfitLoss &&
                selectedPanel != pnlPayment &&
                selectedPanel != pnlExpense &&
                !isFinancialManagementExpanded)
            {
                pnlFinancialManagement.BackColor =
                    Color.FromArgb(190, 216, 230);

                pnlFinancialManagement.ForeColor =
                    Color.Black;

                picFinancialManagement.Image =
                    Properties.Resources.FinancialsHOVER;

                picFinancialManagementArrow.Image =
                    Properties.Resources.downArrowB;
            }
        }

        private void pnlFinancialManagement_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlFinancialManagement &&
                selectedPanel != pnlProfitLoss &&
                selectedPanel != pnlPayment &&
                selectedPanel != pnlExpense &&
                !isFinancialManagementExpanded)
            {
                pnlFinancialManagement.BackColor =
                    Color.Transparent;

                pnlFinancialManagement.ForeColor =
                    Color.White;

                picFinancialManagement.Image =
                    Properties.Resources.Financials;

                picFinancialManagementArrow.Image =
                    Properties.Resources.downArrowW;
            }
        }

        private void pnlFinancialManagement_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();

            if (isFinancialManagementExpanded)
            {
                // ==========================================
                // CLOSE FINANCIAL MANAGEMENT DROPDOWN
                // ==========================================

                pnlDropdownFinancialManagement.Visible = false;

                picFinancialManagementArrow.Image =
                    Properties.Resources.downArrowW;

                isFinancialManagementExpanded = false;

                // Select MAIN Financial Management panel
                SelectPanel(pnlFinancialManagement);

                pnlFinancialManagement.BackColor =
                    Color.FromArgb(68, 97, 174);

                pnlFinancialManagement.ForeColor =
                    Color.White;

                picFinancialManagement.Image =
                    Properties.Resources.Financials;
            }
            else
            {
                // ==========================================
                // OPEN FINANCIAL MANAGEMENT DROPDOWN
                // ==========================================

                CloseAllDropdowns();

                // Select MAIN Financial Management panel
                SelectPanel(pnlFinancialManagement);

                pnlFinancialManagement.BackColor =
                    Color.FromArgb(68, 97, 174);

                pnlFinancialManagement.ForeColor =
                    Color.White;

                picFinancialManagement.Image =
                    Properties.Resources.Financials;

                // Open dropdown
                pnlDropdownFinancialManagement.Visible = true;

                picFinancialManagementArrow.Image =
                    Properties.Resources.topArrowW;

                isFinancialManagementExpanded = true;

                // ==========================================
                // DEFAULT FORM
                // ==========================================

                OpenChildForm(new FrmSAProfitLoss());
            }
        }
        private void pnlSettings_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlSettings &&
                selectedPanel != pnlSuperAdminPasswordChange)
            {
                pnlSettings.BackColor =
                    Color.FromArgb(190, 216, 230);

                pnlSettings.ForeColor = Color.Black;

                picSettings.Image =
                    Properties.Resources.settingHOVER;

                if (isSettingsExpanded)
                {
                    picSettingsArrowe.Image =
                        Properties.Resources.topArrowB;
                }
                else
                {
                    picSettingsArrowe.Image =
                        Properties.Resources.downArrowB;
                }
            }
        }

        private void pnlSettings_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlSettings &&
                selectedPanel != pnlSuperAdminPasswordChange)
            {
                pnlSettings.BackColor = Color.Transparent;

                pnlSettings.ForeColor = Color.White;

                picSettings.Image =
                    Properties.Resources.setting;

                if (isSettingsExpanded)
                {
                    picSettingsArrowe.Image =
                        Properties.Resources.topArrowW;
                }
                else
                {
                    picSettingsArrowe.Image =
                        Properties.Resources.downArrowW;
                }
            }
        }
        private void pnlSettings_Click(object sender, EventArgs e)
        {
            ExpandIfCollapsed();

            if (isSettingsExpanded)
            {
                // ==========================================
                // CLOSE SETTINGS DROPDOWN
                // ==========================================

                pnlDropDownSettings.Visible = false;

                picSettingsArrowe.Image =
                    Properties.Resources.downArrowW;

                isSettingsExpanded = false;

                // Select MAIN Settings panel
                SelectPanel(pnlSettings);

                pnlSettings.ForeColor = Color.White;

                picSettings.Image =
                    Properties.Resources.setting;
            }
            else
            {
                // ==========================================
                // OPEN SETTINGS DROPDOWN
                // ==========================================

                CloseAllDropdowns();

                // Select MAIN Settings panel
                SelectPanel(pnlSettings);

                pnlSettings.ForeColor = Color.White;

                picSettings.Image =
                    Properties.Resources.setting;

                // Open dropdown
                pnlDropDownSettings.Visible = true;

                picSettingsArrowe.Image =
                    Properties.Resources.topArrowW;

                isSettingsExpanded = true;
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
            CloseAllDropdowns();
            ExpandIfCollapsed();

            // ==========================================
            // LOGOUT CONFIRMATION
            // ==========================================

            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            // ==========================================
            // PERFORM LOGOUT
            // ==========================================

            AuthenticationUI authenticationUI = new AuthenticationUI();

            bool logoutResult =
                authenticationUI.SuperAdminLogoutUI();

            if (logoutResult)
            {
                MessageBox.Show(
                    "Logout Successful.",
                    "Logout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                FrmUserRoleSelection frmUserRoleSelection =
                    new FrmUserRoleSelection();

                this.Hide();
                frmUserRoleSelection.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Logout Failed.",
                    "Logout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void pnlSuperAdminPasswordChange_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlSuperAdminPasswordChange)
            {
                pnlSuperAdminPasswordChange.BackColor = Color.FromArgb(190, 216, 230);
                pnlSuperAdminPasswordChange.ForeColor = Color.Black;
                picSuperAdminPasswordChange.Image = Properties.Resources.record_button;
            }

        }

        private void pnlSuperAdminPasswordChange_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlSuperAdminPasswordChange)
            {
                pnlSuperAdminPasswordChange.BackColor = Color.Transparent;
                pnlSuperAdminPasswordChange.ForeColor = Color.White;
                picSuperAdminPasswordChange.Image = Properties.Resources.recor_buttonW;
            }
        }

        private void pnlSuperAdminPasswordChange_Click(object sender, EventArgs e)
        {
            CloseAllDropdowns();
            ExpandIfCollapsed();

            SelectPanel(pnlSuperAdminPasswordChange);

            pnlSuperAdminPasswordChange.ForeColor = Color.White;

            picSuperAdminPasswordChange.Image =
                Properties.Resources.recor_buttonW;

            FrmSAPasswordChange frmSAPasswordChange =
                new FrmSAPasswordChange();

            frmSAPasswordChange.ShowDialog();
        }

        private void picSettingsArrowe_MouseEnter(object sender, EventArgs e)
        {
        }
        private void pnlProfitLoss_Click(object sender, EventArgs e)
        {
            //CloseAllDropdowns();
            ExpandIfCollapsed();

            OpenChildForm(new FrmSAProfitLoss());

            SelectPanel(pnlProfitLoss);

            pnlProfitLoss.ForeColor = Color.White;
            picProfitLoss.Image = Properties.Resources.recor_buttonW;
        }

        private void pnlProfitLoss_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlProfitLoss)
            {
                pnlProfitLoss.BackColor =
                    Color.FromArgb(190, 216, 230);

                pnlProfitLoss.ForeColor = Color.Black;

                picProfitLoss.Image =
                    Properties.Resources.record_button;
            }
        }

        private void pnlProfitLoss_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlProfitLoss)
            {
                pnlProfitLoss.BackColor = Color.Transparent;

                pnlProfitLoss.ForeColor = Color.White;

                picProfitLoss.Image =
                    Properties.Resources.recor_buttonW;
            }
        }

        private void pnlPayment_Click(object sender, EventArgs e)
        {
            //    CloseAllDropdowns();
            ExpandIfCollapsed();

            OpenChildForm(new FrmSAPayment());

            SelectPanel(pnlPayment);

            pnlPayment.ForeColor = Color.White;
            picPayment.Image = Properties.Resources.recor_buttonW;
        }
        private void pnlPayment_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlPayment)
            {
                pnlPayment.BackColor =
                    Color.FromArgb(190, 216, 230);

                pnlPayment.ForeColor = Color.Black;

                picPayment.Image =
                    Properties.Resources.record_button;
            }
        }

        private void pnlPayment_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlPayment)
            {
                pnlPayment.BackColor = Color.Transparent;

                pnlPayment.ForeColor = Color.White;

                picPayment.Image =
                    Properties.Resources.recor_buttonW;
            }
        }
        private void pnlExpense_Click(object sender, EventArgs e)
        {
            //CloseAllDropdowns();
            ExpandIfCollapsed();

            OpenChildForm(new FrmSAExpense());

            SelectPanel(pnlExpense);

            pnlExpense.ForeColor = Color.White;
            picExpense.Image = Properties.Resources.recor_buttonW;
        }
        private void pnlExpense_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlExpense)
            {
                pnlExpense.BackColor =
                    Color.FromArgb(190, 216, 230);

                pnlExpense.ForeColor = Color.Black;

                picExpense.Image =
                    Properties.Resources.record_button;
            }
        }

        private void pnlExpense_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlExpense)
            {
                pnlExpense.BackColor = Color.Transparent;

                pnlExpense.ForeColor = Color.White;

                picExpense.Image =
                    Properties.Resources.recor_buttonW;
            }
        }
        private void CloseAllDropdowns()
        {
            pnlDropdownFinancialManagement.Visible = false;
            pnlDropDownSettings.Visible = false;

            isFinancialManagementExpanded = false;
            isSettingsExpanded = false;

            picFinancialManagementArrow.Image =
                Properties.Resources.downArrowW;

            picSettingsArrowe.Image =
                Properties.Resources.downArrowW;
        }
        //private void CloseAllDropdowns()
        //{
        //   pnlDropdownFinancialManagement.Visible = false;
        //   pnlDropDownSettings.Visible = false;
        //   isFinancialManagementExpanded = false;
        //   isSettingsExpanded = false;
        //   picFinancialManagementArrow.Image =Properties.Resources.downArrowW;
        //   picSettingsArrowe.Image = Properties.Resources.downArrowW;
        //}

        private void pnlExit_MouseEnter(object sender, EventArgs e)
        {
            pnlExit.BackColor = Color.Red;
        }

        private void pnlExit_MouseLeave(object sender, EventArgs e)
        {
            pnlExit.BackColor = Color.Transparent;
        }

        private void pnlExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlMinimize_MouseEnter(object sender, EventArgs e)
        {
            pnlMinimize.BackColor = Color.FromArgb(190, 205, 225);
        }

        private void pnlMinimize_MouseLeave(object sender, EventArgs e)
        {
            pnlMinimize.BackColor = Color.Transparent;
        }

        private void pnlMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlRestore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                picRestore.Image = Properties.Resources.rectangle;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                picRestore.Image = Properties.Resources.copy;
            }
        }

        private void pnlRestore_MouseEnter(object sender, EventArgs e)
        {
            pnlRestore.BackColor = Color.FromArgb(190, 205, 225);
        }

        private void pnlRestore_MouseLeave(object sender, EventArgs e)
        {
            pnlRestore.BackColor = Color.Transparent;
        }
    }
}