using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_from_Lesson_1_Square_of_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int row = 0; row <= n - 3; row++)
            {
                Console.Write("*");
                for (int col = 0; col <= n - 3; col++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
            }

        }
    }
}
