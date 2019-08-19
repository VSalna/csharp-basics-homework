using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops6
{
    class Program
    {
        static void Main(string[] args)
        {

            FizzBuzz();
            Console.ReadKey();
        }

        static void FizzBuzz()
        {

            for (int i = 1; i <= 100; i++)
            {

                if (i % 20 == 0)
                    Console.Write("\n");

                

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(" FizzBuzz ");

                }
                else if (i % 5 == 0)
                {
                    Console.Write(" Buzz ");

                }
                else if (i % 3 == 0)
                {
                    Console.Write(" Fizz ");

                }
                
                else
                {
                    Console.Write(" " + i);
                }
            }

        }
    }
}
