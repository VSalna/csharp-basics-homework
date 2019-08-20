using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write a number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write a number: ");
            var num3 = Convert.ToInt32(Console.ReadLine());
            var sum = num1 + num2 + num3;
            Console.WriteLine($"The sum of all input numbers is: {sum}");
            Console.ReadKey();

        }
    }
}
