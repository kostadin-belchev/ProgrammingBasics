using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks_5_Greater_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers: ");
            var firstInt = int.Parse(Console.ReadLine());
            var secondInt = int.Parse(Console.ReadLine());

            /* var greaterNumber = firstInt;

            if (greaterNumber <= secondInt)
            {
                greaterNumber = secondInt;
            }
            Console.WriteLine("Greater number: " + greaterNumber);

            OR
            */
            if (firstInt > secondInt)
            {
                Console.WriteLine("Greater number: " + firstInt);
            }
            else
            {
                Console.WriteLine("Greater number: " + secondInt);
            }
        
        }
    }
}
