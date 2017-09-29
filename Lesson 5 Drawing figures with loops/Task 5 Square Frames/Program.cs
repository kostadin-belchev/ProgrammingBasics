using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Square_Frames
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write('+');
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("|");
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }

            Console.Write('+');
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
