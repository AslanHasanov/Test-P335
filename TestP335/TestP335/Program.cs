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


    internal class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>()
            {
                new User { Name = "John Doe", Age = 42, Country = "USA" },
                new User { Name = "Jane Doe", Age = 38, Country = "USA" },
                new User { Name = "Joe Doe", Age = 19, Country = "Germany" },
                new User { Name = "Jenna Doe", Age = 19, Country = "Germany" },
                new User { Name = "James Doe", Age = 8, Country = "USA" },
            };


            var usersGroupedByCountry = users.GroupBy(user => user.Country);

            foreach (var group in usersGroupedByCountry)
            {
                Console.WriteLine($"Users from {group.Key} :");

                foreach (var user in group) Console.WriteLine("* " + user.Name);
            }

            var usersGroupedByFirstLetters = users.GroupBy(user => user.Name.Substring(0, 2));
            foreach (var group in usersGroupedByFirstLetters)
            {
                Console.WriteLine("Users starting with " + group.Key + ":");
                foreach (var user in group)
                    Console.WriteLine("* " + user.Name);
            }





        }
        public class User
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string Country { get; set; }
        }
    }

}
