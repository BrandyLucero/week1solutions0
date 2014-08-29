using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOneReview
{
    class Program
    {
        static int loopCount = 0;

        static void Main(string[] args)
        {
           
            //declare a global variable to hold the total number of loops executed


            //call stringbuilding function
            StringBuilding("Brandy");

            sportsList();


            // keep the console open
            Console.ReadKey();

        }

        //building a string
        //Take in a string, and output a string  with all vowels uppercase,
        //and all constatnts lowercase.
        static void StringBuilding(string input)
        {
            string output = string.Empty;

            // loop over the input, to compare each letter
            for (int i = 0; i < input.Length; i++)
                 

            {
               
                //get a letter from input
                //convert the char to a string
                string letter = input[i].ToString();

                //determine if the letter is a vowel
                string vowels = "a e i o u";
                if (vowels.Contains(letter.ToLower()))
                {
                    //it is a vowel add to our output and upper case letter 
                    output = output + letter.ToUpper();
                    loopCount = loopCount + 1();


                }
                else
                {
                    output = output + letter.ToLower();

                }
               
                
            }
            //Print the output
            Console.WriteLine(output);
             
        }
    
    
    
        // declare a new list
        List<string> sportsList = new List<string>(); {"baseball", "basketball", "football"}
    //print out the contents of the sportsList using a for loop in asending order
    Console.WriteLine(sportsList[i]

{
    for (int i = sportsList.Count - 1; i >= 0; i--)
   
    foreach (var item in sportsList)
	{
		Console.WriteLine(item);
 
	}
}

    


