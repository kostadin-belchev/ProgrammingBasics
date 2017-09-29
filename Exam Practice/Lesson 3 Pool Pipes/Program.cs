using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Pool_Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var volumeOfPool = int.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            var hoursAway = double.Parse(Console.ReadLine());

            var volumeOfWaterFromPipe1 = P1 * hoursAway;
            var volumeOfWaterFromPipe2 = P2 * hoursAway;
            var volumeOfWaterFromPipes1And2 = volumeOfWaterFromPipe1 + volumeOfWaterFromPipe2;

            var percentageFull = 0.0;

            var pipe1Percetage = 0.0;
            var pipe2Percetage = 0.0;

            if (volumeOfWaterFromPipes1And2 <= volumeOfPool)
            {
                percentageFull = (volumeOfWaterFromPipes1And2 * 100) / volumeOfPool;
                pipe1Percetage = (volumeOfWaterFromPipe1 * 100) / volumeOfWaterFromPipes1And2;
                pipe2Percetage = (volumeOfWaterFromPipe2 * 100) / volumeOfWaterFromPipes1And2;
                Console.WriteLine("The pool is " + Math.Truncate(percentageFull) + "% full. Pipe 1: " + Math.Truncate(pipe1Percetage) + "%. Pipe 2: " + Math.Truncate(pipe2Percetage) + "%.");
            }
            else
            {
                pipe1Percetage = (volumeOfWaterFromPipe1 * 100) / volumeOfWaterFromPipes1And2;
                pipe2Percetage = (volumeOfWaterFromPipe2 * 100) / volumeOfWaterFromPipes1And2;
                double overflow = volumeOfWaterFromPipes1And2 - volumeOfPool;
                Console.WriteLine("For " + hoursAway + " hours the pool overflows with " + overflow + " liters.");
            }
        }
    }
}
