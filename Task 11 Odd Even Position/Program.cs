using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0.0;
            var evenSum = 0.0;
            var oddMin = -1000000000.0;
            var oddMax = 1000000000.0;
            var evenMin = -1000000000.0;
            var evenMax = 1000000000.0;

            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum = evenSum + num;
                    if (num >= evenMin)
                        evenMin = num;

                    if (num <= evenMax)
                        evenMax = num;
                }
                if (i % 2 == 1)
                {
                    oddSum = oddSum + num;
                    if (num >= oddMin)
                        oddMin = num;

                    if (num <= oddMax)
                        oddMax = num;
                }

            }

            Console.WriteLine("OddSum=" + oddSum + ",");
            Console.WriteLine("OddMin=" + oddMin + ",");
            Console.WriteLine("OddMax=" + oddMax + ",");
            Console.WriteLine("EvenSum=" + evenSum + ",");
            Console.WriteLine("EvenMin=" + evenMin + ",");
            Console.WriteLine("EvenMax=" + evenMax);
        }
    }
}
