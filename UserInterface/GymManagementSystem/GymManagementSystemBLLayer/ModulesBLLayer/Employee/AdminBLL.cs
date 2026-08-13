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
        public string PasswordHash { get; set; }
        public DateTime LastLogin { get; set; }

        public string InsertAdminBLL()
        {
            ValidationBll.CommonValidationMessage result;

            // ==========================================
            // COMMON EMPLOYEE VALIDATION
            // ==========================================

            // First Name
            result = ValidationBll.ValidateName(this.FirstName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            // Middle Name - Optional
            result = ValidationBll.ValidateOptionalText(this.MiddleName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            // Last Name
            result = ValidationBll.ValidateName(this.LastName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            // Phone Number
            result = ValidationBll.ValidatePhoneNumber(this.PhoneNo);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            // Email
            result = ValidationBll.ValidateEmail(this.EmailId);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            // ==========================================
            // ADMIN VALIDATION
            // ==========================================

            // Username
            result = ValidationBll.ValidateUserName(this.UserName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            // Password
            result = ValidationBll.ValidatePassword(this.PasswordHash);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

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
            employeeDAL.PasswordHash = this.PasswordHash;

            // ==========================================
            // INSERT
            // ==========================================

            return employeeDAL.InsertEmployeeDAL();
        }
   
    }
}
