using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Shift;
using GymManagementSystemDALayer.Common;
using GymManagementSystemDALayer.ModulesDALayer.Shift;
using GymManagementSystemBLLayer.ModulesBLLayer.MembershipPlan;
using GymManagementSystemDALayer.ModulesDALayer.MembershipPlan;
using GymManagementSystemBLLayer.ModulesBLLayer.DietPlan;
using GymManagementSystemDALayer.ModulesDALayer.DietPlan;

namespace GymManagementSystemBLLayer.Common
{
    public class LookupBLL
    {
        public static List<string> GetPaymentMethods()
        {
            return new List<string>
            {
               "Cash",
               "UPI",
               "Debit Card",
               "Credit Card",
               "Net Banking"
            };
        }
    }
}
