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

        private void pnlSettings_Click(object sender, EventArgs e)
        {
            if (!isSettingsExpanded)
            {
                pnlDropDownSettings.Visible = true;
                picSettingsArrowe.Image = Properties.Resources.arrow_upWhite;
                isSettingsExpanded = true;
            }
            else
            {
                pnlDropDownSettings.Visible = false;
                picSettingsArrowe.Image = Properties.Resources.down_arrowWhite;
                isSettingsExpanded = false;
            }
        }

        private void pnlMenu_Click(object sender, EventArgs e)
        {
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

        private void pnlMenu_MouseEnter(object sender, EventArgs e)
        {
            pnlMenu.BackColor = Color.FromArgb(190, 216, 230);
        }

        private void pnlMenu_MouseLeave(object sender, EventArgs e)
        {
            pnlMenu.BackColor = Color.FromArgb(34, 52, 72);
        }

    }
}
