using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables8
{
    class Program
    {
        static void Main(string[] args)
        {
            double minute = 4600;
            ConvertMinutesToYrs(minute);
            Console.ReadKey();
        }

        static void ConvertMinutesToYrs(double minute)
        {
            double year = minute / (365 * 60);
            minute = minute % (365 * 60);

            double day = minute / (24 * 60);

            Console.WriteLine($"{year:0.00} years  {day:0.00} days");
        }
    }
}
