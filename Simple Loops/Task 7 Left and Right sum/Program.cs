using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_Left_and_Right_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < n ; i++)
            {
                int num1 = int.Parse(Console.ReadLine());

                leftSum = leftSum + num1;
            }

            for (int i = 0; i < n; i++)
            {
                int num2 = int.Parse(Console.ReadLine());

                rightSum = rightSum + num2;
            }

            int diff = Math.Abs(leftSum - rightSum);

            if (diff == 0)
                Console.WriteLine("Yes, sum = " + leftSum);
            else
                Console.WriteLine("No, diff = " + diff);
        }
    }
}
