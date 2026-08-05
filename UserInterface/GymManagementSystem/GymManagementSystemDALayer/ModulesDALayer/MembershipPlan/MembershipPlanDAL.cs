using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystemDALayer.SqlHelper;

namespace GymManagementSystemDALayer.ModulesDALayer.MembershipPlan
{
    public class MembershipPlanDAL
    {
        public int MembershipPlanId { get; set; }
        public string MembershipPlanName { get; set; }
        public int PlanTypeId { get; set; }
        public string PlanType { get; set; }
        public int DurationInDays { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public List<MembershipPlanDAL> RetrieveMembershipPlansDetailsDAL()
        {
            SqlConnection sqlConnection=null;
            List<MembershipPlanDAL> membershipPlansDal=null;
            try
            {
                 using(sqlConnection=DBconnection.GetSqlConnection())
                 {
                     using (SqlCommand sqlCommand = new SqlCommand("spRetrieveMembershipPlans", sqlConnection))
                     {
                         sqlCommand.CommandType = CommandType.StoredProcedure;
                         membershipPlansDal = new List<MembershipPlanDAL>();
                         sqlConnection.Open();
                         SqlDataReader sqlDataReader=sqlCommand.ExecuteReader();
                         while (sqlDataReader.Read())
                         {
                             MembershipPlanDAL membershipPlanDal = new MembershipPlanDAL();

                             membershipPlanDal.MembershipPlanId = Convert.ToInt32(sqlDataReader["MembershipPlanId"]);
                             membershipPlanDal.MembershipPlanName = sqlDataReader["MembershipPlanName"].ToString();
                             membershipPlanDal.PlanType = sqlDataReader["PlanType"].ToString();
                             membershipPlanDal.DurationInDays = Convert.ToInt32(sqlDataReader["DurationInDays"]);
                             membershipPlanDal.Price = Convert.ToDecimal(sqlDataReader["Price"]);
                             membershipPlanDal.Description = sqlDataReader["Description"].ToString();
                             membershipPlanDal.IsActive = Convert.ToBoolean(sqlDataReader["IsActive"]);

                             membershipPlansDal.Add(membershipPlanDal);
                         }
                         return membershipPlansDal;
                     }
                 }
            }
            catch (Exception ex)
            {
                return membershipPlansDal;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
