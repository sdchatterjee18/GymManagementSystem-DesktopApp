using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.DietPlan;

namespace GymManagementSystem.FORMS.DietPlan.UI
{
    public class DietPlanUI
    {
        public int DietPlanId { get; set; }
        public int CaloriesPerDay { get; set; }
        public string DietPlanDocument { get; set; }
        public string ConditionStatus { get; set; }

        public DataTable GetDietPlansForComboBox()
        {
            DietPlanBLL dietPlanBLL = new DietPlanBLL();
            DataTable dataTable = dietPlanBLL.GetDietPlansForComboBox();
            return dataTable;
        }

        // Display DataGridView
        public DataTable RetrieveDietPlansUI()
        {
            DietPlanBLL dietPlanBLL = new DietPlanBLL();
            return dietPlanBLL.RetrieveDietPlansBLL();
        }
    }
}
