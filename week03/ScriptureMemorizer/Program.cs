using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a list of scriptures
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son"),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding"),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be and men are that they might have joy"),
            new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God"),
            new Scripture(new Reference("Alma", 37, 6), "By small and simple things are great things brought to pass")
        };

        // Step 2: Choose one scripture randomly
        Random rand = new Random();
        int index = rand.Next(scriptureLibrary.Count);
        Scripture scripture = scriptureLibrary[index];

        // Step 3: Loop until all words are hidden or user quits
        while (true)
        {
            Console.Clear(); // Clear the screen
            Console.WriteLine(scripture.GetDisplayText());

            // If all words are hidden, end the loop
            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide a few words each round
            scripture.HideRandomWords(3);
        }

        // Final display
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are now hidden. Goodbye!");
    }
}
