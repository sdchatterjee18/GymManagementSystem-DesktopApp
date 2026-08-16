using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.FORMS.Member.UI;
using GymManagementSystem.FORMS.Shift.UI;

namespace GymManagementSystem.FORMS.Member
{
    
    public partial class FrmChangeShift : Form
    {
        string cmbSelectionMessage = "Please select a shift.";
        string ComfirmationMessage = "Do you want to change shift?";
        string Information = "Info";
        private MemberAllDetailsUI memberAllDetailsUI = null;
        public FrmChangeShift(MemberAllDetailsUI member)
        {
            InitializeComponent();
            memberAllDetailsUI = member;
        }

        private void tlpChangeShiftButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpChangeShiftButton.BackColor = Color.DarkGreen;
        }

        private void tlpChangeShiftButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpChangeShiftButton.BackColor = Color.ForestGreen;
        }

        private void tlpCancleSectionInChangeMemberShift_MouseEnter(object sender, EventArgs e)
        {
            this.tlpCancleSectionInChangeMemberShift.BackColor = Color.OrangeRed;
            
        }

        private void tlpCancleSectionInChangeMemberShift_MouseLeave(object sender, EventArgs e)
        {
            this.tlpCancleSectionInChangeMemberShift.BackColor = Color.Red;
        }

        private void FrmChangeShift_Load(object sender, EventArgs e)
        {
            SetMemberInformation();
            LoadAllShiftTocmbBox();
        }

        private void SetMemberInformation()
        {
            lblRetrieveMemberIDInChangePersonalTrainer.Text =
                memberAllDetailsUI.MemberId.ToString();
            lblRetrieveMemberName.Text =
                memberAllDetailsUI.MemberName.ToString();
            lblRetrievePreviousMembershipPlan.Text =
                memberAllDetailsUI.MembershipPlanName.ToString();
            lblRetrieveTrainerName.Text =
                memberAllDetailsUI.TrainerName.ToString();
        }

        private void LoadAllShiftTocmbBox()
        {
            DataTable dataTable = null;
            ShiftUI shiftUI = new ShiftUI();
            dataTable=shiftUI.GetShiftDetailsForComboBox();

            cmbSelectMembershipPlan.DataSource = null;
            cmbSelectMembershipPlan.DisplayMember = "ShiftName";
            cmbSelectMembershipPlan.ValueMember = "ShiftId";
            cmbSelectMembershipPlan.DataSource = dataTable;
            cmbSelectMembershipPlan.SelectedIndex = -1;
        }

        private void AvailableSlotsOfShift()
        {
            DataTable dataTable = null;
            int ShiftId = Convert.ToInt32(cmbSelectMembershipPlan.SelectedValue);
            try
            {
                MemberAllDetailsUI MemberAllDetailsUI = new MemberAllDetailsUI();
                dataTable = MemberAllDetailsUI.AvailableSlotsOfShiftUI(ShiftId);
                lblRetrieveCurrentCapacityOfAvailableSlotInSelectedShift.Text =
                    dataTable.Rows[0]["AvailableSlots"].ToString();
               
            }
            catch (Exception ex)
            {
                
            }
        }

        private void cmbSelectMembershipPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            AvailableSlotsOfShift();
        }

        private void ChangeShiftByMemberIdAndTrainerId()
        {
            string ChangeShiftMessage = null;
            try
            {

                int MemberId = Convert.ToInt32(lblRetrieveMemberIDInChangePersonalTrainer.Text);
                if (cmbSelectMembershipPlan.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        cmbSelectionMessage,
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmbSelectMembershipPlan.Focus();

                    return;
                }

                int NewShiftId = Convert.ToInt32(cmbSelectMembershipPlan.SelectedValue);

                DialogResult result = MessageBox.Show(ComfirmationMessage, Information, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    return;
                }
                if(result == DialogResult.Yes)
                {
                    MemberAllDetailsUI MemberAllDetailsUI = new MemberAllDetailsUI();
                    ChangeShiftMessage = MemberAllDetailsUI.ChangeShiftByMemberIdAndTrainerIdUI(MemberId, NewShiftId);
                    DialogResult Result= MessageBox.Show(ChangeShiftMessage, Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Result == DialogResult.OK)
                    {
                        this.Dispose();
                    }
                } 

                
            }
            catch (Exception ex)
            {
                 ChangeShiftMessage = null;
            }
        }

        private void pnlChangeShiftButton_Click(object sender, EventArgs e)
        {
            ChangeShiftByMemberIdAndTrainerId();
        }

        private void pnlCancleButtomInChangeMemberShift_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       

       
    }
}
