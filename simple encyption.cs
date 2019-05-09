using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            char key = (char)3;
            string toEncrypt = "abcdef";
            char[] Array = toEncrypt.ToCharArray();

            for (var i = 0; i < Array.Length; i++)
            {
                Array[i] = (char)(Array[i] + key);
            }
            Console.WriteLine(key);
            Console.ReadLine();
        }
    }
}
