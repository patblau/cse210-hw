using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Howdy there.");

        Console.WriteLine("What is your grade persentage? ");
        string gradePersentage = Console.ReadLine();
        int percentage = int.Parse(gradePersentage);
        string grade = "";
        
        if(percentage >= 90)
            grade = "A";
        else if(percentage >= 80)
            grade = "B";
        else if(percentage >= 70)
            grade = "C";
        else if(percentage >= 60)
            grade = "D";
        else
            grade = "F";
        
        
    }
}