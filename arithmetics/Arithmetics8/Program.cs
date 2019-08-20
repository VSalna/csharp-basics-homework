using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics8
{
    class Program
    {
        static void Main(string[] args)
        {

            


            Console.WriteLine(TotalPay(8, 41));
            Console.ReadKey();

        }

        static double TotalPay(double basePay, double hoursWorked)
        {
            if (basePay < 8)
            {
                Console.WriteLine("Error");
            }
            if (hoursWorked > 40)
            {

                double overtime = (hoursWorked -40) * (basePay * 1.5);
                double totalAmount = overtime + basePay * 40;
                basePay = totalAmount / hoursWorked;
            }
            if (hoursWorked > 60)
            {
                Console.WriteLine("Error");
            }

            return basePay * hoursWorked;
            
        }
    }
}
