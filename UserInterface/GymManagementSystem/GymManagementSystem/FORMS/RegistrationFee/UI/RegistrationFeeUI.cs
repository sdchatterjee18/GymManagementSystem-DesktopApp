using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.RegistrationFee;

namespace GymManagementSystem.FORMS.RegistrationFee.UI
{
    class RegistrationFeeUI
    {
        // Data property
        public int RegistrationFeesId { get; set; }
        public decimal FeeAmount { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public DataTable RetrieveRegistrationFeesUI()
        {
            RegistrationBLL registrationBLL = new RegistrationBLL();
            return registrationBLL.RetriveAllRegistrationFeeBll();
        }

        public string InsertRegistrationFeeUI()
        {
            RegistrationBLL registrationBLL = new RegistrationBLL();

            registrationBLL.FeeAmount = this.FeeAmount;

            return registrationBLL.InsertRegistrationFeesBLL();
        }

        //public string ValidateRegistrationFeeUI(decimal FeeAmount)
        //{
        //    RegistrationBLL registrationBLL = new RegistrationBLL();
        //    return registrationBLL.ValidateRegistrationFeesBLL(FeeAmount);
        //}


    }
}
