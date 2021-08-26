using RulePayment.PaymentService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulePayment.PaymentService.Services
{
    public class Membership : IPaymentService
    {
        public void AddPayment()
        {
            Console.WriteLine("Activate the membership.");
            CommonData.GetEmail("activation");
        }        
    }
}
