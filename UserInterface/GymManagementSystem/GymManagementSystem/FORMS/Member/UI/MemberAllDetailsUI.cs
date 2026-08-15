using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemBLLayer.ModulesBLLayer.Member;
using System.Data;

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
        public string GenderName { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string EmergencyContact { get; set; }
        public byte[] ProfilePhoto { get; set; }
        public DateTime JoiningDate { get; set; }
        public string IsActive { get; set; }
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
        public string TrainerType { get; set; }
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
        public byte[] DietPlanDocument { get; set; }
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

        public MemberAllDetailsUI GetMemberDetailsByMemberId(int memberId)
        {
            MemberAllDetailsBLL memberAllDetailsBLL = new MemberAllDetailsBLL();
            DataTable dataTable = memberAllDetailsBLL.GetMemberDetailsByMemberId(memberId);
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                return null;
            }
            DataRow row = dataTable.Rows[0];
            MemberAllDetailsUI member = new MemberAllDetailsUI();

            //PERSONAL DETAILS
            member.MemberId = Convert.ToInt32(row["MemberId"]);
            member.MemberName = row["MemberName"].ToString();
            member.GenderName = row["Gender"].ToString();
            member.PhoneNo = row["PhoneNo"].ToString();
            member.EmailId = row["EmailId"].ToString();
            member.City = row["City"].ToString();
            member.District = row["District"].ToString();
            member.State = row["State"].ToString();
            member.EmergencyContact = row["EmergencyContact"].ToString();
            if (row["ProfilePhoto"] != DBNull.Value)
            {
                member.ProfilePhoto = (byte[])row["ProfilePhoto"];
            }
            else
            {
                member.ProfilePhoto = null;
            }
            member.JoiningDate = Convert.ToDateTime(row["JoiningDate"]);
            if (row["UpdatedAt"] != DBNull.Value)
            {
                member.UpdatedAt = Convert.ToDateTime(row["UpdatedAt"]);
            }
            else
            {
                member.UpdatedAt = DateTime.MinValue;
            }
            if (Convert.ToInt32(row["MemberStatus"]) == 1)
            {
                member.IsActive = "Active";
            }
            else
            {
                member.IsActive = "Inactive";
            }
            // MEMBERSHIP PLAN
            if (row["MembershipPlanId"] != DBNull.Value)
            {
                member.MembershipPlanId =
                    Convert.ToInt32(row["MembershipPlanId"]);

                member.MembershipPlanName =
                    row["MembershipPlanName"].ToString();

                if (row["StartDate"] != DBNull.Value)
                {
                    member.StartDate =
                        Convert.ToDateTime(row["StartDate"]);
                }

                if (row["ExpiryDate"] != DBNull.Value)
                {
                    member.ExpiryDate =
                        Convert.ToDateTime(row["ExpiryDate"]);
                }
            }
            else
            {
                member.MembershipPlanId = 0;
                member.MembershipPlanName = "";
                member.StartDate = DateTime.MinValue;
                member.ExpiryDate = DateTime.MinValue;
            }
            // SHIFT
            if (row["ShiftId"] != DBNull.Value)
            {
                member.ShiftId =
                    Convert.ToInt32(row["ShiftId"]);

                member.ShiftName =
                    row["ShiftName"].ToString();

                if (row["StartTime"] != DBNull.Value)
                {
                    member.StartTime =
                        (TimeSpan)row["StartTime"];
                }

                if (row["EndTime"] != DBNull.Value)
                {
                    member.EndTime =
                        (TimeSpan)row["EndTime"];
                }
            }
            else
            {
                member.ShiftId = 0;
                member.ShiftName = "";
                member.StartTime = TimeSpan.Zero;
                member.EndTime = TimeSpan.Zero;
            }

            //DIET PLAN
            if (row["DietPlanId"] != DBNull.Value)
            {
                member.DietPlanId =
                    Convert.ToInt32(row["DietPlanId"]);

                if (row["CaloriesPerDay"] != DBNull.Value)
                {
                    member.CaloriesPerDay =
                        Convert.ToInt32(row["CaloriesPerDay"]);
                }
                else
                {
                    member.CaloriesPerDay = 0;
                }

                if (row["ConditionStatus"] != DBNull.Value)
                {
                    member.ConditionStatus =
                        row["ConditionStatus"].ToString();
                }
                else
                {
                    member.ConditionStatus = "";
                }

                // Diet plan document
                if (row["DietPlanDocument"] != DBNull.Value)
                {
                    member.DietPlanDocument =
                        (byte[])row["DietPlanDocument"];
                }
                else
                {
                    member.DietPlanDocument = null;
                }
            }
            else
            {
                member.DietPlanId = 0;
                member.CaloriesPerDay = 0;
                member.ConditionStatus = "";
                member.DietPlanDocument = null;
            }


            // PROFILE PHOTO
            if (row["ProfilePhoto"] != DBNull.Value)
            {
                member.ProfilePhoto =
                    (byte[])row["ProfilePhoto"];
            }
            else
            {
                member.ProfilePhoto = null;
            }
            //TRAINER
            if (row["TrainerId"] != DBNull.Value)
            {
                member.TrainerId = Convert.ToInt32(row["TrainerId"]);
                member.TrainerName = row["TrainerName"].ToString();
                member.TrainerPhoneNo = row["TrainerPhoneNo"].ToString();
                member.TrainerType = row["TrainerType"].ToString();
                member.Specialization = row["Specialization"].ToString();
                if (row["AssignedDate"] != DBNull.Value)
                {
                    member.AssignDate = Convert.ToDateTime(row["AssignedDate"]);
                }
            }
            else
            {
                member.TrainerId = 0;
                member.TrainerName = "";
                member.TrainerPhoneNo = "";
                member.TrainerType = "";
                member.Specialization = "";
                member.AssignDate = DateTime.MinValue;
            }
            //LOCKER
            if (row["LockerId"] != DBNull.Value)
            {
                member.LockerId = Convert.ToInt32(row["LockerId"]);
                member.LockerNo = row["LockerNo"].ToString();
                member.LockerStatus = row["LockerStatus"].ToString();
            }
            else
            {
                member.LockerId = 0;
                member.LockerNo = "";
                member.LockerStatus = "";
            }
            //PAYMENT
            if (row["PaymentDate"] != DBNull.Value)
            {
                member.PaymentDate =
                    Convert.ToDateTime(row["PaymentDate"]);
            }
            member.PaymentMethod =
                row["PaymentMethod"].ToString();

            if (row["Amount"] != DBNull.Value)
            {
                member.Amount =
                    Convert.ToDecimal(row["Amount"]);
            }
            member.FeesType =
                row["FeesType"].ToString();

            return member;
        }

        // Display DataGridView
        public DataTable RetrieveAssignTrainerToMemberDetailsUI()
        {
            MemberAllDetailsBLL memberAllDetailsBLL = new MemberAllDetailsBLL();
            return memberAllDetailsBLL.RetrieveAssignTrainerToMemberDetailsBLL();
        }

        //Search by Phone Number

        public DataTable GetMemberTrainerAssignmentsByPhoneNo(string Search)
        {
            MemberAllDetailsBLL memberAllDetailsBLL = new MemberAllDetailsBLL();
            return memberAllDetailsBLL.GetMemberTrainerAssignmentsByPhoneNo(Search);
        }



    }
}
