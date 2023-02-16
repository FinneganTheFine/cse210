class Program {
    static void Main(string[] args) {
        var p = new Person();
        var s = new Student();

        Console.WriteLine(p.GetName());
        Console.WriteLine(s.GetName());
    }
}

class Person{
    public string GetName(){
        return "Cole";
    }
}
class Student: Person{

}