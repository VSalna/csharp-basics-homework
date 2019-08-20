using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(CheckOddEven(3));
            
            Console.WriteLine("bye!");
            Console.ReadKey();
        }

          static bool CheckOddEven(int input)
        {
            if(input % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
