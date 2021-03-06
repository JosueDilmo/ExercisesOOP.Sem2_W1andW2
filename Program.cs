using ExercisesOOP.Question1;
using ExercisesOOP.Question2;
using ExercisesOOP.Question3;
using ExercisesOOP.Question5;
using ExercisesOOP.Question6;
using ExercisesOOP.Question7;
using System;

namespace ExercisesOOP
{
    class Program
    {        
        static void Main(string[] args)
        {
            Program newMenu = new();
            newMenu.openMenu();
        }

        public void openMenu()
        {
            bool keepLoop = true;
            while (keepLoop)
            {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine("Exercises 1 and 2 by 24061 - Josue Santos");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine("Question .1");
                Console.WriteLine("Question .2");
                Console.WriteLine("Question .3");
                Console.WriteLine("Question .5");
                Console.WriteLine("Question .6");
                Console.WriteLine("Question .7");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.Write("Your option: ");
                if (Int32.TryParse(Console.ReadLine(), out int menuOption))
                {
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-");
                    switch (menuOption)
                    {
                        case 1:
                            keepLoop = false;
                            Calculator calc = new();
                            calc.calculatorApp();
                            break;
                        case 2:
                            keepLoop = false;
                            Carpete carp = new();
                            carp.carpeteApp();
                            break;
                        case 3:
                            keepLoop = false;
                            MinToHour time = new();
                            time.timeConvert();
                            break;
                        case 5:
                            keepLoop = false;
                            ValidaRate rate = new();
                            rate.validRate();
                            break;
                        case 6:
                            keepLoop = false;
                            LawnMowing mowing = new();
                            mowing.lawnMowing();
                            break;
                        case 7:
                            keepLoop = false;
                            RandomNum random = new();
                            random.randomNumGen();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(" Please, enter a valid option");
                    Console.WriteLine();
                    keepLoop = true;
                }
            }            
        }        
    }
}
