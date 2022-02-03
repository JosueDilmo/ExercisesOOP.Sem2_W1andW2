using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOOP.Question1
{
    public class Calculator
    {
       public void calculatorApp()
       {
            bool keepLoop = true;
            while (keepLoop)
            {
                Console.WriteLine("==== Calculator App ====");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine("Please, choose one function: ");
                Console.WriteLine(" 1. Addition");
                Console.WriteLine(" 2. Subtraction");
                Console.WriteLine(" 3. Multiplication");
                Console.WriteLine(" 4. Division");
                Console.Write(" Option: ");
                if (Int32.TryParse(Console.ReadLine(), out int menuOption))
                {
                    switch (menuOption)
                    {
                        case 1:
                            keepLoop = false;
                            Console.WriteLine("=== Addtion Function ===");
                            Console.Write("Enter first number: ");
                            bool validNumberOne = double.TryParse(Console.ReadLine(), out double numberOne);
                            Console.Write("Enter second number: ");
                            bool validNumberTwo = double.TryParse(Console.ReadLine(), out double numberTwo);
                            bool validResult = validNumberOne && validNumberTwo;
                            if (validResult == true) 
                            {
                                Console.WriteLine($"The result for the operation is: {numberOne + numberTwo} ");
                            }
                            else
                            {
                                Console.WriteLine("===============================");
                                Console.WriteLine("Please, enter a valid number!");
                                Console.WriteLine("===============================");
                                keepLoop = true;
                            }
                            break;
                        case 2:
                            keepLoop = false;
                            Console.WriteLine("=== Subtraction Function ===");
                            Console.Write("Enter first number: ");
                            validNumberOne = double.TryParse(Console.ReadLine(), out numberOne);
                            Console.Write("Enter second number: ");
                            validNumberTwo = double.TryParse(Console.ReadLine(), out numberTwo);
                            validResult = validNumberOne && validNumberTwo;
                            if (validResult == true)
                            {
                                Console.WriteLine($"The result for the operation is: {numberOne -numberTwo} ");
                            }
                            else
                            {
                                Console.WriteLine("===============================");
                                Console.WriteLine("Please, enter a valid number!");
                                Console.WriteLine("===============================");
                                keepLoop = true;
                            }
                            break;
                        case 3:
                            keepLoop = false;
                            Console.WriteLine("=== Multiplication Function ===");
                            Console.Write("Enter first number: ");
                            validNumberOne = double.TryParse(Console.ReadLine(), out numberOne);
                            Console.Write("Enter second number: ");
                            validNumberTwo = double.TryParse(Console.ReadLine(), out numberTwo);
                            validResult = validNumberOne && validNumberTwo;
                            if (validResult == true)
                            {
                                Console.WriteLine($"The result for the operation is: {numberOne * numberTwo} ");
                            }
                            else
                            {
                                Console.WriteLine("===============================");
                                Console.WriteLine("Please, enter a valid number!");
                                Console.WriteLine("===============================");
                                keepLoop = true;
                            }
                            break;
                        case 4:
                            keepLoop = false;
                            Console.WriteLine("=== Division Function ===");
                            Console.Write("Enter first number: ");
                            validNumberOne = double.TryParse(Console.ReadLine(), out numberOne);
                            Console.Write("Enter second number: ");
                            validNumberTwo = double.TryParse(Console.ReadLine(), out numberTwo);
                            validResult = validNumberOne && validNumberTwo;
                            if (validResult == true)
                            {
                                Console.WriteLine($"The result for the operation is: {numberOne / numberTwo} ");
                            }
                            else
                            {
                                Console.WriteLine("===============================");
                                Console.WriteLine("Please, enter a valid number!");
                                Console.WriteLine("===============================");
                                keepLoop = true;
                            }
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
