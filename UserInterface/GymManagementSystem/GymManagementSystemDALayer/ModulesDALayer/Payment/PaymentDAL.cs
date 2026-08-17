using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystemDALayer.SqlHelper;
using GymManagementSystemDALayer.Common;

namespace GymManagementSystemDALayer.ModulesDALayer.Payment
{
   public  class PaymentDAL
    {
        //Properties
        public string MemberName { get; set; }
        public string MemberShipPlanName { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public string FeesType { get; set; }
        public string AllMemberPaymentSPName { get; set; }
        public string SpecificMemberPaymentSPName { get; set; }
        public string PhoneNo { get; set; }

       //use constructor for initialization 

        public PaymentDAL()
        {
            AllMemberPaymentSPName = "spGetAllMemberSubscriptionPaymentDetails";  //Set AllMemberPaymentSPName
            SpecificMemberPaymentSPName = "spGetSubscriptionHistoryByDetails";    // Set SpecificMemberPaymentSPName
        }

        //Retrieve All Member Subscription Payment Details

        public List<PaymentDAL> RetrieveAllMemberSubscriptionPaymentDetailsDAL()
        {
            List<PaymentDAL> SubscriptionPaymentDetails = null;
            try
            {
                
                SubscriptionPaymentDetails = new List<PaymentDAL>();
                DataTable PaymentSubscriptionDataTable = LookupDAL.RetrieveSpecificItem(AllMemberPaymentSPName);   // get SPName
                foreach (DataRow row in PaymentSubscriptionDataTable.Rows)
                {
                    PaymentDAL PaymentDAL = new PaymentDAL
                    {
                        MemberName = row["MemberName"].ToString(),
                        PhoneNo = row["PhoneNo"].ToString(),
                        MemberShipPlanName = row["MembershipPlanName"].ToString(),
                        PaymentDate = Convert.ToDateTime( row["PaymentDate"]).Date,
                        PaymentMethod = row["PaymentMethod"].ToString(),
                        Amount = Convert.ToDecimal(row["Amount"]),
                        FeesType = row["FeesType"].ToString()
                    };
                    SubscriptionPaymentDetails.Add(PaymentDAL);
                }
                return SubscriptionPaymentDetails;
            }
            catch (Exception ex)
            {
                return SubscriptionPaymentDetails;

            }
        }
        public List<PaymentDAL> RetrieveSpecificMemberSubscriptionByDetailsDAL(string Search)
        {
            List<PaymentDAL> MemberSubscriptionPaymentDetails = null;
            try
            {
               
                MemberSubscriptionPaymentDetails = new List<PaymentDAL>();
                SqlParameter[] sqlParameter =new SqlParameter[]
                {
                    new  SqlParameter("@SearchText",Search)
                };
                DataTable MemberPaymentSubscriptionDataTable = LookupDAL.RetrieveSpecificDetails(SpecificMemberPaymentSPName,sqlParameter);
                foreach (DataRow Row in MemberPaymentSubscriptionDataTable.Rows)
                {
                    PaymentDAL paymentDAL = new PaymentDAL
                    {
                        MemberName = Row["MemberName"].ToString(),
                        PhoneNo = Row["PhoneNo"].ToString(),
                        MemberShipPlanName = Row["MembershipPlanName"].ToString(),
                        PaymentDate = Convert.ToDateTime(Row["PaymentDate"]),
                        PaymentMethod = Row["PaymentMethod"].ToString(),
                        Amount = Convert.ToDecimal(Row["Amount"]),
                        FeesType = Row["FeesType"].ToString()
                    };
                    MemberSubscriptionPaymentDetails.Add(paymentDAL);
                }
                return MemberSubscriptionPaymentDetails;
            }
            catch (Exception ex)
            {
                return MemberSubscriptionPaymentDetails;
            }
        }

       // Super Admin 
        public DataTable SARetrieveSubscriptionPaymentDetailsByMonthDAL(int month, int year)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Month", SqlDbType.Int)
                {
                    Value = month
                },

                new SqlParameter("@Year", SqlDbType.Int)
                {
                    Value = year
                }
            };

            return LookupDAL.RetrieveSpecificDetails(
                "spRetrieveSubscriptionPaymentDetailsByMonth",
                sqlParameters);
        }
        public DataTable SARetrieveTotalPaidSubscriptionAmountByMonthDAL(int month, int year)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Month", SqlDbType.Int)
                {
                    Value = month
                },

                new SqlParameter("@Year", SqlDbType.Int)
                {
                    Value = year
                }
            };

            return LookupDAL.RetrieveSpecificDetails(
                "spRetrieveTotalPaidSubscriptionAmountByMonth",
                sqlParameters);
        }
        public DataTable SARetrieveAllMemberSubscriptionPaymentDetailsDAL()
        {
            return LookupDAL.RetrieveSpecificItem(
                "spGetAllMemberSubscriptionPaymentDetails");
        }
        public DataTable SARetrieveSubscriptionPaymentDetailsBetweenDateRangeDAL(DateTime startDate, DateTime endDate)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@StartDate", SqlDbType.Date)
                {
                    Value = startDate
                },

                new SqlParameter("@EndDate", SqlDbType.Date)
                {
                    Value = endDate
                }
            };

            return LookupDAL.RetrieveSpecificDetails(
                "spRetrieveSubscriptionPaymentDetailsBetweenDateRange",
                sqlParameters);
        }
        public DataTable SARetrieveTotalPaidSubscriptionAmountBetweenDateRangeDAL(DateTime startDate, DateTime endDate)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@StartDate", SqlDbType.Date)
                {
                    Value = startDate
                },

                new SqlParameter("@EndDate", SqlDbType.Date)
                {
                    Value = endDate
                }
            };

            return LookupDAL.RetrieveSpecificDetails(
                "spRetrieveTotalPaidSubscriptionAmountBetweenDateRange",
                sqlParameters);
        }
    }
}
