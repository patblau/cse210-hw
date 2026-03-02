using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bonjour! Learning02 World!");

        //First job
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //Second job
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2024;

        //Generate resume
        Resume resume = new Resume();
        resume._name = "Pat Blau";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
   
       resume.Display();
    }
}

//jobs: Company, Job title, Start Year, End Year
class Job
{ 
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
    
//resume: person's name and list of jobs
class Resume
{ 
    public string _name = ""; 
    public List<Job> _jobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine(_name);
        Console.WriteLine("Jobs:");
    }
}

