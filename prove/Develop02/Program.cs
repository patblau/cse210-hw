using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Namaste! Learning03 World!");
        Console.WriteLine("Welcome to Your Journal Assistant.");
        Console.ReadLine();

        Journal journal = new Journal();
        PropmtGenerator promptGen = new PropmtGenerator():

        //Step 5 Provide a minue to pick from choice
        //Step 7 interface as intructed by video
        bool running = true;
        while (running)
        {
            Console.WriteLine("To start, select one of following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");

            string choice = ConsoleReadLine();
            ConsoleWriteLine();

           
        }

    }
        // Step 1 Display prompt from list
        // Show random prompt
        // Get today's date
        // User selects "Write"
        // Add Entry to Journal and save
        // PrompGenerator returns random promp  
        // Step 2 Display the Journal
        // Iterate through all entries in the journal 
        // Display on scree
        //Step 3 Save the fournal file
        // ask for a file name and sav
        //Step 4 Loan the journal
        //Prompt for filename
        // load to journa
        //Step 5 Provide a minue to pick from choice
        // Step 6 list of 5 different prompts

        //Step 7 interface to follow the video.
    }
}