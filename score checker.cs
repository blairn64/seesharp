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
            //declaring variables

            string userName;
            string result=null;
            

            Console.WriteLine("what is your name?");
             userName = Console.ReadLine();

            Console.WriteLine("what was your mark?");
            int mark = Convert.ToInt32(Console.ReadLine());
            {//start logic

                if (mark <= 50)
                {//start if
                    result = "fail";
                }//end if

                else if (mark >= 50)
                { //start else if
                    result = "pass";
                }//end else if

                else if (mark>=75)
                {//start else if
                 string merit=Console.WriteLine("merit awarded");
                }
            }
               

            
       



                    Console.WriteLine();
                    Console.WriteLine("Nice to speak to you {0}  ", userName);
                    Console.WriteLine("your have recieved a {0}  ", result);
                    Console.WriteLine("your mark was: {0}  ", mark);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("press any key to quit");
                    Console.ReadLine();




                }
            }

    }
