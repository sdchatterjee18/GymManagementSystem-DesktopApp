using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem.FormsSuperAdmin.MainLayout
{
    public partial class FrmSAMainForm : Form
    {
        private bool isSettingsExpanded = false;
        private const int ExpandedWidth = 280;
        private const int CollapsedWidth = 70;
        private bool sidebarExpand = true;
        public FrmSAMainForm()
        {
            InitializeComponent();
        }

        private void FrmSAMainForm_Load(object sender, EventArgs e)
        {
           
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

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void FrmSAMainForm_Load_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Load Working");
           
            timer.Start();
            pnlSidebar.Width = ExpandedWidth;
            sidebarExpand = true;
            ExpandSidebar();
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
                pnlMenu.BackColor = Color.FromArgb(34, 52, 72); // Default Sidebar Color
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
            picDashboard.Image = Properties.Resources.dashboard;
            ExpandIfCollapsed();
        }

        private void pnlEmployeeManagement_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlEmployeeManagement)
            {
                pnlEmployeeManagement.BackColor = Color.FromArgb(190, 216, 230);
                pnlEmployeeManagement.ForeColor = Color.Black;
                //picEmployeeManagement.Image = Properties.Resources.employeeManagementHOVER; 
            }
        }

        private void pnlEmployeeManagement_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlEmployeeManagement)
            {
                pnlEmployeeManagement.BackColor = Color.FromArgb(34, 52, 72);
                pnlEmployeeManagement.ForeColor = Color.White;
                //picEmployeeManagement.Image = Properties.Resources.employeeManagement; 
            }
        }

        private void pnlEmployeeManagement_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlEmployeeManagement);

            pnlEmployeeManagement.ForeColor = Color.White;
            //picEmployeeManagement.Image = Properties.Resources.employeeManagement;

            ExpandIfCollapsed();
        }

        private void pnlEmployeeSalaryManagement_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlEmployeeSalaryManagement)
            {
                pnlEmployeeSalaryManagement.BackColor = Color.FromArgb(190, 216, 230);
                pnlEmployeeSalaryManagement.ForeColor = Color.Black;
                //picEmployeeSalaryManagement.Image = Properties.Resources.employeeSalaryManagementHOVER;
            }
        }

        private void pnlEmployeeSalaryManagement_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlEmployeeSalaryManagement)
            {
                pnlEmployeeSalaryManagement.BackColor = Color.FromArgb(34, 52, 72);
                pnlEmployeeSalaryManagement.ForeColor = Color.White;
                //picEmployeeSalaryManagement.Image = Properties.Resources.employeeSalaryManagement;
            }
        }

        private void pnlEmployeeSalaryManagement_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlEmployeeSalaryManagement);

            pnlEmployeeSalaryManagement.ForeColor = Color.White;
            //picEmployeeSalaryManagement.Image = Properties.Resources.employeeSalaryManagement;

            ExpandIfCollapsed();
        }

        private void pnlFinancialManagement_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlFinancialManagement)
            {
                pnlFinancialManagement.BackColor = Color.FromArgb(190, 216, 230);
                pnlFinancialManagement.ForeColor = Color.Black;
                //picFinancialManagement.Image = Properties.Resources.financialManagementHOVER;
            }
        }

        private void pnlFinancialManagement_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlFinancialManagement)
            {
                pnlFinancialManagement.BackColor = Color.FromArgb(34, 52, 72);
                pnlFinancialManagement.ForeColor = Color.White;
                //picFinancialManagement.Image = Properties.Resources.financialManagement;
            }
        }

        private void pnlFinancialManagement_Click(object sender, EventArgs e)
        {
            SelectPanel(pnlFinancialManagement);

            pnlFinancialManagement.ForeColor = Color.White;
            //picFinancialManagement.Image = Properties.Resources.financialManagement;

            ExpandIfCollapsed();
        }
        private void pnlSettings_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPanel != pnlSettings)
            {
                pnlSettings.BackColor = Color.FromArgb(190, 216, 230);
                pnlSettings.ForeColor = Color.Black;
                picSettings.Image = Properties.Resources.settingHOVER;
            }

        }

        private void pnlSettins_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPanel != pnlSettings)
            {
                pnlSettings.BackColor = Color.Transparent;
                pnlSettings.ForeColor = Color.White;
                picSettings.Image = Properties.Resources.setting;
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
        }

    }
}
