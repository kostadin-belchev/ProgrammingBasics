using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = decimal.Parse(Console.ReadLine()); // from 10.00 to 10 000.00
            var season = Console.ReadLine(); // Either "Summer" or "Winter"

            var location = "nowhere";
            var housing = "";
            decimal price = 0.00m;

            if (budget <= 1000)
            {
                housing = "Camp";
                if (season == "Summer")
                {
                    price = 0.65m * budget;
                    location = "Alaska";
                }
                else
                if (season == "Winter")
                {
                    price = 0.45m * budget;
                    location = "Morocco";
                }
                Console.WriteLine(location + " - " + housing + " - " + Math.Round(price, 2, MidpointRounding.AwayFromZero));
            }else
            if (budget > 1000 && budget <= 3000)
            {
                housing = "Hut";
                if (season == "Summer")
                {
                    price = budget * 0.80m;
                    location = "Alaska";
                }
                else
                if (season == "Winter")
                {
                    price = 0.60m * budget;
                    location = "Morocco";
                }
                Console.WriteLine(location + " - " + housing + " - " + Math.Round(price, 2, MidpointRounding.AwayFromZero));
            }
            else
            {
                housing = "Hotel";
                if (season == "Summer")
                {
                    price = 0.90m * budget;
                    location = "Alaska";
                }
                else
                if (season == "Winter")
                {
                    price = 0.90m * budget;
                    location = "Morocco";
                }
                Console.WriteLine(location + " - " + housing + " - " + Math.Round(price, 2, MidpointRounding.AwayFromZero));
            }

            //Format 2 decimals after the number
        }
    }
}
