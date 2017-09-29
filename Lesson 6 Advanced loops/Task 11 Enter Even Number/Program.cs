using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;

            try
            {
                while (true)
                {
                    Console.WriteLine("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: " + n);
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
