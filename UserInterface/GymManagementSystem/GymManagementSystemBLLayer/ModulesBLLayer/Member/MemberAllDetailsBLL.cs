using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.Common;
using GymManagementSystemDALayer.ModulesDALayer.Member;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Member
{
    public class MemberAllDetailsBLL
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
        public string FeesType { get; set; }
        public decimal Amount { get; set; }

        //Diet Plan Details
        public int DietPlanId { get; set; }
        public int CaloriesPerDay { get; set; }
        public string DietPlanDocument { get; set; }
        public string ConditionStatus { get; set; }

        public string RegisterNewMember()
        {

            // Business Validations
            string validationMessage;

            //validationMessage = ValidationBll.ValidateName(memberBLL.FirstName);
            //if (validationMessage != null)
            //    return validationMessage;

            //validationMessage = ValidationBll.ValidateName(memberBLL.LastName);
            //if (validationMessage != null)
            //    return validationMessage;

            //validationMessage = ValidationBll.ValidatePhoneNumber(memberBLL.PhoneNo);
            //if (validationMessage != null)
            //    return validationMessage;

            //validationMessage = ValidationBll.ValidateEmail(memberBLL.EmailId);
            //if (validationMessage != null)
            //    return validationMessage;

            // Convert BLL object to DAL object
            MemberAllDetailsDAL memberDAL = new MemberAllDetailsDAL();

            memberDAL.FirstName = this.FirstName;
            memberDAL.MiddleName = this.MiddleName;
            memberDAL.LastName = this.LastName;
            memberDAL.GenderId = this.GenderId;
            memberDAL.PhoneNo = this.PhoneNo;
            memberDAL.EmailId = this.EmailId;
            memberDAL.City = this.City;
            memberDAL.District = this.District;
            memberDAL.State = this.State;
            memberDAL.EmergencyContact = this.EmergencyContact;
            memberDAL.ProfilePhoto = this.ProfilePhoto;
            memberDAL.MembershipPlanId = this.MembershipPlanId;
            memberDAL.PaymentMethod = this.PaymentMethod;
            memberDAL.FeesType = this.FeesType;
            memberDAL.ShiftId = this.ShiftId;
            memberDAL.DietPlanId = this.DietPlanId;
            memberDAL.NeedLocker = this.NeedLocker;
            return null;
        }
    }
}
