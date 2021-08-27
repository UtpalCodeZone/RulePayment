using RulePayment.PaymentService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulePayment.PaymentService.Services
{
    public static class PaymentService
    {
        public static void GetService(string serviceType)
        {
            IPaymentService paymentService = PaymentFactory.GetService(serviceType);
            if(paymentService != null)
            {
                paymentService.AddPayment();
            }
        }        
    }
}
