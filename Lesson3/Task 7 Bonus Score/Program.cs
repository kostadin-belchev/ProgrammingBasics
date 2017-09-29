using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            var enteredInt = int.Parse(Console.ReadLine());
            double bonusScore = 0;

            if (enteredInt <= 100)
            {
                bonusScore = bonusScore + 5;
            }
            else
            if(enteredInt > 100 && enteredInt <= 1000)
            {
                bonusScore = enteredInt * 0.20;
            }
            else
            if(enteredInt > 1000)
            {
                bonusScore = enteredInt * 0.10;
            }

            if ((enteredInt % 2) == 0)
            {
                bonusScore = bonusScore + 1;
            }
            else
            if((enteredInt % 10) == 5)
            {
                bonusScore = bonusScore + 2;
            }

            Console.WriteLine("Bonus score: " + bonusScore);
            var totalScore = enteredInt + bonusScore;
            Console.WriteLine("Total score: " + totalScore);
        }
    }
}
