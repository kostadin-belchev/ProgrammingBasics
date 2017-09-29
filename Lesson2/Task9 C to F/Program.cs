using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_C_to_F
{
    class Program
    {
        static void Main(string[] args)
        {
            // T(°F) = T(°C) × 9 / 5 + 32
            var celcious = double.Parse(Console.ReadLine());
            double farenheit = celcious * 9 / 5 + 32;
            Console.WriteLine(Math.Round(farenheit, 2));

        }
    }
}
