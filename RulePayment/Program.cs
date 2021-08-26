using RulePayment.PaymentService.Services;
using System;

namespace RulePayment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter service type : ");
            Console.WriteLine("1. PhysicalProduct");
            Console.WriteLine("2. Book");
            Console.WriteLine("3. Membership");
            Console.WriteLine("4. UpgradeMembership");
            Console.WriteLine("5. Video");
            Console.WriteLine();
            Console.WriteLine("Choose correct number from above");


            var res = Console.ReadLine();
            PaymentService.Services.PaymentService.GetService(res);
            Console.ReadLine();
        }
    }
}
