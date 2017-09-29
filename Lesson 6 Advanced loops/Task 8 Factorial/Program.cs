using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i = 1; i <= n; i++)
            {
                num = num * i;
            }

            Console.WriteLine(num);
            /*do
             * {
             * fact = fact * n;
             * n--;
             * } while (n > 1);
             * Console.WriteLine(fact);
             */
        }
    }
}
