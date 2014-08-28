using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLists
{
    class Program
    {
        //Declare a new list of strings for a menu

        static void Main(string[] args)
        {
            List<string> myMenu = new List<string>() { "Salads", "Tacos", "Pizza" };

            //add one more item
            myMenu.Add("Steak");

            // drop through pur menu
            for (int i = 0; i < myMenu.Count; i++)
            {
                Console.WriteLine(myMenu[i]);
            }

            // remove things from a list
            myMenu.Remove("Pizza");
            //remove by index
            myMenu.RemoveAt(1);

            // Another easier way of printing out an array
            Console.WriteLine(string.Join(", ", myMenu));
            
            //loop through list again 
            for (int i = 0; i < myMenu.Count; i++)
            {
                // set var equal to the current item
                //in our list 
                string item = myMenu[i];
                // convert item to a lowercase

                if (item.ToLower().Contains("s"))
                {
                    {
                        Console.WriteLine(item.ToUpper());

                    }
                  
                }
            }
  // keep menu open
                    Console.ReadKey();
        }
    }
}
