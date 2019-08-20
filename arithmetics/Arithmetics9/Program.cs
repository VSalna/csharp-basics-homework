using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(BodyMassIndex(176.3 ,70.8));
            Console.ReadKey();
        }

        static double BodyMassIndex(double weight, double height)
        {
            double bmi = weight * 703 / Math.Pow(height, 2);

            if (bmi < 18)
            {
                Console.WriteLine("Underweight");
            }
            if (bmi >= 18.5 && bmi <= 25)
            {
                Console.WriteLine("Optimal weight");
            }
            if (bmi > 25)
            {
                Console.WriteLine("Overweight");
            }        
            
             
            
            return bmi;
            
        }
    }
}
