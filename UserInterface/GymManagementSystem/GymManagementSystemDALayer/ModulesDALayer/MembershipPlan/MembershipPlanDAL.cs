using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystemDALayer.SqlHelper;
using GymManagementSystemDALayer.Common;

namespace GymManagementSystemDALayer.ModulesDALayer.MembershipPlan
{
    public class MembershipPlanDAL
    {
        // Properties
        public int MembershipPlanId { get; set; }
        public string MembershipPlanName { get; set; }
        public int PlanTypeId { get; set; }
        public string PlanType { get; set; }
        public int DurationInDays { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string IsActive { get; set; }

        // Inserts a new membership plan into the database.
        public string InsertMembershipPlanDAL()
        {
            SqlParameter[] sqlParameter =
            {
                new SqlParameter("@MembershipPlanName", MembershipPlanName),
                new SqlParameter("@PlanTypeId", PlanTypeId),
                new SqlParameter("@DurationInDays", DurationInDays),
                new SqlParameter("@Price", Price),
                new SqlParameter("@Description", Description),
                new SqlParameter("@IsActive", true)
            };
            return LookupDAL.InsertSpecificItem("spInsertDataIntoMembershipPlan", sqlParameter);
        }
        // Updates the price and description of an existing membership plan.
        public string UpdateMembershipPlanDescriptionAndPriceByMembershipPlanIdDAL(int membershipPlanId,decimal price,string description)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MembershipPlanId", membershipPlanId),
                new SqlParameter("@Description", description),
                new SqlParameter("@NewPrice", price)
            };

            return LookupDAL.UpdateSpecificItem("spUpdateMembershipPlanDescriptionAndPriceByMembershipPlanId",parameters);
        }
        // Deactivates an existing membership plan using its identifier.
        public string DeactivateMembershipPlanByMembershipPlanIdDAL(int membershipPlanId)
        {
            DataTable dt = LookupDAL.DeactivateSpecificItemById("spDeactivateMembershipPlanByMembershipPlanId",membershipPlanId,"@MembershipPlanId");

            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Message"].ToString();
            }

            return string.Empty;
        }
        // Retrieves membership plan details using its identifier.
        public DataTable RetrieveMembershipPlanDetailsByMembershipPlanIdDal(int id)
        {
            DataTable dataTableMembershipPlanDal = LookupDAL.RetrieveSpecificDetailsById("spRetrieveMembershipPlanDetailsByMembershipPlanId", id, "@MembershipPlanId");
            return dataTableMembershipPlanDal;
        }
        // Retrieves membership plan details for a ComboBox.
        public DataTable GetMembershipPlanDetailsForComboBox()
        {
           DataTable dataTable= LookupDAL.GetComboBoxDetails("spRetrieveMembershipPlans");
           return dataTable;
        }
        // Retrieves membership plan type details for a ComboBox.
        public DataTable GetMembershipPlanTypeDetailsForComboBox()
        {
            DataTable dataTable = LookupDAL.GetComboBoxDetails("spRetrieveMembershipPlanTypes");
            return dataTable;
        }
        // Retrieves all membership plan details from the database.
        public List<MembershipPlanDAL> RetrieveMembershipPlansDetailsDAL()
        {
            List<MembershipPlanDAL> membershipPlansDal = new List<MembershipPlanDAL>();
            DataTable dataTable = LookupDAL.RetrieveSpecificItem("spRetrieveMembershipPlans");
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    MembershipPlanDAL membershipPlanDal = new MembershipPlanDAL();

                    membershipPlanDal.MembershipPlanId =
                        Convert.ToInt32(row["MembershipPlanId"]);

                    membershipPlanDal.MembershipPlanName =
                        row["MembershipPlanName"].ToString();

                    membershipPlanDal.PlanType =
                        row["PlanType"].ToString();

                    membershipPlanDal.DurationInDays =
                        Convert.ToInt32(row["DurationInDays"]);

                    membershipPlanDal.Price =
                        Convert.ToDecimal(row["Price"]);

                    membershipPlanDal.Description =
                        row["Description"].ToString();

                    membershipPlanDal.IsActive =
                        row["IsActive"].ToString();

                    membershipPlansDal.Add(membershipPlanDal);
                }
            }

            return membershipPlansDal;
        }

        public static decimal GetPriceByMembershipPlanId(int membershipPlanId)
        {
            SqlParameter[] parameters =
            {
                 new SqlParameter("@MembershipPlanId", membershipPlanId)
            };

            object result = LookupDAL.GetSingleData(
                "spGetMembershipPlanPriceById",
                parameters);

            if (result != null)
            {
                return Convert.ToDecimal(result);
            }

            return 0;
        }
    }
}

