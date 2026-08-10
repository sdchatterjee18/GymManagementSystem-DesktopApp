using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemDALayer.ModulesDALayer.Payment;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Payment
{
    public class PaymentBLL
    {
        //Properties

        public string MemberShipPlanName { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public string FeesType { get; set; }

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
                        MemberShipPlanName = PaymentDetail.MemberShipPlanName,
                        PaymentDate = PaymentDetail.PaymentDate,
                        PaymentMethod = PaymentDetail.PaymentMethod,
                        Amount = PaymentDetail.Amount,
                        FeesType = PaymentDetail.FeesType
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
    }
}
