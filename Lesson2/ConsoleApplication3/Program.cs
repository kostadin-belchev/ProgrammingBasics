using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            var age = Console.ReadLine();
            Console.WriteLine("Enter the name of your town: ");
            var town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}", firstName, lastName, age, town);
        }
    }
}
