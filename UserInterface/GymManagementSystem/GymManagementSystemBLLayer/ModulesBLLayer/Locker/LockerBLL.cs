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
        public string InsertNewLockerBLL(string lockerNo)
        {
            try
            {
                //ValidationBll.CommonValidationMessage validationMessage =
                //    ValidationBll. // Has To be implemented 

                //if (validationMessage !=
                //    ValidationBll.CommonValidationMessage.Valid)
                //{
                //    return ValidationBll.GetValidationMessage(validationMessage);
                //}

                // Insert
                LockerDAL lockerDAL = new LockerDAL();

                return lockerDAL.AddNewLockerDAL(
                        lockerNo
                    );
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
