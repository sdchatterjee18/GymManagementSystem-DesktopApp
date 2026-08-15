using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Payment;

namespace GymManagementSystem.FormsSuperAdmin.Financials.UI
{
    public class SAPaymentUI
    {
        public DataTable SARetrieveSubscriptionPaymentDetailsByMonthUI(int month, int year)
        {
            PaymentBLL paymentBLL = new PaymentBLL();

            return paymentBLL.SARetrieveSubscriptionPaymentDetailsByMonthBLL(
                month,
                year);
        }
        public DataTable SARetrieveTotalPaidSubscriptionAmountByMonthUI(int month, int year)
        {
            PaymentBLL paymentBLL = new PaymentBLL();

            return paymentBLL.SARetrieveTotalPaidSubscriptionAmountByMonthBLL(
                month,
                year);
        }
        public DataTable SARetrieveAllMemberSubscriptionPaymentDetailsUI()
        {
            PaymentBLL paymentBLL = new PaymentBLL();

            return paymentBLL.SARetrieveAllMemberSubscriptionPaymentDetailsBLL();
        }
        public DataTable SARetrieveSubscriptionPaymentDetailsBetweenDateRangeUI(DateTime startDate, DateTime endDate)
        {
            PaymentBLL paymentBLL = new PaymentBLL();

            return paymentBLL.SARetrieveSubscriptionPaymentDetailsBetweenDateRangeBLL(
                startDate,
                endDate);
        }
        public DataTable SARetrieveTotalPaidSubscriptionAmountBetweenDateRangeUI(DateTime startDate, DateTime endDate)
        {
            PaymentBLL paymentBLL = new PaymentBLL();

            return paymentBLL.SARetrieveTotalPaidSubscriptionAmountBetweenDateRangeBLL(
                startDate,
                endDate);
        }
    }
}
