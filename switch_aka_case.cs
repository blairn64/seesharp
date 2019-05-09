using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo  /// start namespace
{
    /// <summary>
    /// a simple program to demonstrate a case statement known in c based languages as switch
    /// </summary>
    class Program // start class
    {
        static void Main(string[] args) // start main
        {
            // derclaring variables
            string fullName;
            string greetings;

            // get data from user
            Console.WriteLine("please enter your full name");
            fullName= Console.ReadLine();

            //check name, compare and store specific greetings
            switch (fullName)
            {
                case "trip 1": // strings get shown in "" marks
                    greetings = "bolton to york - 34";
                    break;

                case "superman":
                    greetings = "help us superman";
                    break;
                case"spiderman":
                    greetings = "Thank heavens you are here spiderman!";
                    break;

                case "catwoman":
                    greetings = "mioooaoaw!";

                case "spawn":
                    greetings = "you can call me al";
                        break;
                case "blackbolt":
            greetings = "   ";

                case "gambit":
                default: // if nothing fits use this
                    greetings = "are there any super heroes out there?";
                    break;
            }//end switch

            //write to screen
            Console.WriteLine(greetings);
            Console.ReadLine();
           

        }// end namespace
    } // end class
} // end main
