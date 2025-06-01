using System;

class Program
{
    static void Main(string[] args)
    {

        // Create 3-4 videos
        Video video1 = new Video("How to code", "CodeBoss", 950);
        Video video2 = new Video("Dancing Babies", "AmericanIdols", 1200);
        Video video3 = new Video("20 Cleaning Tips", "MarthaCleans", 1800);

        // Add 3-4 comments to each video
        video1.AddComment(new Comment("Blake", "Just what I need, thanks!"));
        video1.AddComment(new Comment("Max", "Helpful Tips!"));
        video1.AddComment(new Comment("Mary", "Easier than expected."));

        video2.AddComment(new Comment("Rachel", "I have never seen such cute babies!"));
        video2.AddComment(new Comment("Joe", "This is hilarious!"));
        video2.AddComment(new Comment("Mitchell", "I love this!"));

        video3.AddComment(new Comment("Kate", "My Kitchen is a mess, this is perfect!"));
        video3.AddComment(new Comment("George", "Garbage disposal is my favorite!"));
        video3.AddComment(new Comment("Tom", "I need to try these tips!"));

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}