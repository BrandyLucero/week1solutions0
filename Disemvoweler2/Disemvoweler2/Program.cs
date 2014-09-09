using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler2
{
    class Program
    {
        static void Main(string[] args)
        {

            Disemvoweler("Nickelback is my favorite band. Thier songwriting can't be beat");
            Console.WriteLine("Enter a sentence to disemvoweler");
            string input = Console.ReadLine();
            Disemvoweler(input);
            Console.ReadKey();

        }

        //takes out the vowels and spaces of a string. 
        static void Disemvoweler(string input)
        {

            //declare an output variable 
            string output = string.Empty;
            // declare a variable to hold the vowels
            string vowels = string.Empty;

            //loop over each letter of the string
            for (int i = 0; i < input.Length; i++)
            
             
            {
                //put the current letter to a variable 
                string letter = input[i].ToString();
                //determine f letter is a vowel 
                if ("aeiou".Contains(letter.ToLower()))
                {
                    //its a vowel so add it to the vowels 
                    vowels += letter;

               }
                else if (letter == " ")
               {
                    
               }
                else
               {
                output +=  letter;
               }
            }
              //looped through all the letters 
               //time to prnt the output
             Console.WriteLine("Original: Nickelback is my favorite band. Thier songwriting can't be beat");
           }
    }
}