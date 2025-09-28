using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Console.Write("What is the magic number? ");
        // string response = Console.ReadLine();
        // int magicNumber = int.Parse(response);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        string response;

        while (true)
        {
            Console.Write("What is your guess? ");
            response = Console.ReadLine();
            int guess = int.Parse(response);

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                break;
            }
        }
    }
}