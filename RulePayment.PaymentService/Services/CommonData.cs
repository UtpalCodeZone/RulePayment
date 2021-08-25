using System;
using System.Collections.Generic;
using System.Text;

namespace RulePayment.PaymentService.Services
{
    public class CommonData
    {
        public static void GetCommision(string obj)
        {
            Console.WriteLine($"Generate commision for {obj}");
        }

        public static void GetVideo(string obj)
        {
            Console.WriteLine($"Add free first aid video for {obj}");
        }
    }
}
