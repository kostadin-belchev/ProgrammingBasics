using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_Greater_Common_Devisor_GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             function gcd(a, b)
                while b ≠ 0
                        t := b; 
                        b := a mod b; 
                        a := t; 
                return a;
              */
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            Console.WriteLine(a);
        }
    }
}
