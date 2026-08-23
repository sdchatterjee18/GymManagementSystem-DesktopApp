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

        public DataTable RetrieveEmployeeRoleTypesBLL()
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();

            return employeeDAL.RetrieveEmployeeRoleTypesDAL();
        }
        public string InsertEmployeeBLL()
        {
            ValidationBll.CommonValidationMessage result;

            // First Name
            result = ValidationBll.ValidateName(this.FirstName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            // Middle Name
            result = ValidationBll.ValidateName(this.MiddleName);

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

            // Convert BLL object to DAL object
            EmployeeDAL employeeDAL = new EmployeeDAL();

            employeeDAL.FirstName = this.FirstName;
            employeeDAL.MiddleName = this.MiddleName;
            employeeDAL.LastName = this.LastName;
            employeeDAL.GenderId = this.GenderId;
            employeeDAL.RoleId = this.RoleId;
            employeeDAL.PhoneNo = this.PhoneNo;
            employeeDAL.EmailId = this.EmailId;
            employeeDAL.BankAccountNo = this.BankAccountNo;
            employeeDAL.Amount = this.Amount;

            return employeeDAL.InsertEmployeeDAL();
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
