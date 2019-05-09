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

            Console.WriteLine("Welcome to British Rail, please enter the number of the trip you wish to take");
            Console.WriteLine("trip 1 = Bolton to York");
            Console.WriteLine("trip 1 = london to bristol");
            Console.WriteLine("trip 1 = glasgow to perth");
            Console.WriteLine("trip 1 = edinburgh to inverness");
            Console.WriteLine("trip 1 = glasgow to aberdeen");
            Console.WriteLine("trip 1 = london to cornwall");
            
            tripnum = Convert.ToInt16(Console.ReadLine());
            
            
            switch (tripnum)
            {
            case "0": 
                    placename = "Bolton - York";        
                    fare = ticketnums * 34;
                break;
            
           case "1":
                    placename = "London - Bristol";    
                    fare = ticketnums * 55;
                break;

           case "2":
            placename = "Glasgow - Perth";    
            fare = ticketnums * 12;
                break;

            case "3":
            placename = "Edinburg - Inverness"; 
            fare = ticketnums *19;
                break;

            case "4":
            placename = "Glasgow - Aberdeen";
            fare = ticketnums * 19;
                break;

            case "5":
            placename = "London - Cornwall";   
            fare =  *47;
                break;

            }

            Console.WriteLine ();
            Console.ReadLine();



            Console.WriteLine("press any key to quit"());
            Console.ReadLine();

        } // end namespace
    } // end main
} // end class
