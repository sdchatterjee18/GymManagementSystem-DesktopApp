using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystemBLLayer.Common;
using GymManagementSystemDALayer.ModulesDALayer.RegistrationFee;

namespace GymManagementSystemBLLayer.ModulesBLLayer.RegistrationFee
{
    public class RegistrationBLL
    {

        // Data property
        public int RegistrationFeesId { get; set; }
        public decimal FeeAmount { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public DataTable RetriveAllRegistrationFeeBll()
        {
            RegistrtionFeeDAL registrtionFeeDAL= new RegistrtionFeeDAL();
            return registrtionFeeDAL.RetriveAllRegistrationFeesDAL();

        }


        public string InsertRegistrationFeesBLL()
        {
            RegistrtionFeeDAL registrtionFeeDAL = new RegistrtionFeeDAL();

            registrtionFeeDAL.FeeAmount = this.FeeAmount;


            return registrtionFeeDAL.InsertRegistrationFeeDAL();
        }

        public string ValidateRegistrationFeesBLL(string feeAmount)
        {
            ValidationBll.CommonValidationMessage result;

            // Call common ValidatePrice() method
            result = ValidationBll.ValidatePrice(feeAmount);

            if (result != ValidationBll.CommonValidationMessage.Valid)
                return ValidationBll.GetValidationMessage(result);

            return string.Empty;
        }

    }
}
