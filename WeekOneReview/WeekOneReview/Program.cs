using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOneReview
{
    class Program
    {
        //declare a global variable to hold the total number of loops executed

        static int loopCount = 0;

        static void Main(string[] args)
        {

            //call stringbuilding function

            StringBuilding("Brandy");

            //print out the number of loops
            Console.WriteLine(loopCount);

            // call the string building function to do more loops
            StringBuilding("running a few more loops");

            //print out the loops performed
            Console.WriteLine(loopCount);

            //call the list practice function 
            ListPractice();

            // keep the console open 
            Console.ReadKey();



        }

        //building a string
        //Take in a string, and output a string  with all vowels uppercase,
        //and all constatnts lowercase.
        static void StringBuilding(string input)
        {
            //declare a string to hold our output

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
                }
                else
                {
                    //if its nor a vowel add a lower case letter to output
                    output = output + letter.ToLower();
                }
                //we did a loop hip hip hooray
                //add one to loop counter
                loopCount = loopCount + 1;
            }
            //after the loop print the output
            //Print the output
            Console.WriteLine(output);

        }
        //working with lists
        static void ListPractice()
        {
          
        // declare a new list of strings
        List<string> sportsList = new List<string>() { "Baseball", "Basketball", "Football" };

    //print out the contents of the sportsList using a for loop in asending order
            for (int i = 0; i < sportsList.Count; i++)
			{
			 
        Console.WriteLine(sportsList[i]);
                // did a loop , count it on the loop count glabal variable
                loopCount ++;
            }
            //List out the contents of the sports list using foreach loop               
   
         foreach (var item in sportsList)
	       {
		        Console.WriteLine(item);
 
	      }
            //looping over a string using for each loop
            string whateves = "Party On People";
            foreach (char item in whateves)
            {
                Console.WriteLine(item);
            }
        }
    }
}


    


