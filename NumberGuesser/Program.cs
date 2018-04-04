using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            ///intro
            Console.WriteLine("Hey Player! Bet you can't guess my number!");

            ///TODO: asking for a random number range
            Console.WriteLine("How hard do you want to make it? Pick a range:");
            Console.WriteLine("What's the lowest end of the range?");
            int floorRange = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's the highest end of the range?");
            int ceilRange = Convert.ToInt32(Console.ReadLine());

            ///display range:
            Console.WriteLine($"So you wanna play between {floorRange} and {ceilRange} huh?");

            ///generating a random number between 1+10
            Console.WriteLine("Fine, I'm picking a number. Hold tight...");

            ///run random number program
            Random rnd = new Random();
            int computerNumber = rnd.Next(floorRange, ceilRange);
            Console.WriteLine($"I've chosen {computerNumber}. It's a secret...");

            Console.WriteLine("What are you sitting around for?");
            ///input field for player to input their guess
            Console.WriteLine($"Pick a number between {floorRange} and {ceilRange}:");
            int playerGuess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"So you think my number is {playerGuess}?");

            Console.ReadLine();
        }
    }
}
