using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            dopassword(); 
        
        }
        static void dopassword() 
        {
                string password = "pass"; 
                string input = ""; 
                int counter; 


                Console.Write("Please enter the password: ");//prompts for user input
                input = Console.ReadLine(); //sets user input variable
                counter=0; // counts what attempt the question is (out of 3)

                if (input == password) // the input password attempt is a match to the PASSWORD
                {//start if
                    Console.WriteLine("Correct password"); // program will display correct password
                    Console.ReadLine();
                    domath(); //does the maths
                    

                }//end if
                    
                    
                    /*shirley i couldnt get my knick knack pady whack to run properly and found it difficult to add the main from my calculator program
                   

                {add main for caalculator app} do{
                     * calculator
                                    */


                else //this else statement diferenciates between the password being correct and incorrect, if the password is incorect:
                {//start else
                    Console.WriteLine("Incorrect password");
                    counter++;     //increments counter to start the logical operations of this program             
                }//end else


                {//start logic

                    if (counter == 1) //if the counter is incremented the password was incorect and the program will ask for a second attempt ("got lost and confused with loops")
                    {//start if
                        Console.WriteLine("password = fail enter second attempt");
                        Console.Write("Please enter the password: ");
                        input = Console.ReadLine();
                         if (input == password)
                        {//start if
                            Console.WriteLine("Correct password");
                            Console.ReadLine();
                            domath(); //if the user gets the correct password the maths will run

                            //do calculator
                        }//end if
                        else
                        {//start else
                            Console.WriteLine("Incorrect password");
                            counter=2;
                        }//end else
                    }//end if

                    if (counter == 2)
                    { //start else if
                        Console.WriteLine("password = fail enter last attempt");
                        Console.Write("Please enter the password: ");
                        input = Console.ReadLine();
                         if (input == password)
                        {//start if
                            Console.WriteLine("Correct password");
                            Console.ReadLine();
                            domath();
                            //do calculator
                        }//end if
                        else
                        {//start else
                            Console.WriteLine("Incorrect password");
                            counter = 3;
                        }//end else
                    }//end else if

                    if (counter==3)
                    { //start if
                        Console.WriteLine("end"); // i have to look back at the program thatquits the system
                        Console.Read();
                    }//END ELSE IF
                    }//end logic
                }//end else

           static void domath() //maths program
        {


            Console.WriteLine("Enter first number"); //asks for first number
            int num1 = Convert.ToInt32(Console.ReadLine()); //converts user input as intiger num1
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine()); // creates second intiger num2 from user input
            Console.WriteLine("Enter 1 to add"); //prompts user for maths operation
            Console.WriteLine("Enter 2 to subtract");
            Console.WriteLine("Enter 3 to divide");
            Console.WriteLine("Enter 4 to multiply");
            int maths = Convert.ToInt32(Console.ReadLine()); //accepts users input to do maths 
            switch (maths) //selects case of maths so the user can chose a different equation between the 2 numbers
            {
                case 1:
                    Console.WriteLine(num1 + num2);
                    break;
                case 2:
                    Console.WriteLine(num1 - num2);
                    break;
                case 3:
                    Console.WriteLine(num1 / num2);
                    break;
                case 4:
                    Console.WriteLine(num1 * num2);
                    break;
            }


            Console.ReadLine();
        }
            }//end main
        }//end class
    

