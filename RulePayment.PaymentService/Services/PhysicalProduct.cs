using RulePayment.PaymentService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulePayment.PaymentService.Services
{
    public class PhysicalProduct : IPaymentService
    {
        public void AddPayment()
        {
            Console.WriteLine("Generate Packing Slip for shipping.");
        }
    }
}
