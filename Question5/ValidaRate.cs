using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOOP.Question5
{
    public class ValidaRate
    {
        public void validRate()
        {
            Console.WriteLine("Hour pay rate App");
            Console.WriteLine("==================");
            Console.Write("Enter your hourly pay rate: ");
            decimal payRate;
            while (!decimal.TryParse(Console.ReadLine(), out payRate) || (payRate <(decimal) 7.50 || payRate >(decimal) 49.00))
            {
                Console.WriteLine("Please, enter a valid number.");
                Console.Write("Enter your hourly pay rate: ");
            }
                Console.WriteLine("You've entered a valid rate!");
                Console.WriteLine("=============");
            Program menu = new();
            menu.openMenu();
        }
    }
}
