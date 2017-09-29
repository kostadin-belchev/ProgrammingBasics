using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string format = "dd-MM-yyyy";

            DateTime date = DateTime.ParseExact(inputString, format, CultureInfo.InvariantCulture);

            date = date.AddDays(999);

            Console.WriteLine(date.ToString(format));
        }
    }
}
