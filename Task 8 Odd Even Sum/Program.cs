using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum = evenSum + num;
                }
                if (i % 2 == 1)
                {
                    oddSum = oddSum + num;
                }
            }

            int diff = Math.Abs(evenSum - oddSum);

            if (diff == 0)
                Console.WriteLine("Yes\nSum = " + evenSum);
            else
                Console.WriteLine("No\nDiff = " + diff);
        }
    }
}
