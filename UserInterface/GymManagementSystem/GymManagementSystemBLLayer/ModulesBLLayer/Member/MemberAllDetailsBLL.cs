using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Member
{
    class MemberAllDetailsBLL
    {
        //Member Personal Details
        public int MemberId { get; set; }
        public string MemberName { get; set; }
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
    }
}
