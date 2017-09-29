using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Fruit_or_Vegerable
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameOfObject = Console.ReadLine().ToLower();

            if (nameOfObject == "banana" || nameOfObject == "apple" || nameOfObject == "kiwi" || nameOfObject == "cherry" || nameOfObject == "lemon" || nameOfObject == "grapes")
            {
                Console.WriteLine("fruit");
            }else
            if (nameOfObject == "tomato" || nameOfObject == "cucumber" || nameOfObject == "pepper" || nameOfObject == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
