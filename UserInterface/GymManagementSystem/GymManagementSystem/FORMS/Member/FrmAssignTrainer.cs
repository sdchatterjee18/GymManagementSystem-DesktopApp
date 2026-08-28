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
    public partial class FrmAssignTrainer : Form
    {
        string AssignConfirmationMessage = "Are you sure for assigning trainer to Member ?";
        private MemberAllDetailsUI memberAllDetailsUI = null;
        public FrmAssignTrainer( MemberAllDetailsUI member)
        {
            InitializeComponent();
            memberAllDetailsUI = member;
        }

        private void ShowMemberIdNameShiftNameMembershipPlanExpiryDate()
        {
            lblRetrieveMemberIDInMemberInformation.Text =
                memberAllDetailsUI.MemberId.ToString();

            lblRetrieveMemberNameInMemberInformation.Text =
                memberAllDetailsUI.MemberName.ToString();

            lblRetrieveMemberCurrentShiftTime.Text =
                memberAllDetailsUI.ShiftName.ToString();

            lblRetrieveMemberActiveTime.Text =
               Convert.ToDateTime(memberAllDetailsUI.ExpiryDate).ToString("dd-MM-yyyy");
        }

        DataTable dataTable = null;
        private void RetrievePersonalTrainers()
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

        private void AssignTrainerToMember()
        {
            string AssignTrainerMessage = null;
            int MemberId = Convert.ToInt32(lblRetrieveMemberIDInMemberInformation.Text);

            ComboBox[] combobox = new ComboBox[]
                {
                    cmbSelectTrainer
                };

            //if (!ValidationUI.ValidateRequiredComboBoxes(combobox))
            //{
            //    return;  
            //}
            //else
            //{
            //    int trainerId = Convert.ToInt32(cmbSelectTrainer.SelectedValue);
            //    DialogResult result = MessageBox.Show
            //        (
            //         AssignConfirmationMessage,
            //         "Confirmation",
            //         MessageBoxButtons.YesNo,
            //         MessageBoxIcon.Question
            //        );

            //    if (result != DialogResult.Yes)
            //    {
            //        return;
            //    }
            //    try
            //    {
            //        MemberAllDetailsUI MemberAllDetailsUI = new MemberAllDetailsUI();
            //        AssignTrainerMessage = MemberAllDetailsUI.AssignTrainerToMemberUI(MemberId, trainerId);
            //       DialogResult Result= MessageBox.Show(AssignTrainerMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //       if (Result == DialogResult.OK)
            //       {
            //           this.Dispose();
                       
            //       }
            //    }
            //    catch (Exception Ex)
            //    {
            //        AssignTrainerMessage = null;
            //    }
            //}
        }

        private void RetrieveTrainerDetails(int TrainerId)
        {
            DataTable TrainerTable = null;
            try
            {
                MemberAllDetailsUI MemberAllDetailsUI = new MemberAllDetailsUI();

                TrainerTable = MemberAllDetailsUI.RetrieveTrainerDetailsUI(TrainerId);
                if (TrainerTable.Rows.Count > 0)
                {
                    DataRow row = TrainerTable.Rows[0];

                    lblTrainerIDRetrieve.Text =
                        row["TrainerId"].ToString();

                    lblTrainerNameRetrieve.Text =
                        row["TrainerName"].ToString();

                    lblRetrieveTrainerSpecialization.Text =
                        row["Specialization"].ToString();
                }
            }
            catch (Exception ex)
            {
                TrainerTable = null; 
            }
        }
        private void FrmAssignTrainer_Load(object sender, EventArgs e)
        {
            pnlDefaultTrainerSectionShow.Visible = true;
            pnlTrainerInformationSectionRetrieve.Visible = false;

            cmbSelectTrainer.SelectedIndex = -1;

            ShowMemberIdNameShiftNameMembershipPlanExpiryDate();
            RetrievePersonalTrainers();
            
        }

        private void cmbSelectTrainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbSelectTrainer.SelectedIndex != -1)
            {
                int trainerId =Convert.ToInt32(cmbSelectTrainer.SelectedValue);
                RetrieveTrainerDetails(trainerId);
                pnlDefaultTrainerSectionShow.Visible = false;
                pnlTrainerInformationSectionRetrieve.Visible = true;

                pnlTrainerInformationSectionRetrieve.BringToFront();
            }
            else
            {
                pnlDefaultTrainerSectionShow.Visible = true;
                pnlTrainerInformationSectionRetrieve.Visible = false;

                pnlDefaultTrainerSectionShow.BringToFront();
            }
            
        }

        private void tlpAssignButtonCreateInAssignPersonalTrainer_MouseEnter(object sender, EventArgs e)
        {
            this.tlpAssignButtonCreateInAssignPersonalTrainer.BackColor = Color.DarkGreen;
        }

        private void tlpAssignButtonCreateInAssignPersonalTrainer_MouseLeave(object sender, EventArgs e)
        {
            this.tlpAssignButtonCreateInAssignPersonalTrainer.BackColor = Color.ForestGreen;
        }

        private void tlpCancleImageAndLevel_MouseEnter(object sender, EventArgs e)
        {
            this.tlpCancleImageAndLevel.BackColor = Color.OrangeRed;
        }

        private void tlpCancleImageAndLevel_MouseLeave(object sender, EventArgs e)
        {
            this.tlpCancleImageAndLevel.BackColor = Color.Red;
        }

        private void pnlAssignButtontoAssignTrainerInAssignPersonalTrainer_Click(object sender, EventArgs e)
        {            
                AssignTrainerToMember();
        }

        private void pnlCancleButtonCreateInAssignPersonalTrainer_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}