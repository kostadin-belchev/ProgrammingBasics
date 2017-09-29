using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_Vowels_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            String word = Console.ReadLine().ToLower();
            var sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                    sum += 1;
                if (word[i] == 'e')
                    sum += 2;
                if (word[i] == 'i')
                    sum += 3;
                if (word[i] == 'o')
                    sum += 4;
                if (word[i] == 'u')
                    sum += 5;
            }
            Console.WriteLine(sum);
        }
    }
}
