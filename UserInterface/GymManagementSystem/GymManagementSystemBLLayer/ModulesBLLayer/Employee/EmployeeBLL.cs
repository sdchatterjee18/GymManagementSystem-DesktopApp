using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemBLLayer.ModulesBLLayer.Employee;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.Employee;
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Employee
{
    public class EmployeeBLL
    {
        public int EmployeeId { get; set; }
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

        public DataTable RetrieveEmployeeRoleTypesBLL()
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();

            return employeeDAL.RetrieveEmployeeRoleTypesDAL();
        }
        public ValidationResult InsertEmployeeBLL()
        {
            ValidationBll.CommonValidationMessage result;

            // COMMON EMPLOYEE VALIDATION
            //------------------------------
            // FIRST NAME
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

            // MIDDLE NAME - OPTIONAL
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

            // LAST NAME
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
            // PHONE NUMBER
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
            // EMAIL
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

            // OBJECT CREATION
            EmployeeDAL employeeDAL = new EmployeeDAL();

            // EMPLOYEE INFORMATION
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

            // INSERT
            string message =employeeDAL.InsertEmployeeDAL();
            // RETURN SUCCESS RESULT
            return new ValidationResult
            {
                FieldName = "",
                Result = ValidationBll.CommonValidationMessage.Valid,
                Message = message
            };
        }


        public DataTable DisplayAllEmployeeDetailsBLL()
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();
            return employeeDAL.DisplayAllEmployeeDetailsDAL();
        }

        public DataTable DisplayEmployeeDetailsByPhoneNoBLL(string phoneNo)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();

            return employeeDAL.DisplayEmployeeDetailsByPhoneNoDAL(phoneNo);
        }
        public string ToggleEmployeeActiveStatusBLL(int employeeId)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();
            return employeeDAL.ToggleEmployeeActiveStatusDAL(employeeId);
        }
    }
}
