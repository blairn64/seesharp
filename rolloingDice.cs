using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDemo
{
    class Roller
    {
        static void Main(string[] args)
        {
            // Declaring variables
           
            int coin;

            Random generator = new Random();

            // or, do it all in one line with more complex code
            coin = (int)(generator.NextDouble() * 10) / 5;
            Console.WriteLine("coin: {0}", coin);

          
           


             if (coin <= 5) {

               result = "heads";
            }
            else if (coin => 5) {
                    result = "tails";
            }

             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine("press enter to quit");
             Console.ReadLine();


        }// end main
    } //end class
 }// end namespace
