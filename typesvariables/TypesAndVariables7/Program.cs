using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Please enter a name: ");
            string inputString = Console.ReadLine();

            foreach (char u in inputString)  //counts number of uppercase letters
            {
                if (Char.IsUpper(u))
                    count++;
            }
            Console.WriteLine($"There are {count} upper case letters in the word {inputString}");
            Console.ReadKey();
        }
    }
}
