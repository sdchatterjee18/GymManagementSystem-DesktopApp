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

        
        public string InsertNewMemberDAL()
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
        public DataTable RetrieveRecentExpiredMembershipPlanDAL(int memberId)
        {
            DataTable dataTable = null;
            try
            {
                SqlParameter[] sqlParameter = new SqlParameter[]
                {
                    new SqlParameter("@MemberId",memberId)
                };
                dataTable = LookupDAL.RetrieveSpecificDetails("spGetRecentExpiredMembershipPlan", sqlParameter);
                return dataTable;
            }
            catch (Exception ex)
            {
                return dataTable;
            }
        }

        public string RenewalMemberShipPlanDAL(int MemberId, int MemberShipPlanId, string PaymentMethod)
        {
            string RenewalMessage = null;
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@MemberId",MemberId),
                    new SqlParameter("@MembershipPlanId",MemberShipPlanId),
                    new SqlParameter("@PaymentMethod",PaymentMethod)
                };

                RenewalMessage = LookupDAL.InsertSpecificItem("spInsertDataIntoMembershipSubscriptionTableWhileReneweal", sqlParameters);
                return RenewalMessage;
            }
            catch (Exception ex)
            {
                return RenewalMessage;
            }
        }

        public DataTable RetrievePersonalTrainersDAL(int ShiftId)
        {
            DataTable dataTable = null;
            try
            {
                SqlParameter[] sqlParameter = new SqlParameter[]
                {
                    new SqlParameter("@ShiftId",ShiftId)
                };

                dataTable = LookupDAL.RetrieveSpecificDetails("spGetInactivePersonalTrainersByShift", sqlParameter);
                return dataTable;
            }
            catch (Exception ex)
            {
                return dataTable;
            }
        }

        public string AssignTrainerToMemberDAL(int MemberId, int TrainerId)
        {
            string AssignTrainerMessage = null;
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@MemberId",MemberId),
                    new SqlParameter("@TrainerId",TrainerId)
                };

                AssignTrainerMessage = LookupDAL.InsertSpecificItem("spAssignPersonalTrainerToMember", sqlParameters);
                return AssignTrainerMessage;
            }
            catch (Exception Ex)
            {
                return AssignTrainerMessage;
            }
        }

        public DataTable RetrieveTrainerDetailsDAL(int TrainerId)
        {
            DataTable TrainerTable = null;
            try
            {
                SqlParameter[] sqlParameter = new SqlParameter[]
                {
                    new SqlParameter("@TrainerId",TrainerId)
                };

                TrainerTable = LookupDAL.RetrieveSpecificDetails("spGetTrainerDetailsByTrainerId", sqlParameter);
                return TrainerTable;
            }
            catch (Exception ex)
            {
                return TrainerTable;
            }

        }

        public string ChangeTrainerOfMemberByNewTrainerIdDAL(int MemberId, int NewTrainerId)
        {
            string ChangeTrainer = null;
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@MemberId",MemberId),
                    new SqlParameter("@NewTrainerId",NewTrainerId)
                };
                ChangeTrainer = LookupDAL.InsertSpecificItem("spChangePersonalTrainer", sqlParameters);
                return ChangeTrainer;
            }
            catch (Exception ex)
            {
                return ChangeTrainer;
            }
        }

        public DataTable AvailableSlotsOfShiftDAL(int ShiftId)
        {
            DataTable dataTable = null;
            try
            {
                SqlParameter[] sqlParameter = new SqlParameter[]
                {
                    new SqlParameter("@ShiftId",ShiftId)
                };
                dataTable = LookupDAL.RetrieveSpecificDetails("spGetAvailableShiftSlots", sqlParameter);
                return dataTable;
            }
            catch (Exception ex)
            {
                return dataTable;
            }
        }

        public string ChangeShiftByMemberIdAndTrainerIdDAL(int MemberId,int NewShiftId)
        {
            string ChangeShiftMessage = null;
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@MemberId",MemberId),
                    new SqlParameter("@NewShiftId",NewShiftId)
                };
                ChangeShiftMessage = LookupDAL.InsertSpecificItem("spChangeMemberShift", sqlParameters);
                return ChangeShiftMessage;
            }
            catch(Exception ex)
            {
                return ChangeShiftMessage;
            }
        }

        public DataTable RetrieveConditionStatusByDietPlanIdDAL(int DietPlanId)
        {
            DataTable dataTable = null;
            try
            {
                SqlParameter[] sqlParameter = new SqlParameter[]
                {
                    new SqlParameter("@DietPlanId",DietPlanId)
                };
                dataTable = LookupDAL.RetrieveSpecificDetails("spRetrieveConditionStatusByDietPlanId", sqlParameter);
                return dataTable;
            }
            catch (Exception Ex)
            {
                return dataTable;
            }
        }

        public string ChangeMemberDietPlanDAL(int MemberId, int NewDietPlanId)
        {
            string ChangeDietPlanMessage = null;
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@MemberId",MemberId),
                    new SqlParameter("@NewDietPlanId",NewDietPlanId)
                };

                ChangeDietPlanMessage = LookupDAL.InsertSpecificItem("spChangeMemberDietPlan", sqlParameters);
                return ChangeDietPlanMessage;
            }
            catch (Exception ex)
            {
                return ChangeDietPlanMessage;
            }
        }
        // Retrieves all Assign Trainer of Members details for displaying in the DataGridView.
        public DataTable RetrieveAssignTrainerToMemberDetailsDAL()
        {
            DataTable dataTable = LookupDAL.RetrieveSpecificItem("spRetrieveAllMemberTrainerAssignmentsDetails");
            return dataTable;
        }

        //Search by Phone Number

        public DataTable GetMemberTrainerAssignmentsByPhoneNo(string Search)
        {

            SqlParameter[] parameters = { new SqlParameter("@Search", Search) };

            return LookupDAL.RetrieveSpecificDetails("spRetrieveMemberTrainerAssignmentsDetailsByMemberPhoneNo", parameters);
        }
    }
}
