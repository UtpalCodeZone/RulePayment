using RulePayment.PaymentService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulePayment.PaymentService.Services
{
    public class UpgradeMembership : IPaymentService
    {
        public void AddPayment()
        {
            Console.WriteLine("Upgrade the membership");
            CommonData.GetEmail("upgrade");
        }
    }
}
