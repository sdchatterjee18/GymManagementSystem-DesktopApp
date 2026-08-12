using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Locker;

namespace GymManagementSystem.FORMS.Locker.UI
{
    public class LockerUI
    {
        // Properties
        public string LockerNo { get; set; }
        public string MemeberName { get; set; }
        public string Status { get; set; }

        // Display DataGridView
        public DataTable RetrieveLockersUI()
        {
            LockerBLL lockerBLL = new LockerBLL();
            return lockerBLL.RetrieveLockersBLL();
        }

        // Add New Locker through the business layer.
        public string InserNewLockerUI(string lockerNo)
        {
            try
            {
                LockerBLL lockerBLL = new LockerBLL();

                return lockerBLL.InsertNewLockerBLL(
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
