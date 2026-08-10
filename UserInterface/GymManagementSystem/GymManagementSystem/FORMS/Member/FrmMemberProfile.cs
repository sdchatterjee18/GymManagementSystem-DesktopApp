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

namespace GymManagementSystem.FORMS.Member
{
    public partial class FrmMemberProfile : Form
    {
        private MemberAllDetailsUI memberAllDetailsUI;

        public FrmMemberProfile(MemberAllDetailsUI member)
        {
            InitializeComponent();
            this.memberAllDetailsUI = member;
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

       
        //(200, 180, 240);

    }


}
