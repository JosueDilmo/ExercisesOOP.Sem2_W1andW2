using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOOP.Question3
{
    public class MinToHour
    {
        public void timeConvert()
        {
            Console.WriteLine("Minute to Hour App");
            Console.WriteLine("=============");
            Console.Write("Enter the minutes: ");
            double timeMinute;
            while (!double.TryParse(Console.ReadLine(), out timeMinute))
            {
                Console.WriteLine("Please, enter a valid number.");
                Console.Write("Enter the minutes: ");
            }
            double timeHour = timeMinute / 60;
            Console.WriteLine($"Hours: {timeHour:#.##}");
            Program menu = new();
            menu.openMenu();
        }

    }
}
