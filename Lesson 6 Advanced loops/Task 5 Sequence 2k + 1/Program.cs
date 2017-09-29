using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Sequence_2k___1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            do
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            } while (num <= n);
            
        }
    }
}
