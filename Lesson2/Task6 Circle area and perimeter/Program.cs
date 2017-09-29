using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_Circle_area_and_perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius r of a circle: ");
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of a circle with radius r is: " + Math.PI * r * r);
            Console.WriteLine("The perimeter of a circle with radius r is: " + 2 * Math.PI * r);

        }
    }
}
