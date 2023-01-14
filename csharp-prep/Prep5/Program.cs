using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string Name = PromptUserName();
        int Number = PromptUserNumber();
        int NumberSquared = SquareNumber(Number);
        DisplayResult(Name, Number, NumberSquared);
    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program");
    }
    static string PromptUserName(){
        Console.Write("What's your name? ");
        string name = Console.ReadLine() ?? "";
        return name;
    }
    static int PromptUserNumber(){
        Console.Write("What's your favorite number? (Whole Number Please) ");
        string name = Console.ReadLine() ?? "";
        int number = int.Parse(name);
        return number;
    }
    static int SquareNumber(int number){
        int numberSquared = number*number;
        return numberSquared;
    }
    static void DisplayResult(string Name, int Number, int NumberSquared){
        Console.WriteLine($"User {Name}'s favorite number is {Number}, that number squared is {NumberSquared}.");
    }
}