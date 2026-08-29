using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemBLLayer.Common;
using GymManagementSystemDALayer.ModulesDALayer.Employee;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Employee
{
    public class AdminBLL : EmployeeBLL
    {
        public int AdminId { get; set; }
        public int SuperAdminID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }

        public ValidationResult InsertAdminBLL()
        {
            ValidationBll.CommonValidationMessage result;

            // ==========================================
            // COMMON EMPLOYEE VALIDATION
            // ==========================================

            // =========================
            // FIRST NAME
            // =========================

            result = ValidationBll.ValidateOnlyLettersAndSpaces(this.FirstName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "FirstName",
                    Result = result,
                    Message = "FirstName"+ValidationBll.GetValidationMessage(result)
                };
            }


            // =========================
            // MIDDLE NAME - OPTIONAL
            // =========================

            if (!string.IsNullOrWhiteSpace(this.MiddleName))
            {
                result = ValidationBll.ValidateOnlyLettersAndSpaces(this.MiddleName);

                if (result != ValidationBll.CommonValidationMessage.Valid)
                {
                    return new ValidationResult
                    {
                        FieldName = "MiddleName",
                        Result = result,
                        Message = "MiddleName"+ValidationBll.GetValidationMessage(result)
                    };
                }
            }


            // =========================
            // LAST NAME
            // =========================

            result = ValidationBll.ValidateOnlyLettersAndSpaces(this.LastName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "LastName",
                    Result = result,
                    Message = "LastName"+ValidationBll.GetValidationMessage(result)
                };
            }


            // =========================
            // PHONE NUMBER
            // =========================

            result = ValidationBll.ValidatePhoneNumber(this.PhoneNo);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "PhoneNo",
                    Result = result,
                    Message = "PhoneNo"+ValidationBll.GetValidationMessage(result)
                };
            }


            // =========================
            // EMAIL
            // =========================

            result = ValidationBll.ValidateEmail(this.EmailId);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "EmailId",
                    Result = result,
                    Message = "EmailId"+ValidationBll.GetValidationMessage(result)
                };
            }

            // =========================
            // SALARY VALIDATION
            // =========================
            result = ValidationBll.ValidatePrice(this.Amount);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "Amount",
                    Result = result,
                    Message = "Salary"+ValidationBll.GetValidationMessage(result)
                };
            }
            // ==========================================
            // ADMIN VALIDATION
            // ==========================================

            // =========================
            // USERNAME
            // =========================

            result = ValidationBll.ValidateUserName(this.UserName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "UserName",
                    Result = result,
                    Message = "UserName"+ValidationBll.GetValidationMessage(result)
                };
            }


            // =========================
            // PASSWORD
            // =========================

            result = ValidationBll.ValidatePassword(this.Password);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "PasswordHash",
                    Result = result,
                    Message = "Password"+ValidationBll.GetValidationMessage(result)
                };
            }


            // ==========================================
            // HASH PASSWORD
            // ==========================================

            this.Password =
                PasswordHelperBLL.HashPassword(this.Password);


            // ==========================================
            // BLL → DAL
            // ==========================================

            EmployeeDAL employeeDAL = new EmployeeDAL();


            // ==========================================
            // COMMON EMPLOYEE DETAILS
            // ==========================================

            employeeDAL.FirstName = this.FirstName;
            employeeDAL.MiddleName = this.MiddleName;
            employeeDAL.LastName = this.LastName;
            employeeDAL.DateOfBirth = this.DateOfBirth;
            employeeDAL.GenderId = this.GenderId;
            employeeDAL.RoleId = this.RoleId;
            employeeDAL.PhoneNo = this.PhoneNo;
            employeeDAL.EmailId = this.EmailId;
            employeeDAL.BankAccountNo = this.BankAccountNo;
            employeeDAL.Amount = this.Amount;


            // ==========================================
            // ADMIN DETAILS
            // ==========================================

            employeeDAL.UserName = this.UserName;
            employeeDAL.PasswordHash = this.Password;


            // ==========================================
            // INSERT
            // ==========================================

            string message =employeeDAL.InsertEmployeeDAL();


            // ==========================================
            // RETURN SUCCESS RESULT
            // ==========================================

            return new ValidationResult
            {
                FieldName = "",
                Result = ValidationBll.CommonValidationMessage.Valid,
                Message = message
            };
        }
   
    }
}
