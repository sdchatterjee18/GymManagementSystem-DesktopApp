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
            SpecificMemberPaymentSPName = "spGetSubscriptionHistoryByPhoneNo";    // Set SpecificMemberPaymentSPName
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
                        MemberShipPlanName = row["MembershipPlanName"].ToString(),
                        PaymentDate = Convert.ToDateTime( row["PaymentDate"]),
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
        public List<PaymentDAL> RetrieveSpecificMemberSubscriptionByPhoneNoDAL(string phoneNo)
        {
            List<PaymentDAL> MemberSubscriptionPaymentDetails = null;
            try
            {
                PhoneNo = phoneNo; // Set the value of PhoneNo
                MemberSubscriptionPaymentDetails = new List<PaymentDAL>();
                SqlParameter[] sqlParameter =new SqlParameter[]
                {
                    new  SqlParameter("@PhoneNo",PhoneNo)
                };
                DataTable MemberPaymentSubscriptionDataTable = LookupDAL.RetrieveSpecificDetails(SpecificMemberPaymentSPName,sqlParameter);
                foreach (DataRow Row in MemberPaymentSubscriptionDataTable.Rows)
                {
                    PaymentDAL paymentDAL = new PaymentDAL
                    {
                        MemberName = Row["MemberName"].ToString(),
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
    }
}
