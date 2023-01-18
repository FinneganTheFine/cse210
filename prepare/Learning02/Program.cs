using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job personOne = new Job();
        personOne._company = "Bimf";
        personOne._jobTitle = "Mimmflr";
        personOne._startYear = 2001;
        personOne._endYear = 2020;

        Job personTwo = new Job();
        personTwo._company = "Bipus";
        personTwo._jobTitle = "Bopus";
        personTwo._startYear = 2020;
        personTwo._endYear = 2023;

        Resume resumeOne = new Resume();
        resumeOne._name = "Ryan Bryan";
        resumeOne._jobs = new List<Job>();
        resumeOne._jobs.Add(personOne);
        resumeOne._jobs.Add(personTwo);

        resumeOne.DisplayResumeDetails();
    }
}

class Resume{
    public string _name;
    public List<Job> _jobs;

    public void DisplayResumeDetails() {
        Console.WriteLine($"Resume of {_name}");
        foreach(var job in _jobs){
            job.DisplayJobDetails();
        }
    }
}
class Job{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public void DisplayJobDetails(){
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}