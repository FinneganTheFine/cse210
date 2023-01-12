using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write the numbers that you want in the list. When you're finished type 0. ");
        SortedList<int, int> numbers = new SortedList<int, int>();
        Console.Write("Write your Number here: ");
        string StringNumbers = Console.ReadLine() ?? "";
        int numberinos = int.Parse(StringNumbers);
        while (numberinos != 0){
            if(numbers.ContainsKey(numberinos)){
                Console.WriteLine("That's already here.");
                Console.Write("Write your Number here: ");
                StringNumbers = Console.ReadLine() ?? "";
                numberinos = int.Parse(StringNumbers);
            } else {
                numbers.Add(numberinos, numberinos);
                Console.Write("Write your Number here: ");
                StringNumbers = Console.ReadLine() ?? "";
                numberinos = int.Parse(StringNumbers);
            }
        }
        int Total = 0;
        int Average = 0;
        int Maximum = -1;
        int Min = 3333333;
        foreach(var kvp in numbers){
            if(kvp.Value > 0){
                Total += kvp.Value;
            }
            if(kvp.Value > Maximum){
                Maximum = kvp.Value;
            }
            if(kvp.Value > 0 && kvp.Value < Min){
                Min = kvp.Value;
            }
        }
        Average = Total/numbers.Count;
        Console.WriteLine($"The total of your list is {Total}");
        Console.WriteLine($"The average of your list is {Average}");
        Console.WriteLine($"The largest number on your list is {Maximum}");
        Console.WriteLine($"The smallest positive number on your list is {Min}");
        foreach(var kvp in numbers){
            Console.WriteLine(kvp);
        }
    }
}