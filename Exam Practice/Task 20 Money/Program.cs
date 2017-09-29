using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfBitCoins = int.Parse(Console.ReadLine());
            var numberOfChineseY = double.Parse(Console.ReadLine());
            var commissionPercentage = double.Parse(Console.ReadLine());

            var bitCoinInLv = numberOfBitCoins * 1168;
            var YinDollars = numberOfChineseY * 0.15;
            var YinLv = YinDollars * 1.76;

            var bitCoinsPlusYensInLv = bitCoinInLv + YinLv;
            var bitCoinsPlusYensInEuro = bitCoinsPlusYensInLv / 1.95;

            var commissionDecimal = commissionPercentage / 100;

            var commissionAmmountInEuro = bitCoinsPlusYensInEuro * commissionDecimal;

            var finalResult = bitCoinsPlusYensInEuro - commissionAmmountInEuro;
            Console.WriteLine(finalResult);
        }
    }
}
