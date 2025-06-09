using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        List<string> sessionQuestions = new List<string>(_questions);

        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nReflect on the following prompt:\n--- {prompt} ---");
        Console.WriteLine("\nPrepare to reflect...");
        ShowSpinner(5);

        int timePerQuestion = 5;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            if (sessionQuestions.Count == 0)
                sessionQuestions = new List<string>(_questions);

            int qIndex = rand.Next(sessionQuestions.Count);
            string question = sessionQuestions[qIndex];
            sessionQuestions.RemoveAt(qIndex);

            Console.WriteLine($"\n> {question}");
            ShowSpinner(timePerQuestion);
        }

        DisplayEndingMessage();
    }
}
