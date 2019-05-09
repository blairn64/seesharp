using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gettingstarted
{
    class intro
    { 
        static void Main(string[] args)
        {
            //declaring variables 
            string person;
            string Job;
            string friend;
            string weapon;
            string monster;
            string animal;
            string problem;

            //get information from user and store it in memmory
            Console.WriteLine("name your person");         //this  displays a message onscreen
            person=Console.ReadLine();                              //adds the keystrokes to memmory
            Console.WriteLine("Hello {0}");

            Console.WriteLine("what is your job");
            Job=Console.ReadLine();

            Console.WriteLine("name your friend");
            friend=Console.ReadLine();

            Console.WriteLine("What is your weapon of choice?");
            weapon=Console.ReadLine();

            Console.WriteLine("{0}", person);
            Console.WriteLine("{0}", Job);
            Console.WriteLine("{0}", friend);
            Console.WriteLine("{0}", weapon);
            Console.WriteLine("{0}", monster);
            Console.WriteLine("{0}", animal);
            Console.WriteLine("{0}", problem);


        }//end main
    }//end class
}// end namespace


