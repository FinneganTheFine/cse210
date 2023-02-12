using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pick a number for the top");
        string toppy = Console.ReadLine();
        int top = int.Parse(toppy);
        Console.WriteLine("Pick a number for the bottom");
        string bottomString = Console.ReadLine();
        int bottom = int.Parse(bottomString);

        Fraction fraction1 = new Fraction(top, bottom);
        Console.WriteLine(fraction1.getFractionString());
        Console.WriteLine(fraction1.getDecimalValue());
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.getFractionString());
        Console.WriteLine(fraction2.getDecimalValue());
        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine(fraction3.getFractionString());
        Console.WriteLine(fraction3.getDecimalValue());
        Fraction fraction4 = new Fraction(1,3);
        Console.WriteLine(fraction4.getFractionString());
        Console.WriteLine(fraction4.getDecimalValue());
    }
}
