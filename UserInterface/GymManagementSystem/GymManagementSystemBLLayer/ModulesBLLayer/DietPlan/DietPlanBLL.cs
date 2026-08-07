using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.DietPlan;

namespace GymManagementSystemBLLayer.ModulesBLLayer.DietPlan
{
    public class DietPlanBLL
    {
        public int DietPlanId { get; set; }
        public int CaloriesPerDay { get; set; }
        public string DietPlanDocument { get; set; }
        public string ConditionStatus { get; set; }

        public DataTable GetDietPlansForComboBox()
        {
            DietPlanDAL dietPlanDAL = new DietPlanDAL();
            DataTable dataTable = dietPlanDAL.GetDietPlansForComboBox();
            return dataTable;
        }

        // Display DataGridView
        public DataTable RetrieveDietPlansBLL()
        {
            DietPlanDAL dietPlanDAL = new DietPlanDAL();
            return dietPlanDAL.RetrieveDietPlansDAL();
        }
    }
}
