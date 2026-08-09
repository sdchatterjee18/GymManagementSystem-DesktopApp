using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystemDALayer.Common;

namespace GymManagementSystemDALayer.ModulesDALayer.Member
{
    public class MemberAllDetailsDAL
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
        public int NeedLocker { get; set; }
        public string LockerNo { get; set; }
        public string LockerStatus { get; set; }

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

        public string InsertMembershipPlanDAL()
        {
            SqlParameter[] parameters =
            {
               new SqlParameter("@FirstName", this.FirstName),
               new SqlParameter("@MiddleName", this.MiddleName),
               new SqlParameter("@LastName", this.LastName),
               new SqlParameter("@GenderId", this.GenderId),
               new SqlParameter("@PhoneNo", this.PhoneNo),
               new SqlParameter("@EmailId", this.EmailId),
               new SqlParameter("@City", this.City),
               new SqlParameter("@District", this.District),
               new SqlParameter("@State", this.State),
               new SqlParameter("@EmergencyContact", this.EmergencyContact),
               new SqlParameter("@ProfilePhoto", this.ProfilePhoto),
               // Membership
               new SqlParameter("@MembershipPlanId", this.MembershipPlanId),
               // Payment
               new SqlParameter("@PaymentMethod", this.PaymentMethod),
               new SqlParameter("@FeesType", this.FeesType),
               // Shift
               new SqlParameter("@ShiftId", this.ShiftId),
               // Diet
               new SqlParameter("@DietPlanId", this.DietPlanId),
               // Locker
               new SqlParameter("@NeedLocker", this.NeedLocker)
            };

            return LookupDAL.InsertSpecificItem("spRegisterNewMember", parameters);
        }

        public  DataTable GetMemberDetailsByMemberId(int memberId)
        {
            return LookupDAL.RetrieveSpecificDetailsById(
                "spRetrieveRegisterMemberDetailsByMemberId",
                memberId,
                "@MemberId");
        }
    }
}
