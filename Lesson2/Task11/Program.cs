using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            // USD to BGN
            var usd = double.Parse(Console.ReadLine());
            double bgn = 1.79549 * usd;
            Console.WriteLine(Math.Round(bgn, 2));
        }
    }
}
