using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Whqat is your first name?");
        string first = Console.ReadLine() ?? "";
        Console.Write("Whqat is your last name?");
        string last = Console.ReadLine() ?? "";
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}