using RulePayment.PaymentService.Interfaces;
using RulePayment.PaymentService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulePayment.PaymentService.Services
{
    public class PaymentFactory
    {
        public static IPaymentService GetService(string objName)
        {
            IPaymentService paymentService = null;
            
            switch(objName)
            {
                case "PhysicalProduct":
                    paymentService = new PhysicalProduct();
                    break;
                case "Book":
                    paymentService = new Book();
                    break;
                case "Membership":
                case "UpgradeMembership":
                    paymentService = new Membership();
                    break;               
                case "Video":
                    paymentService = new VideoService();
                    break;
            }
            return paymentService;
        }

        public void GetSelectedType()
        {

        }
    }
}