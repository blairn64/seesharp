using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple_Maths_Game
{// start namespace
  
    class Game
    { //start class
        static void Main(string[] args)
        { //start main

            //addition
            int a, b, c, guess, score;
            score = 0;

            //create the random number generator
            Random roller = new Random();

            Console.WriteLine("solve the problems?");
            
            // addition
            a = (int)(roller.NextDouble() * 10) + 1;
            b = (int)(roller.NextDouble() * 10) + 1;
            c = a + b;

            Console.Write("What is {0} + {1}?", a, b);
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess == c)
            {
                score++;
            }

            // subtraction
            a = (int)(roller.NextDouble() * 10) + 1;
            b = (int)(roller.NextDouble() * 10) + 1;
            c = a + b;

            Console.Write("What is {0} - {1}?", c, a);
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess == b)
            {
                score++;
            }
            Console.WriteLine();

            //multiplication
            a = (int)(roller.NextDouble() * 10) + 1;
            b = (int)(roller.NextDouble() * 10) + 1;
            c = a * b;

            Console.Write("What is {0} * {1}?", a, b);
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess == c)
            
            {
                 score++;
            }

            Console.WriteLine();

     //division
            a = (int)(roller.NextDouble() * 10) + 1;
            b = (int)(roller.NextDouble() * 10) + 1;
            c = a * b;

     
            Console.Write("What is {0} / {1}?", c,a);
            guess = Convert.ToInt32(Console.ReadLine());

     
            if (guess == b)
     
            {
                score++;
            }



    // Getting the results
      
            Console.WriteLine("Score: {0} out of 4", score);
       
            Console.WriteLine();
      
            switch (score)
       
            {
           case 4:
                Console.WriteLine("You are brilliant!");
                break;
           case 3:
                Console.WriteLine("You are quite smart");
                break;
           case 2:
                Console.WriteLine("I think you need more practice");
                break;
           case 1:
                Console.WriteLine("Perhaps you would be better studying football!");
                break;
           default:
                Console.WriteLine("There is something very wrong here!");
                break;
     
            }// end switch

        
       
            Console.WriteLine();
       
            Console.WriteLine();
      
            Console.WriteLine("Please press any key to quit");
      
            Console.ReadLine();

        } //end namespace
    } // end class
} // end main
