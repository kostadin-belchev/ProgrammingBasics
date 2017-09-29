using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Task_19_Transport_price
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dayOrNight = Console.ReadLine();


            var taxiPricePerKm = 0.79;
            if (dayOrNight == "night") taxiPricePerKm = 0.90;

            if (n <  20)
                Console.WriteLine(taxiPricePerKm * n + 0.70);
            else
            if (n < 100)
                Console.WriteLine(0.09 * n);
            else
                Console.WriteLine(0.06 * n);
        }
    }
}
