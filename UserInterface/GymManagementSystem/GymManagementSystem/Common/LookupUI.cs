using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystem.FORMS.Shift.UI;
using GymManagementSystem.FORMS.MembershipPlan.UI;
using GymManagementSystemBLLayer.ModulesBLLayer.Shift;
using GymManagementSystemBLLayer.ModulesBLLayer.MembershipPlan;
using GymManagementSystemBLLayer.ModulesBLLayer.DietPlan;
using GymManagementSystem.FORMS.DietPlan.UI;

using GymManagementSystemBLLayer.Common;
namespace GymManagementSystem.Common
{
    public class LookupUI
    {
        public static List<string> GetPaymentMethods()
        {
            return LookupBLL.GetPaymentMethods();
        }
        public static List<string> GetFeesType()
        {
            return LookupBLL.GetFeesType();
        }
        public static DataTable GetMonths()
        {
            return LookupBLL.GetMonths();
        }
    }
}
