using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsToBeProduced = int.Parse(Console.ReadLine()); //from 1 to 10 000
            var numberOfWorkers = int.Parse(Console.ReadLine()); //from 1 to 1000
            var numberOfDaysWorked = int.Parse(Console.ReadLine());

            var hoursWorked = numberOfWorkers * numberOfDaysWorked * 8.00m;
            var actualNumbersOfCupsProduced = Math.Floor(hoursWorked / 5);

            decimal difference = numberOfCupsToBeProduced - actualNumbersOfCupsProduced;

            var profitsOrLosses = difference * 4.20m;

            if (difference < 0)
            {
                profitsOrLosses = Math.Abs(profitsOrLosses);
                Console.WriteLine(Math.Round(profitsOrLosses, 2) + " extra money");
            }
            else
            {
                profitsOrLosses = Math.Abs(profitsOrLosses);
                Console.WriteLine("Losses: " + Math.Round(profitsOrLosses, 2));
            }
            //Format 2 decimals after the number
        }
    }
}
