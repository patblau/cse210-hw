using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aloha Develop02 World!");
        Console.WriteLine("Welcome to your Journal Assistant.");
        Console.WriteLine();

        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        bool running = true;

        //Step 5 Provide a minue to pick from choices
        //Step 7 interface to follow the video.

        while (running)
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            Console.WriteLine();

           // Step 1 Write a new entry 
            if (choice == "1")
            {
                // Display prompt from list / Show random prompt
                // PromptGenerator returns random prompt
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");

                // Get user's response
                // Get today's date
                string response = Console.ReadLine();
                String date = DateTime.Now.ToShortDateString();

        
                // Step 2 Display the Journal
                // Iterate through all entries in the journal
                // Display on screen

                // Step 3 Save the journal file
                // Ask for a file name and save
                
                // Step 4 Load the journal
                // Prompt for filename
                // Load to journal

                // Saves to one line using a separator that is unlikely to appear in responses.
                // Format: date~|~prompt~|~response
            }
        }
    }
}
