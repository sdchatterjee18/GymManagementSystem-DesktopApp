using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using GymManagementSystem.FORMS.Member.UI;
using System.Drawing;
using System.IO;
using GymManagementSystem.FORMS.Main;

namespace GymManagementSystem.FORMS.Member
{
    
    public partial class FrmMemberProfile : Form
    {
        string ShiftSelectionMessage = "You need to assign a shift to the member.";
        string MembershipExpireNotNullMessage = "Member is already assign to a membership Plan";
        string MemberTrainerAssignmentNotNullMessage = "Member is already assign to a Trainer";
        string MemberIsActive = "Member is not active";
        string InfoMessage = "Info";
        string AssignedTrainerMessage = "Member is already assign to a Trainer";
        string ActiveTrainerMessage = "This member does not have an assigned trainer. Please assign a trainer first.";
        private MemberAllDetailsUI memberAllDetailsUI = null;
        public FrmMemberProfile(MemberAllDetailsUI member)
        {
            InitializeComponent();
            memberAllDetailsUI = member;
        }
        private void LoadMemberDetails()
        {
            // =========================================================
            // BASIC MEMBER DETAILS
            // =========================================================

            lblRetrieveMemberId.Text =
                memberAllDetailsUI.MemberId.ToString();

            lblMemberName.Text =
                memberAllDetailsUI.MemberName;

            lblRetrieveMemberGenderName.Text =
                memberAllDetailsUI.GenderName;

            lblRetrievePhoneNo.Text =
                memberAllDetailsUI.PhoneNo;

            lblRetrieveEmailId.Text =
                memberAllDetailsUI.EmailId;

            lblRetrieveAddress.Text =
                memberAllDetailsUI.City + ", " +
                memberAllDetailsUI.District + ", " +
                memberAllDetailsUI.State;

            lblRetrieveEmergencyContact.Text =
                memberAllDetailsUI.EmergencyContact;

            lblRetrieveJoiningDate.Text =
                memberAllDetailsUI.JoiningDate.ToString("dd-MM-yyyy");
                lblRetrieveUpdatedDateAndTime.Text =
                    Convert.ToDateTime(memberAllDetailsUI.UpdatedAt)
                    .ToString("dd-MM-yyyy hh:mm tt");

            lblRetrieveMemberStatus.Text =
                memberAllDetailsUI.IsActive;


            // =========================================================
            // PROFILE PHOTO
            // =========================================================

            if (memberAllDetailsUI.ProfilePhoto != null &&
                memberAllDetailsUI.ProfilePhoto.Length > 0)
            {
                using (MemoryStream ms =
                    new MemoryStream(memberAllDetailsUI.ProfilePhoto))
                {
                    PicMemberPicture.Image =
                        Image.FromStream(ms);
                }
            }
            else
            {
                PicMemberPicture.Image = null;
            }


            // =========================================================
            // MEMBERSHIP PLAN
            // =========================================================

            if (memberAllDetailsUI.MembershipPlanId != 0)
            {
                lblRetrieveMembershipPlanName.Text =
                    memberAllDetailsUI.MembershipPlanName;

                lblRetrieveStartingDateTitle.Text =
                    memberAllDetailsUI.StartDate.ToString("dd-MM-yyyy");

                lblRetrieveExpiryDate.Text =
                    memberAllDetailsUI.ExpiryDate.ToString("dd-MM-yyyy");
            }
            else
            {
                lblRetrieveMembershipPlanName.Text = "";
                lblRetrieveStartingDateTitle.Text = "";
                lblRetrieveExpiryDate.Text = "";
            }


            // =========================================================
            // SHIFT
            // =========================================================

            if (memberAllDetailsUI.ShiftId != 0)
            {
                lblRetrieveShiftName.Text =
                    memberAllDetailsUI.ShiftName;

                lblShiftStartTime.Text =
                    memberAllDetailsUI.StartTime.ToString();

                lblShiftEndTime.Text =
                    memberAllDetailsUI.EndTime.ToString();
            }
            else
            {
                lblRetrieveShiftName.Text = "";
                lblShiftStartTime.Text = "";
                lblShiftEndTime.Text = "";
            }


            // =========================================================
            // DIET PLAN
            // =========================================================

            if (memberAllDetailsUI.DietPlanId != 0)
            {
                lblRetrieveDietPlanName.Text =
                    memberAllDetailsUI.ConditionStatus;

                lblRetrieveDietPlanConditionName.Text =
                    memberAllDetailsUI.ConditionStatus;
            }
            else
            {
                lblRetrieveDietPlanName.Text = "";
                lblRetrieveDietPlanConditionName.Text = "";
            }

            if (memberAllDetailsUI.DietPlanDocument != null &&
                memberAllDetailsUI.DietPlanDocument.Length > 0)
            {
                using (MemoryStream ms =
                    new MemoryStream(memberAllDetailsUI.DietPlanDocument))
                {
                    picDietPlanDocument.Image =
                        Image.FromStream(ms);
                }
            }
            else
            {
                picDietPlanDocument = null;
            }


            // =========================================================
            // LOCKER
            // =========================================================

            if (memberAllDetailsUI.LockerId != 0)
            {
                lblRetrieveLockerNo.Text =
                    memberAllDetailsUI.LockerNo;

                lblLockerStatus.Text =
                    memberAllDetailsUI.LockerStatus;
            }
            else
            {
                lblRetrieveLockerNo.Text = "";
                lblLockerStatus.Text = "";
            }


            // =========================================================
            // PAYMENT
            // =========================================================

            if (memberAllDetailsUI.PaymentDate != DateTime.MinValue)
            {
                lblRetrievePaymentDate.Text =
                    memberAllDetailsUI.PaymentDate.ToString("dd-MM-yyyy");

                lblRetrievePaymentMethod.Text =
                    memberAllDetailsUI.PaymentMethod;

                lblRetrievePaymentAmount.Text =
                    "₹ " + memberAllDetailsUI.Amount.ToString("N2");

                lblRetrievePaymentFeesType.Text =
                    memberAllDetailsUI.FeesType;
            }
            else
            {
                lblRetrievePaymentDate.Text = "";
                lblRetrievePaymentMethod.Text = "";
                lblRetrievePaymentAmount.Text = "";
                lblRetrievePaymentFeesType.Text = "";
            }


            // =========================================================
            // TRAINER
            // =========================================================

            if (memberAllDetailsUI.TrainerId != 0)
            {
                lblRetrieveTrainerName.Text =
                    memberAllDetailsUI.TrainerName;

                lblRetrieveTrainerPhoneNo.Text =
                    memberAllDetailsUI.TrainerPhoneNo;

                lblRetrieveTrainerSpecialization.Text =
                    memberAllDetailsUI.Specialization;

                lblRetrieveTrainerAssignedDate.Text =
                    memberAllDetailsUI.AssignDate.ToString("dd-MM-yyyy");
            }
            else
            {
                lblRetrieveTrainerName.Text = "";
                lblRetrieveTrainerPhoneNo.Text = "";
                lblRetrieveTrainerSpecialization.Text = "";
                lblRetrieveTrainerAssignedDate.Text = "";
            }
        }
        private void FrmMemberProfile_Load(object sender, EventArgs e)
        {
            LoadMemberDetails();
        }

        private void tlpMiddlePartMemberNameAndIcon_MouseEnter(object sender, EventArgs e)
        {
            this.tlpMiddlePartMemberNameAndIcon.BackColor = Color.Navy;
        }

        private void tlpMiddlePartMemberNameAndIcon_MouseLeave(object sender, EventArgs e)
        {
            this.tlpMiddlePartMemberNameAndIcon.BackColor = Color.FromArgb(0, 0, 152);
        }

        private void tlpRenewMembershipPlan_MouseEnter(object sender, EventArgs e)
        {
            this.tlpRenewMembershipPlan.BackColor = Color.Purple;
        }

        private void tlpRenewMembershipPlan_MouseLeave(object sender, EventArgs e)
        {
            this.tlpRenewMembershipPlan.BackColor = Color.MediumOrchid;
        }

        private void tlpAssignTrainerButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpAssignTrainerButton.BackColor = Color.Navy; 
        }

        private void tlpAssignTrainerButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpAssignTrainerButton.BackColor = Color.RoyalBlue; 
        }

        private void tlpChangeTrainerButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpChangeTrainerButton.BackColor = Color.Navy; 
        }

        private void tlpChangeTrainerButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpChangeTrainerButton.BackColor = Color.RoyalBlue;
        }

        private void lblChangeTrainer_MouseLeave(object sender, EventArgs e)
        {
            this.tlpChangeTrainerButton.BackColor = Color.RoyalBlue;
        }

        private void picChangeTrainer_MouseLeave(object sender, EventArgs e)
        {
            this.tlpChangeTrainerButton.BackColor = Color.RoyalBlue;
        }

        private void tlpChangeShiftButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpChangeShiftButton.BackColor = Color.DarkOliveGreen;
        }

        private void tlpChangeShiftButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpChangeShiftButton.BackColor = Color.OliveDrab;
        }

        private void tlpChangeDietPlan_MouseEnter(object sender, EventArgs e)
        {
            this.tlpChangeDietPlan.BackColor = Color.Red;
        }

        private void tlpChangeDietPlan_MouseLeave(object sender, EventArgs e)
        {
            this.tlpChangeDietPlan.BackColor = Color.Crimson;
        }

        private void pnlRenewMembershipPlan_Click(object sender, EventArgs e)
        {

            
        }

        private void tlpRenewMembershipPlan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpAssignTrainerButton_Click(object sender, EventArgs e)
        {

            if (memberAllDetailsUI.TrainerId != 0)
            {
                MessageBox.Show(MemberTrainerAssignmentNotNullMessage, InfoMessage, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (memberAllDetailsUI.IsActive == "InActive")
            {
                MessageBox.Show(MemberIsActive, InfoMessage, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (memberAllDetailsUI.ShiftId == 0)
            {
                MessageBox.Show(ShiftSelectionMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (memberAllDetailsUI.TrainerId != 0)
            {
                MessageBox.Show(AssignedTrainerMessage, InfoMessage, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                FrmAssignTrainer FrmAssignTrainer = new FrmAssignTrainer(memberAllDetailsUI);
                FrmAssignTrainer.ShowDialog();
            }
            MemberAllDetailsUI member = memberAllDetailsUI.GetMemberDetailsByMemberId(memberAllDetailsUI.MemberId);
            this.memberAllDetailsUI = member;
            LoadMemberDetails();
        }

        private void pnlChangeShiftButton_Click(object sender, EventArgs e)
        {
            if (memberAllDetailsUI.IsActive == "InActive")
            {
                MessageBox.Show(MemberIsActive, InfoMessage, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                FrmChangeShift FrmChangeShift = new FrmChangeShift(memberAllDetailsUI);
                FrmChangeShift.ShowDialog();
            }
            MemberAllDetailsUI member = memberAllDetailsUI.GetMemberDetailsByMemberId(memberAllDetailsUI.MemberId);
            this.memberAllDetailsUI = member;
            LoadMemberDetails();

        }

        private void tlpChangeTrainerButton_Click(object sender, EventArgs e)
        {
            if (memberAllDetailsUI.IsActive == "InActive")
            {
                MessageBox.Show(MemberIsActive, InfoMessage, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (memberAllDetailsUI.TrainerId == 0)
            {
                MessageBox.Show(ActiveTrainerMessage, InfoMessage, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                FrmChangeTrainer FrmChangeTrainer = new FrmChangeTrainer(memberAllDetailsUI);
                FrmChangeTrainer.ShowDialog();
            }
            MemberAllDetailsUI member = memberAllDetailsUI.GetMemberDetailsByMemberId(memberAllDetailsUI.MemberId);
            this.memberAllDetailsUI = member;
            LoadMemberDetails();
        }

        private void pnlChangeDietPlanButton_Click(object sender, EventArgs e)
        {
            if (memberAllDetailsUI.IsActive == "InActive")
            {
                MessageBox.Show(MemberIsActive, InfoMessage, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            
            else
            {
                FrmChangeDietPlan FrmChangeDietPlan = new FrmChangeDietPlan(memberAllDetailsUI);
                FrmChangeDietPlan.ShowDialog();
            }
            MemberAllDetailsUI member = memberAllDetailsUI.GetMemberDetailsByMemberId(memberAllDetailsUI.MemberId);
            this.memberAllDetailsUI = member;
            LoadMemberDetails();
        }

        private void pnlRenewMembershipPlan_Click_1(object sender, EventArgs e)
        {
            if (memberAllDetailsUI.MembershipPlanId != 0)
            {
                MessageBox.Show(MembershipExpireNotNullMessage, InfoMessage, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (memberAllDetailsUI.IsActive == "InActive")
            {
                MessageBox.Show(MemberIsActive, InfoMessage, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                FrmMembershipRenewal frmMembershipRenewal = new FrmMembershipRenewal(memberAllDetailsUI);
                frmMembershipRenewal.ShowDialog();
            }
            MemberAllDetailsUI member = memberAllDetailsUI.GetMemberDetailsByMemberId(memberAllDetailsUI.MemberId);
            this.memberAllDetailsUI = member;
            LoadMemberDetails();
        }

        

    }


}
