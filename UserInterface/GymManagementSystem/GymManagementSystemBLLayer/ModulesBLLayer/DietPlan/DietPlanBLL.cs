using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.DietPlan;
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystemBLLayer.ModulesBLLayer.DietPlan
{
    public class DietPlanBLL
    {
        // Properties
        public int DietPlanId { get; set; }
        public int CaloriesPerDay { get; set; }
        public byte[] DietPlanDocument { get; set; }
        public string ConditionStatus { get; set; }

        // Retrieves diet plan details for a ComboBox.
        public DataTable GetDietPlansForComboBox()
        {
            DietPlanDAL dietPlanDAL = new DietPlanDAL();
            DataTable dataTable = dietPlanDAL.GetDietPlansForComboBox();
            return dataTable;
        }

        // Retrieves all diet plan details for displaying in the DataGridView.
        public DataTable RetrieveDietPlansBLL()
        {
            DietPlanDAL dietPlanDAL = new DietPlanDAL();
            return dietPlanDAL.RetrieveDietPlansDAL();
        }

        // updates an existing diet plan.
        public string UpdateDietPlanBLL(int dietPlanId,int caloriesPerDay,byte[] dietPlanDocument,string conditionStatus)
        {
            try
            {
                // Calories Validation
                if (caloriesPerDay <= 0)
                {
                    return ValidationBll.GetValidationMessage(
                        ValidationBll.CommonValidationMessage.CaloriesMustBeGreaterThanZero);
                }

                // Condition Status Validation
                ValidationBll.CommonValidationMessage validationMessage =
                    ValidationBll.ValidateConditionStatus(conditionStatus);

                if (validationMessage !=
                    ValidationBll.CommonValidationMessage.Valid)
                {
                    return ValidationBll.GetValidationMessage(validationMessage);
                }

                // Update
                DietPlanDAL dietPlanDAL = new DietPlanDAL();

                return dietPlanDAL.UpdateDietPlanDAL(dietPlanId,caloriesPerDay,dietPlanDocument,conditionStatus);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Inserts a new diet plan.
        public string InsertDietPlanBLL(int caloriesPerDay,byte[] dietPlanDocument, string conditionStatus)
        {
            try
            {
                // Calories Validation
                ValidationBll.CommonValidationMessage validationMessage =
                    ValidationBll.ValidateCalories(caloriesPerDay);

                if (validationMessage !=
                    ValidationBll.CommonValidationMessage.Valid)
                {
                    return ValidationBll.GetValidationMessage(validationMessage);
                }

                // Condition Status Validation
                validationMessage =
                    ValidationBll.ValidateConditionStatus(conditionStatus);

                if (validationMessage !=
                    ValidationBll.CommonValidationMessage.Valid)
                {
                    return ValidationBll.GetValidationMessage(validationMessage);
                }

                // Insert
                DietPlanDAL dietPlanDAL = new DietPlanDAL();

                return dietPlanDAL.InsertDietPlanDAL(
                    caloriesPerDay,
                    dietPlanDocument,
                    conditionStatus);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
