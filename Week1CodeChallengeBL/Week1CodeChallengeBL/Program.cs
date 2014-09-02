using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallengeBL
{
    class Program
    {
        static void Main(string[] args)
        {

            //create a loop from 0=>20
            for (var i = 0; i <= 20; i++)
            {
             Console.WriteLine(FizzBuzz(i));
            }
            //end fiz buzz loop 1=>20             
            //create a loop from 92=>97
           
   
            for (var i = 92; i >= 79; i--) 
           {
             Console.WriteLine(FizzBuzz(i));
           }   
            //end fizz buzz loop 92=>79


            //Call yodaizer("I Like code")
             Yodaizer("I like code");

            //call text stats function using 3 sentences. 

            TextStats("I enjoyed week one. I can't wait until week two. I am learning alot");

            //call IsPrime function
            //Do IsPrime loop
            //call IsPrime (i) for each loop
             for (var i = 1; 1 <= 25; i++)
             {
                 IsPrime(i);
             }
            //end is prime function 1=>25

             //call insert dash function 8675309
                 DashInsert(8675309);
                 //keep the console open
                 Console.ReadKey();
        }
        
        //Create FizzBuzz Function
       static string FizzBuzz(int number)
        {
           //fill in fizz buzz logic
           //iff divisible by both 5&3
            if (number % 3 == 0 && number % 5 == 0)
            {
               return "FizzBuzz!";
            }
            //if # is divisible by 5 output "Fizz"
            else if (number % 5 == 0)
            {
                return "Fizz!";
            }
                //if divisible by 3
            else if (number % 3 == 0)
            {          
                return "Buzz!";
            }
            else
            //if not either divisible by 5 or 3 output the number
            {
                return number.ToString();
            }

        }
        //Yodaizer function
        static void Yodaizer(string text)
        {

         //take the text "i Like code" and reverse it"
            string[] input = text.Split(' ');
        // put words in reverse in console
            for (var i = input.Length - 1; i >= 0; i--)
            {
                if(input.Length == 3)
                {
                Console.WriteLine(input[2] + ", " + input[0] + " " + input[1]);
                break;
            }
            
            
             //calling input with i index will print the words in reverse
                else
            {   
                Console.WriteLine(input[i] + " ");
            }
         }
    }
            //Text Stats
            static void TextStats(string input)
            { 
          // report text stats

            var characters = input.Length;
            var words = 0;
            var vowels = 0;
            var consonants = 0;
            var special = 0;
            string[] array = input.Split(' ');
            words = array.Length;
                //create a loop
           for (var i = 0; i < input.Length; i++)
        {
            if (input[i].ToString() == "a" || input[i].ToString() == "e" || input[i].ToString() == "i" || input[i].ToString() == "o" || input[i].ToString() == "u")
        {
            vowels = vowels + 1;
            }
                else if (input [i].ToString() == "!" || input[i].ToString() == ";" || input[i].ToString() == "'" || input[i].ToString() == "," || input[i].ToString() == "." || input[i].ToString() == "?" || input[i].ToString() == " ")
            {
                special = special + 1;

              }
                else
             {
                consonants = consonants + 1;
             }
        }
           Console.WriteLine(input);
           Console.WriteLine("There are " + characters + " characters in this sentence");
           Console.WriteLine("There are " + words + " words in this sentence");
           Console.WriteLine("There are " + vowels + " vowels in this sentence");
           Console.WriteLine("There are " + consonants + " consonants in this sentence");
           Console.WriteLine("There are " + special + " special characters in this sentence");
        }

        // Find prime numbers
        static void IsPrime(int number)
        {
        //create a var to hold how many times a number is a prime number
        var divCount = 0;
        for (var i = 1; i <= number; i++)
        //loop wll check to see if divisibe by i
        {
            if (number % i == 0)
                 {
                   divCount = divCount + 1; 
                 }
             }

        //check the counter  for less than 3 will confirm if number is prime 
           if (divCount > 2)
          {
            Console.WriteLine("This number " + number + " is Prime");
          }   
    
        }
        //DashInset function
        static void DashInsert(int number)
        {
            //insert the dashinsert info 
            var num = number.ToString();
            var array = num.Split(); 
            for (var i = 0; i < num.Length - 1; i++)
            {
                if (num[i] % 2 != 0 && num[i + 1] % 2 != 0)
                {

                }
                else
                {
                    Console.Write(num[i] + "-");
                }   
                }
                     Console.Write(num.Last());
            }
        }

    }

  
            
