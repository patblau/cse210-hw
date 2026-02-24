using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Howdy there.");

        Console.WriteLine("What is your grade persentage? ");
        string gradePercentage = Console.ReadLine();
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
        
        Console.WriteLine($"\nYour grade is {grade}");  

        if (persentage >= 70)
        {
            Console.WriteLine("You did it. You passed the class. Congradulations!");
        }
        else
        {        
            Console.WriteLine("Sorry, you did not pass the course. Don't quit. You will do better next time.");
        }
    }
}