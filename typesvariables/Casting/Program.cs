using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            first();
            second();
            Console.ReadKey();
        }
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
        static void first()
        {
            String a = "1";
            int b = 2;
            int c = 3;
            double d = 4;
            float e = 5;
<<<<<<< Updated upstream

            //fixme - should be 15 :|
            //int sum = a + b + c + d + e;
            //Console.WriteLine(sum);
        }

=======
            int sum = Convert.ToByte(a) + b + c + (int)d + (int)e;
            
            //fixme - should be 15 :neutral_face:
            //int sum = a + b + c + d + e;
            Console.WriteLine(sum);
        }
>>>>>>> Stashed changes
        static void second()
        {
            String a = "1";
            int b = 2;
            int c = 3;
            double d = 4.2;
            float e = 5.3f;
<<<<<<< Updated upstream

            //fixme - should be 15.5 :| 
            //float sum = a + b + c + d + e;
            //Console.WriteLine(sum);
=======
            //fixme - should be 15.5 :neutral_face:
            float sum = Convert.ToInt32(a) + b + c + (float)d + e;
            Console.WriteLine(sum);
>>>>>>> Stashed changes
        }
    }
}
    

