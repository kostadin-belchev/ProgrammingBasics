using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_Rad_to_Deg
{
    class Program
    {
        static void Main(string[] args)
        {
            // π rad = 180°
            var rad = double.Parse(Console.ReadLine());
            double degrees = rad * 180 / Math.PI;
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
