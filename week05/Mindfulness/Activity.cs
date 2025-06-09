using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How many seconds would you like this session to last? ");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out _duration) || _duration <= 0)
        {
            Console.WriteLine("Invalid input. Using default of 60 seconds.");
            _duration = 60;
        }
        Console.WriteLine("\nGet ready to begin...");
        ShowCountdown(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowCountdown(2);
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        ShowCountdown(2);
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index % spinner.Length]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            index++;
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
}
