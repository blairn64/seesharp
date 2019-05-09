using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

                        // declairing a variable and assigning a value to it at creation

            string userName = "jack";

                        // using the variable and then the special character
            Console.WriteLine("Hi, " + userName + " welcome to my world!");
            Console.WriteLine();
            Console.WriteLine("this line has a \t tab in it");          // \t creates a stop tab
            Console.WriteLine("this line has a \n new line in it");     // puts text on a new line
            Console.WriteLine("this line has a \\ backslash in it");    // creates a single backslash
            Console.WriteLine("this line has \"quotation marks\" in it");// creates "" marks within text
            Console.WriteLine();
            Console.WriteLine("press enter key to quit");
            Console.ReadLine();

                
        }// end main
    } //end class
} // end namespace
