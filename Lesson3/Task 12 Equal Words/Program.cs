using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            String input1 = Console.ReadLine().ToLower();
            String input2 = Console.ReadLine().ToLower();

            if (input1 == input2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
