using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemDALayer.ModulesDALayer.Employee;
using System.Data;
using GymManagementSystemDALayer.Common;
using System.Data.SqlClient;

namespace GymManagementSystemDALayer.ModulesDALayer.Employee
{
    public class EmployeeDAL
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int GenderId { get; set; }
        public int RoleId { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool IsActive { get; set; }
        public string BankAccountNo { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int AdminId { get; set; }
        public int SuperAdminID { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public DateTime LastLogin { get; set; }

        public int TrainerId { get; set; }
        public string TrainerType { get; set; }
        public string Specialization { get; set; }
        public byte[] Document { get; set; }

        public DataTable RetrieveEmployeeRoleTypesDAL()
        {
            return LookupDAL.GetComboBoxDetails(
                "spRetrieveEmployeeRoleTypes"
            );
        }

        public string InsertEmployeeDAL()
        {
            try
            {
                SqlParameter documentParam = new SqlParameter("@Document", SqlDbType.VarBinary);
                documentParam.Value = Document ?? (object)DBNull.Value;
                SqlParameter[] sqlParameters =
            {
                new SqlParameter("@FirstName", FirstName),

                new SqlParameter("@MiddleName",
                    string.IsNullOrWhiteSpace(MiddleName)
                        ? (object)DBNull.Value
                        : MiddleName),
                new SqlParameter("@LastName", LastName),
                new SqlParameter("@DateOfBirth",DateOfBirth),
                new SqlParameter("@GenderId", GenderId),
                new SqlParameter("@PhoneNo", PhoneNo),
                new SqlParameter("@EmailId", EmailId),
                new SqlParameter("@BankAccountNo", BankAccountNo),
                new SqlParameter("@RoleId", RoleId),
                new SqlParameter("@Amount", Amount),
                new SqlParameter("@UserName",
                    string.IsNullOrWhiteSpace(UserName)
                        ? (object)DBNull.Value
                        : UserName),
                new SqlParameter("@PasswordHash",
                    string.IsNullOrWhiteSpace(PasswordHash)
                        ? (object)DBNull.Value
                        : PasswordHash),
                new SqlParameter("@TrainerType",
                    string.IsNullOrWhiteSpace(TrainerType)
                        ? (object)DBNull.Value
                        : TrainerType),
                new SqlParameter("@Specialization",
                    string.IsNullOrWhiteSpace(Specialization)
                        ? (object)DBNull.Value
                        : Specialization),
                documentParam
            };

                return LookupDAL.InsertSpecificItem(
                    "spInsertEmployee",
                    sqlParameters);
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            
        }
        public DataTable DisplayAllEmployeeDetailsDAL()
        {
            return LookupDAL.GetComboBoxDetails(
                "spDisplayAllEmployeeDetails"
            );
        }
        public DataTable DisplayEmployeeDetailsByPhoneNoDAL(string phoneNo)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@PhoneNo", phoneNo)
            };
            return LookupDAL.RetrieveSpecificDetails(
                "spDisplayEmployeeDetailsByPhoneNo",
                sqlParameters
            );
        }
        public string ToggleEmployeeActiveStatusDAL(int employeeId)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@EmployeeId", employeeId)
            };
            return LookupDAL.UpdateSpecificItem(
                "spToggleEmployeeActiveStatus",
                sqlParameters
            );
        }
    }
}
