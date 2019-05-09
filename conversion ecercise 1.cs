using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcprog
{// start namespace
    class calcprog
    {//start class
        static void Main(string[] args)
        {// start main

            Console.WriteLine("enter number 1");
            int number0= Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("enter number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number0 + number1);
            Console.ReadLine();


        }// end main
    } //end class
}// end namspace
