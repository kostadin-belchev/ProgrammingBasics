using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //When found return;
            var startOfInverval = int.Parse(Console.ReadLine()); //int from 1 to 1000
            var endOfInterval = int.Parse(Console.ReadLine()); //int smaller than 1st number

            var magicNumber = int.Parse(Console.ReadLine()); //int from 1 to 10 000


            int combinationNumber = 0;
            int stopper = 0;

            int num1 = 44;
            int num2 = 55;

            for (int i = startOfInverval; i >= endOfInterval; i--)
            {
                for (int j = startOfInverval; j >= endOfInterval; j--)
                {
                    combinationNumber++;
                    if (i + j == magicNumber)
                        stopper = 1;
                        break;
                }
                if (stopper == 1)
                {
                    break;
                }
            }
            Console.WriteLine("Combination N:"+ combinationNumber+" ("+num1+" + "+ num2 + " = "+magicNumber+")");
            
        }
    }
}
