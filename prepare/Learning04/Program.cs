using System;

class Program
{
    static void Main(string[] args)
    {
        var a = new Assignment("ryan", "Math");
        var m = new MathAssignment("ryan", "Math", "Section 7.3", "Problems 8-19");
        var w = new WritingAssignment("ryan", "Math", "The Causes of World War II");
        Console.WriteLine(a.GetSummary());
        Console.WriteLine(m.GetHomeworkList());
        Console.WriteLine(w.GetWritingInformation());
    }
}

class Assignment{
    private string _studentName;
    private string _topic;
    public Assignment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSummary(){
        string summary = $"Name: {_studentName} Topic: {_topic}";
        return summary;
    }
}
class MathAssignment: Assignment{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string studentName, string topic, string textbookSection, string problems): base(studentName, topic){
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList(){
        string homeworkList = $"{_textbookSection} {_problems}";
        return homeworkList;
    }
}
class WritingAssignment: Assignment{
    private string _title;
    public WritingAssignment(string studentName, string topic, string title):base(studentName, topic){
        _title = title;
    }
    public string GetWritingInformation(){
        string writingInformation = $"{_title}";
        return writingInformation;
    }
}