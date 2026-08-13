using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystemDALayer.Common;

namespace GymManagementSystemDALayer.ModulesDALayer.DietPlan
{
    public class DietPlanDAL
    {
        // Properties
        public int DietPlanId { get; set; }
        public int CaloriesPerDay { get; set; }
        public byte[] DietPlanDocument { get; set; }
        public string ConditionStatus { get; set; }

        // Retrieves all diet plan details for display.
        public  DataTable GetDietPlansForComboBox()
        {
            DataTable dataTable = LookupDAL.GetComboBoxDetails("spRetrieveDietPlanDetails");
            return dataTable;
        }
        public DataTable RetrieveDietPlansDAL()
        {
            DataTable dataTable = LookupDAL.RetrieveSpecificItem("spRetrieveDietPlanDetails");
            return dataTable;
        }

        // Updates an existing diet plan.
        public string UpdateDietPlanDAL(int dietPlanId,int caloriesPerDay,byte[] dietPlanDocument,string conditionStatus)
        {
            try
            {
                SqlParameter documentParam = new SqlParameter("@DietPlanDocument", SqlDbType.VarBinary);
                documentParam.Value = dietPlanDocument ?? (object)DBNull.Value;
                SqlParameter[] sqlParameter =
                {
                    new SqlParameter("@DietPlanId", dietPlanId),
                    new SqlParameter("@CaloriesPerDay", caloriesPerDay),
                    documentParam,
                    new SqlParameter("@ConditionStatus", conditionStatus)
                };

                return LookupDAL.UpdateSpecificItem(
                    "spUpdateDietPlanDetails",
                    sqlParameter);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Inserts a new diet plan.
        public string InsertDietPlanDAL(int caloriesPerDay,byte[] dietPlanDocument,string conditionStatus)
        {
            try
            {
                SqlParameter documentParam = new SqlParameter("@DietPlanDocument", SqlDbType.VarBinary);
                documentParam.Value = dietPlanDocument ?? (object)DBNull.Value;
                SqlParameter[] sqlParameter =
                    {
                        new SqlParameter("@CaloriesPerDay", caloriesPerDay),
                        documentParam,
                        new SqlParameter("@ConditionStatus", conditionStatus)
                    };

                return LookupDAL.InsertSpecificItem("spInsertDietPlan",sqlParameter);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
