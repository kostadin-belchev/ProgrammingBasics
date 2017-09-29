using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var maxNum = int.Parse(Console.ReadLine());
            var sum = maxNum;

            for (int i = 0; i < n - 1; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;

                if (num >= maxNum)
                {
                    maxNum = num;
                }
            }

            int diff = Math.Abs(maxNum - (sum - maxNum));

            if (diff == 0)
                Console.WriteLine("Yes\nSum = " + (sum - maxNum));
            else
                Console.WriteLine("No\nDiff = " + diff);

        }
    }
}
