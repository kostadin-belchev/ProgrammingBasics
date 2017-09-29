using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPlayer = int.Parse(Console.ReadLine());
            var secondPlayer = int.Parse(Console.ReadLine());
            var thirdPlayer = int.Parse(Console.ReadLine());

            var totalSeconds = firstPlayer + secondPlayer + thirdPlayer;
            var minutes = 0;
            


            if (totalSeconds > 59 && totalSeconds <= 119)
            {
                minutes++;
                totalSeconds = totalSeconds - 60;
            }
            if (totalSeconds > 119)
            {
                minutes += 2;
                totalSeconds = totalSeconds - 120;
            }
            if (totalSeconds < 10)
            {
                Console.WriteLine(minutes + ":0" + totalSeconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + totalSeconds);
            }
        }
    }
}
