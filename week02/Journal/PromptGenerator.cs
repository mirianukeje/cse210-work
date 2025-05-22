using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Each prompt has an associated quote
    public List<(string Prompt, string Quote)> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<(string, string)>
        {
            ("Who was the most interesting person I interacted with today?",
             "“Strangers are just friends waiting to happen.” – Rod McKuen"),
            ("What was the best part of my day?",
             "“Enjoy the little things, for one day you may look back and realize they were the big things.” – Robert Brault"),
            ("How did I see the hand of the Lord in my life today?",
             "“God is in the details.” – Ludwig Mies van der Rohe"),
            ("What was the strongest emotion I felt today?",
             "“Feelings are much like waves, we can’t stop them from coming but we can choose which one to surf.” – Jonatan Mårtensson"),
            ("If I had one thing I could do over today, what would it be?",
             "“Every day brings a chance to start over.” – Oprah Winfrey"),
            ("What is one thing I learned today?",
             "“Live as if you were to die tomorrow. Learn as if you were to live forever.” – Mahatma Gandhi"),
            ("Describe a small act of kindness you witnessed or did today.",
             "“No act of kindness, no matter how small, is ever wasted.” – Aesop"),
            ("Who is someone you are grateful for and why?",
             "“Let us be grateful to people who make us happy.” – Marcel Proust"),
            ("Write about a happy memory from your childhood.",
             "“Sometimes you will never know the value of a moment until it becomes a memory.” – Dr. Seuss"),
            ("What made you smile today?",
             "“Peace begins with a smile.” – Mother Teresa")
        };
    }

    public (string Prompt, string Quote) GetRandomPromptWithQuote()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
}
