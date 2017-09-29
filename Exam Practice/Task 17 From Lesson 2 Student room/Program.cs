using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17_From_Lesson_2_Student_room
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            double numOfRowsPossible = 0;
            double numOfColsPossible = 0;

            var newW = w - 1.0;
            numOfRowsPossible = Math.Truncate(h/1.20);
            numOfColsPossible = Math.Truncate(newW / 0.70);

            var numOfSeats = numOfRowsPossible * numOfColsPossible - 3;
            Console.WriteLine(numOfSeats);
        }
    }
}
