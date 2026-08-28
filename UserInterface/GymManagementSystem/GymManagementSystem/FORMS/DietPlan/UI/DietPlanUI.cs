using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.DietPlan;
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystem.FORMS.DietPlan.UI
{
    public class DietPlanUI
    {
        // Properties
        public int DietPlanId { get; set; }
        public int CaloriesPerDay { get; set; }
        public byte[] DietPlanDocument { get; set; }
        public string ConditionStatus { get; set; }

        // Retrieves diet plan details for a ComboBox.
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

        // Updates an existing diet plan through the business layer.
        public string UpdateDietPlanUI(int dietPlanId,int caloriesPerDay,byte[] dietPlanDocument,string conditionStatus)
        {
            try
            {
                DietPlanBLL dietPlanBLL = new DietPlanBLL();

                return dietPlanBLL.UpdateDietPlanBLL(
                    dietPlanId,
                    caloriesPerDay,
                    dietPlanDocument,
                    conditionStatus);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

         //Inserts a new diet plan through the business layer.
        public ValidationResult InsertDietPlanUI()
        {
            DietPlanBLL dietPlanBLL = new DietPlanBLL();

            dietPlanBLL.CaloriesPerDay = this.CaloriesPerDay;
            dietPlanBLL.DietPlanDocument = this.DietPlanDocument;
            dietPlanBLL.ConditionStatus = this.ConditionStatus;

            return dietPlanBLL.InsertDietPlanBLL();
        }
    }
}
