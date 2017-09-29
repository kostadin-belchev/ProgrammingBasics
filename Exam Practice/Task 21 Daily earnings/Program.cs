using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_Daily_earnings
{
    class Program
    {
        static void Main(string[] args)
        {
            var NdaysWorkedInAMonth = int.Parse(Console.ReadLine()); //from 5 to 30
            var MamountOfMoneyPerDayInDollars = double.Parse(Console.ReadLine()); //from 10.00 to 2000.00
            var dollarLvRatio = double.Parse(Console.ReadLine()); //from 0.99 to 1.99

            var MonthlySalaryInDollars = NdaysWorkedInAMonth * MamountOfMoneyPerDayInDollars;

            var yearlySalaryInDollars = MonthlySalaryInDollars * 12 + MonthlySalaryInDollars * 2.5;

            var afterTaxesInDollars = yearlySalaryInDollars * 0.75;

            var afterTaxesInLv = afterTaxesInDollars * dollarLvRatio;

            var meanIncomePerDay = afterTaxesInLv / 365;

            Console.WriteLine(Math.Round(meanIncomePerDay, 2));
        }
    }
}
