using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables4
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            short birthyear;

            Console.Write("Please enter your name: ");

            name = Console.ReadLine();

            Console.Write("What year were you born?: ");

            birthyear = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("My Name is {0}", name);
            Console.Write("and I was born in {0}", birthyear);

            Console.ReadKey();

        }
    }
}
