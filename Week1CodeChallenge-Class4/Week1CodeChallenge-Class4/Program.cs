using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge_Class4
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

            DashInsert(8675309);

            //keep the windo open
            Console.ReadKey();

        }

        static void FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                // is # num div by 5 & 3

                Console.WriteLine("FizzBuzz");

            }

            else if (number % 5 == 0)
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
        static void TextStats(string input)
        {
            int numChars = input.Length;
            int numWords = input.Split(' ').ToList().Count;
            int numVowels = 0;
            int numCons = 0;
            int numSpec = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string letter = input[i].ToString().ToLower();
                if ("aeiou".Contains(letter))
                {
                    numVowels++;
                }

                else if (",!? .".Contains(letter))
                {
                    numSpec++;
                }
                else
                {
                    numCons++;
                }

            }
            Console.WriteLine("There are " + numChars + " characters in this sentence");
            Console.WriteLine("There are " + numSpec + " sprcial characters in this sentence");
            Console.WriteLine("There are " + numCons + " constants in this sentence");
            Console.WriteLine("There are " + numVowels + " vowerls in this sentence");
            Console.WriteLine("There are " + numWords + " words in this sentence");

        }

        static void IsPrime(int number)
        {
            for (int i = 2; i <= number; i++)
            {
                IsPrime(i);

            }
        }

        static void DashInsert(int number)
        {
            //insert a dash betwreen 2 odd numbers
            string output = "";
            //declare a string t hold a number 
            string numberString = number.ToString();
            // loop each digit 
            for (int i = 0; i <= numberString.Length - 2; i++)
            {
                //get the current ot the one next to it
                string num1String = numberString[i].ToString();
                string num2String = numberString[i + 1].ToString();
                //convert our strings to numbers
                int num1 = int.Parse(num1String);
                int num2 = int.Parse(num2String);
                //see if they are both odd numbers
                if (num1 % 2 != 0 && num2 % 2 != 0)
             
                {
                    output = output + num1 + "-";
                }
                else
                {
                   
                    output = output + num1;

                }
                
            }
            output = output + numberString[numberString.Length - 1];

            Console.WriteLine(output);
        }

    }
}