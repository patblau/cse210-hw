using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

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
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");

                // Get user's response
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                // Create entry and add to journal
                Entry entry = new Entry(date, prompt, response);
                journal.AddEntry(entry);  
                
                Console.WriteLine("Entry added.\n");
            }
                
            // Step 2 Display the Journal  
            else if (choice == "2")
            {
                // Display each entry on the screen
                journal.DisplayAll();
                ConsoleWriteLine();
            }

            // Iterate through all entries in the journal
            else if (choice == "5")
            {
                running = false;
            }
        }
    }
}
           
    // The Journal class will loop through the list of entries
public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _enteries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}

public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }
}
   // Step 3 Save the journal file 
   // Ask for a file name and save 
   // Step 4 Load the journal 
   // Prompt for filename 
   // Load to journal 
   // Saves to one line using a separator that is unlikely to appear in responses.
   // Format: date~|~prompt~|~response 
   
            
            
            