using System;

class Program
{
    static void Main(string[] args)
    {
        var employees = new List<Employee>();

        var salary = new Employee();
        var hourly = new HourlyEmployee();
        var executive = new Executive();

        employees.Add(salary);
        employees.Add(hourly);
        employees.Add(executive);

        foreach (var e in employees){
            e.CalculateYearlyPay();
        }
    }
}
abstract class Person{
    abstract public string Speak();
}
class NicePerson : Person
{
    public override string Speak()
    {
        return "Hello! How are you? It's very nice out today";
    }
}
class MeanPerson: Person{
    public override string Speak()
    {
        return "Your code stinks";
    }
}
class Employee{
    protected int Salary = 100000;
    virtual public int CalculateYearlyPay(){
        return Salary;
    }
}
class Executive: Employee{
    private int Bonus = 100000000;
    public override int CalculateYearlyPay()
    {
        return Salary+Bonus;
    }
}
class HourlyEmployee: Employee{
    private int HourlyWage = 25;
    private int HoursPerYear = 2000;
    public override int CalculateYearlyPay(){
        return HourlyWage*HoursPerYear;
    }
}