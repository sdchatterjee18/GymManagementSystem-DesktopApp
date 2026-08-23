using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Locker;
using GymManagementSystemBLLayer.Common;
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
        public ValidationResult InserNewLockerUI()
        {
            LockerBLL lockerBLL = new LockerBLL();
            lockerBLL.LockerNo = this.LockerNo;
            return lockerBLL.InsertNewLockerBLL();
        }
    }
}
