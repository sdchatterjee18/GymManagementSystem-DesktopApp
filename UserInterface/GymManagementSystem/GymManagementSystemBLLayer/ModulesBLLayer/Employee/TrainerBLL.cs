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

        public string InsertTrainerBLL()
        {
            ValidationBll.CommonValidationMessage result;

            // =========================
            // Common Employee Validation
            // =========================

            result = ValidationBll.ValidateName(this.FirstName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            result = ValidationBll.ValidateName(this.MiddleName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            result = ValidationBll.ValidateName(this.LastName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            result = ValidationBll.ValidatePhoneNumber(this.PhoneNo);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            result = ValidationBll.ValidateEmail(this.EmailId);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            // =========================
            // Trainer Specific Validation
            // =========================

            result = ValidationBll.ValidateName(this.TrainerType);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            result = ValidationBll.ValidateName(this.Specialization);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            // =========================
            // BLL → DAL
            // =========================

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

            // Trainer Details
            employeeDAL.TrainerId = this.TrainerId;
            employeeDAL.TrainerType = this.TrainerType;
            employeeDAL.Specialization = this.Specialization;
            employeeDAL.Document = this.Document;

            return employeeDAL.InsertEmployeeDAL();
        }
      
    }
}
