using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOOP.Question6
{
    public class LawnMowing
    {
        public void getLotSize(double yardSquareMeter)
        {
            decimal lawnFee;
            const double week = 20;
            if (yardSquareMeter < 400)
            {
                lawnFee = (decimal)week * 25;
                Console.WriteLine($"The weekly price is $25 and 20-week season price is: {lawnFee}");
            }
            else if (yardSquareMeter >= 400 || yardSquareMeter < 600)
            {
                lawnFee = (decimal)week * 35;
                Console.WriteLine($"The weekly price is $35 and 20-week season price is: {lawnFee}"); 
            }
            else if (yardSquareMeter >= 600)
            {
                lawnFee = (decimal)week * 50;
                Console.WriteLine($"The weekly price is $50 and 20 - week season price is: { lawnFee}");
            }
        }

        public void lawnMowing()
        {
            Console.WriteLine("Lawn-Mowing App");
            Console.Write("Please enter the length of your yard: ");
            bool validNumberOne = double.TryParse(Console.ReadLine(), out double lotLength);
            Console.Write("Please enter the width of your yard: ");
            bool validNumberTwo = double.TryParse(Console.ReadLine(), out double lotWidth);
            bool executeAct = validNumberOne && validNumberTwo;
            if (!executeAct)
            {
                Console.WriteLine("Restarting the app. Please enter valid numbers!");
                lawnMowing();
            }
            else
            {
                double yardSquareMeter = lotLength * lotWidth;
                getLotSize(yardSquareMeter);
            }
        }
    }
}
