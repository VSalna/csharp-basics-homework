using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetics1
{
    class Program
    {
        static void Main(string[] args)

        {
            
            Console.WriteLine(CheckNumbers(10, 15));
            Console.ReadKey();

        }

        static bool CheckNumbers(int a, int b)
        {

            return (a == 15 || b == 15) || a+b == 15 || a-b == 15;

            /*if(a == 15 || b == 15 || a + b == 15 || a - b == 15)
                {
                return true;
            }*/
        }
    }
}
