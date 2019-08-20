using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        private const double _incToCmRatio = 2.54;
        private const double _poundToKgRatio = 0.453592;
        static void Main(string[] args)
        {
          
            string name = "Zed A. Shaw";
            int age = 35;
            double height = Convert(74, _incToCmRatio);  // inches was now cm
            
            double weight = Convert(180, _poundToKgRatio); // lbs now kg
            
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";

            Console.WriteLine($"Let's talk about  {name} .");
            Console.WriteLine("He's " + String.Format("{0:0.00}", height) + " inches tall."); //{height:0.00} var ja $
            Console.WriteLine("He's " + String.Format("{0:0.00}", weight) + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + String.Format("{0:0.00}", height) + ", and " + String.Format("{0:0.00}", weight)
                               + " I get " + (age + String.Format("{0:0.00}", height) + String.Format("{0:0.00}", weight)) + ".");

<<<<<<< Updated upstream
            Console.WriteLine("If I add " + myAge + ", " + myHeight + ", and " + myWeight
                               + " I get " + (myAge + myHeight + myWeight) + ".");

            Console.ReadKey();
=======
            Console.ReadKey();
        }

        static double Convert(double value, double ratio)
        {
            return value * ratio;
>>>>>>> Stashed changes
        }
    }
}