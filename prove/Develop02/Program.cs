using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Markup;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
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
            Console.WriteLine("What woud you like to do?");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Place number here: ");

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

                // Create entry, add date, and add to journal
                Entry entry = new Entry(date, prompt, response);
                journal.AddEntry(entry);  
                Console.WriteLine("Your journal entry was added.\n");
            }
                
            // Step 2 Display the Journal 
            // Display each entry on the screen
            else if (choice == "2")
            { 
                journal.DisplayAll();
                Console.WriteLine();
            }

            // Step 3 Load the journal
            // Prompt for filename
            // Load to journal
            
            else if (choice == "3")
            { 
                Console.Write("What file do you want loaded? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Your Journal:");
            }

            // Step 4 Save the journal file to one line
            // Ask for a file name and save
            // use a separator that isn't in responses. 
            // Format: date~|~prompt~|~response

            else if (choice == "4") 
            { 
                Console.Write("Name your file: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Your journal was saved successfully.");
            }

            // Step 5 to quit
            else if (choice == "5")
            {
                running = false;
            }
        }
    }
}
           
// Step 1 Store all entries
// add new entry
// Loop for entries list
public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    
    // Step 2 DisplayAll method
    // Iterate through all entries in journal
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Step 3 Add LoadFromFile method
    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();
        foreach (string line in lines)
        {
            Entry entry = Entry.FromFileString(line);
            _entries.Add(entry);
        }
     }

    // step 4 add the save/load methods 
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputfile.WriteLine(entry.ToFileString());
            }
        }
    }
}

//Step 1 create an entry
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

    //Step 2 display an entry
    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }

    //Step 3 load one entry from a CVS line
    public static Entry FromFileString(string line)
    {
        List<string> parts = ParseCsvLine(line);
        return new Entry(parts[0], parts[1], parts[2]);
    }

    private static List<string> ParseCsvLine(string line)
    {
        List<string> values = new List<string>();
        string current = "";
        bool inQuotes = false;

        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];
            
            if (c == '"')
            {
                if (inQuotes && i + 1 < line.Length && line[i + 1] == '"')
                {
                    current += '"';
                    i++;
                }
                else
                {
                    inQuotes = !inQuotes;
                }
            }
            else if (c == ',' && !inQuotes)
            {
                values.Add(current);
                current = "";
            }
            else
            {
                current += c;
            }
        }
        values.Add(current);
        return values;
    }

    //Step 4 save one entry as a CVS line
    public string ToFileString()
    {
        return $"{EscapeCsv(_date)}, {EscapeCsv(_prompt)}, {EscapeCsv(_response)}";
    }

    public string EscapeCvs(string text)
    {
        if (text == null)
        {
            return "\"\"";
        }
        //replace one (") quote with 2 "quotes"
        string escaped = text.Replace("\"", "\"\"");
        
        // Wrap whole field in " "
        return $"\"{escaped}\"";
    }
}
    
// Step 1 create list of prompts 
public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What did you discover about yourself today?",
        "What does sucess mean to you?",
        "What do you want to accomplish tomorrow?",
        "Did anything happen out of the ordinary?",
        "Is there a skill you are developing? How are progressing with it",
        "What changes do you want to make in your life?",
        "What makes you happy?",
        "Name a friend and what do they mean to you?",
        "Did someone hurt you today? What can you do to bring about a possitve outcome?",
        "Name your family members, their date of birth, and where they were born.",
        "Name an ancestor and what you know about them.",
        "What do you value the most and why?",
        "What boundries do you have for yourself?",
        "What lines will you never cross?",
        "What makes you feel safe?",
        "What brings you comfort?",
        "Who makes you feel loved?",
        "What do you want most out of life?",
        "What do you believe in?",
        "Where have you lived?",
        "What states have you been to and why?",
        "Have you traveled out of the U.S?",
        "What talents do you have?",
        "What do you like about yourself?"
    };

    // Random object selecting a prompt
    private Random _random = new Random();
    private int _currentIndex = 0;

    // Return random prompt from list
    public string GetRandomPrompt()
    {
        // Shuffel prompts once when starting
        if (_currentIndex == 0)
        {
            ShufflePrompts();
        }

        string prompt = _prompts[_currentIndex];
        _currentIndex++;

        // Reset after all prompts are used
        if (_currentIndex >= _prompts.Count)
        {
            _currentIndex = 0;
        }
    return prompt;
    }

    private void ShufflePrompts()
    {
        for (int i = _prompts.Count - 1; i >0; i--)
        {
            int j = _random.Next(i +1);
            string temp = _prompts[i];
            _prompts[i] = _prompts[j];
            _prompts[j] = temp;
        }
    }    
}

     
            
            