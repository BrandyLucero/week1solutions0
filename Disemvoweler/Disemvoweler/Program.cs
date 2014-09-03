using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Original: Nickleback is my favorite band. Their songwriting can't be beat!");
            Console.WriteLine("Disemvoweled: " + Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!"));

            Console.WriteLine("Original: How many bears Bear Grylls grill if Bear Grylls could grill bears?");
            Console.WriteLine("Disemvoweled: " + Disemvoweler("How many bears Bear Grylls grill if Bear Grylls could grill bears?"));

            Console.WriteLine("Original: I'm a code ninja, baby. I make the functions and I make the calls.");
            Console.WriteLine("Disemvoweled: " + Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls."));
            Console.ReadKey();
        }
        //create Disemvoweler function
        static string Disemvoweler(string inString)
        {
            //create a variable to store each nonvowel in order
            string returnString = "";
            //create a variable to store each vowel in order
            string vowels = "";
            //for loop that runs through every character in inString
            for (var i = 0; i <= inString.Length - 1; i++)
            {
                //if-else/if-else statement to determine if a character is a vowel or a space
                if (inString[i] == 'a' || inString[i] == 'e' || inString[i] == 'i' || inString[i] == 'o' || inString[i] == 'u')
                {
                    vowels += inString[i];
                }
                else if (inString[i] == ' ')
                {

                }
                else
                {
                    returnString += inString[i];
                }
            }
            return returnString;
        }
    }
}