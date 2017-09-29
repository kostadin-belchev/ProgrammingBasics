using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_19_Tiles_Repair
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            
            int M = int.Parse(Console.ReadLine());
            int O = int.Parse(Console.ReadLine());

            var squareN = N * N;
            var squareMxO = M * O;
            var totalSquareToBeCovered = squareN - squareMxO;

            var squareWxL = W * L;

            var totalTiles = totalSquareToBeCovered / squareWxL;
            Console.WriteLine(totalTiles);
            var totalTime = totalTiles * 0.2;
            Console.WriteLine(totalTime);
        }
    }
}
