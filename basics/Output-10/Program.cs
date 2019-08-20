using System;

namespace Output_10
{
    class Program
    {
        //todo: change the function so it concatinates 3 words together
        //in Main method display the result.
        static void Main(string[] args)
        {
            Console.WriteLine(Concat());


            Console.ReadKey();
        }

        static string Concat(string w1 = "hello",string w2 = "codelex",string w3 = "world")
        {
            return string.Concat(w1+w2+w3);
        }
    }
}
