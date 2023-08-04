using System.Linq.Expressions;
using System;
using System.Net.Sockets;
using System.Threading.Channels;

namespace TestP335
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //// Simple string concatenation
            //Console.WriteLine("Hello" + " " + "String " + "!");

            //string firstName = "Mahesh";
            //string lastName = "Chand";

            //string name = firstName + " " + lastName;
            //Console.WriteLine(name);



            //// String Interpolation
            //string author = "Mahesh Chand";
            //string book = "C# Programming";

            //string bookAuthor = $"{author} is the author of {book}.";
            //Console.WriteLine(bookAuthor);

            ////............................if..................................//

            ////int number = 2;
            ////if (number < 5)
            ////{
            ////    Console.WriteLine(number+" is less than 5" );
            ////}


            //int number = 12;

            //if (number < 5)
            //{
            //    Console.WriteLine(number+ " is less than 5");
            //}
            //else
            //{
            //    Console.WriteLine(number + " is greater than or equal to 5");
            //}

            string word1 = "tree";
            string word2 = "eter";

            bool areAnagrams = true;

            if (word1.Length != word2.Length)
            {
                areAnagrams = false;
            }
            else
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    bool found = false;
                    for (int j = 0; j < word2.Length; j++)
                    {
                        if (word1[i] == word2[j])
                        {
                            found = true;
                            word2 = word2.Remove(j, 1);


                            break;
                        }
                    }
                    if (!found)
                    {
                        areAnagrams = false;
                        break;
                    }
                }
            }
                Console.WriteLine(areAnagrams);





        }
    }
}