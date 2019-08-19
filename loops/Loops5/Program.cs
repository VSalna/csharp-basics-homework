using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops5
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Please write a word: ");
          var word1 = Console.ReadLine();
            Console.WriteLine("Please write another word: ");
          var word2 = Console.ReadLine();
        
          var count = (word1+word2).Length;
            
            Console.Write(word1);

            for (int i = count; i < 30; i++)
          {
                Console.Write(".");
                count++;
                
            }
            Console.Write(word2);

            Console.ReadKey();
        }
    }
}
