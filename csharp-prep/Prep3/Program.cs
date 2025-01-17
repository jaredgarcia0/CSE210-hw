using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(0, 101);

        // Console.Write("What is the magic number? ");
        // string StringNumber = Console.ReadLine();
        // int MagicNumber = int.Parse(StringNumber);

        int guess = 0;

        int numberGuess = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string StringGuess = Console.ReadLine();
            guess = int.Parse(StringGuess);

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
                numberGuess++;
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("lower");
                numberGuess++;
            }
        }
        Console.WriteLine("You guessed it!");
        System.Console.WriteLine($"Number of guesses were  {numberGuess} ");
    }

}