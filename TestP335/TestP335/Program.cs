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
            //1

            //Console.Write("Please enter Array's lenght: ");
            //int lenght = int.Parse(Console.ReadLine());

            //int total = 0;
            //for (int i = 0; i < lenght; i++)
            //{
            //    Console.Write($"Enter {i + 1}. number: ");
            //    int number = int.Parse(Console.ReadLine());
            //    total += number;
            //}

            //Console.WriteLine($"Total of arrays numbers: {total}");





            //2

            //Console.Write("Please enter Array's lenght: ");
            //int arrayLenght = int.Parse(Console.ReadLine());

            //int[] array = new int[arrayLenght];

            //for (int i = 0; i < arrayLenght; i++)
            //{
            //    Console.Write($"Enter {i + 1}. number: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int small = array[0];
            //int large = array[0];

            //for (int i = 1; i < arrayLenght; i++)
            //{
            //    if (array[i] > large)
            //    {
            //        large = array[i];
            //    }

            //    if (array[i] < small)
            //    {
            //        small = array[i];
            //    }
            //}

            //Console.WriteLine($"Largest number: {large}");
            //Console.WriteLine($"Smallest number: {small}");



            Console.Write("enter arr lenght: ");
            int lenht= int.Parse(Console.ReadLine());
            int[] ints = new int[lenht];

            for (int i = 0; i < lenht; i++)
            {
                Console.WriteLine($"enter {i+1}. number");
                ints[i] = int.Parse(Console.ReadLine());
            }

            int small = ints[0];
            int large = ints[0];

            for (int i = 0; i < lenht; i++)
            {
                if (ints[i] > large)
                {
                    large= ints[i];
                }
                if (ints[i] < small)
                {
                    small= ints[i];
                }
            }



            //3 

            //Console.Write("Please enter Array's lenght: ");
            //int lenght = int.Parse(Console.ReadLine());

            //int[] array = new int[lenght];

            //for (int i = 0; i < lenght; i++)
            //{
            //    Console.Write($"Enter {i + 1}. number: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int evenTotal = 0;

            //foreach (int number in array)
            //{
            //    if (number % 2 == 0)
            //    {
            //        evenTotal += number;
            //    }
            //}

            //Console.WriteLine($"Total of even numbers: {evenTotal}");










            //4 app

            //1.Bizə elə bir method lazımdır ki, biz ora öz textimizi göndərdikdə, o textdə olan bütün kiçik hərflər, böyükləri ilə əvəz olunsun,
            //və həmin methodun çağırıldığı yerə dəyişdirilmiş  nəticəni qaytarsın. 

            //Nümünə:    Richard McClintock, a Latin professor   -> RICHARD MCCLINTOCK, A LATIN PROFESSOR

            //NOTES:     Yalnız ingilis hərflərini nəzərə almaq kifayət edir.  Hazır methodlardan yalnız, Replace() istifadə etmək olar.







            //2.Bizə elə bir method lazımdır ki, biz ora öz textimizi göndərdikdə, o textdə olan bütün böyük hərflər, kiçikləri ilə əvəz olunsun,
            //və həmin methodun çağırıldığı yerə dəyişdirilmiş nəticəni qaytarsın. 

            //Nümünə:      RICHARD MCCLINTOCK, A LATIN PROFESSOR -> richard mcclintock, a latin professor

            //NOTES:       Yalnız ingilis hərflərini nəzərə alma¬¬q kifayət edir.   Hazır methodlardan yalnız, Replace istifadə etmək olar.







            //3.Bizə elə bir method lazımdır ki, göndərilən textin daxilində,  digər bir characterin var olub - olmaması barəsində bizi məlumatlandırsın.




            //        string command1 = "Change The Big Letter";
            //        string command2 = "Change The Small Letter";
            //        string command3 = "Choose The Letter";
            //        Console.WriteLine(command1);
            //        Console.WriteLine(command2);
            //        Console.WriteLine(command3);
            //        Console.WriteLine();

            //        char[] TargetBiggLetter = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            //        char[] TargetSmallLetter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            //        while (true)
            //        {
            //            Console.Write("Enter Your Command : ");
            //            string command = Console.ReadLine();

            //            if (command == command1)
            //            {
            //                Console.Write("Enter Your Text :");
            //                string targetTXT = Console.ReadLine();
            //                for (int i = 0; i < TargetBiggLetter.Length; i++)
            //                {
            //                    targetTXT = targetTXT.Replace(TargetSmallLetter[i], TargetBiggLetter[i]);
            //                }
            //                Console.WriteLine(targetTXT);
            //            }
            //            else if (command == command2)
            //            {
            //                Console.Write("Enter Your Text :");
            //                string targetTXT = Console.ReadLine();
            //                for (int i = 0; i < TargetSmallLetter.Length; i++)
            //                {
            //                    targetTXT = targetTXT.Replace(TargetBiggLetter[i], TargetSmallLetter[i]);
            //                }
            //                Console.WriteLine(targetTXT);
            //            }
            //            else if (command == command3)
            //            {

            //                Console.Write("Enter Your Text :");
            //                string targetTXT = Console.ReadLine();

            //                Console.Write("Enter Your Char :");
            //                string character = Console.ReadLine();

            //                Console.WriteLine(IsContain(targetTXT, character));
            //            }
            //            else { break; }

            //        }
            //    }
            //    public static bool IsContain(string targetTxt, string targetChar)
            //    {
            //        for (int i = 0; i < targetTxt.Length; i++)
            //        {
            //            if (targetTxt[i] == targetChar[0])
            //            {
            //                Console.Write("Contain :");
            //                return true;
            //            }
            //        }
            //        Console.Write("IsContain : ");
            //        return false;
            //    }

        }
    }

}
