using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{//start namespace
    class Program
    {//start class
        static void Main(string[] args)
        {//start main

            int computersnumber, yourguess, counter;
            double prize;
            bool correctguess;

            counter = 0;

            correctguess = false;

            Random roller = new Random();
            computersnumber = (int)(roller.NextDouble() * 9) + 1;
            do
            {// start do
                counter++;
                Console.WriteLine("guess a number between 1 & 100");
                yourguess = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("this is guess number {0}", counter);

                while (yourguess < 1 || yourguess > 100)
                {//start while
                    Console.WriteLine("you must guess a number between 1 - 100 only");
                    yourguess = Convert.ToInt16(Console.ReadLine());
                }//end while

                if (yourguess == computersnumber)
                {// start if
                    correctguess = true;
                }// end if
            }//end do while

            while (counter > 5 | correctguess == false);
            prize = (100 * 1) / counter;
            if (correctguess == false)
            {// start if
                Console.WriteLine("your 5 chances were failures");
            }//end if

            else
            {// start else
                if (correctguess == true)
                {//start if
                    if (counter == 1)
                    {//start if
                        Console.WriteLine("guessed it in 1");
                    }// end if
                }//end if
            }        Console.WriteLine("you won {0:c} pounds",prize);
            
                //end else
    
        }//end main
    }//end class
}//end namespace
