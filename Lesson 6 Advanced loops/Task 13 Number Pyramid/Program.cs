using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var i = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(i + " ");
                    i++;
                    if (i == n + 1)
                        break;

                }
                if (i == n + 1)
                    break;

                Console.WriteLine();
            }
        }
    }
}
