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

            Console.WriteLine("please enter decimal number");
            double a =Convert.ToDouble(Console.ReadLine());//converts users input to integer

            double d1 = Convert.ToInt32(a); //converts a to double
            Console.WriteLine("My double is {0}.", d1);
            
            Console.ReadLine();
        }// end main
    } //end class
}// end namspace
