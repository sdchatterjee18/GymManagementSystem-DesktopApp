using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.Locker;
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Locker
{
    public class LockerBLL
    {
        // Properties
        public string LockerNo { get; set; }
        public string MemeberName { get; set; }
        public string Status { get; set; }

        // Retrieves all Locker details for displaying in the DataGridView.
        public DataTable RetrieveLockersBLL()
        {
            LockerDAL lockerDAL = new LockerDAL();
            return lockerDAL.RetrieveLockersDAL();
        }

        // Inserts a new Locker.
        public ValidationResult InsertNewLockerBLL()
        {
            ValidationBll.CommonValidationMessage result;

            result = ValidationBll.ValidateLockerNumber(this.LockerNo);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "LockerNumber",
                    Result = result,
                    Message = ValidationBll.GetValidationMessage(result)
                };
            }

            LockerDAL lockerDAL = new LockerDAL();

            string message = lockerDAL.AddNewLockerDAL(this.LockerNo);

            return new ValidationResult
            {
                FieldName = "",
                Result = ValidationBll.CommonValidationMessage.Valid,
                Message = message
            };
        }
    }
}
