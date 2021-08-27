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
                case "1":
                    paymentService = new PhysicalProduct();
                    break;
                case "2":
                    paymentService = new Book();
                    break;
                case "3":
                    paymentService = new Membership();
                    break;
                case "4":
                    paymentService = new UpgradeMembership();
                    break;
                case "5":
                    paymentService = new VideoService();
                    break;
                //default:
                //    paymentService = null;
                //    Console.WriteLine("Proper name is not selected!");
                //    break;
            }
            return paymentService;
        }
    }
}