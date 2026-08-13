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
        public static List<string> GetFeesType()
        {
            return new List<string>
            {
               "Renewal",
               "New Registration"
            };
        }

        public static DataTable GetMonths()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("MonthNumber", typeof(int));
            dataTable.Columns.Add("MonthName", typeof(string));

            for (int month = 1; month <= 12; month++)
            {
                dataTable.Rows.Add(
                    month,
                    new DateTime(2000, month, 1).ToString("MMMM")
                );
            }

            return dataTable;
        }
    }
}
