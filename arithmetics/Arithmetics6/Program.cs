using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics6
{
    class Program
    {
        static void Main(string[] args)
        {

            CozaLozaWoza();
            Console.ReadKey();
                

        }

        static void CozaLozaWoza()
        {

            for (int i = 1; i <= 110; i++)
            {
                
                if (i % 11 == 0)
                    Console.Write("\n");

                if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                    
                {
                    Console.Write(" CozaLozaWoza ");
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(" CozaLoza ");

                }
                else if (i % 5 == 0)
                {
                    Console.Write(" Loza ");

                }
                else if (i % 3 == 0)
                {
                    Console.Write(" Coza ");

                }
                else if (i % 7 == 0)
                {
                    Console.Write(" Woza ");

                }
                else
                {
                    Console.Write(" " + i);
                }
            }

        }
    }
}
