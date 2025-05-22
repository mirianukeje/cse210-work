using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Resumes Project.");

        // Create the first job instance
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Display the company for job1
        // job1.Display();

        // Create the second job instance
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Display the company for job2
        // job2.Display();

        // Create a resume instance
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        // Add the jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Verify: display the first job title
        // Console.WriteLine(myResume._jobs[0]._jobTitle);
         myResume.Display();


    }
}