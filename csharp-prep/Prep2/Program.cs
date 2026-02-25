using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Howdy there.");

        //ask for the grade percentage
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);
        string grade = "";
        
       //define grades using separate print statements
       //change veribles into letter grades
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

        if (grade )

        //include "+ (>=7)" or "- (<3)" to the grade
        // use modulus operator %
        int lastDigit = percentage % 10;
        
        Console.WriteLine($"\nYour grade is {grade}");  

        //Need 70% to pass, state if passed or not
        if (percentage >= 70) 
        {
            Console.WriteLine("You did it. You passed the class. Congradulations!");
        }
        else
        {        
            Console.WriteLine("Sorry, you did not pass the course. Don't quit. You will do better next time.");
        }
    }
}