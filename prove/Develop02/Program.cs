using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Select an option\n1. Write\n2. Read\n3. Save\n4. Load\n5. Quit\n> ");
        string choicey = Console.ReadLine();
        int choice = int.Parse(choicey);
        Journal journalOne = new Journal();
        while (choice != 5){
            if(choice == 1){
                journalOne.CreateEntry();
            }else if(choice == 2){
                journalOne.readJournal();
            }else if(choice == 3){
                journalOne.saveJournal();
            }else{
                Console.WriteLine("What is the name of the file you want to load\n> ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    journalOne.entries.Add(line);
                }
            }
            Console.Write("Select an option\n1. Write\n2. Read\n3. Save\n4. Load\n5. Quit\n> ");
            choicey = Console.ReadLine();
            choice = int.Parse(choicey);
        }
    }
}
class Journal{
    public List<Entry> entries;
    
    public List<string> prompts = new List<string>();
    public Journal(){
        prompts.Add("What did you do today?");
        prompts.Add("How are you feeling");
        prompts.Add("What is something you felt you could have done better today");
        prompts.Add("What is something you feel you did well today");
    }
    public void CreateEntry(){        
        
        
        Random generator = new Random();
        int phraseNumber = generator.Next(prompts.Count());
        Console.WriteLine(prompts[phraseNumber]);
        
    }
    public void readJournal(){
        foreach(var entry in entries){
            Console.WriteLine(entry);
        }
    }
    public void saveJournal(){
        Console.WriteLine("What is the name of the file you want to save to\n> ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            foreach(var entry in entries){
                outputFile.WriteLine(entry);
            }
        }
    }
}
class Entry{
    public string timestamp;
    public string content;
    public string prompt;
    public void CreateEntry(){        
        //Saves the Date
        DateTime theCurrentTime = DateTime.Now;
        timestamp = theCurrentTime.ToShortDateString();
        content = Console.ReadLine();
        entries.Add($"{timestamp} - {content}");
    }
    public void loadJournal(){
        
    }
    public void saveJournal(){
        
    }
}
//Random generator = new Random();