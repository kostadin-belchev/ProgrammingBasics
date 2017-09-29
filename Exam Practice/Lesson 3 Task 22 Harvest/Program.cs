using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Task_22_Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareMetersArea = int.Parse(Console.ReadLine());
            var kilosGrapesPerSquareMeter = double.Parse(Console.ReadLine());
            var neededLitersWine = int.Parse(Console.ReadLine());
            var numberOfWorkers = int.Parse(Console.ReadLine());

            var kilosGrapes = kilosGrapesPerSquareMeter * squareMetersArea;

            var litersWine = 0.40 * kilosGrapes / 2.5;

            if (litersWine >= neededLitersWine)
            {
                Console.WriteLine("Good harvest this year! Total wine: " + Math.Floor(litersWine) + " liters.");
                var litersLeft = litersWine - neededLitersWine;
                var litersPerPersonLeft = litersLeft / numberOfWorkers;
                Console.WriteLine(Math.Ceiling(litersLeft) + " liters left -> " + Math.Ceiling(litersPerPersonLeft) + " liters per person.");
            }
            else
            {
                var litersNotEnough = neededLitersWine - litersWine;
                Console.WriteLine("It will be a tough winter! More " + Math.Floor(litersNotEnough) + " liters wine needed.");
            }
        }
    }
}
