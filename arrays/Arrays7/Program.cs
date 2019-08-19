using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray1 = { 25, 14, 56, 15, 36, 56, 77, 18, 29, 49 };
            int[] myArray2 = new int[10];

            Array.Copy(myArray1, myArray2, 10);
            myArray1[Array.IndexOf(myArray1, 49)] = -7;
            Console.WriteLine("Array 1: " + string.Join(" , ", myArray1));
            Console.WriteLine("Array 2: " + string.Join(" , ", myArray2));
            

            Console.ReadKey();
        }

        
    }
}
