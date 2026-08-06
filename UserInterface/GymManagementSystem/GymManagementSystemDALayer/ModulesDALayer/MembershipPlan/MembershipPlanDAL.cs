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
        public int MembershipPlanId { get; set; }
        public string MembershipPlanName { get; set; }
        public int PlanTypeId { get; set; }
        public string PlanType { get; set; }
        public int DurationInDays { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string IsActive { get; set; }

        public List<MembershipPlanDAL> RetrieveMembershipPlansDetailsDAL()
        {
            List<MembershipPlanDAL> membershipPlansDal = new List<MembershipPlanDAL>();

            DataTable dataTable = LookupDAL.RetrieveSpecificItem(
                "spRetrieveMembershipPlans"
            );

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
        public string UpdateMembershipPlanDescriptionAndPriceByMembershipPlanIdDAL(int membershipPlanId,decimal price,string description)
        {
            DataTable dt = LookupDAL.UpdateSpecificItemById(
                "spUpdateMembershipPlanDescriptionAndPriceByMembershipPlanId",
                membershipPlanId,
                "@MembershipPlanId",
                price,
                description
            );

            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Message"].ToString();
            }

            return string.Empty;
        }
        public string DeactivateMembershipPlanByMembershipPlanIdDAL(int membershipPlanId)
        {
            DataTable dt = LookupDAL.DeactivateSpecificItemById(
                "spDeactivateMembershipPlanByMembershipPlanId",
                membershipPlanId,
                "@MembershipPlanId");

            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Message"].ToString();
            }

            return string.Empty;
        }
        public DataTable RetrieveMembershipPlanDetailsByMembershipPlanIdDal(int id)
        {
            DataTable dataTableMembershipPlanDal = LookupDAL.RetrieveSpecificDetailsById("spRetrieveMembershipPlanDetailsByMembershipPlanId", id, "@MembershipPlanId");
            return dataTableMembershipPlanDal;
        }
       
    }
}

