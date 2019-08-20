using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it: ");
            GuessTheNumber();

            Console.ReadKey();
        }

        static void GuessTheNumber()
        {
            Random random = new Random();
            var myNumber = random.Next(0, 100);
            var usersNumber = Convert.ToInt16(Console.ReadLine());

            if(myNumber == usersNumber)
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }else if(myNumber > usersNumber)
            {
                Console.WriteLine("Sorry, you are too low. I was thinking of " + myNumber);
            }else if(myNumber < usersNumber)
            {
                Console.WriteLine("Sorry, you are too high. I was thinking of " + myNumber);
            }

        }
    }
}
