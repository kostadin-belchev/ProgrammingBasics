using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18_Vegetable_auction
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());

            int kilosN = int.Parse(Console.ReadLine());
            int kilosM = int.Parse(Console.ReadLine());

            var NcostLv = N * kilosN;
            var McostLv = M * kilosM;

            var totalCost = NcostLv + McostLv;

            Console.WriteLine(totalCost/1.94);
        }
    }
}
