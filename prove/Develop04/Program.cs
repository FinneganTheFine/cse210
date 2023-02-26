using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the activty game\nWhat activity would you like to do?\n1. A Learning activity\n2. A Breathing activity\n3. A Reflection Activity\n4. Quit");
        Console.Write("What is your choice: ");
        string ActivityChoice = Console.ReadLine();
        while (ActivityChoice != "4"){
            if(ActivityChoice == "1"){
                Activity activityOne = new Activity("Learning");
                LearningActivity lActivityOne = new LearningActivity();
                lActivityOne.RunActivity();
            } else if(ActivityChoice == "2"){
                Activity activityOne = new Activity("Breathing");
                BreathingActivity breathingOne = new BreathingActivity();
                breathingOne.RunActivity();
            }else{
                Activity activityOne = new Activity("Reflection");
                ReflectionActivity reflectionOne = new ReflectionActivity();
                reflectionOne.RunActivity();
            }
            Console.Clear();
            Console.WriteLine("Welcome to the activty game\nWhat activity would you like to do?\n1. A Learning activity\n2. A Breathing activity\n3. A Reflection Activity\n4. Quit");
            Console.Write("What is your choice: ");
            ActivityChoice = Console.ReadLine();
        }
    }
}
class Activity{
    protected string _name;
    protected string _welcomeMessage;
    protected string _endMessage;
    protected int _duration;

    public Activity(string name){
        _name = name;
    }

    public void DisplayIntro(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!!!");
        Console.WriteLine();
        Console.WriteLine(_welcomeMessage);
        Console.WriteLine();
        Console.Write("How long in seconds would you like for your exercise: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void StartMessage(){
        Console.Clear();
        Console.WriteLine("Get Ready");
    }

    public void DisplayOutro(){
        Console.WriteLine(_endMessage);
    }
}

class LearningActivity: Activity{
    private static string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private string _message = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    public LearningActivity(): base("Learning"){
        _welcomeMessage = _message;
        _endMessage = "You are now relaxed!";
    }
    public void RunActivity(){
        DisplayIntro();
        StartMessage();
        Console.WriteLine("Prompt: " + prompts[new Random().Next(prompts.Length)]);
        Thread.Sleep(_duration*1000);
        Console.WriteLine("Keep listing items:");
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrEmpty(item))
            {
                break;
            }
            count++;
        }
        Console.WriteLine($"You listed {count} items.");
        Thread.Sleep(3000);
        DisplayOutro();
    }
}

class BreathingActivity:Activity{
    protected string _message = "This exercise will help you to relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    private string[] breathingPrompts = { "Breathe in...", "Breathe out..." };

    public BreathingActivity(): base("Breathing"){
        _welcomeMessage = _message;
        _endMessage = "You are now relaxed!";
    }

    public void RunActivity(){
        DisplayIntro();
        StartMessage();
        int promptIndex = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(breathingPrompts[promptIndex]);
            promptIndex = (promptIndex + 1) % breathingPrompts.Length;
            Thread.Sleep(3000);
        }
        DisplayOutro();
    }
}
class ReflectionActivity : Activity{
    private string[] reflectionPrompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection"){
        _welcomeMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void RunActivity(){
        DisplayIntro();
        StartMessage();
        Console.WriteLine("Here are some reflection questions to help you think about your experience:");
        Console.WriteLine();

        Random rand = new Random();
        int promptIndex = rand.Next(reflectionPrompts.Length);
        int questionIndex = rand.Next(reflectionQuestions.Length);

        Console.WriteLine(reflectionPrompts[promptIndex]);
        Console.WriteLine(reflectionQuestions[questionIndex]);
        Thread.Sleep(_duration*1000);
        DisplayOutro();
    }
}