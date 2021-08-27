using RulePayment.PaymentService.Services;
using System;
using Xunit;

namespace TestProject.RulePayment
{
    public class TestService
    {
        [Fact]
        public void ValidPaymentService()
        {
            bool check = false;
            // 1 for PhysicalProduct
            string a1 = "1";
            // 2 for Book
            string a2 = "2";
            // 3 for Membership
            string a3 = "3";
            // 4 for UpgradeMembership
            string a4 = "4";
            // 5 for Video
            string a5 = "5";

            PaymentService.GetService(a1);
            PaymentService.GetService(a2);
            PaymentService.GetService(a3);
            PaymentService.GetService(a4);
            PaymentService.GetService(a5);
            check = true;

            Assert.True(check);


        }
    }
}
