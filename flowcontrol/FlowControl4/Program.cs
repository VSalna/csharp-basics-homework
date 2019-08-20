using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl4
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintDayInWord();
            Console.ReadKey();

        }

        static void PrintDayInWord()
        {

            int dayNumber = 1;

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }

        }
    }
}
