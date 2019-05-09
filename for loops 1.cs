using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{//start namespace
    class Program
    {//start class
        static void Main(string[] args)
        {//start main

            
            Console.WriteLine("what times table would you like to know?");
            double ttable = Convert.ToDouble(Console.ReadLine());

            for (int i =0; i < 50; i++)
            {//start for
                Console.WriteLine(" {0} x {1} = {2}",ttable,i,i*ttable);
            }//end for
        Console.ReadLine();
        }//end main
    }//end class
}//end namespace
