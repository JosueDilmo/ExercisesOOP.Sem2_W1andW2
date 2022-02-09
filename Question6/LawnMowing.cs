using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOOP.Question6
{
    public class LawnMowing
    {
        public void getLotSize(double lotMeterSquare)
        {
            decimal lawnFee;
            const double week = 20;
            if (lotMeterSquare < 400)
            {
                lawnFee = (decimal)week * 25;
                string answer = $"The weekly price is $25 and 20-week season price is: {lawnFee}";
                Console.WriteLine(answer.ToString());
            }
            else if (lotMeterSquare >= 400 || lotMeterSquare < 600)
            {
                lawnFee = (decimal)week * 35;
                string answer = $"The weekly price is $35 and 20-week season price is: {lawnFee}"; 
                Console.WriteLine(answer.ToString());
            }
            else if (lotMeterSquare >= 600)
            {
                lawnFee = (decimal)week * 50;
                string answer = $"The weekly price is $50 and 20-week season price is: {lawnFee}";
                Console.WriteLine(answer.ToString());
            }
        }

        public void lawnMowing()
        {
            Console.WriteLine("Lawn-Mowing App");
            Console.Write("Please enter the length of a lawn: ");
            bool validNumberOne = double.TryParse(Console.ReadLine(), out double lotLength);
            Console.Write("Please enter the width of a lawn: ");
            bool validNumberTwo = double.TryParse(Console.ReadLine(), out double lotWidth);
            bool executeAct = validNumberOne && validNumberTwo;
            if (!executeAct)
            {
                Console.WriteLine("Restarting the app. Please enter valid numbers!");
                lawnMowing();
            }
            else
            {
                double lotMeterSquare = lotLength * lotWidth;
                getLotSize(lotMeterSquare);
            }
        }
    }
}
