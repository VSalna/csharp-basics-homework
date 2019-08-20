using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAverageRunningInt1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            int average =sum;
            int lowerBound = 1;
            int upperBound = 100;
            
            

            for (var number = lowerBound; number <= upperBound; ++number)
            {
                sum += number;
                
            
                
            }
            
        }
    }
}
