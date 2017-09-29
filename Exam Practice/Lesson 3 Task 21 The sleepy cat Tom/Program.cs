using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Task_21_The_sleepy_cat_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            var holidays = int.Parse(Console.ReadLine());

            var workingDays = 365 - holidays;

            var minutesToPlay = workingDays * 63 + holidays * 127;

            var differenceFromNormInMin = 30000 - minutesToPlay;
            

            if (differenceFromNormInMin >= 0)
            {
                Console.WriteLine("Tom sleeps well");
                var differenceFromNormHours = differenceFromNormInMin / 60;
                var differenceFromNormMinutes = differenceFromNormInMin % 60;
                Console.WriteLine(differenceFromNormHours + " hours and " + differenceFromNormMinutes + " minutes less for play");
            }else
            if (differenceFromNormInMin < 0)
            {
                Console.WriteLine("Tom will run away");
                differenceFromNormInMin = Math.Abs(differenceFromNormInMin);
                var differenceFromNormHours = differenceFromNormInMin / 60;
                var differenceFromNormMinutes = differenceFromNormInMin % 60;
                Console.WriteLine(differenceFromNormHours + " hours and " + differenceFromNormMinutes + " minutes more for play");
            }
        }
    }
}
