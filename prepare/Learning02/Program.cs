using System;
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


        //jobs: Company, Job title, Start Year, End Year
        class Job
        {
            public string _company;
            public string _jobTitle;
            public string _startYear;
            public string _endYear;
            public void Display()
            {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
            }
        }
    
        //resume: person's name and list of jobs
        class Resume
        { 
            public string _name;
            public List<Job> _jobs = new List<Job>();
            public void Display()
            {
            Console.WriteLine(_name);
            Console.WriteLine("Jobs:");
            }
        }
    }
}