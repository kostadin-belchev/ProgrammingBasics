using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //2 * n + 1;

            //Print first line
            for (int i = 0; i < 2*n + 1; i++)
                Console.Write('*');

            Console.WriteLine();

            //print second line
            Console.Write(".*");
            for (int i = 0; i < 2*n - 3; i++)
                Console.Write(" ");

            Console.WriteLine("*.");

            //pring top half
            for (var row = n - 2; row >= 1; row--)
            {
          
                Console.Write("{0}*{1}*{0}\n", new string('.', row - 1), new string('@', row));
            }
                


        }
    }
}
