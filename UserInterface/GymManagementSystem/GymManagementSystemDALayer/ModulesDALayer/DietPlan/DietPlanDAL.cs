using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.Common;

namespace GymManagementSystemDALayer.ModulesDALayer.DietPlan
{
    public class DietPlanDAL
    {
        public int DietPlanId { get; set; }
        public int CaloriesPerDay { get; set; }
        public string DietPlanDocument { get; set; }
        public string ConditionStatus { get; set; }

        public  DataTable GetDietPlansForComboBox()
        {
            DataTable dataTable = LookupDAL.GetComboBoxDetails("spRetrieveDietPlanDetails");
            return dataTable;
        }
    }
}
