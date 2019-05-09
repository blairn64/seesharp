using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passfail
{
    /// <summary>
    /// Blair Niblo
    /// oct 2014
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
        // declare variables
            int Jacksage;
            int Jillsage;
            int result;
            string eldest;
           

            Console.WriteLine("what is Jacks Age?"); // ask name and store as a variable {0}
            Jacksage = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("what is Jills age?");       // ask score and store as a varable {1}
            Jillsage = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine();

           
            //convert string to intiger 
            
            if (Jacksage > Jillsage) {
                result = Jacksage - Jillsage;
                eldest = "Jack";
            }

            else {
                result = Jillsage - Jacksage;
                eldest = "Jill";
            }
            
            Console.WriteLine("The eldest of the two is {0}, by {1} years", eldest, result);
            


            Console.WriteLine();
            Console.WriteLine("Press enter key to quit");
            Console.ReadLine();
                

        } //end namespace

    } // end class
} // end main
