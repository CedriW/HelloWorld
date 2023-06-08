using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randNum = random.Next(1, 100);
            int tries = 6;

            Console.WriteLine("A number between 1-99 has been chosen, you have 6 guesses");
            
            while (tries > 0)
            {
                Console.Write("Enter your guess: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == randNum)
                {
                    Console.WriteLine("Good job! You guessed the right number.");
                    break;
                }
                else if (guess < randNum)
                {
                    Console.WriteLine("Guessed too low");
                }
                else
                {
                    Console.WriteLine("Guessed too high");
                }

                tries--;
                Console.WriteLine($"You have {tries} tries remaining");
            }

            if (tries == 0)
            {
                Console.WriteLine($"Good try, the number was: {randNum}");
            }

            Console.WriteLine("Thank you for playing!");
        }
    }
}