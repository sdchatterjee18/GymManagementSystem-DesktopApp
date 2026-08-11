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
        public string MemberName { get; set; }
        public string MemberShipPlanName { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public string FeesType { get; set; }
        string PhoneNo { get; set; }

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
                        MemberName = PaymentDetail.MemberName,
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

        //Retrieve Specific Member Subscription Payment Details
        public List<PaymentUI> RetrieveSpecificMemberSubscriptionPaymentDetailsUI(string phoneNo)
        {
            List<PaymentUI> SubsctiptionPaymentDetails = null;
            try
            {
                PhoneNo = phoneNo; // set the value of PhoneNo
                SubsctiptionPaymentDetails = new List<PaymentUI>();
                PaymentBLL paymentBLL = new PaymentBLL();
                List<PaymentBLL> SubscriptionPaymentDetails = paymentBLL.RetrieveSpeificMemberSubscriptionPaymentDetailsByPhoneNoBLL(PhoneNo);
                foreach (PaymentBLL paymentDetail in SubscriptionPaymentDetails)
                {
                    PaymentUI paymentUI = new PaymentUI
                    {
                        MemberName = paymentDetail.MemberName,
                        MemberShipPlanName = paymentDetail.MemberShipPlanName,
                        PaymentDate = paymentDetail.PaymentDate,
                        PaymentMethod = paymentDetail.PaymentMethod,
                        Amount = paymentDetail.Amount,
                        FeesType = paymentDetail.FeesType
                    };
                    SubsctiptionPaymentDetails.Add(paymentUI);
                }
                return SubsctiptionPaymentDetails;
            }
            catch (Exception ex)
            {
               return SubsctiptionPaymentDetails;
            }
        }
    }
}
