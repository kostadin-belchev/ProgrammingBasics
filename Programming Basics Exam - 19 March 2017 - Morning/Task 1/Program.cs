using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = decimal.Parse(Console.ReadLine()); // from 2 to 100
            var y = decimal.Parse(Console.ReadLine()); // from 2 to 100
            var h = decimal.Parse(Console.ReadLine()); // from 2 to 100

            //Walls
            decimal sideWall = x * y;
            decimal sideWallWindow = 2.25m;

            decimal bothSideWalls = 2 * sideWall - 2 * sideWallWindow;

            decimal backWall = x * x;
            decimal entranceDoor = 2.40m;

            decimal bothFrontAndBackWalls = 2 * backWall - entranceDoor;

            decimal totalWalls = bothSideWalls + bothFrontAndBackWalls;

            var greeenPaint = totalWalls / 3.40m;
            Console.WriteLine(Math.Round(greeenPaint, 2));
            //Roof
            decimal bothRectangles = 2.00m * (x * y);

            decimal bothTriangles = 2.00m * ((x * h) / 2.00m);

            decimal totalRoof = bothRectangles + bothTriangles;

            decimal redPaint = totalRoof / 4.30m;
            Console.WriteLine(Math.Round(redPaint, 2));
            //Format 2 decimals after the number
        }
    }
}
