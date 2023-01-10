using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;


        int numberGuesses = 0;


        while (guess != magicNumber)
        {
            Console.WriteLine("What's your guess: ");
            guess = int.Parse(Console.ReadLine());

            numberGuesses = numberGuesses + 1;

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.Write ($"Number Guesses = {numberGuesses}");
            }
        }


    
    
    }

}