using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Task_15_On_time_for_the_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var hourOfTheExam = int.Parse(Console.ReadLine()); //Int from 0 to 23
            var minuteOfTheExam = int.Parse(Console.ReadLine()); //Int from 0 to 59

            var hourOfArrival = int.Parse(Console.ReadLine()); //Int from 0 to 23
            var minuteOfArrival = int.Parse(Console.ReadLine()); //Int from 0 to 59

            int hours = 0;
            int minutes = 0;

            if (hourOfArrival < hourOfTheExam)
            {
                Console.WriteLine("Early");
            }else
            if(hourOfArrival == hourOfTheExam)
            {
                if (minuteOfArrival - minuteOfTheExam >= 30)
                {

                }
            }

            if (minutes > 59)
            {
                hours++;
                minutes = minutes - 60;
            }
            if (hours > 23)
                hours = 0;

            if (minutes < 10)
                Console.WriteLine(hours + ":0" + minutes);
            else
                Console.WriteLine(hours + ":" + minutes);
        }
    }
}
