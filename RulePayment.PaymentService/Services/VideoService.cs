using RulePayment.PaymentService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulePayment.PaymentService.Services
{
    public class VideoService : IPaymentService
    {
        public void AddPayment()
        {
            Console.WriteLine("Free add video to the packing slip.");
        }
    }
}
