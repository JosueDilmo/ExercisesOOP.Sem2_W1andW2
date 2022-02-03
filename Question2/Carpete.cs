using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOOP.Question2
{
    public class Carpete
    {
        public void carpeteApp()
        {
            Console.WriteLine("Carpete App");
            Console.WriteLine("=============");
            Console.Write("Enter the lenght of your room (meters): ");
            double roomLength;
            while (!double.TryParse(Console.ReadLine(), out roomLength))
            {
                Console.WriteLine("Please, enter a valid number.");
                Console.Write("Enter the lenght of your room (meters): ");
            }
            Console.Write("Enter the width of your room (meters): ");
            double roomWidth;
            while (!double.TryParse(Console.ReadLine(), out roomWidth))
            {
                Console.WriteLine("Please, enter a valid number.");
                Console.Write("Enter the width of your room (meters): ");
            }
            Console.WriteLine("The price of the carpete is $1.59 per meter");
            const decimal carpetePrice = (decimal) 1.59;
            double roomArea = roomLength * roomWidth;
            decimal totalPrice = Convert.ToDecimal(roomArea) * carpetePrice;
            Console.WriteLine($"The price for carpeting your room is: ${totalPrice}");
            Program menu = new();
            menu.openMenu();
        }
    }
}
