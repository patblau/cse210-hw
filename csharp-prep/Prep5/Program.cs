using System;

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

    // Asks for and returns the user's name (string)
    static string PromptUserName()
    {
        Console.Write("Emter your name here: ");
    }
       
}
