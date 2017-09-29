using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2D_Rectagle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x1: ");
            var x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter y1: ");
            var y1 = double.Parse(Console.ReadLine());
            Console.Write("Enter x2: ");
            var x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter y2: ");
            var y2 = double.Parse(Console.ReadLine());
            

            Console.WriteLine("Area of rectangle: " + Math.Abs((x1 - x2) * (y2 - y1)));
            Console.WriteLine("Perimeter of rectangle: " + 2 * (Math.Abs((x1 - x2)) + Math.Abs(y2 - y1)));
        }
    }
}
