using System;
using System.Collections.Generic;

public class ExerciseActivity : Activity
{
    private List<string> _exercises;

    public ExerciseActivity(string name, string description) : base(name, description)
    {
        _exercises = new List<string>
        {
            "Stand up and stretch your arms overhead.",
            "Roll your shoulders gently backward five times.",
            "Tilt your head left and right to stretch your neck.",
            "Stand and shake out your hands and fingers.",
            "Gently twist your torso left and right.",
            "Do a few slow deep breaths and relax your muscles."
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        int numExercises = Math.Min(3, _exercises.Count); // Do up to 3 exercises per session

        List<string> sessionExercises = new List<string>(_exercises);

        for (int i = 0; i < numExercises; i++)
        {
            if (sessionExercises.Count == 0)
                break;

            int idx = rand.Next(sessionExercises.Count);
            string exercise = sessionExercises[idx];
            sessionExercises.RemoveAt(idx);

            Console.WriteLine($"\n> {exercise}");
            ShowSpinner(4);
        }

        DisplayEndingMessage();
    }
}
