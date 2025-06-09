using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description) { }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            if (DateTime.Now >= endTime) break;
            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
        }

        DisplayEndingMessage();
    }
}
