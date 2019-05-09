using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    class ThisOldMan
    {
        static void Main(string[] args)
        {
            doVerse(1);
            doChorus();
            doVerse(2);
            doChorus();
            Console.WriteLine();
        }//end main

        static void doChorus(){
            string message = "";
            message += "\n... with a knick knack pady whack \n";
            message += "Give the dog a bone \n";
            message += "This old man came roling home.";
            message += "\n\n";
            System.Console.WriteLine(message);
           
        }//end doChorus

        static void doVerse(int verseNum)
        {
            string message = "";
            message += "This old man, he played";
            message += verseNum;
            message += "\n he played knick knack";
            message += getPlace(verseNum);
            Console.WriteLine(message);
        }//end verse

        static string getPlace(int verseNum)
        {
            string message = "";
            switch (verseNum)
            {
                case 1:
                    message = "on my thumb";
                    break;
                case 2:
                    message = "on my shoe";
                    break;
                default:
                    message="not yet defined";
                        break;
          }// end switch
            return message;
            
        }//end getPlace

    
    }//end class
}//end namespace
