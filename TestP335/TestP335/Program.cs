using System.Linq.Expressions;
using System;

namespace TestP335
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simple string concatenation
            Console.WriteLine("Hello" + " " + "String " + "!");

            string firstName = "Mahesh";
            string lastName = "Chand";

            string name = firstName + " " + lastName;
            Console.WriteLine(name);

            // String Interpolation
            string author = "Mahesh Chand";
            string book = "C# Programming";
           
            string bookAuthor = $"{author} is the author of {book}.";
            Console.WriteLine(bookAuthor);

            //............................if..................................//

            //int number = 2;
            //if (number < 5)
            //{
            //    Console.WriteLine(number+" is less than 5" );
            //}




            int number = 12;

            if (number < 5)
            {
                Console.WriteLine(number+ " is less than 5");
            }
            else
            {
                Console.WriteLine(number + " is greater than or equal to 5");
            }


        }
    }
}