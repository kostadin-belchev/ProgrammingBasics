using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputValue = double.Parse(Console.ReadLine());
            var inputCurre = Console.ReadLine();
            var outputCurre = Console.ReadLine();
            double outputValue = 0;
            double inputValueInBGN = 0;

            if (inputCurre == "BGN")
            {
                inputValueInBGN = inputValue;
            }
            if (inputCurre == "USD")
            {
                inputValueInBGN = inputValue * 1.79549;
            }
            if (inputCurre == "EUR")
            {
                inputValueInBGN = inputValue * 1.95583;
            }
            if (inputCurre == "GBP")
            {
                inputValueInBGN = inputValue * 2.53405;
            }


            if (outputCurre == "BGN")
            {
                outputValue = inputValueInBGN;
            }
            if (outputCurre == "USD")
            {
                outputValue = inputValueInBGN / 1.79549;
            }
            if (outputCurre == "EUR")
            {
                outputValue = inputValueInBGN / 1.95583;
            }
            if (outputCurre == "GBP")
            {
                outputValue = inputValueInBGN / 2.53405;
            }

            Console.WriteLine(Math.Round(outputValue, 2));

        }
    }
}
