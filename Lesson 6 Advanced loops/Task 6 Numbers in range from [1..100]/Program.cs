using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_Numbers_in_range_from__1._._100_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            var number = int.Parse(Console.ReadLine());

            while (number < 1 || number > 100)
            {
                Console.WriteLine("Invalid numer!");
                Console.Write("Еnter a number in the range [1...100]: ");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: " + number);
        }
    }
}
