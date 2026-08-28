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



        public ValidationResult RegisterNewMemberBLL()
        {
            ValidationBll.CommonValidationMessage result;

            // =========================================================
            // FIRST NAME
            // =========================================================
            result = ValidationBll.ValidateName(this.FirstName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "FirstName",
                    Result = result,
                    Message = ValidationBll.GetValidationMessage(result)
                };
            }


            // =========================================================
            // MIDDLE NAME
            // =========================================================
            if (!string.IsNullOrWhiteSpace(this.MiddleName))
            {
                result = ValidationBll.ValidateName(this.MiddleName);

                if (result != ValidationBll.CommonValidationMessage.Valid)
                {
                    return new ValidationResult
                    {
                        FieldName = "MiddleName",
                        Result = result,
                        Message = ValidationBll.GetValidationMessage(result)
                    };
                }
            }


            // =========================================================
            // LAST NAME
            // =========================================================
            result = ValidationBll.ValidateName(this.LastName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "LastName",
                    Result = result,
                    Message = ValidationBll.GetValidationMessage(result)
                };
            }


            // =========================================================
            // DISTRICT
            // =========================================================
            result = ValidationBll.ValidateName(this.District);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "District",
                    Result = result,
                    Message = ValidationBll.GetValidationMessage(result)
                };
            }


            // =========================================================
            // STATE
            // =========================================================
            result = ValidationBll.ValidateName(this.State);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "State",
                    Result = result,
                    Message = ValidationBll.GetValidationMessage(result)
                };
            }


            // =========================================================
            // CITY
            // =========================================================
            result = ValidationBll.ValidateName(this.City);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "City",
                    Result = result,
                    Message = ValidationBll.GetValidationMessage(result)
                };
            }


            // =========================================================
            // PHONE NUMBER
            // =========================================================
            result = ValidationBll.ValidatePhoneNumber(this.PhoneNo);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "PhoneNo",
                    Result = result,
                    Message = ValidationBll.GetValidationMessage(result)
                };
            }


            // =========================================================
            // EMERGENCY CONTACT
            // =========================================================
            if (!string.IsNullOrWhiteSpace(this.EmergencyContact))
            {
                result = ValidationBll.ValidatePhoneNumber(this.EmergencyContact);

                if (result != ValidationBll.CommonValidationMessage.Valid)
                {
                    return new ValidationResult
                    {
                        FieldName = "EmergencyContact",
                        Result = result,
                        Message = ValidationBll.GetValidationMessage(result)
                    };
                }
            }


            // =========================================================
            // EMAIL
            // =========================================================
            result = ValidationBll.ValidateEmail(this.EmailId);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "EmailId",
                    Result = result,
                    Message = ValidationBll.GetValidationMessage(result)
                };
            }


            // =========================================================
            // CONVERT BLL OBJECT TO DAL OBJECT
            // =========================================================
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

            memberDAL.ShiftId = this.ShiftId;

            memberDAL.DietPlanId = this.DietPlanId;

            memberDAL.NeedLocker = this.NeedLocker;

            // =========================================================
            // DAL CALL
            // =========================================================
            string message = memberDAL.InsertNewMemberDAL();

            return new ValidationResult
            {
                FieldName = "",
                Result = ValidationBll.CommonValidationMessage.Valid,
                Message = message
            };
        }

        public DataTable GetMemberDetailsByMemberId(int memberId)
        {
            MemberAllDetailsDAL memberAllDetailsDAL = new MemberAllDetailsDAL();
            return memberAllDetailsDAL.GetMemberDetailsByMemberId(memberId);
        }
        public DataTable RetrieveRecentExpiredMembershipPlanBLL(int memberId)
        {
            DataTable dataTable = null;
            try
            {
                MemberAllDetailsDAL MemberAllDetailsDAL = new MemberAllDetailsDAL();
                dataTable = MemberAllDetailsDAL.RetrieveRecentExpiredMembershipPlanDAL(memberId);
                return dataTable;
            }
            catch (Exception ex)
            {
                return dataTable;
            }
        }

        public string RenewalMemberShipPlanBLL(int MemberId, int MemberShipPlanId, string PaymentMethod)
        {
            string RenewalMessage = null;
            try
            {
                MemberAllDetailsDAL MemberAllDetailsDAL = new GymManagementSystemDALayer.ModulesDALayer.Member.MemberAllDetailsDAL();
                RenewalMessage = MemberAllDetailsDAL.RenewalMemberShipPlanDAL(MemberId, MemberShipPlanId, PaymentMethod);
                return RenewalMessage;
            }
            catch (Exception ex)
            {
                return RenewalMessage;
            }
        }

        public DataTable RetrievePersonalTrainersBLL(int ShiftId)
        {
            DataTable dataTable = null;
            try
            {
                MemberAllDetailsDAL MemberAllDetailsDAL = new MemberAllDetailsDAL();
                dataTable = MemberAllDetailsDAL.RetrievePersonalTrainersDAL(ShiftId);
                return dataTable;
            }
            catch (Exception ex)
            {
                return dataTable;
            }
        }

        public string AssignTrainerToMemberBLL(int MemberId, int TrainerId)
        {
            string AssignTrainerMessage = null;
            try
            {
                MemberAllDetailsDAL MemberAllDetailsDAL = new MemberAllDetailsDAL();
                AssignTrainerMessage = MemberAllDetailsDAL.AssignTrainerToMemberDAL(MemberId, TrainerId);
                return AssignTrainerMessage;
            }
            catch (Exception Ex)
            {
                return AssignTrainerMessage;
            }
        }

        public DataTable RetrieveTrainerDetailsBLL(int TrainerId)
        {
            DataTable TrainerTable = null;
            try
            {
                MemberAllDetailsDAL MemberAllDetailsDAL = new MemberAllDetailsDAL();

                TrainerTable = MemberAllDetailsDAL.RetrieveTrainerDetailsDAL(TrainerId);
                return TrainerTable;
            }
            catch (Exception ex)
            {
                return TrainerTable;
            }

        }

        public string ChangeTrainerOfMemberByNewTrainerIdBLL(int MemberId, int NewTrainerId)
        {
            string ChangeTrainer = null;
            try
            {
                MemberAllDetailsDAL MemberAllDetailsDAL = new MemberAllDetailsDAL();
                ChangeTrainer = MemberAllDetailsDAL.ChangeTrainerOfMemberByNewTrainerIdDAL(MemberId,NewTrainerId);
                return ChangeTrainer;
            }
            catch (Exception ex)
            {
                return ChangeTrainer;
            }
        }

        public DataTable AvailableSlotsOfShiftBLL(int ShiftId)
        {
            DataTable dataTable = null;
            try
            {
                MemberAllDetailsDAL MemberAllDetailsDAL = new MemberAllDetailsDAL();
                dataTable = MemberAllDetailsDAL.AvailableSlotsOfShiftDAL(ShiftId);
                return dataTable;
            }
            catch (Exception ex)
            {
                return dataTable;
            }
        }

        public string ChangeShiftByMemberIdAndTrainerIdBLL(int MemberId, int NewShiftId)
        {
            string ChangeShiftMessage = null;
            try
            {
                MemberAllDetailsDAL MemberAllDetailsDAL = new MemberAllDetailsDAL();
                ChangeShiftMessage = MemberAllDetailsDAL.ChangeShiftByMemberIdAndTrainerIdDAL(MemberId, NewShiftId);
                return ChangeShiftMessage;
            }
            catch (Exception ex)
            {
                return ChangeShiftMessage;
            }
        }

        public DataTable RetrieveConditionStatusByDietPlanIdBLL(int DietPlanId)
        {
            DataTable dataTable = null;
            try
            {
                MemberAllDetailsDAL memberAllDetailsDAL = new MemberAllDetailsDAL();
                dataTable = memberAllDetailsDAL.RetrieveConditionStatusByDietPlanIdDAL(DietPlanId);
                return dataTable;
            }
            catch (Exception Ex)
            {
                return dataTable;
            }
        }

        public string ChangeMemberDietPlanBLL(int MemberId, int NewDietPlanId)
        {
            string ChangeDietPlanMessage = null;
            try
            {
                MemberAllDetailsDAL memberAllDetailsDAL = new MemberAllDetailsDAL();
                ChangeDietPlanMessage = memberAllDetailsDAL.ChangeMemberDietPlanDAL(MemberId,NewDietPlanId);
                return ChangeDietPlanMessage;
            }
            catch (Exception ex)
            {
                return ChangeDietPlanMessage;
            }

        }
        // Retrieves all Assign Trainer of Members details for displaying in the DataGridView.
        public DataTable RetrieveAssignTrainerToMemberDetailsBLL()
        {
            MemberAllDetailsDAL MemberAllDetailsDAL = new MemberAllDetailsDAL();
            return MemberAllDetailsDAL.RetrieveAssignTrainerToMemberDetailsDAL();
        }
        //Search by Phone Number

        public DataTable GetMemberTrainerAssignmentsByPhoneNo(string Search)
        {
            MemberAllDetailsDAL memberAllDetailsDAL = new MemberAllDetailsDAL();
            return memberAllDetailsDAL.GetMemberTrainerAssignmentsByPhoneNo(Search);
        }
    }
}
