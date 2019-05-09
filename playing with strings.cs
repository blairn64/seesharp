using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class mangler 
    {
        static void Main(string[] args)
        {
            string theString = "getting started with programming in c#";

            Console.WriteLine("default: \t {0}", theString);
            Console.WriteLine();
            Console.WriteLine("lowercase: \t {0}", theString.ToLower());
            Console.WriteLine("uppercase: \t {0}",theString.ToUpper());
            Console.WriteLine("replace: \t {0}", theString.Replace("#", "sharp"));
            Console.WriteLine("length: \t {0}", theString.Length);
            Console.WriteLine("\"started\" occurs at character {0}", theString.IndexOf("started"));
            Console.Read();
        }//end main
    }//end class
}//end namespace
