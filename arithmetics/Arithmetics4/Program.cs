using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics3
{
    class Program
    {
        static void Main(string[] args)
        {
            SumAndAverage();
            Console.ReadKey();
        }

        static void SumAndAverage()
        {
            var data = Enumerable.Range(1, 100);
            Console.WriteLine("The sum of 1 to 100 is " + data.Sum());
            Console.WriteLine("The average is " + data.Average());
        }
    }
}
