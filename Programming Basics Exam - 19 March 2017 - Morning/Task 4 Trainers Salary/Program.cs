using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfLecturs = int.Parse(Console.ReadLine()); //int from 1 to 100
            var budget = decimal.Parse(Console.ReadLine()); //decimal from 100.00 to 10 000.00
            var input = string.Empty;
            var pricePerLecture = budget / numberOfLecturs;

            decimal jelevSalary = 0.00m;
            decimal roYaLSalary = 0.00m;
            decimal roliSalary = 0.00m;
            decimal trofonSalary = 0.00m;
            decimal sinoSalary = 0.00m;
            decimal othersSalary = 0.00m;

            int jelevCounter = 0;
            int roYaLCounter = 0;
            int roliCounter = 0;
            int trofonCounter = 0;
            int sinoCounter = 0;
            int othersCounter = 0;


            for (int i = 0; i < numberOfLecturs; i++)
            {
                input = Console.ReadLine();
                if (input == "Jelev")
                    jelevCounter++;
                else if (input == "RoYaL")
                    roYaLCounter++;
                else if (input == "Roli")
                    roliCounter++;
                else if (input == "Trofon")
                    trofonCounter++;
                else if (input == "Sino")
                    sinoCounter++;
                else
                    othersCounter++;
            }

            jelevSalary = jelevCounter * pricePerLecture;
            roYaLSalary = roYaLCounter * pricePerLecture;
            roliSalary = roliCounter * pricePerLecture;
            trofonSalary = trofonCounter * pricePerLecture;
            sinoSalary = sinoCounter * pricePerLecture;
            othersSalary = othersCounter * pricePerLecture;


            Console.WriteLine("Jelev salary: {0:f2} lv", jelevSalary);
            Console.WriteLine("RoYaL salary: {0:f2} lv", roYaLSalary);
            Console.WriteLine("Roli salary: {0:f2} lv", roliSalary);

            Console.WriteLine("Trofon salary: {0:f2} lv", trofonSalary);
            Console.WriteLine("Sino salary: {0:f2} lv", sinoSalary);
            Console.WriteLine("Others salary: {0:f2} lv", othersSalary);

        }
    }
}
