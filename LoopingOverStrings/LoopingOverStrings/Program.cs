using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingOverStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            FindALetter("e", "the united states of america");
            {
                
            }
        }

        //Create a new function to loop over the letters of a string
        static void FindALetter(string LetterToFind, string text)
        {
            //Letter to find a var to hold the # of letter matches
            int letterCount = 0;

            //loop over the string 
            for (int i = 0; i < text.Length; i++)
            {
                //get the current letter we are looking at, and convert a tring for ease of use 
                string letter = text[i].ToString();
                // is this a  letter we need to find?


                if (letter == LetterToFind)
                {
                    letterCount = letterCount + 1;
              }
          }
                 
        //then display output
                Console.WriteLine("Found " + LetterToFind+ "'s in'" + text);
            }
        }
    }
        

