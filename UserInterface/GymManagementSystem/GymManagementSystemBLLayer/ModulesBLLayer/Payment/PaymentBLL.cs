using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.Payment;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Payment
{
    public class PaymentBLL
    {
        //Properties
        public string MemberName { get; set; }
        public string MemberShipPlanName { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public string FeesType { get; set; }
        public string PhoneNo { get; set; }

        //Retrieve All Member Subscription Payment Details

        public List<PaymentBLL> RetieveAllMemberSubscriptionPaymentDetailsBLL()
        {
            List<PaymentBLL> SubscriptionPaymentDetails = new List<PaymentBLL>();
            
            try
            {
                SubscriptionPaymentDetails = new List<PaymentBLL>();
                PaymentDAL paymentDAL = new PaymentDAL();
                List<PaymentDAL> PaymentDetails = paymentDAL.RetrieveAllMemberSubscriptionPaymentDetailsDAL();
                foreach (PaymentDAL PaymentDetail in PaymentDetails)
                {
                    PaymentBLL PaymentBLL = new PaymentBLL
                    {
                        MemberName = PaymentDetail.MemberName,
                        MemberShipPlanName = PaymentDetail.MemberShipPlanName,
                        PaymentDate = PaymentDetail.PaymentDate,
                        PaymentMethod = PaymentDetail.PaymentMethod,
                        Amount = PaymentDetail.Amount,
                        FeesType = PaymentDetail.FeesType,
                        PhoneNo=PaymentDetail.PhoneNo
                    };

                    SubscriptionPaymentDetails.Add(PaymentBLL);
                }

                return SubscriptionPaymentDetails;
            }
            catch (Exception Ex)
            {
                SubscriptionPaymentDetails = null;
                return SubscriptionPaymentDetails;
            }
        }

        //Retrieve Specific Member Subcription Payment Details

        public List<PaymentBLL> RetrieveSpeificMemberSubscriptionPaymentDetailsByDetailsBLL(string Search)
        {
            List<PaymentBLL> SpecificMemberSubscriptionPaymentDetails = null;
            try
            {
                SpecificMemberSubscriptionPaymentDetails = new List<PaymentBLL>();
                PaymentDAL paymentDAL = new PaymentDAL();
                List<PaymentDAL> PaymentDetails = paymentDAL.RetrieveSpecificMemberSubscriptionByDetailsDAL(Search);
                foreach (PaymentDAL PaymentDetail in PaymentDetails)
                {
                    PaymentBLL paymentBLL = new PaymentBLL
                    {
                        MemberName = PaymentDetail.MemberName,
                        PhoneNo=PaymentDetail.PhoneNo,
                        MemberShipPlanName = PaymentDetail.MemberShipPlanName,
                        PaymentDate = PaymentDetail.PaymentDate,
                        PaymentMethod = PaymentDetail.PaymentMethod,
                        Amount = PaymentDetail.Amount,
                        FeesType = PaymentDetail.FeesType
                    };
                    SpecificMemberSubscriptionPaymentDetails.Add(paymentBLL);
                }
                return SpecificMemberSubscriptionPaymentDetails;
            }
            catch (Exception ex)
            {
                return SpecificMemberSubscriptionPaymentDetails;
            }
        }

        //Super Admin
        public DataTable SARetrieveSubscriptionPaymentDetailsByMonthBLL(int month, int year)
        {
            PaymentDAL paymentDAL = new PaymentDAL();

            return paymentDAL.SARetrieveSubscriptionPaymentDetailsByMonthDAL(
                month,
                year);
        }
        public DataTable SARetrieveTotalPaidSubscriptionAmountByMonthBLL(int month, int year)
        {
            PaymentDAL paymentDAL = new PaymentDAL();

            return paymentDAL.SARetrieveTotalPaidSubscriptionAmountByMonthDAL(
                month,
                year);
        }
        public DataTable SARetrieveAllMemberSubscriptionPaymentDetailsBLL()
        {
            PaymentDAL paymentDAL = new PaymentDAL();

            return paymentDAL.SARetrieveAllMemberSubscriptionPaymentDetailsDAL();
        }
        public DataTable SARetrieveSubscriptionPaymentDetailsBetweenDateRangeBLL(DateTime startDate, DateTime endDate)
        {
            PaymentDAL paymentDAL = new PaymentDAL();

            return paymentDAL.SARetrieveSubscriptionPaymentDetailsBetweenDateRangeDAL(
                startDate,
                endDate);
        }
        public DataTable SARetrieveTotalPaidSubscriptionAmountBetweenDateRangeBLL(DateTime startDate, DateTime endDate)
        {
            PaymentDAL paymentDAL = new PaymentDAL();

            return paymentDAL.SARetrieveTotalPaidSubscriptionAmountBetweenDateRangeDAL(
                startDate,
                endDate);
        }
    }
}
