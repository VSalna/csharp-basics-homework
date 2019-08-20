using System;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads an positive integer and count the number of digits the number (less than ten billion) has.
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");
            
            var input = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(getDigits(input, (input=0)));
            //  Console.Write($" The number {input} contains number of digits : {1} ", input, getDigits(input, 0));





            //  todo - check if Long
            if (input > 2147483647)
          {
              //todo - check if n is less than zero
              if (input < 0)
              {
                  input *= -1;
              }

          

          if (input > 10000000000)
              {
                  Console.WriteLine("Number is greater or equals 10,000,000,000!");
              }
          

            //  Console.WriteLine("Number of digits in the number: " + digits);

                }
           else  {
                  Console.WriteLine("The number is not a long");
              }

          
    }
        public static int getDigits(int n1, int nodigits)
        {
            if (n1 == 0)
                return nodigits;
          //  Console.WriteLine("Number of digits in the number: " + digits);
            return getDigits(n1 / 10, ++nodigits);
            
        }
    }
}
    

