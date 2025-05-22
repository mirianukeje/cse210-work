/*
Exceeding Requirements

1. Tagging: Each journal entry can be tagged (e.g., "family", "work", "gratitude"). Tags help users organize or later search their entries.
2. Motivational Quotes: Each prompt is paired with a motivational quote for inspiration and encouragement.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal (.txt)");
            Console.WriteLine("4. Load the journal (.txt)");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Get random prompt and quote
                    var (prompt, quote) = promptGenerator.GetRandomPromptWithQuote();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.WriteLine($"Quote: {quote}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Console.Write("Add a tag for this entry (e.g., family, work, gratitude): ");
                    string tag = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();

                    Entry newEntry = new Entry();
                    newEntry._date = date;
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;
                    newEntry._tag = tag;

                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added!\n");
                    break;

                case "2":
                    if (journal._entries.Count == 0)
                    {
                        Console.WriteLine("\nNo entries yet.\n");
                    }
                    else
                    {
                        Console.WriteLine("\nYour Journal Entries:\n");
                        journal.DisplayAll();
                    }
                    break;

                case "3":
                    Console.Write("\nEnter a filename to save your journal (e.g., journal.txt): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved!\n");
                    break;

                case "4":
                    Console.Write("\nEnter the filename to load your journal from (e.g., journal.txt): ");
                    string loadFile = Console.ReadLine();
                    try
                    {
                        journal.LoadFromFile(loadFile);
                        Console.WriteLine("Journal loaded!\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Could not load file: {ex.Message}\n");
                    }
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
