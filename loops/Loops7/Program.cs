using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Piglet!");
            GamePlay();
            Console.ReadKey();
        }

       static void GamePlay()
        {
            
            Random random = new Random();
            var myNumber = random.Next(1, 7);
            Console.WriteLine($"You rolled a {myNumber}!");


            var result = 0;
            var attempts = 0;


            while (myNumber != 1)
                {

                    Console.Write($"Roll again? ");
                    var input = Console.ReadLine();

                if (input == "y")
                    {

                        Console.WriteLine($"You rolled a {myNumber = random.Next(1, 7)}!");
                      result += myNumber;
                    attempts++;
                    
                    }
                    else if (input == "n")
                    {
                    result += myNumber;
                    Console.WriteLine($"You got {result} points!");
                    
                    break;
                    }
                    else if (myNumber == 1)
                    {
                        Console.WriteLine("You got 0 points.");
                        break;
                    }
                }
            
        }
    }
}
