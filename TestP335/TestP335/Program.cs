using System.Linq.Expressions;
using System;
using System.Net.Sockets;
using System.Threading.Channels;


namespace TestP335
{
    public class ShortEmailException : Exception
    {
        public ShortEmailException(string message) : base(message) { }
    }

    public class NotEmailAdressException : Exception
    {
        public NotEmailAdressException(string message) : base(message) { }
    }

    public class EmailValidator
    {
        public bool Validate(string email)
        {
            if (email.Length < 10)
            {
                throw new ShortEmailException("Email address is short.");
            }

            if (!email.EndsWith("@gmail.com"))
            {
                throw new NotEmailAdressException("The email address not valid");
            }

            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var emailValidator = new EmailValidator();

            try
            {
                bool isValid = emailValidator.Validate("ali.aliyev@gmail.com");
                Console.WriteLine(isValid);
            }
            catch (ShortEmailException ex)
            {
                Console.WriteLine($"ShortEmailException: {ex.Message}");
            }
            catch (NotEmailAdressException ex)
            {
                Console.WriteLine($"NotEmailAdressException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }


        }
    }

}
