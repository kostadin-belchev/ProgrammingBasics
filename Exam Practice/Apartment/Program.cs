using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Square meters: ");
            var KM = double.Parse(Console.ReadLine());
            Console.Write("Enter the price for a Square Meter in euro: ");
            var pricePerKM = double.Parse(Console.ReadLine());
            Console.Write("Is there a closet in the apartement (Y/N): ");
            var kiler = Console.ReadLine().ToLower();

            
            var KMPlusObshtiChasti = KM * 1.176;

            var finalPrice = KMPlusObshtiChasti * pricePerKM;

            

            if (kiler == "y" || kiler == "yes")
            {
                finalPrice = finalPrice + 300.00 + 7900;
                Console.WriteLine("You have a closet, which means you cannot buy a basement and the price of your partking spot will be 7 900 euro.");
                Console.WriteLine("Your price for the apartment alone is: " + (finalPrice - 7900));
            }
            else
            {
                finalPrice = finalPrice + 8500;
                Console.WriteLine("You can buy a parking spot + a basement for 8 500 euro combined.");
                Console.WriteLine("Your price for the apartment alone is: " + (finalPrice - 8500));
            }
            

            Console.WriteLine("Your final price (apartement + parking spot (+ basement if you have no closet) is: " + finalPrice);
        }
    }
}
