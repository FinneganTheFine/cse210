using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Do you wanna play a game? yes or no");
        string gameplay = Console.ReadLine() ?? "";
        while (gameplay.ToLower() == "yes"){
            Random generator = new Random();
            int MagicNumber = generator.Next(1,101);
            int Guesses = 0;
            Console.Write("What do you think it is? ");
            string StringGuess = Console.ReadLine() ?? "";
            int Guess = int.Parse(StringGuess);
            Guesses += 1;
            while(Guess != MagicNumber){
                if (Guess < MagicNumber){
                    Console.WriteLine("Higher");
                    StringGuess = Console.ReadLine() ?? "";
                    Guesses += 1;
                    Guess = int.Parse(StringGuess);
                } else if (Guess > MagicNumber){
                    Console.WriteLine("Lower");
                    StringGuess = Console.ReadLine() ?? "";
                    Guess = int.Parse(StringGuess);
                    Guesses += 1;
                }
            }
            Console.WriteLine("Wait you actually got it!?");
            Console.WriteLine($"It took you {Guesses} Guesses to get it.");
            Console.WriteLine();
            Console.WriteLine("Do you wanna play a game? yes or no ");
            gameplay = Console.ReadLine() ?? "";
        }
        Console.WriteLine("Okay...I understand");
    }
}