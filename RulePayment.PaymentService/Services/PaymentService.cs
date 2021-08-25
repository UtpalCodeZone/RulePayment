using RulePayment.PaymentService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulePayment.PaymentService.Services
{
    public class PaymentService
    {
        public void GetService(string serviceType)
        {
            IPaymentService paymentService = PaymentFactory.GetService(serviceType);
            paymentService.AddPayment();
        }
        
    }
}
