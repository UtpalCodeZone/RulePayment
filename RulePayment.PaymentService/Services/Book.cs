using RulePayment.PaymentService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulePayment.PaymentService.Services
{
    public class Book : IPaymentService
    {
        public void AddPayment()
        {
            Console.WriteLine("Create duplicate shipping slip for royality department.");
            CommonData.GetCommision("Book");
        }
    }
}
