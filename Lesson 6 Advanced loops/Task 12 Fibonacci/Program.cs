using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var fNum = 0;
            var f0 = 1;
            var f1 = 1;

            if (n < 2)
            {
                fNum = 1;
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    var fNext = f0 + f1;
                    f0 = f1;
                    f1 = fNext;
                }
                fNum = f1;
            }
            Console.WriteLine(fNum);
        }
    }
}
