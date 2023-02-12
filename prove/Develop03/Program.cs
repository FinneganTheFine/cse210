using System;
using System.Collections.Generic; 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Do you want to study scriptures? (yes/no)");
        string choice = Console.ReadLine();
        while (choice.ToLower() == "yes"){
            Console.WriteLine("Do you want scripture 1 or 2?");
            string nice = Console.ReadLine();
            int scripturechoice = int.Parse(nice);
            if(scripturechoice == 1){
                Reference reference = new Reference("Proverbs",3,5);
                string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
                Scripture scripture = new Scripture(reference, text);
                scripture.AllHidden();
                while (scripture.AllHidden() == false){
                    Console.Clear();
                    scripture.Display();
                    Console.WriteLine("\nPress enter to continue memorizing");
                    Console.ReadLine();
                    scripture.HideWords(3);
                }
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nDo you want to study another scripture? (yes/no)");
                choice = Console.ReadLine();
            } else {
                Reference reference = new Reference("Proverbs",3,5,6);
                string text = "5. Trust in the Lord with all thine heart; and lean not unto thine own understanding.\n6. In all thy ways acknowledge him, and he shall direct thy paths.";
                Scripture scripture = new Scripture(reference, text);
                scripture.AllHidden();
                while (scripture.AllHidden() == false){
                    Console.Clear();
                    scripture.Display();
                    Console.WriteLine("\nPress enter to continue memorizing");
                    Console.ReadLine();
                    scripture.HideWords(3);
                }
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nDo you want to study another scripture? (yes/no)");
                choice = Console.ReadLine();
            }
        }
    }
}

class Scripture{
    private Reference _ref;
    private List<Word> _words;
    public Scripture(Reference reference, string text){
        _words = new List<Word>();
        _ref = reference;
        var words = text.Split(" ");
        foreach(string word in words){
            Word wordle = new Word(word);
            _words.Add(wordle);
            //Console.Write(word);
        }
    }
   public void HideWords(int count){
        Random generator = new Random();
        for(int i=0;i<count;i++){
            int removal = generator.Next(_words.Count());
            if(_words[removal].checkHidden() == true){
                i-=1;
            } else {
                _words[removal].Hide();
            }
            int visibleWordsCount = _words.Count(w => !w.checkHidden());
            if (visibleWordsCount < 3)
            {
                break;
            }
        }
    }
    public Boolean AllHidden(){
        Boolean allGone = true;
        foreach(Word word in _words){
            if (word.checkHidden() == true){
                allGone = true;
            } else {
                allGone = false;
                return allGone;
            }
        }
        return allGone;
    }
    public void Display(){
        Console.Write($"{_ref.Display()} ");
        foreach(var word in _words){
            Console.Write($"{word.Display()} ");
        }
    }
    public Reference GetReference(){
        return _ref;
    }
    public void SetReference(Reference reference){
        _ref = reference;
    }
    public List<Word> GetWords(){
        return _words;
    }
    public void SetWords(List<Word> words){
        _words = words;
    }
}
class Reference{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;
    public Reference(string book, int chapter, int start){
        _book = book;
        _chapter = chapter;
        _startVerse = start;
    }
    public Reference(string book, int chapter, int start, int end){
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
    }
    public string Display(){
        string theReference;
        if (_endVerse != null){
            theReference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        } else {
            theReference = $"{_book} {_chapter}:{_startVerse}";
        }
        return theReference;
    }
    public string GetBook(){
        return _book;
    }
    public void SetBook(string book){
        _book = book;
    }
    public int GetChapter(){
        return _chapter;
    }
    public void SetChapter(int chapter){
        _chapter = chapter;
    }
    public int GetStartVerse(){
        return _startVerse;
    }
    public void SetStartVerse(int startVerse){
        _startVerse = startVerse;
    }
    // public int GetEndVerse(){
    //     return _endVerse;
    // }
    // public void SetEndVerse(int endVerse){
    //     _endVerse = endVerse;
    // }
}
class Word{
    private string _text;
    private Boolean _isHidden;
    public Word(string text){
        _text = text;
        _isHidden = false;
    }
    public void Hide(){
        _isHidden = true;
    }
    public string Display(){
        string script = "";
        if(_isHidden != true){
            script = $"{_text}";
        } else {
            foreach(char letter in _text){
                script +="-";
            }
        }
        return script;
    }
    public Boolean checkHidden(){
        return _isHidden;
    }
    public string GetText(){
        return _text;
    }
    public void SetText(string text){
        _text = text;
    }
}