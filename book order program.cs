using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {

        static void Main(string[] args)
        {
            string book = "Software Development For Beginners"; 
            double price = 15.99; 
            double discount, cost = 0; 

            Console.WriteLine("how many books would you like to order?"); 
            int bookorder = Convert.ToInt16(Console.ReadLine()); 

            cost = bookorder * price; 

            while (bookorder <= 0 || bookorder > 80) 
            {
                Console.WriteLine("you have selected an invalid amount of books"); //prints error message
                Console.WriteLine("maximum order number is 80"); // prints maximum order number
                Console.WriteLine("how many books would you like to order?");//asks user to re input an amount of books within range
                bookorder = Convert.ToInt16(Console.ReadLine());
            }

            
            if (bookorder < 5) // if the book order is less than 5 no discount is applied
            {
                Console.WriteLine("no discount applied");
                discount = 0;
            }

            else if (bookorder <= 10)// if books ordered are more than 10 a 5% discount is applied
            {
                discount = 5;
            }

            else if (bookorder <= 50) // if the books ordered are between 11 & 50 a 7.5% discount is applied
            {
                discount = 7.5;
            }
            else
            {// for all books amounts greater than 50 a 10% discount is applied
                discount = 10;
            }


            cost = price * bookorder; // multiply the cost of books by the amount of books to get a cost price
            double totaldiscount = cost / 100 * discount; // works out how much discount is given (price * books / 100 * discount amount) to deduct from total price


            Console.WriteLine("voucher number");
            int vouchercode = 123; //pre defined voucher number for discount to work
            int vouchernumber = Convert.ToInt16(Console.ReadLine()); // asks user for voucher number
            double voucherprice = 0.00; // gives price of discount voucher 
            double finalcost = ((cost - totaldiscount) - (voucherprice));// // changes price of final cost to deduct voucher price

            if (vouchernumber != vouchercode) // condition will only run if voucher numbers must mach
            {
                Console.WriteLine("thats not a valid voucher number");
                voucherprice = 0;
            }
            else
            {
                Console.WriteLine("£25.00 off order has been applied");
                voucherprice = 25;
            }
            //calculates the cost to two decimal places
            discount = Math.Round(discount, 2); // rounds up discount price to 2 decimal places
            finalcost = Math.Round(finalcost, 2); // rounds up final cost to 2 decimal places
            totaldiscount = Math.Round(totaldiscount, 2); // rounds total discount to 2 decimal places


            // prints off information
            Console.WriteLine("Book Title: {0}", book); // shows book title
            Console.WriteLine("ammounts of books ordered: {0}", bookorder); // displays numbers of books ordered
            Console.WriteLine("price of each book: {0:c}", price);
            Console.WriteLine("total price of all books: cost {0:c} - {1:c} ({4}% discount) - {2:c}(voucher price) = {3:c}", cost, totaldiscount, voucherprice, (cost - totaldiscount) - (voucherprice), discount); // displays total cost
            Console.WriteLine("discount amount: {0}%, total cost of discount: {1:c}", discount, totaldiscount);//displays discount amounts
            Console.WriteLine("vouchernumber: {0}, value of voucher = {1:c}", vouchernumber, voucherprice);//displays voucher price

            Console.ReadLine();

        }
    }
}

