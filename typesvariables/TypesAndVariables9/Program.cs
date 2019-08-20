using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables9
{
    class Program
    {
        static void Main(string[] args)
        {

            speedInDistance();
            Console.ReadKey();

        }
        static void speedInDistance()
        {

            float distance;
            float hour, min, sec;

            float timeSec;
            float mps;
            float kph, mph;

            Console.Write("Input distance in meters: ");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input time in hours: ");
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input time in minutes: ");
            min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input time in seconds: ");
            sec = Convert.ToSingle(Console.ReadLine());

            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timeSec;
            kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;

            Console.WriteLine($"Your speed in meters/sec is:  {mps: 0.00}");
            Console.WriteLine($"Your speed in km/h is: {kph:0.00}");
            Console.WriteLine($"Your speed in miles/h is: {mph:0.00}");
            Console.ReadKey();
        }
    }
}
