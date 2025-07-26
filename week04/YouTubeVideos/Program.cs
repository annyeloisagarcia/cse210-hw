using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Exploring the Amazon Jungle", "WildLifeHD", 540);
        video1.AddComment(new Comment("Alice", "This is amazing! I feel like I was there."));
        video1.AddComment(new Comment("John", "Great footage and narration."));
        video1.AddComment(new Comment("Emily", "Loved the part with the jaguar."));
        videos.Add(video1);

        Video video2 = new Video("How to Bake the Perfect Bread", "ChefDaily", 300);
        video2.AddComment(new Comment("Mike", "Can't wait to try this recipe!"));
        video2.AddComment(new Comment("Sara", "So helpful, thanks!"));
        video2.AddComment(new Comment("Bob", "Mine turned out amazing!"));
        videos.Add(video2);

        Video video4 = new Video("SpaceX Launch Recap", "TechSpace", 480);
        video4.AddComment(new Comment("Chris", "This was historic."));
        video4.AddComment(new Comment("Alex", "Love the animations."));
        video4.AddComment(new Comment("Jamie", "Perfect summary of the launch."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
             video.DisplayVideoInfo();
            Console.WriteLine();
         }

    }
}