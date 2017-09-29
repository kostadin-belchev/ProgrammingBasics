using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_Area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            String figureType = Console.ReadLine();

            if (figureType == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                double squareArea = Math.Round(Math.Pow(squareSide, 2), 3);
                Console.WriteLine(squareArea);
            }else
            if (figureType == "rectangle")
            {
                double rectangleSideA = double.Parse(Console.ReadLine());
                double rectangleSideB = double.Parse(Console.ReadLine());
                double rectangleArea = Math.Round(rectangleSideA * rectangleSideB, 3);
                Console.WriteLine(rectangleArea);
            }
            else
            if (figureType == "circle")
            {
                double circleRadius = double.Parse(Console.ReadLine());
                double circleArea = Math.Round(Math.PI * Math.Pow(circleRadius, 2), 3);
                Console.WriteLine(circleArea);
            }
            else
            if (figureType == "triangle")
            {
                double triangleSide = double.Parse(Console.ReadLine());
                double triangleHeightToSide = double.Parse(Console.ReadLine());
                double triangleArea = Math.Round(triangleSide * triangleHeightToSide /2 , 3);
                Console.WriteLine(triangleArea);
            }
        }
    }
}
