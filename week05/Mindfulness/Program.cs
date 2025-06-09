// Exceeds Requirements:
// I added a new Exercise Activity to help users take a quick ergonomic break.
// The program tracks and displays how many times each activity was performed in the current session.
// Reflection questions don’t repeat until all have been shown in a session.

using System;

class Program
{
    // Session counters for each activity
    static int breathingCount = 0;
    static int reflectingCount = 0;
    static int listingCount = 0;
    static int exerciseCount = 0;

    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Start Exercise Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine().Trim();

            if (choice == "1")
            {
                breathingCount++;
                BreathingActivity activity = new BreathingActivity(
                    "Breathing",
                    "This activity will help you relax by guiding you through slow breathing.");
                activity.Run();
            }
            else if (choice == "2")
            {
                reflectingCount++;
                ReflectingActivity activity = new ReflectingActivity(
                    "Reflecting",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience.");
                activity.Run();
            }
            else if (choice == "3")
            {
                listingCount++;
                ListingActivity activity = new ListingActivity(
                    "Listing",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                activity.Run();
            }
            else if (choice == "4")
            {
                exerciseCount++;
                ExerciseActivity activity = new ExerciseActivity(
                    "Exercise",
                    "This activity will guide you through some quick ergonomic exercises.");
                activity.Run();
            }
            else if (choice == "5")
            {
                // Session summary (exceeds requirements)
                Console.WriteLine("\nSession Activity Summary:");
                Console.WriteLine($"Breathing Activities: {breathingCount}");
                Console.WriteLine($"Reflecting Activities: {reflectingCount}");
                Console.WriteLine($"Listing Activities: {listingCount}");
                Console.WriteLine($"Exercise Activities: {exerciseCount}");
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}
