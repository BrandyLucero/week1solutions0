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
            FindAWord("and", "I'm really happy its not raining today, because rain is for the birds and the jerks. and and and ");
             
            //keep the console window open 
            Console.ReadKey();

        }
        //Create a new function to loop over the letters of a string
        // a string, and count the number of a certain letter
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
                //convert both the letter and letterToFind to lower case

                if (letter.ToLower() == LetterToFind.ToLower())
                {
                    //find letter, increment out counter
                    letterCount = letterCount + 1;
                }
            }

            //then display output
            Console.WriteLine("Found " + letterCount + " " + LetterToFind + "'s in '" + text);
        }
        //create a function to loop over words in a string 
        static void FindAWord(string wordToFind, string text)
        {

            //counter to count number of letters found 
            int wordCount = 0;
            //split the string into words and convert the array to a list for ease of use
            List<string> words = text.Split(' ').ToList();
            //loop over each word
            for (int i = 0; i < words.Count; i++)
            {
                //get the current word in our loop 
                string word = words[i];
                //compare the lowercase word with the wordToFind 
                if (word.ToLower() == wordToFind.ToLower())
                {
                    //found a word, Count It
                    wordCount = wordCount + 1;

                }
            }
            //output
            Console.WriteLine("Found " + wordCount + " " + wordToFind + "'s in '" + text);
        }

    }
}

        

