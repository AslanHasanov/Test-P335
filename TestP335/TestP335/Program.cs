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

            // app

            //1.Bizə elə bir method lazımdır ki, biz ora öz textimizi göndərdikdə, o textdə olan bütün kiçik hərflər, böyükləri ilə əvəz olunsun,
            //və həmin methodun çağırıldığı yerə dəyişdirilmiş  nəticəni qaytarsın. 

            //Nümünə:    Richard McClintock, a Latin professor   -> RICHARD MCCLINTOCK, A LATIN PROFESSOR

            //NOTES:     Yalnız ingilis hərflərini nəzərə almaq kifayət edir.  Hazır methodlardan yalnız, Replace() istifadə etmək olar.


            //2.Bizə elə bir method lazımdır ki, biz ora öz textimizi göndərdikdə, o textdə olan bütün böyük hərflər, kiçikləri ilə əvəz olunsun,
            //və həmin methodun çağırıldığı yerə dəyişdirilmiş nəticəni qaytarsın. 

            //Nümünə:      RICHARD MCCLINTOCK, A LATIN PROFESSOR -> richard mcclintock, a latin professor

            //NOTES:       Yalnız ingilis hərflərini nəzərə alma¬¬q kifayət edir.   Hazır methodlardan yalnız, Replace istifadə etmək olar.


            //3.Bizə elə bir method lazımdır ki, göndərilən textin daxilində,  digər bir characterin var olub - olmaması barəsində bizi məlumatlandırsın.



            string command1 = "BigLetter";
            string command2 = "SmallLetter";
            string command3 = "Letter";

            Console.WriteLine(command1);
            Console.WriteLine(command2);
            Console.WriteLine(command3);
            Console.WriteLine();

            char[] TargetBiggLetter = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] TargetSmallLetter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
           
          

            while (true)
            {
                Console.Write("Enter Command : ");
                string command = Console.ReadLine();
                if (command == command1)
                {
                    Console.Write("Enter your Text: ");
                    string text = Console.ReadLine();

                    for (int i = 0; i < TargetBiggLetter.Length; i++)
                    {
                        text = text.Replace(TargetSmallLetter[i], TargetBiggLetter[i]);
                    }
                    Console.WriteLine(text);

                }
                else if(command == command2)
                {
                    Console.Write("Enter your text: ");
                    string text= Console.ReadLine();

                    for (int i = 0; i < TargetSmallLetter.Length; i++)
                    {
                        text = text.Replace(TargetBiggLetter[i], TargetSmallLetter[i]);
                    }
                    Console.WriteLine(text);
                }
                else if (command == command3)
                {
                    Console.Write("Enter your text: ");
                    string targetText = Console.ReadLine();

                    Console.Write("Enter your character: ");
                    string targetChar = Console.ReadLine();

                    Console.WriteLine(IsContain(targetText, targetChar));
                }
                else
                {
                    Console.WriteLine("Command not found");
                    break;
                }
            }

            static bool IsContain(string text, string character)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == character[0])
                    {
                        Console.Write("Is Contain: ");
                        return true;
                    }
                }
                Console.Write("Is Contain: ");
                return false;

            }


        }
    }

}
