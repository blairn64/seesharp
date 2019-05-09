using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
    /// <summary>
    /// blair niblo
    /// october 2014
    /// </summary>
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            int tripnum = 0;
            int ticketnums = 0;
            int fare = 0;
            string placename = "";
            string country;

            Console.WriteLine("Please enter the desired country, England or Scotland");
            country = Console.ReadLine();

            if (country.ToUpper() == "ENGLAND") {}

                Console.WriteLine("Welcome to British Rail, please enter the number of the trip you wish to take");
                Console.WriteLine();
                Console.WriteLine("1. Bolton to York");
                Console.WriteLine("2.London to Bristol");
                Console.WriteLine("3. London to Cornwall");
            
                tripnum = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Please enter the number of tickets required");
                ticketnums = Convert.ToInt16(Console.ReadLine());
            
            
                switch (tripnum)
                {
                case 1: 
                    placename = "Bolton - York";        
                    fare = ticketnums * 34;
                    Console.WriteLine("Your journey from {0} for {1} people will cost £{2}", placename, ticketnums, fare);
                    break;
            
                case 2:
                    placename = "London - Bristol";    
                    fare = ticketnums * 55;
                    Console.WriteLine("Your journey from {0} for {1} people will cost £{2}", placename, ticketnums, fare);
                    break;

                case 3:
                    placename = "London to Cornwall";    
                    fare = ticketnums * 47;
                    Console.WriteLine("Your journey from {0} for {1} people will cost £{2}", placename, ticketnums, fare);
                    break;
                default:
                        Console.WriteLine("Please only enter a valid trip number or valid number of tickets required!");
                        break;
                }//end switch
            }//end if section of if statement

            else {


            case 1:
                placename = "Edinburgh - Inverness"; 
                fare = ticketnums * 19;
                Console.WriteLine("Your journey from {0} for {1} people will cost £{2}", placename, ticketnums, fare);
                break;

            case 2:
                placename = "Glasgow - Aberdeen";
                fare = ticketnums *19;
                Console.WriteLine("Your journey from {0} for {1} people will cost £{2}", placename, ticketnums, fare);      
                break;

            case 6:
            placename = "Glasgow - Perth";   
            fare = ticketnums *12;
            Console.WriteLine("Your journey from {0} for {1} people will cost £{2}", placename, ticketnums, fare);      
            break;

            }

            Console.WriteLine ();
            Console.ReadLine();

            Console.WriteLine(“Please enter country you require”);
          
            If (country.ToUpper() == “SCOTLAND”) {        OR 
                If (Country.ToLower() == “scotland”) {
                
              
///if country is england print trip 1 + trip 2 + trip 6 = false 
///if country is scotland print trip 3 + trip 4 + trip 5 = true
/// if
                    


            Console.WriteLine("press any key to quit"());
            Console.ReadLine();
            Console.ReadLine();
                    {
                    if (true) Console.WriteLine ("all destinations in scotland");
                    Console.WriteLine ("case trip {3} + case trip {4} + case trip {5}");
                    }
                    if (false) (( Console.WriteLine ("all destinations in England ");
                    Console.WriteLine (case trip {1} + case trip {2} + case trip {6});
                    {
        } // end namespace
    } // end main
} // end class
