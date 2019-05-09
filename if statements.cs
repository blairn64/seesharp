using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstratingif
{
    /// <summary>
    /// simple program to demonstrate the use of if statement syntax
    /// blair niblo
    /// september 2014
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            string userName;
            string result;
            int mark;

            // ask the user the required question! and store your answer as a variable
            Console.WriteLine ("what is your name?");
            userName = Console.ReadLine();

            Console.WriteLine("what was your mark?");
            mark = Convert.ToInt32(Console.ReadLine());
            

            
           
            // basic if statement with one condition only
            
            if (mark <= 50) {
               result = "pass";
            }
            else 
                (mark => 50) { 
                    result = "fail";
            }
                    
           Console.WriteLine();
           Console.WriteLine ("Nice to speak to you {0}", userName ));

            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine ("press any key to quit");
            Console.ReadLine();

        
  





        } //end main
      } //end class
}//end namespace