using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{// start namespace
    class Program
    {//start class
        static void Main(string[] args)
        {
            Console.WriteLine("enter decimal number");
            Double number1 = Convert.ToDouble(Console.ReadLine());
            float i = Convert.ToInt32(number1);

            Console.WriteLine(i);
            Console.ReadLine();


        }

    }//end class
}//end namespace
