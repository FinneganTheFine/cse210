using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Select an option\n1. Write\n2. Read\n3. Save\n4. Load\n5. Quit\n> ");
        int choice = Console.Read();
        Journal journalOne = new Journal();
        while (choice != 5){
            if(choice == 1){

            }else if(choice == 2){
                
            }else if(choice == 3){

            }else{

            }
            Console.Write("Select an option\n1. Write\n2. Read\n3. Save\n4. Load\n5. Quit\n> ");
            choice = Console.Read();
        }
    }
}
class Journal{
    public string timestamp;
    public string content;
    List<string> prompts = new List<string>();
    prompts.Add("hi");
    static void CreateEntry(){
        Random generator = new Random();
        int phraseNumber = generator.Next(0,4);
    }
}
//Random generator = new Random();