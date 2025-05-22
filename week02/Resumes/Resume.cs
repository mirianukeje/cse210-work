using System;

public class Resume
{
    // Member variables
    public string _name;

    public List<Job> _jobs = new List<Job>();

    // methods to access these variables
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }

}

