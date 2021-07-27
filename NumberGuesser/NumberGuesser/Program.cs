using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess number from 1 to 10...: ");
            
            Random random = new Random();
            int correctNumber = random.Next(1, 11);

            bool correctAnswer = false;
            

            while (!correctAnswer)
            {
                string input = Console.ReadLine();
                int guess;
                int.TryParse(input, out guess);

                if (guess > correctNumber)
                {
                    Console.WriteLine("Guessed number is bigger than correct number.");
                }
                else if (guess < correctNumber)
                {
                    Console.WriteLine("Guessed number is smaller than correct number.");
                }
                else
                {
                    Console.WriteLine("Congratulations! That's correct answer.");
                    correctAnswer = true;
                }
            }
        }
    }
}
