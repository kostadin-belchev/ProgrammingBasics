using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2_Inch_to_cm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value in inches to be converted to cm: ");
            var inches = float.Parse(Console.ReadLine());
            var cm = inches * 2.54;
            Console.WriteLine(inches + " inches are: " + cm + " cm");
        }
    }
}