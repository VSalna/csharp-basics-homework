using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        //TODO: Write a C# program to find the index of an array element.
        private static void Main(string[] args)
        {
            int[] myArray = {25, 14, 56, 15, 36, 56, 77, 18, 29, 49};

            //    var indexOfElement36 = -1;
            //    var indexOfElement29 = -1;


            var indexOfElement = Find(myArray, 36);
            
                //Array.IndexOf(myArray, 36);
            var indexOfElement1 = Array.IndexOf(myArray, 29);
            Console.WriteLine("Index position of 36 is: " + indexOfElement);
            Console.WriteLine("Index position of 29 is: " + indexOfElement1);

            //Expected output:
            //Index position of 36 is: 4
            //Index position of 29 is: 8
            Console.ReadKey();   
        }

        static int Find(int[] array, int needle)
        {
            int result = 9999999;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == needle)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}
