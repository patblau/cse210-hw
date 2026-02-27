using System;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Konnichiwa! Prep5 World!");

        DisplayWelcomeMessage();
    }

    // Displays the message, "Welcome to the Program!"
    static void DisplayWelcomeMessage()
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
}
