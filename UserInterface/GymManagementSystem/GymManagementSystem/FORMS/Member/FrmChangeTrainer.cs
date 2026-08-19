using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.FORMS.Member.UI;
using GymManagementSystem.Common;

namespace GymManagementSystem.FORMS.Member
{
    public partial class FrmChangeTrainer : Form
    {
        string ChangeConfirmationMessage = " Are you sure for change Trainer?";
        string IsSelectTrainerMessage = "Please select a trainer.";
        string Info = "Validation";
        string TrainerChangeSuccessMessage = "Trainer is Changed successfylly.";
        string Information = "Info";
        private MemberAllDetailsUI memberAllDetailsUI = null;
        public FrmChangeTrainer(MemberAllDetailsUI member)
        {
            InitializeComponent();
            memberAllDetailsUI = member;
        }

        private void FrmChangeTrainer_Load(object sender, EventArgs e)
        {
            ShowMemberIdNameShiftNameMembershipPlanExpiryDate();
            RetrievePersonalTrainersByShift();
        }
        private void ShowMemberIdNameShiftNameMembershipPlanExpiryDate()
        {
            lblRetrieveMemberIDInChangePersonalTrainer.Text =
                memberAllDetailsUI.MemberId.ToString();
            lblRetrieveMemberNameInChangePersonalTrainer.Text =
                memberAllDetailsUI.MemberName.ToString();
            lblRetrieveCurrentShiftInChangePersonalTrainer.Text =
                memberAllDetailsUI.ShiftName.ToString();
            lblRetrieveMemberMembershipStatusActiveTimeInChangePersonalTrainer.Text =
                Convert.ToDateTime(memberAllDetailsUI.ExpiryDate).ToString("dd-MM-yyyy");
            lblRetrieveTrainerIDInChangePersonalTrainer.Text =
                memberAllDetailsUI.TrainerId.ToString();
            lblRetrieveTrainerNameInChangePersonalTrainer.Text =
                memberAllDetailsUI.TrainerName.ToString();
            lblRetrieveTrainerSpecializationInChangePersonalTrainer.Text =
                memberAllDetailsUI.Specialization.ToString();
        }
        DataTable dataTable = null;
        private void RetrievePersonalTrainersByShift()
        {
            int ShiftId = memberAllDetailsUI.ShiftId;

            try
            {
                MemberAllDetailsUI MemberAllDetailsUI = new MemberAllDetailsUI();
                dataTable = MemberAllDetailsUI.RetrievePersonalTrainersUI(ShiftId);
                cmbSelectTrainer.DataSource = null;
                cmbSelectTrainer.DisplayMember = "TrainerName";
                cmbSelectTrainer.ValueMember = "TrainerId";
                cmbSelectTrainer.DataSource = dataTable;
                cmbSelectTrainer.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                dataTable = null;
            }
        }

        private void ChangeTrainerOfMemberByNewTrainerId()
        {
            ComboBox[] combobox = new ComboBox[]
                {
                    cmbSelectTrainer
                };

            if (!ValidationUI.ValidateRequiredComboBoxes(combobox))
            {
                return;
            }
            else
            {

                DialogResult result = MessageBox.Show
                    (
                     ChangeConfirmationMessage,
                     "Confirmation",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question
                    );

                if (result != DialogResult.Yes)
                {
                    return;
                }
                int MemberId = memberAllDetailsUI.MemberId;
                int NewTrainerId = Convert.ToInt32(cmbSelectTrainer.SelectedValue);
                string ChangeTrainer = null;
                try
                {
                    MemberAllDetailsUI MemberAllDetailsUI = new MemberAllDetailsUI();
                    ChangeTrainer = MemberAllDetailsUI.ChangeTrainerOfMemberByNewTrainerIdUI(MemberId, NewTrainerId);
                    DialogResult Result = MessageBox.Show(ChangeTrainer, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Result == DialogResult.OK)
                    {
                        this.Dispose();
                    }

                }
                catch (Exception ex)
                {
                    ChangeTrainer = null;
                }
            }
        }

        private void tlpRegisterButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpAssignButton.BackColor = Color.DarkGreen;
        }

        private void tlpRegisterButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpAssignButton.BackColor = Color.ForestGreen;
        }

        private void tlpCancleSection_MouseEnter(object sender, EventArgs e)
        {
            this.tlpCancleSection.BackColor = Color.OrangeRed;
        }

        private void tlpCancleSection_MouseLeave(object sender, EventArgs e)
        {
            this.tlpCancleSection.BackColor = Color.Red;
        }

        private void pnlCancleButtom_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pnlRegisterButton_Click(object sender, EventArgs e)
        {
            if (cmbSelectTrainer.SelectedIndex == -1)
            {
                MessageBox.Show(
                    IsSelectTrainerMessage,
                    Info,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbSelectTrainer.Focus();

                return;
            }
            
                ChangeTrainerOfMemberByNewTrainerId();

               
            
        }

        private void cmbSelectTrainer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
