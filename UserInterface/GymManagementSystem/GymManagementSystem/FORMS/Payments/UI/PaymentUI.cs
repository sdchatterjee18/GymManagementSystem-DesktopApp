using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemBLLayer.ModulesBLLayer.Payment;

namespace GymManagementSystem.FORMS.Payments.UI
{
    public class PaymentUI
    {
        //Properties

        public string MemberShipPlanName { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public string FeesType { get; set; }

        //Retrieve All Member Subcription Payment Details

        public List<PaymentUI> RetrieveAllMemberSubscriptionPaymentDetailsUI()
        {
            List<PaymentUI> SubscriptionPaymentDetails = new List<PaymentUI>();
            try
            { 
                PaymentBLL PaymentBLL = new PaymentBLL();
                List<PaymentBLL> PaymentDetails = PaymentBLL.RetieveAllMemberSubscriptionPaymentDetailsBLL();
                foreach (PaymentBLL PaymentDetail in PaymentDetails)
                {
                    PaymentUI PaymentUI = new PaymentUI
                    {
                        MemberShipPlanName = PaymentDetail.MemberShipPlanName,
                        PaymentDate = PaymentDetail.PaymentDate,
                        PaymentMethod = PaymentDetail.PaymentMethod,
                        Amount = PaymentDetail.Amount,
                        FeesType = PaymentDetail.FeesType
                    };

                    SubscriptionPaymentDetails.Add(PaymentUI);
                }
                return SubscriptionPaymentDetails;
            }
            catch (Exception ex)
            {
                SubscriptionPaymentDetails = null;
                return SubscriptionPaymentDetails;
            }
        }
    }
}
