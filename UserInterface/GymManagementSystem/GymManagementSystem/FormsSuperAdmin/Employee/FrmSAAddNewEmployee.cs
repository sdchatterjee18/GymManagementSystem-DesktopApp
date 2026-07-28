using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem.FormsSuperAdmin.Employee
{
    public partial class FrmSAAddNewEmployee : Form
    {
        public FrmSAAddNewEmployee()
        {
            InitializeComponent();
        }

        private void FrmSAAddNewEmployee_Load(object sender, EventArgs e)
        {
            // Employee Type
            cmbEmployeeType.Items.Clear();
            cmbEmployeeType.Items.Add("Admin");
            cmbEmployeeType.Items.Add("Trainer");
            cmbEmployeeType.Items.Add("Staff");

            cmbEmployeeType.SelectedIndex = -1;
            //pnlDefault.Visible = true;
            pnlDefault.BringToFront();
            SetPlaceholder(this);
            this.ActiveControl = null;   
        }

        private void cmbEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployeeType.Text == "Admin")
            {
                pnlAdminDetails.Visible = true;
                pnlAdminDetails.BringToFront();
            }
            else if (cmbEmployeeType.Text == "Trainer")
            {
                pnlTrainerDetails.Visible = true;
                pnlTrainerDetails.BringToFront();
            }
            else if (cmbEmployeeType.Text == "Staff")
            {
                pnlStaffDetails.Visible = true;
                pnlStaffDetails.BringToFront();
            }

        }

        private void SetPlaceholder(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = (TextBox)c;

                    txt.Tag = txt.Text;         
                    txt.ForeColor = Color.Gray;

                    txt.Enter += Placeholder_Enter;
                    txt.Leave += Placeholder_Leave;
                }

                if (c.HasChildren)
                    SetPlaceholder(c);
            }
        }

        private void Placeholder_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text == txt.Tag.ToString())
            {
                txt.Clear();
                txt.ForeColor = Color.Black;
            }
        }

        private void Placeholder_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = txt.Tag.ToString();
                txt.ForeColor = Color.Gray;
            }
        }
        private void Placeholder_Click(object sender, MouseEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text == txt.Tag.ToString())
            {
                txt.Clear();
                txt.ForeColor = Color.Black;
            }
        }

        private void FrmSAAddNewEmployee_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void pnlSubmitForm_MouseEnter(object sender, EventArgs e)
        {
            pnlSubmitForm.BackColor = Color.FromArgb(76, 175, 80);
        }

        private void pnlSubmitForm_MouseLeave(object sender, EventArgs e)
        {
            pnlSubmitForm.BackColor = Color.Green;
        }

        private void pnlSubmitForm_Click(object sender, EventArgs e)
        {

        }

        private void pnlReset_MouseEnter(object sender, EventArgs e)
        {
            pnlReset.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void pnlReset_MouseLeave(object sender, EventArgs e)
        {
            pnlReset.BackColor = Color.Blue;
        }

        private void pnlReset_Click(object sender, EventArgs e)
        {

        }

        private void pnlCancel_MouseEnter(object sender, EventArgs e)
        {
            pnlCancel.BackColor = Color.FromArgb(203, 67, 53);
        }

        private void pnlCancel_MouseLeave(object sender, EventArgs e)
        {
            pnlCancel.BackColor = Color.Red;
        }

        private void pnlCancel_Click(object sender, EventArgs e)
        {

        }
     
        
    }
}
