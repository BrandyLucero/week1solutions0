using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // call our whilelooptest
            WhileLoopTest();
            // call our flipACoin function
           // FlipACoin(1042);
            FlipforHeads(416);

            // keep console window open
            Console.ReadKey();

        }
        // Functions go here

        static void WhileLoopTest()
        {
            // declaring our incrementor 
            int i = 1;
            //define the whle loop condition 
            while (i <= 10)
            {
                Console.WriteLine(i);
                i = i + 1;
            }

        }

        static void FlipACoin(int flips)
        {
            //integers to hold 
            //how many times flipped on heads 
            int countHeads = 0;
            int countTails = 0;

            //Create a randon number generator
            Random rng = new Random();

            // flip the coin as many as the flips
            //parameter says we should

            for (int i = 0; i < flips; i = i + 1)
            {
                // flip that coin
                int flip = rng.Next(0, 2);
                if (flip == 0)
                {
                    countTails = countTails + 1;
                }

                else
                {

                    countHeads = countHeads + 1;
                }

            }
            //output the number of heads 

            Console.WriteLine("# of Heads: " + countHeads);
            Console.WriteLine("# of Tails: " + countTails);
           
        }

        //flip a coing until we get x number if heads
        static void FlipforHeads(int numheads)
        {
            // counts how many heads we flipped 
            int headsFlipped = 0;
                
            //incrementor for our loop
            int totalFlips = 0;

            //random number generator
            //"flip" our coin
            Random rng = new Random();
            //do a whooe loop until we reachd the desired number of heads
            while (numheads != headsFlipped)
            {
                //flip a coin
                if (rng.Next(0,2) == 0)
                {
                    headsFlipped = headsFlipped + 1;
                }
                totalFlips = totalFlips + 1;
            }
            {
                Console.WriteLine("It took " + totalFlips + " flips to get " + numheads + " heads ");
            }
                //write the output of total flips 
               
                {
                  
                }
            }
        }

    }






