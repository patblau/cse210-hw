using System;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Konnichiwa! Prep5 World!");

        DisplayWelcome();
    }

    // Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Asks for and returns name (string)
    static string PromptUserName()
    {
        Console.Write("Emter your name here: ");
        return Console.ReadLine();
    }

    // Asks for/returns favorite number (integer)
    static int PrompUserNumber()
    {
        Console.Write("Enter your favorite number here, please: ");
        return int.Parse(ControlledExecution.ReadLine());
    }
    
    // Prompts for users birth year (outer parameter)
    static void PromptUserBirthYear(out int birthYear)
    {
        ConsoleWrite("Please enter your birth year: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    // Return square number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Display results
    static void DisplayResults(string name, int quaredNumber, int birthYear)
    {
        int age = DateTime.Now.Year - birthYear;
        Console.WriteLines($"{name}, the square of your favorite number is {squareNumber}");
        Console.WriteLines($"{name}, you will be {age} this year.");
    }
}
