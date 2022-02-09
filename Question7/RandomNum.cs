using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOOP.Question7
{
    public class RandomNum
    {
        public void randomNumGen()
        {
            Console.WriteLine("Random Number Generator App");
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);
            Console.WriteLine("Enter a number between 1 and 10");
            bool validNumber = int.TryParse(Console.ReadLine(), out int userGuess);
            if (!validNumber)
            {
                Console.WriteLine("Please, enter a valid number!");
                randomNumGen();
            }
            else if (randomNumber == userGuess)
            {
                Console.WriteLine($"You guessed it right! Your number: {userGuess}, system number: {randomNumber}");
            }
            else if (userGuess < randomNumber)
            {
                Console.WriteLine("Your number is too low.");
                //Console.WriteLine($"Random number was: {randomNumber}");
                randomNumGen();
            }
            else if (userGuess > randomNumber)
            {
                Console.WriteLine("Your number is too high.");
                //Console.WriteLine($"Random number was: {randomNumber}");
                randomNumGen();
            }
        }
    }
}
