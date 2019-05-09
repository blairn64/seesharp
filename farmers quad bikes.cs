using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{//START NAMESPACE
    class Program
    {//START CLASS
        static void Main(string[] args)
        {//START MAIN
            

            //set up variables to get info from procedures

            string groupname = getGroupname();
            int groupnum = getGroupnum();
            int age = getage();
            float total=gettotal();
            string totaltext = string.Format("{00:00.00}", total);
        }

            static string getGroupname();
            {//start getgroupname
            Console.Writeline("what is the name of this group?");
           string groupname = Convert.ToString(Console.ReadLine());
           }//end getgroupname

            static int getGroupnum()
            {//startgetgroupnum
            Console.WriteLine("how many people are in this group?");
            int groupnum = Convert.ToInt16(Console.ReadLine());
            }//end getgroupnum



            if (groupnum >= 10 || groupnum < 2)
            {//start if
                Console.WriteLine("wrong amount of people chosen for group bookings");
                Console.ReadLine();
                Environment.Exit(1);
            }//end if
            
            
            
          
            /* this is not possible can i loop the question and store the individual ages 
             * 
             
             * foreach (int s in groupnum)
          {
                Console.WriteLine(s);
                Console.WriteLine("what age is this person?");
                int age = Convert.ToInt16(Console.ReadLine());
            }
           */
            static string getage()
            {//start getuserage
            
            for (int i = 0; i < groupnum; i++)
            {//start for
             Console.WriteLine("what age is this person?");
             int age = Convert.ToInt16(Console.ReadLine());
            }//end for

            }// end getuserage


            static float gettotal()
            {//start gettotal
            
            if (age <= 18 | age >= 60)
            {//start if
                double price = 27.50;
            }//end if

            else {//start else
             double price = 40.00
            }//end else

            Console.WriteLine("");


    //lost on adding up the total  

            Console.WriteLine("Name of group:{0}", Groupname);
            Console.WriteLine("number in group:{0}", groupnum);
            Console.WriteLine("total cost:{0}", price*groupnum);
            Console.ReadLine();
           


           
        }// END MAIN


    }//END CLASS
}//END NAMESPACE
