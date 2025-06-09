using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nYou may begin in:");
        ShowCountdown(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;
        List<string> responses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                count++;
                responses.Add(response);
            }
        }

        Console.WriteLine($"\nYou listed {count} items!");
        foreach (string resp in responses)
        {
            Console.WriteLine("- " + resp);
        }
        DisplayEndingMessage();
    }
}
