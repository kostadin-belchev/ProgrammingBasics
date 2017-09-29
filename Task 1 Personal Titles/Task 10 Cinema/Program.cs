using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfEvent = Console.ReadLine().ToLower();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());

            if (typeOfEvent == "premiere")
            {
                Console.WriteLine(Math.Round(rows * columns * 12.00, 2) + " leva");
            }else
            if (typeOfEvent == "normal")
            {
                Console.WriteLine(Math.Round(rows * columns * 7.50, 2) + " leva");
            }
            else
            if (typeOfEvent == "discount")
            {
                Console.WriteLine(Math.Round(rows * columns * 5.00, 2) + " leva");
            }
        }
    }
}
