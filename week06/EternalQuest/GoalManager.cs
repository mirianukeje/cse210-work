using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void MainMenu()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine($"Score: {_score}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": running = false; break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    public void CreateGoal()
{
    Console.WriteLine("Goal Types:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");
    Console.WriteLine("4. Milestone Goal"); // NEW
    Console.Write("Select a goal type: ");
    string choice = Console.ReadLine();

    Console.Write("Enter goal name: ");
    string name = Console.ReadLine();
    Console.Write("Enter goal description: ");
    string desc = Console.ReadLine();
    Console.Write("Enter points: ");
    int points = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case "1":
            _goals.Add(new SimpleGoal(name, desc, points));
            break;
        case "2":
            _goals.Add(new EternalGoal(name, desc, points));
            break;
        case "3":
            Console.Write("Enter times to complete: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new CheckListGoal(name, desc, points, target, bonus));
            break;
        case "4":
            Console.Write("Enter total times to reach goal (target): ");
            int milestoneTarget = int.Parse(Console.ReadLine());
            Console.Write("Enter how often to give milestone points (milestone size): ");
            int milestoneSize = int.Parse(Console.ReadLine());
            _goals.Add(new MilestoneGoal(name, desc, points, milestoneTarget, milestoneSize));
            break;
        default:
            Console.WriteLine("Invalid type.");
            break;
    }
}


    public void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        if (_goals.Count == 0)
            Console.WriteLine("No goals yet!");
        else
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
            }
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        ListGoals();
        Console.Write("Which goal did you accomplish? (enter number): ");
        if (int.TryParse(Console.ReadLine(), out int num) && num > 0 && num <= _goals.Count)
        {
            int points = _goals[num - 1].RecordEvent();
            _score += points;
            Console.WriteLine(points > 0
                ? $"Congrats! You earned {points} points!"
                : "This goal is already complete.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save to: ");
        string filename = Console.ReadLine();
        using (StreamWriter sw = new StreamWriter(filename))
        {
            sw.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                sw.WriteLine(goal.GetSaveString());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load from: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _goals.Clear();
            _score = int.Parse(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                try
                {
                    Goal goal = Goal.LoadFromString(lines[i]);
                    _goals.Add(goal);
                }
                catch
                {
                    Console.WriteLine($"Could not load goal: {lines[i]}");
                }
            }
            Console.WriteLine("Goals loaded!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
