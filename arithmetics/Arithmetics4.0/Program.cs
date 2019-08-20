using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics4._0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Product1ToN(4));
            Console.ReadKey();
        }

        static int Product1ToN(int n)
        {

            int result = 1;
            while (n != 1)
            {
                result *= n;
                n -= 1;

            }
            return result;
           
        }
    }
}
