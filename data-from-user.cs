using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace address
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring string variables to hold text
            string userName;                                                       // variable - string
            string address1;                                                        // variable - string
            string town;                                                             //...
            string postcode;
            string telephone;

                                            //Gathering data from the user
            
            Console.Beep();
            Console.Write("Please enter your full name ");                       // input data
            userName=Console.ReadLine();                                        // reads stored/input data
            Console.Write("Please enter the first line of your address: ");
            address1=Console.ReadLine();
            Console.Write("Please enter your town: ");
            town=Console.ReadLine();
            Console.Write("Please enter your postcode: ");
            postcode=Console.ReadLine();
            Console.Write("Please enter your telephone number: ");
            telephone=Console.ReadLine();

            
                                               //Displaying the results
            Console.WriteLine();
            Console.WriteLine("your details are: ");                            //output
            Console.WriteLine(); 
                                                                                // outputs all entered/stored data
            Console.WriteLine("{0}", userName);
            Console.WriteLine("{0}", address1);
            Console.WriteLine("{0}", town);
            Console.WriteLine("{0}", postcode);
            Console.WriteLine("{0}", telephone);
;           

            //end section
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter key to quit");
            Console.ReadLine();


        }//end main
    }//end class
}//end namespace
