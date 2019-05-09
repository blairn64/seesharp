using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            // derclaring variables
            
            
            string greetings;
            Console.WriteLine("Trip 1 Bolton to York");

            Console.WriteLine("Trip 2 London to Bristol");
            Console.WriteLine("Trip 3 Glasgow to Perth");
            Console.WriteLine("Trip 4 Edinburgh to Inverness");
            Console.WriteLine("Trip 5 Glasgow to Aberdeen");
            Console.WriteLine("Trip 6 London to Cornwall");
           
            
            int destination = Convert.ToInt32(Console.ReadLine());
           
            
            

            
            
            switch (destination)
            {
                case 1: 
                greetings = "bolton to york - 34";
                int price= 34;
                Console.WriteLine("how many tickets do you require?");
                int ticketnum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("price is {0}", ticketnum * price);
                
                break;

                case 2:
                greetings = "London to Bristol";
                break;
                
                case 3:
                greetings = "Glasgow to Perth";
                break;

                case 4:
                greetings = "Edinburgh to Inverness";
                break;
                

                case 5:
                greetings = "Glasgow to Aberdeen";
                break;


                case 6:
                greetings = "London to Cornwall";
                break;

                default:// if nothing fits use this
                greetings = "are there any super heroes out there?";
                break;
            //end switch
}
            //write to screen
            Console.WriteLine("{0}",greetings);
            Console.ReadLine();
           
               
            }
        }
    }


