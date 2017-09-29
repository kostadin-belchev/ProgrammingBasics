using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_Triangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a side a of a triangle: ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Enter a hight h of a triangle: ");
            var h = double.Parse(Console.ReadLine());
            var area = a * h / 2;
            Console.WriteLine("The area of the triangle is: " + Math.Round(area, 2));
        }
    }
}
