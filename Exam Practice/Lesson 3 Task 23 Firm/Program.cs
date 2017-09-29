using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Task_23_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var daysToWorkOnProject = int.Parse(Console.ReadLine());
            var numberOfEmployeesWorkingExtra = int.Parse(Console.ReadLine());

            var workingHours = 0.90 * daysToWorkOnProject * 8;
            var extraWorkingHours = numberOfEmployeesWorkingExtra * 2 * daysToWorkOnProject;

            var totalHoursWorkedOnProject = Math.Floor(workingHours + extraWorkingHours);

            if (totalHoursWorkedOnProject >= hoursNeeded)
            {
                var hoursLeft = totalHoursWorkedOnProject - hoursNeeded;
                Console.WriteLine("Yes!" + hoursLeft + " hours left.");
            }
            else
            {
                var xMoreHoursNeeded = hoursNeeded - totalHoursWorkedOnProject;
                Console.WriteLine("Not enough time!" + xMoreHoursNeeded + " hours needed.");
            }
        }
    }
}
