using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_Min_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var minNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num <= minNum)
                {
                    minNum = num;
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
