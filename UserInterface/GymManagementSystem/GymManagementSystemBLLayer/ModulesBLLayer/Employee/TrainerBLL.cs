using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemBLLayer.Common;
using GymManagementSystemDALayer.ModulesDALayer.Employee;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Employee
{
    public class TrainerBLL : EmployeeBLL
    {
        public int TrainerId { get; set; }
        public string TrainerType { get; set; }
        public string Specialization { get; set; }
        public byte[] Document { get; set; }

        public List<string> GetTrainerTypesBLL()
        {
            List<string> trainerTypes = new List<string>();
            trainerTypes.Add("Personal");
            trainerTypes.Add("General");
            return trainerTypes;
        }

        public ValidationResult InsertTrainerBLL()
        {
            ValidationBll.CommonValidationMessage result;

            // =========================
            // COMMON EMPLOYEE VALIDATION
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
            // MIDDLE NAME VALIDATION
            // =========================

            // Middle Name is optional, so validate only if entered

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
            // LAST NAME VALIDATION
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
            // PHONE NUMBER VALIDATION
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
            // EMAIL VALIDATION
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
                    Message = "Amount"+ValidationBll.GetValidationMessage(result)
                };
            }

            // =========================
            // BLL → DAL
            // =========================

            EmployeeDAL employeeDAL = new EmployeeDAL();


            // =========================
            // EMPLOYEE INFORMATION
            // =========================

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


            // =========================
            // TRAINER INFORMATION
            // =========================

            employeeDAL.TrainerId = this.TrainerId;
            employeeDAL.TrainerType = this.TrainerType;
            employeeDAL.Specialization = this.Specialization;
            employeeDAL.Document = this.Document;

            string message = employeeDAL.InsertEmployeeDAL();

            return new ValidationResult
            {
                FieldName = "",
                Result = ValidationBll.CommonValidationMessage.Valid,
                Message = message
            };
        }
      
    }
}
