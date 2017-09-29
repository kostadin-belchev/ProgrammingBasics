using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfYear = Console.ReadLine().ToLower();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());

            var weekendsInSofia = 48 - h;
            var numberOfPlaysDuringWeekendsInSofia = weekendsInSofia * 3.0 / 4;
            var numberOfPlaysDuringWeekendsInHomeTown = h;
            var numberOfPlaysDuringHolidays = p * 2.0 / 3;

            var totalNumberOfPlays = numberOfPlaysDuringHolidays + numberOfPlaysDuringWeekendsInHomeTown + numberOfPlaysDuringWeekendsInSofia;

            if (typeOfYear == "leap")
            {
                Console.WriteLine(Math.Truncate(totalNumberOfPlays = totalNumberOfPlays * 1.15));
            }else
            if (typeOfYear == "normal")
            {
                Console.WriteLine(Math.Truncate(totalNumberOfPlays));
            }
            
        }
    }
}
