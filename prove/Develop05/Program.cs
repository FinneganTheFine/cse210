using System;
//using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        var goals = new List<Goal>();
        int points = 0;
        int level = 0;
        Console.WriteLine($"Your points are :{points}");
        Console.WriteLine($"You're level {level}\nYou gain a level every 50 points");
        Console.Write("Select an option\n1. Create New Goal\n2. List Goals\n3. Load Goals\n4. Save Goals\n5. Record Event\n6. Quit\n> ");
        int choice = int.Parse(Console.ReadLine());
        while (choice != 6){
            if (choice == 1){
                Console.WriteLine("What kind of goal do you want to make?\n1. Simple Goal\n2. Checklist Goal\n3. Eternal Goal\n");
                int choicey = int.Parse(Console.ReadLine());
                if(choicey == 1){
                    Console.Write("What is the Name of your goal: ");
                    var name = Console.ReadLine();
                    Console.Write("Write a short description of the Goal: ");
                    var description = Console.ReadLine();
                    Console.Write("How many points will it be worth: ");
                    var pointvalue = int.Parse(Console.ReadLine());
                    goals.Add(new Simple(pointvalue, name, description));
                } else if(choicey == 2){
                    Console.Write("What is the Name of your goal: ");
                    var name = Console.ReadLine();
                    Console.Write("Write a short description of the Goal: ");
                    var description = Console.ReadLine();
                    Console.Write("How many times must it be completed for a bonus: ");
                    var goal = int.Parse(Console.ReadLine());
                    Console.Write("How many points will it be worth each time: ");
                    var pointvalue = int.Parse(Console.ReadLine());
                    goals.Add(new Checklist(pointvalue, name, description, goal));
                }else{
                    Console.Write("What is the Name of your goal: ");
                    var name = Console.ReadLine();
                    Console.Write("Write a short description of the Goal: ");
                    var description = Console.ReadLine();
                    Console.Write("How many points will it be worth each time: ");
                    var pointvalue = int.Parse(Console.ReadLine());
                    goals.Add(new Eternal(pointvalue, name, description));
                }
                if(points >= level*50){
                    level+=1;
                }
                Console.WriteLine($"Your points are :{points}");
                Console.WriteLine($"You're level {level}\nYou gain a level every 50 points");
                Console.Write("Select an option\n1. Create New Goal\n2. List Goals\n3. Load Goals\n4. Save Goals\n5. Record Event\n6. Quit\n> ");
                choice = int.Parse(Console.ReadLine());
            } else if(choice == 2){
                foreach(var goal in goals){
                    Console.WriteLine(goal.Display());
                }
                if(points >= level*50){
                    level+=1;
                }
                Console.WriteLine($"Your points are :{points}");
                Console.WriteLine($"You're level {level}\nYou gain a level every 50 points");
                Console.Write("Select an option\n1. Create New Goal\n2. List Goals\n3. Load Goals\n4. Save Goals\n5. Record Event\n6. Quit\n> ");
                choice = int.Parse(Console.ReadLine());
            } else if(choice == 3){
                Console.WriteLine("What is the name of the file you want to load\n> ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('-');
                    int type = int.Parse(parts[0]);
                    string name = parts[1];
                    string desc = parts[2];
                    points = int.Parse(parts[3]);
                    bool completed = bool.Parse(parts[4]);

                    switch(type)
                    {
                        case 1:
                            goals.Add(new Simple(points, name, desc){ completed = completed });
                            break;
                        case 2:
                            int timesCompleted = int.Parse(parts[5]);
                            int goal = int.Parse(parts[6]);
                            goals.Add(new Checklist(points, name, desc, goal){ completed = completed, _timesCompleted = timesCompleted });
                            break;
                        case 3:
                            goals.Add(new Eternal(points, name, desc){ completed = completed });
                            break;
                    }
                }
                if(points >= level*50){
                    level+=1;
                }
                Console.WriteLine($"Your points are :{points}");
                Console.WriteLine($"You're level {level}\nYou gain a level every 50 points");
                Console.Write("Select an option\n1. Create New Goal\n2. List Goals\n3. Load Goals\n4. Save Goals\n5. Record Event\n6. Quit\n> ");
                choice = int.Parse(Console.ReadLine());
            } else if(choice == 4){
                Console.WriteLine("What is the name of the file you want to save to\n> ");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    // You can add text to the file with the WriteLine method
                    foreach(var goal in goals){
                        outputFile.WriteLine(goal.Save());
                    }
                }
                if(points >= level*50){
                    level+=1;
                }
                Console.WriteLine($"Your points are :{points}");
                Console.WriteLine($"You're level {level}\nYou gain a level every 50 points");
                Console.Write("Select an option\n1. Create New Goal\n2. List Goals\n3. Load Goals\n4. Save Goals\n5. Record Event\n6. Quit\n> ");
                choice = int.Parse(Console.ReadLine());
            } else if(choice == 5){
                var i=0;
                foreach(var goal in goals){
                    if (!goal.completed){
                        Console.WriteLine($"{i}{goal.Display()}");
                        i+=1;
                    }
                    //points += goal._pointvalue;
                }
                Console.Write("What goal did you complete: ");
                var comple = int.Parse(Console.ReadLine());
                goals[comple].RecordEvent();
                points += goals[comple]._pointvalue;
                goals[comple].Unbonus();
                if(points >= level*50){
                    level+=1;
                }
                Console.WriteLine($"Your points are :{points}");
                Console.WriteLine($"You're level {level}\nYou gain a level every 50 points");
                Console.Write("Select an option\n1. Create New Goal\n2. List Goals\n3. Load Goals\n4. Save Goals\n5. Record Event\n6. Quit\n> ");
                choice = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
abstract class Goal{
    public int _pointvalue;
    protected string _name;
    protected string _description;
    public Boolean completed;
    public Goal(int pointvalue, string name, string description) {
        _pointvalue = pointvalue;
        _name = name;
        _description = description;
        completed = false;
    }

    public virtual void RecordEvent() {
        completed = true;
    }

    public virtual void LoadGoal() {
        completed = false;
    }

    public virtual string Display() {
        string completeded = completed ? "Completed" : "Not Completed";
        return $"{_name} - {_description} - Point Value: {_pointvalue} - {completed}";
    }
    public abstract void MarkDone();
    public abstract string Save();
    public virtual void Unbonus(){
        _pointvalue = _pointvalue*1;
    }
}
class Simple: Goal{
    public Simple(int pointvalue, string name, string description) : base(pointvalue, name, description){
    }

    public override void MarkDone(){
        completed = true;
    }

    public override string Display(){
        return $"[Simple]\n{_name}\n{_description}\nPoints: {_pointvalue}\nCompleted: {(completed ? "Yes" : "No")}";
    }
    public override void RecordEvent() {
        Console.WriteLine($"You completed the {_name} goal and earned {_pointvalue} points!");
    }
    public override string Save()
    {
        return $"1-{_name}-{_description}-{_pointvalue}-{completed}";
    }
    public override void Unbonus()
    {
        throw new NotImplementedException();
    }
}
class Checklist: Goal{
    public int _timesCompleted;
    private int _goal;

    public Checklist(int pointvalue, string name, string description, int goal) : base(pointvalue, name, description){
        _timesCompleted = 0;
        _goal = goal;
    }

    public override string Display(){
        return $"[Checklist]\n{_name}\n{_description}\nPoints: {_pointvalue} each\nCompleted {_timesCompleted} out of {_goal} times";
    }

    public override void MarkDone(){
        if (!completed){
            _timesCompleted++;
            if (_timesCompleted == _goal){
                completed = true;
            }
        }
    }
    public override void RecordEvent() {
        _timesCompleted++;
        Console.WriteLine($"You completed the {_name} goal and earned {_pointvalue} points!");
        if (_timesCompleted == _goal) {
            Console.WriteLine($"You also earned a bonus of {_pointvalue*5} points for completing the goal {_goal} times!");
            _pointvalue = _pointvalue*6;
        }
    }
    public override void Unbonus(){
        if (_timesCompleted == _goal){
            _pointvalue = _pointvalue/6;
        }
    }
    public override string Save()
    {
        return $"2-{_name}-{_description}-{_pointvalue}-{completed}-{_timesCompleted}-{_goal}";
    }
}
class Eternal: Goal{
    public Eternal(int pointvalue, string name, string description) : base(pointvalue, name, description){
        completed = false;
    }

    public override void MarkDone(){
        Console.WriteLine($"Congratulations! You have completed the eternal goal '{_name}' and earned {_pointvalue} points.");
    }
    public override string Display(){
        return $"[Eternal]\n{_name}\n{_description}\nPoints: {_pointvalue}";
    }
    public override void RecordEvent() {
        Console.WriteLine($"You completed the {_name} goal and earned {_pointvalue} points!");
    }
    public override string Save()
    {
        return $"3-{_name}-{_description}-{_pointvalue}-False";
    }
    public override void Unbonus()
    {
        throw new NotImplementedException();
    }
}