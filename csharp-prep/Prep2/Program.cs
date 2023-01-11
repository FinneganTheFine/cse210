using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage ");
        string percentile = Console.ReadLine() ?? "";
        int grade = int.Parse(percentile);
        if (grade > 93){
            Console.WriteLine($"your grade is an A because your percentage is {grade}");
        }else if (grade <= 93 && grade >= 90){
            Console.WriteLine($"your grade is an A- because your percentage is {grade}");
        }else if (grade < 90 && grade >= 87){
            Console.WriteLine($"your grade is an B+ because your percentage is {grade}");
        }else if (grade < 87  && grade > 83){
            Console.WriteLine($"your grade is an B because your percentage is {grade}");
        }else if (grade <= 83  && grade >= 80){
            Console.WriteLine($"your grade is an B- because your percentage is {grade}");
        }else if (grade < 80 && grade >= 77){
            Console.WriteLine($"your grade is an C+ because your percentage is {grade}");
        }else if (grade < 77  && grade > 73){
            Console.WriteLine($"your grade is an C because your percentage is {grade}");
        }else if (grade <= 73  && grade >= 70){
            Console.WriteLine($"your grade is an C- because your percentage is {grade}");
        }else if (grade <= 70 && grade >= 67){
            Console.WriteLine($"your grade is an D+ because your percentage is {grade}");
        }else if (grade < 67  && grade > 63){
            Console.WriteLine($"your grade is an D because your percentage is {grade}");
        }else if (grade <= 63  && grade >= 60){
            Console.WriteLine($"your grade is an D- because your percentage is {grade}");
        }else if (grade < 60){
            Console.WriteLine($"your grade is an F, which stands for Failure, because your percentage is {grade}");
        }
    }
}
/*grade = int(input("What is your grade percentage: "))
if (grade > 93):
    Console.WriteLine($"your grade is an A because your percentage is {grade}")
else if (grade <= 93 and grade >= 90):
    Console.WriteLine($"your grade is an A- because your percentage is {grade}")
else if (grade < 90 and grade >= 87):
    Console.WriteLine($"your grade is an B+ because your percentage is {grade}")
else if (grade < 87  and grade > 83):
    Console.WriteLine($"your grade is an B because your percentage is {grade}")
else if (grade <= 83  and grade >= 80):
    Console.WriteLine($"your grade is an B- because your percentage is {grade}")
else if (grade < 80 and grade >= 77):
    Console.WriteLine($"your grade is an C+ because your percentage is {grade}")
else if (grade < 77  and grade > 73):
    Console.WriteLine($"your grade is an C because your percentage is {grade}")
else if (grade <= 73  and grade >= 70):
    Console.WriteLine($"your grade is an C- because your percentage is {grade}")
else if (grade <= 70 and grade >= 67):
    Console.WriteLine($"your grade is an D+ because your percentage is {grade}")
else if (grade < 67  and grade > 63):
    Console.WriteLine($"your grade is an D because your percentage is {grade}")
else if (grade <= 63  and grade >= 60):
    Console.WriteLine($"your grade is an D- because your percentage is {grade}")
else if (grade < 60):
    Console.WriteLine($"your grade is an F, which stands for Failure, because your percentage is {grade}")*/