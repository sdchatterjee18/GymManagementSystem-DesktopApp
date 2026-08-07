using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemBLLayer.ModulesBLLayer.Member;

namespace GymManagementSystem.FORMS.Member.UI
{
    public class MemberAllDetailsUI
    {
        //Member Personal Details
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int GenderId { get; set; }
        public int GenderName { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string EmergencyContact { get; set; }
        public byte[] ProfilePhoto { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? UpdatedAt { get; set; }

        //Membership Details
        public int MemberSubscriptionId { get; set; }
        public int MembershipPlanId { get; set; }
        public string MembershipPlanName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        //Shift Details
        public int ShiftId { get; set; }
        public string ShiftName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        //Assigned Trainer Details 
        public int TrainerId { get; set; }
        public int EmployeeId { get; set; }
        public string TrainerName { get; set; }
        public string TrainerPhoneNo { get; set; }
        public string Specialization { get; set; }
        public DateTime AssignDate { get; set; }

        //Locker Details
        public int LockerId { get; set; }
        public string LockerNo { get; set; }
        public string LockerStatus { get; set; }
        public int NeedLocker { get; set; }
        //Last Payment Details
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public string FeesType { get; set; }

        //Diet Plan Details
        public int DietPlanId { get; set; }
        public int CaloriesPerDay { get; set; }
        public string DietPlanDocument { get; set; }
        public string ConditionStatus { get; set; }

        //METHODS
        public string RegisterNewMemberUI()
        {
            MemberAllDetailsBLL memberBLL = new MemberAllDetailsBLL();

            memberBLL.FirstName = this.FirstName;
            memberBLL.MiddleName = this.MiddleName;
            memberBLL.LastName = this.LastName;
            memberBLL.GenderId = this.GenderId;
            memberBLL.PhoneNo = this.PhoneNo;
            memberBLL.EmailId = this.EmailId;
            memberBLL.City = this.City;
            memberBLL.District = this.District;
            memberBLL.State = this.State;
            memberBLL.EmergencyContact = this.EmergencyContact;
            memberBLL.ProfilePhoto = this.ProfilePhoto;

            // Membership
            memberBLL.MembershipPlanId = this.MembershipPlanId;

            // Payment
            memberBLL.PaymentMethod = this.PaymentMethod;
            memberBLL.FeesType = this.FeesType;

            // Shift
            memberBLL.ShiftId = this.ShiftId;

            // Diet
            memberBLL.DietPlanId = this.DietPlanId;

            // Locker
            memberBLL.NeedLocker = this.NeedLocker;

            return memberBLL.RegisterNewMemberBLL();
        }
        //Method:Retrieve shifts in combo box
    }
}
