using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a from 1=>35
           
            for (int i = 1; i <= 35; i = i + 1)
            {
                FizzBuzz(i);
            }


            //keep the windo open
            Console.ReadKey();

        }

         static void FizzBuzz( int number)
            {
                if (number % 5 == 0 && number % 3 == 0)
                {
        // is # num div by 5 & 3

        Console.WriteLine("FizzBuzz");

    }

            else if ( number % 5 == 0)
        {
            // is it divisible by 
            Console.WriteLine("Fizz");
        }
                else if (number % 3 == 0)
                {
                    //if dv by 5
                    Console.WriteLine("Buzz");
                }
                else
                {
                    // if neither than print number
                    Console.WriteLine(number);
                }
        }
    }

}

