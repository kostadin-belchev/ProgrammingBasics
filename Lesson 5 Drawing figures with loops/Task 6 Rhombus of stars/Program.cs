using System;

namespace Task_6_Rhombus_of_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            for (var row = 1; row <= n; row++)
            {
                for (var col = 1; col <= n - row; col++)
                    Console.Write(" ");

                Console.Write("*");

                for (var col = 1; col <= row - 1; col++)
                    Console.Write(" *");

                Console.WriteLine();
            }

            for (var row = 1; row <= n - 1; row++)
            {
                
                for (var col = 1; col <= n - 1; col++)
                    Console.Write(" *");

                Console.WriteLine();

                for (var col = 1; col <= n - row; col++)
                    Console.Write(" ");

                
            }

        }
    }
}
